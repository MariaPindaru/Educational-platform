using SchoolPlatform.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SchoolPlatform.Converters
{
    class SubjectProfessorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            foreach (var value in values)
            {
                if (value == null)
                    return null;
            }

            int number;
            return new ProfessorSubjectVM()
            {
                Subj = new Models.Subject()
                {
                    SubjectID = Int32.TryParse(values[0].ToString(), out number) ? number : 0,
                    Name = values[1].ToString()
                },
                Prof = new ProfessorVM()
                {
                    Person = new PersonVM()
                    {
                        PersonId = Int32.TryParse(values[2].ToString(), out number) ? number : 0,
                        LastName = values[3].ToString(),
                        FirstName = values[4].ToString()
                    }
                }
            };
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            ProfessorSubjectVM ps = value as ProfessorSubjectVM;
            object[] result = new object[5] { ps.Subj.SubjectID, ps.Subj.Name, ps.Prof.Person.PersonId, ps.Prof.Person.LastName, ps.Prof.Person.FirstName};
            return result;
        }
    }
}
