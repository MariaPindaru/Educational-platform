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
    class SubjectSpecializationConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            foreach (var value in values)
            {
                if (value == null)
                    return null;
            }
            int number;
            return new SubjectSpecializationVM()
            {
                ProfPersonID = Int32.TryParse(values[0].ToString(), out number) ? number : 0,
                SubjectID = Int32.TryParse(values[1].ToString(), out number) ? number : 0,
                YearID = Int32.TryParse(values[2].ToString(), out number) ? number : 0,
                SpecializationID = Int32.TryParse(values[3].ToString(), out number) ? number : 0,
                Houres = Int32.TryParse(values[4].ToString(), out number) ? number : 0,
                Final =  (bool)values[5] 
            };
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            SubjectSpecializationVM ss = value as SubjectSpecializationVM;
            object[] result = new object[6] { ss.ProfPersonID, ss.SubjectID, ss.YearID, ss.SpecializationID, ss.Houres, ss.Final};
            return result;
        }
    }
}
