using SchoolPlatform.Helpers;
using SchoolPlatform.Models;
using SchoolPlatform.Models.Actions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SchoolPlatform.ViewModels
{
    class ProfessorLogVM : BaseVM
    {
        private string message;
        private bool isHearMaster;
        private ProfessorActions professorActions;
        private ProfessorVM currentProfessor;
        private StudentVM currentStudent;
        private Semester currentSemester;
        private GradeVM currentGrade;
        private AttendanceVM currentAttendance;
        private ObservableCollection<StudentVM> studentList;
        private ObservableCollection<StudentVM> studentListFromClass;
        private ObservableCollection<StudentVM> firstStudents;
        private ObservableCollection<StudentVM> expulsions;
        private ObservableCollection<Tuple<StudentVM, Tuple<GradeVM, GradeVM, float>>> averagesComplete;
        private ObservableCollection<Tuple<StudentVM, Tuple<GradeVM, GradeVM, float>>> fails;
        private ObservableCollection<Semester> semesters;
        private ObservableCollection<AttendanceType> attendanceTypes;
        private ObservableCollection<AttendanceVM> attendances;
        private ObservableCollection<GradeVM> averages;
        private List<float> grades;
        private Subject subject;
        private int total;
        private int averageForCurrentStudent;
        private bool unmotivated;
        public ProfessorLogVM()
        {
            this.professorActions = new ProfessorActions(this);
            currentProfessor = professorActions.GetProfessor(Helpers.Helper.CurrentUser);
            currentProfessor.ProfID = professorActions.GetProfessorID(currentProfessor.Person.PersonId);
            semesters = professorActions.GetSemesters();
            attendanceTypes = professorActions.GetAttendanceTypes();
            isHearMaster = professorActions.IsHeadMaster(currentProfessor.ProfID);

            if (isHearMaster == true)
            {
                studentListFromClass = professorActions.GetStudentsFromClass(currentProfessor.ProfID);
                InitStudents();
                InitAttendance();
                InitAverages();
                studentListFromClass = new ObservableCollection<StudentVM>(studentListFromClass.ToList().OrderByDescending(s => s.FinalAverage));
                firstStudents = new ObservableCollection<StudentVM>(studentListFromClass.Take(4));
                fails = new ObservableCollection<Tuple<StudentVM, Tuple<GradeVM, GradeVM, float>>>(averagesComplete.ToList().Where(s => s.Item2.Item3 < 5));
                expulsions = new ObservableCollection<StudentVM>(studentListFromClass.Where(s => s.Unmotivated >= 10)); 
            }
            unmotivated = false;
        }
        public string Message
        {
            set
            {
                message = value;
                NotifyPropertyChanged("Message");
            }
            get
            {
                return message;
            }
        }
        public Subject Subject
        {
            set
            {
                subject = value;
                NotifyPropertyChanged("Subject");
                NotifyPropertyChanged("StudentList");
            }
            get
            {
                return subject;
            }
        }
        public int Total
        {
            set
            { 
                total = value;
                NotifyPropertyChanged("Total");
            }
            get 
            { 
                return total; 
            }
        } 
        public int Average
        {
            set
            { 
                averageForCurrentStudent = value;
                NotifyPropertyChanged("Average");
            }
            get 
            { 
                return averageForCurrentStudent; 
            }
        } 
        public void InitStudents()
        {
            averagesComplete = new ObservableCollection<Tuple<StudentVM, Tuple<GradeVM, GradeVM, float>>>();
            foreach (var student in studentListFromClass)
            {
                student.AverageGradeListCombined = professorActions.AveragesComplete(student.StudentId);
                foreach(var avg in student.AverageGradeListCombined)
                {
                    averagesComplete.Add(new Tuple<StudentVM, Tuple<GradeVM, GradeVM, float>>(student, new Tuple<GradeVM, GradeVM, float>(avg.Item1, avg.Item2, avg.Item3)));
                }
            }  
        }
        public void InitAttendance()
        {
            attendances = new ObservableCollection<AttendanceVM>();
            foreach (var student in studentListFromClass)
            {
                student.AttendanceList = professorActions.AttendanceListComplete(student.StudentId);
                foreach (var attendance in student.AttendanceList)
                {
                    if (currentStudent == null || (currentStudent != null && currentStudent.StudentId == attendance.StudentID))
                    {
                        attendance.FirstName = student.Person.FirstName;
                        attendance.LastName = student.Person.LastName;
                        attendances.Add(attendance);
                    }
                }

            }
            NotifyPropertyChanged("Attendances");
            Total = attendances.Count;
        }
        private void UpdateAttendance()
        {
            attendances = new ObservableCollection<AttendanceVM>();
            foreach (var student in studentListFromClass)
            {
                student.AttendanceList = professorActions.AttendanceListComplete(student.StudentId);
                foreach (var attendance in student.AttendanceList)
                {
                    if (attendance.Motivated == false)
                    {
                        if (currentStudent == null || (currentStudent != null && currentStudent.StudentId == attendance.StudentID))
                        {
                            attendance.FirstName = student.Person.FirstName;
                            attendance.LastName = student.Person.LastName;
                            attendances.Add(attendance);
                        }
                    }
                }
                Total = attendances.Count;
            }
        }
        private void InitAverages()
        {
            averages = new ObservableCollection<GradeVM>();
            foreach (var student in studentListFromClass)
            {
                student.AverageGradeList = professorActions.Averages(student.StudentId);
                foreach(var average in student.AverageGradeList)
                {
                    averages.Add(average);
                }
            }
        }
        public bool Unmotivated
        {
            set
            { 
                unmotivated = value;
                
                if (unmotivated == false)
                {
                    InitAttendance();
                }
                else
                {
                    UpdateAttendance();
                }
                
                NotifyPropertyChanged("Unmotivated");
                NotifyPropertyChanged("Attendances");
            }
            get 
            { 
                return unmotivated; 
            }
        }
        public ProfessorVM CurrentProfessor
        {
            set
            {
                currentProfessor = value;
                NotifyPropertyChanged("CurrentProfessor");
            }
            get
            {
                return currentProfessor;
            }
        }
        public StudentVM CurrentStudent
        {
            set
            {
                currentStudent = value;
                if (currentStudent != null && currentSemester != null)
                {
                    currentStudent.GradeList = professorActions.GradeList(currentStudent.StudentId, subject.Name, currentSemester.Number);
                    currentStudent.AttendanceList = professorActions.AttendanceList(currentStudent.StudentId, subject.Name, currentSemester.Number);
                    float aux = 0;
                    foreach(var grade in currentStudent.GradeList)
                    {
                        aux += grade.Grade;
                    }
                    Average = professorActions.GetAverageGrade(currentStudent.StudentId, currentStudent.ClassId, currentProfessor.ProfID, subject.SubjectID, currentSemester.SemesterID);
                }
                if (unmotivated == false)
                {
                    InitAttendance();
                }
                else
                {
                    UpdateAttendance();
                }
                NotifyPropertyChanged("CurrentStudent");
                NotifyPropertyChanged("Attendances");
            }
            get
            {
                return currentStudent;
            }
        }
        public GradeVM CurrentGrade
        {
            set
            {
                currentGrade = value;

                if (currentStudent != null && currentGrade != null)
                {
                    currentGrade.StudentID = currentStudent.StudentId;
                    currentGrade.ProfID = currentProfessor.ProfID;
                }
                NotifyPropertyChanged("CurrentGrade");
            }
            get
            {
                return currentGrade;
            }
        }
        public AttendanceVM CurrentAttendance
        {
            set
            {
                currentAttendance = value;
                if (currentAttendance != null && currentStudent != null)
                {
                    currentAttendance.ProfID = currentProfessor.ProfID;
                    currentAttendance.StudentID = currentStudent.StudentId;
                }
                NotifyPropertyChanged("CurrentAttendance");
            }
            get
            {
                return currentAttendance;
            }
        }
        public Semester CurrentSemester
        {
            set
            {
                currentSemester = value;
                if (currentStudent != null && currentSemester != null)
                {
                    currentStudent.GradeList = professorActions.GradeList(currentStudent.StudentId, subject.Name, currentSemester.Number);
                    currentStudent.AverageGradeListCombined = professorActions.AveragesComplete(currentStudent.StudentId);
                    currentStudent.AttendanceList = professorActions.AttendanceList(currentStudent.StudentId, subject.Name, currentSemester.Number);
                    Average = professorActions.GetAverageGrade(currentStudent.StudentId, currentStudent.ClassId, currentProfessor.ProfID, subject.SubjectID, currentSemester.SemesterID);
                }
                NotifyPropertyChanged("CurrentSemester");
            }
            get
            {
                return currentSemester;
            }
        }
        public ObservableCollection<StudentVM> StudentList
        {
            set
            {
                studentList = value;
                NotifyPropertyChanged("StudentList");
            }
            get
            {
                if (subject != null)
                {
                    studentList = professorActions.GetStudents(professorActions.GetProfessorID(this.CurrentProfessor.Person.PersonId), this.Subject.SubjectID);
                }
                return studentList;
            }
        }
        public ObservableCollection<StudentVM> Expulsions
        {
            set
            {
                expulsions = value;
                NotifyPropertyChanged("Expulsions");
            }
            get
            {
                return expulsions;
            }
        }
        public ObservableCollection<StudentVM> FirstStudents
        {
            set
            {
                firstStudents = value;
                NotifyPropertyChanged("FirstStudents");
            }
            get
            {
                return firstStudents;
            }
        }
        public ObservableCollection<StudentVM> StudentListFromClass
        {
            set
            {
                studentListFromClass = value;
                NotifyPropertyChanged("StudentListFromClass");
            }
            get
            {
                return studentListFromClass;
            }
        }
        public ObservableCollection<Semester> Semesters
        {
            set
            {
                semesters = value;
                NotifyPropertyChanged("Semesters");
            }
            get
            {
                return semesters;
            }
        }
        public ObservableCollection<AttendanceType> AttendanceTypes
        {
            get
            {
                return attendanceTypes;
            }
        }
        public ObservableCollection<AttendanceVM> Attendances
        {
            set
            {
                attendances = value;
                NotifyPropertyChanged("Attendances");
            }
            get
            {
                return attendances;
            }
        }
        public ObservableCollection<Tuple<StudentVM, Tuple<GradeVM, GradeVM, float>>> AveragesSemesters
        {
            set
            {
                averagesComplete = value;
                NotifyPropertyChanged("AveragesSemesters");
            }
            get
            {
                return averagesComplete;
            }
        }        
        public ObservableCollection<Tuple<StudentVM, Tuple<GradeVM, GradeVM, float>>> Fails
        {
            set
            {
                fails = value;
                NotifyPropertyChanged("Fails");
            }
            get
            {
                return fails;
            }
        }
        public ObservableCollection<GradeVM> Averages
        {
            set
            {
                averages = value;
                NotifyPropertyChanged("Averages");
            }
            get
            {
                return averages;
            }
        }
        public string IsHeadMaster
        {
            get
            {
                if (isHearMaster == true)
                    return "Visible";
                return "Collapsed";
            }
        }
        public List<float> Grades
        {
            set
            {
                grades = value;
                NotifyPropertyChanged("Grades");
            }
            get
            {
                grades = Enumerable.Range(1, 10).Select(x => x / 1.0f).ToList();
                return grades;
            }
        }
        private ICommand addGrade;
        public ICommand AddGrade
        {
            get
            {
                if (addGrade == null)
                {
                    addGrade = new RelayCommand(professorActions.AddGrade);
                }
                return addGrade;
            }
        }
        private ICommand addAttedance;
        public ICommand AddAttedance
        {
            get
            {
                if (addAttedance == null)
                {
                    addAttedance = new RelayCommand(professorActions.AddAtendance);
                }
                return addAttedance;
            }
        }

        private ICommand deleteGrade;
        public ICommand DeleteGrade
        {
            get
            {
                if (deleteGrade == null)
                {
                    deleteGrade = new RelayCommand(professorActions.DeleteGrade);
                }
                return deleteGrade;
            }
        }
        private ICommand motivate;
        public ICommand Motivate
        {
            get
            {
                if (motivate == null)
                {
                    motivate = new RelayCommand(professorActions.MotivateAtendance);
                }
                return motivate;
            }
        }

        private ICommand addAverage;
        public ICommand AddAverage
        {
            get
            {
                if (addAverage == null)
                {
                    addAverage = new RelayCommand(professorActions.AddAverage);
                }
                return addAverage;
            }
        }
    }

}
