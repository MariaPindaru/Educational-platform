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
    class AverageGradeConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {

            foreach (var value in values)
            {
                if (value == null || string.IsNullOrEmpty(value.ToString()))
                    return null;
            }

            int number;
            float nr;
            return new GradeVM()
            {
                ProfID = Int32.TryParse(values[0].ToString(), out number) ? number : 0,
                StudentID = Int32.TryParse(values[1].ToString(), out number) ? number : 0,
                Grade = float.TryParse(values[2].ToString(), out nr) ? nr : 0,
                Subj = values[3] as Subject,
                Semester = values[4] as Semester,
            };
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            GradeVM grade = value as GradeVM;
            object[] result = new object[5] { grade.ProfID, grade.StudentID, grade.Grade, grade.Subj, grade.Semester };
            return result;
        }
    }
}
