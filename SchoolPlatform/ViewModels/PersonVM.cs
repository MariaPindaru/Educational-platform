using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.ViewModels
{
    class PersonVM : BaseVM
    {
        private int personId;
        private string firstName;
        private string lastName;
        private string username;
        public int PersonId
        {
            set
            {
                personId = value;
                NotifyPropertyChanged("PersonId");
            }
            get
            {
                return personId;
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

        public string Username
        {
            set
            {
                username = value;
                NotifyPropertyChanged("Username");
            }
            get
            {
                return username;
            }
        }
    }
}
