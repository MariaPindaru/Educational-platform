using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.ViewModels
{
    class ClassVM : BaseVM
    {
        private int classID;
        private string yearName;
        private string letter;
        private string specialization;
        private int headMasterPersID;
        private ProfessorVM headMaster;

        public int ClassID
        {
            set
            {
                classID = value;
                NotifyPropertyChanged("ClassID");
            }
            get
            {
                return classID;
            }
        }
        public int HeadMasterID
        {
            set
            {
                headMasterPersID = value;
                NotifyPropertyChanged("HeadMasterID");
            }
            get
            {
                return headMasterPersID;
            }
        }
        public ProfessorVM HeadMaster
        {
            set
            {
                headMaster = value;
                NotifyPropertyChanged("HeadMaster");
            }
            get
            {
                return headMaster;
            }
        }
        public string YearName
        {
            set
            {
                yearName = value;
                NotifyPropertyChanged("YearName");
            }
            get
            {
                return yearName;
            }
        }
        public string Letter
        {
            set
            {
                letter = value;
                NotifyPropertyChanged("Letter");
            }
            get
            {
                return letter;
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
