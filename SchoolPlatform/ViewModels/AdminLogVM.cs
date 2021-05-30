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
    class AdminLogVM : BaseVM
    {
        private string message;

        private AdminActions adminActions;
        private ObservableCollection<StudentVM> studentList;
        private ObservableCollection<ClassVM> classList;
        private ObservableCollection<ProfessorVM> profList;
        private ObservableCollection<Subject> subjectList;
        private ObservableCollection<Year> yearsList;
        private ObservableCollection<Specialization> specsList;

        public AdminLogVM()
        {
            adminActions = new AdminActions(this);
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
        public ObservableCollection<StudentVM> StudentList
        {
            get
            {
                studentList = adminActions.AllStudents();
                return studentList;
            }
            set
            {
                studentList = value;
                NotifyPropertyChanged("StudentList");
            }
        }
        public ObservableCollection<ProfessorVM> ProfList
        {
            get
            {
                profList = adminActions.AllProffesors();
                return profList;
            }
            set
            {
                profList = value;
                NotifyPropertyChanged("ProfList");
            }
        }
        public ObservableCollection<Year> YearsList
        {
            get
            {
                yearsList = adminActions.AllYears();
                return yearsList;
            }
            set
            {
                yearsList = value;
                NotifyPropertyChanged("YearsList");
            }
        }
        public ObservableCollection<Specialization> SpecsList
        {
            get
            {
                specsList = adminActions.AllSpecializations();
                return specsList;
            }
            set
            {
                specsList = value;
                NotifyPropertyChanged("SpecsList");
            }
        }
        public ObservableCollection<Subject> SubjectList
        {
            get
            {
                subjectList = adminActions.AllSubjects();
                return subjectList;
            }
            set
            {
                subjectList = value;
                NotifyPropertyChanged("SubjectList");
            }
        }
        public ObservableCollection<ClassVM> ClassList
        {
            get
            {
                classList = adminActions.AllClasses();
                return classList;
            }
            set
            {
                classList = value;
                NotifyPropertyChanged("ClassList");
            }
        }

        private ICommand addStudent;
        public ICommand AddStudent
        {
            get
            {
                if (addStudent == null)
                {
                    addStudent = new RelayCommand(adminActions.AddNewStudent);
                }
                return addStudent;
            }
        }
        private ICommand addSubject;
        public ICommand AddSubject
        {
            get
            {
                if (addSubject == null)
                {
                    addSubject = new RelayCommand(adminActions.AddNewSubject);
                }
                return addSubject;
            }
        }
        private ICommand updateStudent;
        public ICommand UpdateStudent
        {
            get
            {
                if (updateStudent == null)
                {
                    updateStudent = new RelayCommand(adminActions.UpdateStudent);
                }
                return updateStudent;
            }
        }
        private ICommand deleteStudent;
        public ICommand DeleteStudent
        {
            get
            {
                if (deleteStudent == null)
                {
                    deleteStudent = new RelayCommand(adminActions.DeleteStudent);
                }
                return deleteStudent;
            }
        }
        private ICommand deleteSubject;
        public ICommand DeleteSubject
        {
            get
            {
                if (deleteSubject == null)
                {
                    deleteSubject = new RelayCommand(adminActions.DeleteSubject);
                }
                return deleteSubject;
            }
        }

        private ICommand updateSubject;
        public ICommand UpdateSubject
        {
            get
            {
                if (updateSubject == null)
                {
                    updateSubject = new RelayCommand(adminActions.UpdateSubject);
                }
                return updateSubject;
            }
        }

        private ICommand addProfessor;
        public ICommand AddProfessor
        {
            get
            {
                if (addProfessor == null)
                {
                    addProfessor = new RelayCommand(adminActions.AddNewProfessor);
                }
                return addProfessor;
            }
        }
        private ICommand updateProfessor;
        public ICommand UpdateProfessor
        {
            get
            {
                if (updateProfessor == null)
                {
                    updateProfessor = new RelayCommand(adminActions.UpdateProfessor);
                }
                return updateProfessor;
            }
        }
        private ICommand deleteProfessor;
        public ICommand DeleteProfessor
        {
            get
            {
                if (deleteProfessor == null)
                {
                    deleteProfessor = new RelayCommand(adminActions.DeleteProfessor);
                }
                return deleteProfessor;
            }
        }
        private ICommand addLinkSP;
        public ICommand AddLinkSP
        {
            get
            {
                if (addLinkSP == null)
                {
                    addLinkSP = new RelayCommand(adminActions.AddLinkProfSubj);
                }
                return addLinkSP;
            }
        }

        private ICommand deleteLinkSP;
        public ICommand DeleteLinkSP
        {
            get
            {
                if (deleteLinkSP == null)
                {
                    deleteLinkSP = new RelayCommand(adminActions.DeleteLinkProfSubj);
                }
                return deleteLinkSP;
            }
        }

        private ICommand addSubjectToSpeialization;
        public ICommand AddSubjectToSpeialization
        {
            get
            {
                if (addSubjectToSpeialization == null)
                {
                    addSubjectToSpeialization = new RelayCommand(adminActions.AddSubjectToSpecialization);
                }
                return addSubjectToSpeialization;
            }
        }
        private ICommand updateHeadMaster;
        public ICommand UpdateHeadMaster
        {
            get
            {
                if (updateHeadMaster == null)
                {
                    updateHeadMaster = new RelayCommand(adminActions.AddHeadMaster);
                }
                return updateHeadMaster;
            }
        }
    }
}
