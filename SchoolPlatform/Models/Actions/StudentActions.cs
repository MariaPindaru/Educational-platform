using SchoolPlatform.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.Models.Actions
{
    class StudentActions 
    {
        private schoolEntities context = new schoolEntities();
        private StudentLogVM  studentContext;
        public StudentActions(StudentLogVM student)
        {
            studentContext = student;
        }
        public StudentVM GetStudent(string username)
        {
            var s = context.GetStudentByUsername(username).FirstOrDefault();
            
            return new StudentVM()
            {
                Person = new PersonVM()
                {
                    Username = s.Username,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    PersonId = s.PersonID
                },
                ClassId = s.ClassID,
                StudentId = s.StudentID,
                ClassNumber = s.y,
                ClassName = s.Letter,
                Specialization = s.spec,
                Password = s.Password
            };
        }
        public ObservableCollection<GradeVM> GradeList(int studentID)
        {
            var grades = context.AllGradesForStudent(studentID);
            ObservableCollection<GradeVM> result = new ObservableCollection<GradeVM>();
            foreach (var grade in grades)
            {
                result.Add(new GradeVM()
                {
                    Subj = new Subject()
                    {
                        SubjectID = grade.SubjectID,
                        Name = grade.subject
                    },
                        Grade = float.Parse(grade.Number.ToString()),
                    Date = grade.Date,
                    Semester = new Semester()
                    {
                        SemesterID = grade.SemesterID,
                        Number = grade.semester
                    },
                    Final = grade.Final
                });
            }

            return result;
        }
        public ObservableCollection<GradeVM> Averages(int studentID)
        {
            var grades = context.GetAveragesForStudent(studentID);
            ObservableCollection<GradeVM> result = new ObservableCollection<GradeVM>();
            foreach (var grade in grades)
            {
                result.Add(new GradeVM()
                {
                    Subj = new Subject()
                    {
                        SubjectID = grade.SubjectID,
                        Name = grade.subject
                    },
                    Grade = int.Parse(grade.Grade.ToString()),
                    Semester = new Semester()
                    {
                        SemesterID = grade.SemesterID,
                        Number = grade.semester
                    }
                });
            }

            return result;
        }
        public ObservableCollection<AttendanceVM> AttendanceList (int studentID)
        {
            var attendance = context.AttendanceForStudent(studentID);
            ObservableCollection<AttendanceVM> result = new ObservableCollection<AttendanceVM>();
            foreach (var a in attendance)
            {
                result.Add(new AttendanceVM()
                {
                    Subj = new Subject()
                    {
                        SubjectID = a.SubjectID,
                        Name = a.subject
                    },
                    Date = a.Date,
                    Semester = new Semester()
                    {
                        SemesterID = a.SemesterID,
                        Number = a.semester
                    },
                    Motivated = a.Motivated,
                    Type = a.Name
                });
            }

            return result;
        }

        public ObservableCollection<Tuple<GradeVM, GradeVM, float>> AveragesComplete(int studentID)
        {
            var grades1 = context.AverageGradeSem(studentID, 1);
            var grades2 = context.AverageGradeSem(studentID, 2);
            ObservableCollection<Tuple<GradeVM, GradeVM, float>> result = new ObservableCollection<Tuple<GradeVM, GradeVM, float>>();

            ObservableCollection<GradeVM> sem1 = new ObservableCollection<GradeVM>();
            ObservableCollection<GradeVM> sem2 = new ObservableCollection<GradeVM>();
            
            foreach(var grade in grades1)
            {
                sem1.Add(
                    new GradeVM()
                    {
                        Grade = grade.Grade,
                        Semester = new Semester()
                        {
                            Number = 1
                        },
                        Subj = new Subject()
                        {
                            Name = grade.subject
                        }
                    });
            }
            foreach (var grade in grades2)
            {
                sem2.Add(
                    new GradeVM()
                    {
                        Grade = grade.Grade,
                        Semester = new Semester()
                        {
                            Number = 1
                        },
                        Subj = new Subject()
                        {
                            Name = grade.subject
                        }
                    });
            }
            for(int i = 0; i < sem1.Count; ++i)
            {
                result.Add(new Tuple<GradeVM, GradeVM, float>(sem1[i], sem2[i], (sem2[i].Grade + sem1[i].Grade) / 2));
            }

            return result;
        }
    }
    
}
