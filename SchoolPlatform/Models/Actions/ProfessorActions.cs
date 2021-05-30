using SchoolPlatform.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.Models.Actions
{
    class ProfessorActions
    {
        private schoolEntities context = new schoolEntities();
        private ProfessorLogVM professorContext;
        public ProfessorActions(ProfessorLogVM prof)
        {
            this.professorContext = prof;
        }
        public ProfessorVM GetProfessor(string username)
        {
            var p = context.GetProfessorByUsername(username).FirstOrDefault();
            return new ProfessorVM()
            {
                Person = new PersonVM()
                {
                    Username = p.Username,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    PersonId = p.PersonID
                },
                Password = p.Password,
                SubjectsList = AllSubjectsForProfessor(p.PersonID)
            };
        }
        public ObservableCollection<Semester> GetSemesters()
        {
            var sem = context.Semesters;
            ObservableCollection<Semester> result = new ObservableCollection<Semester>();
            foreach (var s in sem)
            {
                result.Add(s);
            }
            return result;
        }
        public ObservableCollection<Subject> AllSubjectsForProfessor(int personID)
        {
            var prof = context.Professors.Where(x => x.PersonID == personID).FirstOrDefault();
            var res = context.AllSubjectsForProfessor(prof.ProfessorID);
            ObservableCollection<Subject> result = new ObservableCollection<Subject>();
            foreach (var x in res)
            {
                result.Add(new Subject()
                {
                    SubjectID = x.SubjectID,
                    Name = x.Name
                });
            }
            return result;
        }
        public ObservableCollection<StudentVM> GetStudents(int profID, int subjID)
        {
            var res = context.StudentsByProfessorSubject(profID, subjID);
            ObservableCollection<StudentVM> result = new ObservableCollection<StudentVM>();
            foreach (var s in res)
            {
                result.Add(new StudentVM()
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
                });
            }
            return result;
        }
        public ObservableCollection<StudentVM> GetStudentsFromClass(int profID)
        {
            int classID = context.Classes.Where(c => c.HeadMasterID == profID).FirstOrDefault().ClassID;
            var res = context.GetStudents();
            ObservableCollection<StudentVM> result = new ObservableCollection<StudentVM>();
            foreach (var s in res)
            {
                if (s.ClassID == classID)
                {
                    result.Add(new StudentVM()
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
                    });
                }
            }
            return result;
        }
        public int GetProfessorID(int personID)
        {
            var prof = context.Professors.Where(p => p.Person.PersonID == personID).FirstOrDefault();
            return prof.ProfessorID;
        }
        public ObservableCollection<ProfessorSubjectVM> SubjectsWithFinalExam(int studentID)
        {
            ObservableCollection<ProfessorSubjectVM> list = new ObservableCollection<ProfessorSubjectVM>();
            var x = context.SubjectsWithFinals(studentID);
            foreach (var s in x)
            {
                list.Add(new ProfessorSubjectVM()
                {
                    Prof = new ProfessorVM()
                    {
                        ProfID = s.ProfessorID
                    },
                    Subj = new Subject()
                    {
                        SubjectID = s.SubjectID,
                        Name = s.subject
                    }
                }

                    );
            }
            return list;
        }
        public ObservableCollection<GradeVM> GradeList(int studentID, string subject, int semester)
        {
            var grades = context.AllGradesForStudent(studentID);
            ObservableCollection<GradeVM> result = new ObservableCollection<GradeVM>();
            foreach (var grade in grades)
            {
                if (grade.subject == subject && grade.semester == semester)
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
            }

            return result;
        }
        public ObservableCollection<AttendanceVM> AttendanceList(int studentID, string subject, int semester)
        {
            var attendances = context.AttendanceForStudent(studentID);
            ObservableCollection<AttendanceVM> result = new ObservableCollection<AttendanceVM>();
            foreach (var attendance in attendances)
            {
                if (attendance.subject == subject && attendance.semester == semester)
                {
                    result.Add(new AttendanceVM()
                    {
                        Subj = new Subject()
                        {
                            SubjectID = attendance.SubjectID,
                            Name = attendance.subject
                        },
                        Date = attendance.Date,
                        Semester = new Semester()
                        {
                            SemesterID = attendance.SemesterID,
                            Number = attendance.semester
                        },
                        Motivated = attendance.Motivated,
                        Type = attendance.Name
                    });
                }
            }

            return result;
        }
        public ObservableCollection<AttendanceType> GetAttendanceTypes()
        {
            ObservableCollection<AttendanceType> types = new ObservableCollection<AttendanceType>();
            var aux = context.AttendanceTypes;
            foreach (var a in aux)
            {
                types.Add(a);
            }
            return types;
        }
        public ObservableCollection<AttendanceVM> AttendanceListComplete(int studentID)
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
                    Type = a.Name,
                    StudentID = studentID,
                    ProfID = a.ProfessorID
                });
            }

            return result;
        }
        public int GetAverageGrade(int studentID, int classID, int profID, int subjectID, int semesterID)
        { 
            var grade = context.GetAverageGrade(studentID, classID, profID, subjectID, semesterID).FirstOrDefault();
            if (grade == null)
                return -1;
            return (int)Math.Ceiling(double.Parse(grade.ToString()));
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

        public ObservableCollection<Tuple<GradeVM, GradeVM, float>> AveragesComplete(int studentID)
        {
            var grades1 = context.AverageGradeSem(studentID, 1);
            var grades2 = context.AverageGradeSem(studentID, 2);
            ObservableCollection<Tuple<GradeVM, GradeVM, float>> result = new ObservableCollection<Tuple<GradeVM, GradeVM, float>>();

            ObservableCollection<GradeVM> sem1 = new ObservableCollection<GradeVM>();
            ObservableCollection<GradeVM> sem2 = new ObservableCollection<GradeVM>();

            foreach (var grade in grades1)
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
            if(sem1.Count != sem2.Count)
            {
                for(int i = 0; i < sem1.Count - sem2.Count; ++i)
                {
                    sem2.Add(
                    new GradeVM()
                    {
                        Grade = -1
                    }) ;
                }
            }
            
            for (int i = 0; i < sem1.Count; ++i)
            {
                float final;
                if(sem2[i].Grade == -1)
                {
                    final = -1;
                }
                else
                {
                    final = (sem2[i].Grade + sem1[i].Grade) / 2;
                }
                
                result.Add(new Tuple<GradeVM, GradeVM, float>(sem1[i], sem2[i], final));
            }

            return result;
        }
        public bool IsHeadMaster(int profID)
        {
            var classs = context.Classes.Where(c => c.HeadMasterID == profID).FirstOrDefault();
            if (classs == null)
                return false;
            return true;
        }
        public void AddGrade(object obj)
        {
            GradeVM grade = obj as GradeVM;
            if (grade == null)
            {
                professorContext.Message = "Operatia nu s-a putut efectua!";
                return;
            }
            if (grade.ProfID == 0 || grade.StudentID == 0 || grade.Subj.SubjectID == 0 ||
              grade.Semester.SemesterID == 0)
            {
                professorContext.Message = "Exista campuri neselectate!";
                return;
            }
            bool canBeFinal = SubjectsWithFinalExam(grade.StudentID).Where(subject => subject.Subj.SubjectID == grade.Subj.SubjectID && subject.Prof.ProfID == grade.ProfID).FirstOrDefault() != null;
            if (grade.Final == true && canBeFinal == false)
            {
                professorContext.Message = "Aceasta materie nu poate avea teza!";
                return;
            }
            var existingGrades = GradeList(grade.StudentID, grade.Subj.Name, grade.Semester.SemesterID);
            bool hasAlreadyFinalExanTaken = existingGrades.Where(g => g.Semester.SemesterID == grade.Semester.SemesterID && g.Final == true).FirstOrDefault() != null;
            if (grade.Final == true && hasAlreadyFinalExanTaken == true)
            {
                professorContext.Message = "Aceasta materie are deja trecuta teza pt acest semestru!";
                return;
            }
            context.AddGrade(grade.ProfID, grade.StudentID, (int)grade.Grade, grade.Date, grade.Subj.SubjectID, grade.Semester.SemesterID, grade.Final);
            professorContext.Message = "Nota adaugata!";
            professorContext.CurrentStudent.GradeList = GradeList(professorContext.CurrentStudent.StudentId, professorContext.Subject.Name, professorContext.CurrentSemester.Number);
        }
        public void DeleteGrade(object obj)
        {
            GradeVM grade = obj as GradeVM;
            if (grade == null)
            {
                professorContext.Message = "Operatia nu s-a putut efectua!";
                return;
            }

            context.DeleteGrade(grade.ProfID, grade.StudentID, (int)grade.Grade, grade.Date, grade.Subj.SubjectID, grade.Semester.SemesterID, grade.Final);
            professorContext.Message = "Nota a fost stearsa!";
            professorContext.CurrentStudent.GradeList = GradeList(professorContext.CurrentStudent.StudentId, professorContext.Subject.Name, professorContext.CurrentSemester.Number);
        }
        public void AddAtendance(object obj)
        {
            AttendanceVM attendance = obj as AttendanceVM;
            if (attendance == null)
            {
                professorContext.Message = "Operatia nu s-a putut efectua!";
                return;
            }
            if (attendance.ProfID == 0 || attendance.StudentID == 0 || attendance.Subj.SubjectID == 0 ||
              attendance.Semester.SemesterID == 0)
            {
                professorContext.Message = "Exista campuri neselectate!";
                return;
            }
            var existing = AttendanceList(attendance.StudentID, attendance.Subj.Name, attendance.Semester.SemesterID);
            bool canAdd = existing.Where(g => g.Semester.SemesterID == attendance.Semester.SemesterID && g.Date.ToString() == attendance.Date.ToString()).FirstOrDefault() == null;
            if (canAdd == false)
            {
                professorContext.Message = "Exista deja o absenta in ziua selectata!";
                return;
            }
            context.AddAttendance(attendance.ProfID, attendance.StudentID, attendance.Date, attendance.Subj.SubjectID, attendance.Semester.SemesterID, attendance.Type);
            professorContext.Message = "Absenta adaugata!";
            professorContext.CurrentStudent.AttendanceList = AttendanceList(professorContext.CurrentStudent.StudentId, professorContext.Subject.Name, professorContext.CurrentSemester.Number);
        }
        public void MotivateAtendance(object obj)
        {
            AttendanceVM attendance = obj as AttendanceVM;
            if (attendance == null)
            {
                professorContext.Message = "Operatia nu s-a putut efectua!";
                return;
            }
            if (attendance.ProfID == 0 || attendance.StudentID == 0 || attendance.Subj.SubjectID == 0 ||
              attendance.Semester.SemesterID == 0)
            {
                professorContext.Message = "Exista campuri neselectate!";
                return;
            }
            if (attendance.Type == "nemotivabila")
            {
                professorContext.Message = "Absenta este nemotivabila!";
                return;
            }
            context.MotivateAttendance(attendance.ProfID, attendance.StudentID, attendance.Date, attendance.Subj.SubjectID, attendance.Semester.SemesterID);
            professorContext.Message = "Absenta motivata!";
            if(professorContext.CurrentStudent != null)
                professorContext.CurrentStudent.AttendanceList = AttendanceList(professorContext.CurrentStudent.StudentId, professorContext.Subject.Name, professorContext.CurrentSemester.Number);
            professorContext.InitAttendance();
        }
        public void AddAverage(object obj)
        {
            GradeVM average = obj as GradeVM;
            if (average == null)
            {
                professorContext.Message = "Operatia nu s-a putut efectua!";
                return;
            }
            if (average.ProfID == 0 || average.StudentID == 0 || average.Subj.SubjectID == 0 ||
              average.Semester.SemesterID == 0)
            {
                professorContext.Message = "Exista campuri neselectate!";
                return;
            }
            if(average.Grade == -1)
            {
                professorContext.Message = "Media nu poate fi incheiata fara teza!";
                return;
            }
            if (average.Grade == -2)
            {
                professorContext.Message = "Media nu poate fi incheiata fara note!";
                return;
            }
            int idps = GetProfSubjID(average.ProfID, average.Subj.SubjectID);
            bool existing = context.AverageGrades.Where(x => x.ProfSubjID == idps && x.StudentID == average.StudentID && x.SemesterID == average.Semester.SemesterID).FirstOrDefault() != null;
            if (existing == true)
            {
                professorContext.Message = "Media este deja incheiata!";
                return;
            }
            var aux = context.Grades.Where(g => g.StudentID == average.StudentID && g.StudentID == average.StudentID && g.ProfSubjID == idps);
            if(aux == null || aux.Count() < 4)
            {
                professorContext.Message = "Media nu poate fi incheiata! Prea putine note";
                return;
            }
            context.AddAverageGrade(average.StudentID, average.ProfID, average.Subj.SubjectID, average.Semester.SemesterID, (int)average.Grade);
            professorContext.Message = "Medie adaugata!";
            professorContext.CurrentStudent.AttendanceList = AttendanceList(professorContext.CurrentStudent.StudentId, professorContext.Subject.Name, professorContext.CurrentSemester.Number);
        }
        public int GetProfSubjID(int profID, int subjectID)
        {
            var aux = context.Professor_Subject.Where(profSubj => profSubj.ProfessorID == profID && profSubj.SubjectID == subjectID).FirstOrDefault();
            return aux.ProfSubjID;
        }
    }
    
}
