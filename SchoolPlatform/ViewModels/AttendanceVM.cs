using SchoolPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.ViewModels
{
    class AttendanceVM : BaseVM
    {
        private Subject subject;
        private DateTime date;
        private Semester semester;
        private string type;
        private bool motivated;
        private int profD;
        private int studentID;
        private string firstName;
        private string lastName;

        public Subject Subj
        {
            set
            {
                subject = value;
                NotifyPropertyChanged("Subj");
            }
            get
            {
                return subject;
            }
        }
        public DateTime Date
        {
            set
            {
                date = value;
                NotifyPropertyChanged("Date");
            }
            get
            {
                return date;
            }
        }
        public Semester Semester
        {
            set
            {
                semester = value;
                NotifyPropertyChanged("Semester");
            }
            get
            {
                return semester;
            }
        }
        public string FirstName
        {
            set
            {
                firstName = value;
                NotifyPropertyChanged("FirstName");
            }
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            set
            {
                lastName = value;
                NotifyPropertyChanged("LastName");
            }
            get
            {
                return lastName;
            }
        }
        public string Type
        {
            set
            {
                type = value;
                NotifyPropertyChanged("Type");
            }
            get
            {
                return type;
            }
        }
        public bool Motivated
        {
            set
            {
                motivated = value;
                NotifyPropertyChanged("Motivated");
            }
            get
            {
                return motivated;
            }
        }
        public int ProfID
        {
            set
            {
                profD = value;
                NotifyPropertyChanged("ProfID");
            }
            get
            {
                return profD;
            }
        }
        public int StudentID
        {
            set
            {
                studentID = value;
                NotifyPropertyChanged("StudentID");
            }
            get
            {
                return studentID;
            }
        }
    }
}
