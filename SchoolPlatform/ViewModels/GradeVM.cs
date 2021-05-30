using SchoolPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.ViewModels
{
    class GradeVM : BaseVM
    {
        private Subject subject;
        private float grade;
        private DateTime date;
        private Semester semester;
        private bool final;
        private int profD;
        private int studentID;

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
        public float Grade
        {
            set
            {
                grade = value;
                NotifyPropertyChanged("Grade");
            }
            get
            {
                return grade;
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
        public bool Final
        {
            set
            {
                final = value;
                NotifyPropertyChanged("Final");
            }
            get
            {
                return final;
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
