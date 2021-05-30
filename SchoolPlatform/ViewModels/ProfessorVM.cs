using SchoolPlatform.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.ViewModels
{
    class ProfessorVM : BaseVM
    {
        private PersonVM person;
        private string password;
        private int profID;
        private ObservableCollection<Subject> subjectsList;
        public ProfessorVM()
        {
            person = new PersonVM();
            subjectsList = new ObservableCollection<Subject>();
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
        public ObservableCollection<Subject> SubjectsList
        {
            get
            {
                return subjectsList;
            }
            set
            {
                subjectsList = value;
                NotifyPropertyChanged("SubjectsList");
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
        public int ProfID
        {
            set
            {
                profID = value;
                NotifyPropertyChanged("ProfID");
            }
            get
            {
                return profID;
            }
        }
    }
}
