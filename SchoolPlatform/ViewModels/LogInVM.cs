using SchoolPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.ViewModels
{
    class LogInVM : BaseVM
    {
        private schoolEntities context = new schoolEntities();

        private Registration user = new Registration();
        public Registration User
        {
            set
            {
                user = value;
                NotifyPropertyChanged("User");
            }
            get
            {
                return user;
            }
        }
        public bool ValidRegistration()
        {
            return context.Registrations.Where(registration => registration.Username == user.Username && registration.Password == user.Password).FirstOrDefault() != null;
        }
        public bool IsStudent()
        {
            return context.Students.Where(s => s.PersonID == context.People.Where(x => x.Username == user.Username).FirstOrDefault().PersonID).FirstOrDefault() != null;
        }
        public bool IsProfessor()
        {
            return context.Professors.Where(p => p.PersonID == context.People.Where(x => x.Username == user.Username).FirstOrDefault().PersonID).FirstOrDefault() != null;
        }
        public bool IsAdmin()
        {
            return context.Admins.Where(a => a.PersonID == context.People.Where(x => x.Username == user.Username).FirstOrDefault().PersonID).FirstOrDefault() != null;
        }
        public void RememberUser()
        {
            Helpers.Helper.CurrentUser = user.Username;
        }
    }
}
