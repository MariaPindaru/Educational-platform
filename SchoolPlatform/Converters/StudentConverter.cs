using SchoolPlatform.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SchoolPlatform.Converters
{
    class StudentConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            foreach (var value in values)
            {
                if (value == null)
                    return null;
            }
            int number;
            return new StudentVM()
            {
                Person = new PersonVM()
                {
                    FirstName = values[0].ToString(),
                    LastName = values[1].ToString(),
                    Username = values[2].ToString(),
                    PersonId = Int32.TryParse(values[9].ToString(), out number) ? number : 0
                },
                Specialization = values[3].ToString(),
                ClassNumber = values[4].ToString(),
                ClassName = values[5].ToString(),
                Password = values[6].ToString(),
                StudentId = Int32.TryParse(values[7].ToString(), out number) ? number : 0 ,
                ClassId = Int32.TryParse(values[8].ToString(), out number) ? number : 0 
            };

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            StudentVM student = value as StudentVM;
            object[] result = new object[10] { student.Person.FirstName, student.Person.LastName, student.Person.Username,
                student.Specialization, student.ClassNumber , student.ClassName, student.Password, student.StudentId, student.ClassId,  student.Person.PersonId};
            return result;
        }
    }
}
