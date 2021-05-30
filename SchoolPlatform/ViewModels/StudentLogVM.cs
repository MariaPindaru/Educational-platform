using SchoolPlatform.Models;
using SchoolPlatform.Models.Actions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.ViewModels
{
    class StudentLogVM : BaseVM
    {
        private string message;

        private StudentActions studentActions;
        private StudentVM currentStudent;
        public StudentLogVM()
        {
            studentActions = new StudentActions(this);
            currentStudent = studentActions.GetStudent(Helpers.Helper.CurrentUser);
            currentStudent.GradeList = studentActions.GradeList(currentStudent.StudentId);
            currentStudent.AverageGradeListCombined = studentActions.AveragesComplete(currentStudent.StudentId);
            currentStudent.AttendanceList = studentActions.AttendanceList(currentStudent.StudentId);
            currentStudent.AverageGradeList = studentActions.Averages(currentStudent.StudentId);
        }
        public StudentVM CurrentStudent
        {
            set
            {
                currentStudent = value;
                NotifyPropertyChanged("CurrentStudent");
            }
            get
            {
                return currentStudent;
            }
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
    }
}
