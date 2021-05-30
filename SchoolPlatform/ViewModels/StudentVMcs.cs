using SchoolPlatform.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.ViewModels
{
    class StudentVM : BaseVM
    {
        private PersonVM person;
        private int studentId;
        private int classId;
        private string classNumber;
        private string className;
        private string specialization;
        private string password;
        private float finalAverage;


        public StudentVM()
        {
            this.Person = new PersonVM();
        }
        private ObservableCollection<GradeVM> gradeList;
        private ObservableCollection<GradeVM> averageGradeList;
        private ObservableCollection<Tuple<GradeVM, GradeVM, float>> averagesAll;
        private ObservableCollection<AttendanceVM> attendanceList;
        private ObservableCollection<Subject> subjectList;
        private int unmotivated;

        public ObservableCollection<Subject> SubjectList
        {
            set
            {
                subjectList = value;
                NotifyPropertyChanged("SubjectList");
            }
            get
            {
                return subjectList;
            }
        }
        public ObservableCollection<GradeVM> GradeList
        {
            set
            {
                gradeList = value;
                NotifyPropertyChanged("GradeList");
            }
            get
            {
                return gradeList;
            }
        }
        public ObservableCollection<GradeVM> AverageGradeList
        {
            set
            {
                averageGradeList = value;
                NotifyPropertyChanged("AverageGradeList");
            }
            get
            {
                return averageGradeList;
            }
        }
        public ObservableCollection<Tuple<GradeVM, GradeVM, float>> AverageGradeListCombined
        {
            set
            {
                averagesAll = value;
                float aux = 0;
                foreach (var grade in averagesAll)
                {
                    aux += grade.Item3;
                }
                FinalAverage = aux / averagesAll.Count;
                NotifyPropertyChanged("AverageGradeListCombined");
            }
            get
            {
                return averagesAll;
            }
        }
        public ObservableCollection<AttendanceVM> AttendanceList
        {
            set
            {
                attendanceList = value;
                foreach (var attendance in attendanceList)
                    if(attendance.Motivated == false)
                        Unmotivated += 1;
                NotifyPropertyChanged("AttendanceList");
            }
            get
            {
                return attendanceList;
            }
        }
        public PersonVM Person
        {
            set
            {
                person = value;
                NotifyPropertyChanged("Person");
            }
            get
            {
                return person;
            }
        }

        public int StudentId
        {
            set
            {
                studentId = value;
                NotifyPropertyChanged("StudentId");
            }
            get
            {
                return studentId;
            }
        }
        public float FinalAverage
        {
            set
            {
                finalAverage = value;
                NotifyPropertyChanged("FinalAverage");
            }
            get
            {
                return finalAverage;
            }
        }
        public string ClassNumber
        {
            set
            {
                classNumber = value;
                NotifyPropertyChanged("ClassNumber");
            }
            get
            {
                return classNumber;
            }
        }

        public string Password
        {
            set
            {
                password = value;
                NotifyPropertyChanged("Password");
            }
            get
            {
                return password;
            }
        }

        public int ClassId
        {
            set
            {
                classId = value;
                NotifyPropertyChanged("ClassId");
            }
            get
            {
                return classId;
            }
        } 
        public int Unmotivated
        {
            set
            {
                unmotivated = value;
                NotifyPropertyChanged("Unmotivated");
            }
            get
            {
                return unmotivated;
            }
        }

        public string ClassName
        {
            set
            {
                className = value;
                NotifyPropertyChanged("ClassName");
            }
            get
            {
                return className;
            }
        }
        public string Specialization
        {
            set
            {
                specialization = value;
                NotifyPropertyChanged("Specialization");
            }
            get
            {
                return specialization;
            }
        }
    }
}
