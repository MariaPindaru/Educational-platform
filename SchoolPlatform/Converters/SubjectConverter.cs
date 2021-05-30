using SchoolPlatform.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SchoolPlatform.Converters
{
    class SubjectConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            foreach (var value in values)
            {
                if (value == null)
                    return null;
            }

            int number;
            return new Subject()
            {
                SubjectID = Int32.TryParse(values[0].ToString(), out number) ? number : 0 ,
                Name = values[1].ToString()
            };
        }


        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            Subject s = value as Subject;
            object[] result = new object[2] { s.SubjectID, s.Name };
            return result;
        }
    }
}
