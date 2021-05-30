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
    class ClassConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            foreach (var value in values)
            {
                if (value == null)
                    return null;
            }

            int number;
            return new ClassVM()
            {
                HeadMasterID = Int32.TryParse(values[0].ToString(), out number) ? number : 0,
                ClassID = Int32.TryParse(values[1].ToString(), out number) ? number : 0
            };
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            ClassVM classs = value as ClassVM;
            object[] result = new object[2] { classs.HeadMasterID, classs.HeadMasterID };
            return result;
        }
    }
}
