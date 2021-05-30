using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.ViewModels
{
    class SubjectSpecializationVM : BaseVM
    {
        private int yearID;
        private int specializationID;
        private int subjectID;
        private int profPersonID;
        private int houres;
        private bool final;
        public int YearID
        {
            set
            {
                yearID = value;
                NotifyPropertyChanged("YearID");
            }
            get
            {
                return yearID;
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
        public int SpecializationID
        {
            set
            {
                specializationID = value;
                NotifyPropertyChanged("SpecializationID");
            }
            get
            {
                return specializationID;
            }
        }
        public int SubjectID
        {
            set
            {
                subjectID = value;
                NotifyPropertyChanged("SubjectID");
            }
            get
            {
                return subjectID;
            }
        }
        public int ProfPersonID
        {
            set
            {
                profPersonID = value;
                NotifyPropertyChanged("ProfPersonID");
            }
            get
            {
                return profPersonID;
            }
        }
        public int Houres
        {
            set
            {
                houres = value;
                NotifyPropertyChanged("Houres");
            }
            get
            {
                return houres;
            }
        }
    }
}
