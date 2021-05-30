using SchoolPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.ViewModels
{
    class ProfessorSubjectVM : BaseVM
    {
        private Subject subject;
        private ProfessorVM prof;
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
        public ProfessorVM Prof
        {
            set
            {
                prof = value;
                NotifyPropertyChanged("Prof");
            }
            get
            {
                return prof;
            }
        }

    }
}
