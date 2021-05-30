using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using SchoolPlatform.ViewModels;

namespace SchoolPlatform.Converters
{
    class ProfessorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            foreach (var value in values)
            {
                if (value == null)
                    return null;
            }
            int number;
            return new ProfessorVM()
            {
                Person = new PersonVM()
                {
                    FirstName = values[0].ToString(),
                    LastName = values[1].ToString(),
                    Username = values[2].ToString(),
                    PersonId = Int32.TryParse(values[3].ToString(), out number) ? number : 0
                },
                Password = values[4].ToString()
            };
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            ProfessorVM prof = value as ProfessorVM;
            object[] result = new object[5] { prof.Person.FirstName, prof.Person.LastName, prof.Person.Username, prof.Person.PersonId, prof.Password};
            return result;
        }
    }
}
