using SchoolPlatform.Models;
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
    class AttendanceConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            foreach (var value in values)
            {
                if (value == null)
                    return null;
            }

            int number;
            return new AttendanceVM()
            {
                ProfID = Int32.TryParse(values[0].ToString(), out number) ? number : 0,
                StudentID = Int32.TryParse(values[1].ToString(), out number) ? number : 0,
                Date = DateTime.Parse(values[2].ToString()),  
                Subj = values[3] as Subject,
                Semester = values[4] as Semester,
                Type = values[5].ToString()
            };
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            AttendanceVM a = value as AttendanceVM;
            object[] result = new object[6] { a.ProfID, a.StudentID, a.Date, a.Subj, a.Semester, a.Type };
            return result;
        }
    }
}
