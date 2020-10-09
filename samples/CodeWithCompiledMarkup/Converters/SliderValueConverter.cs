using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CodeWithCompiledMarkup.Converters
{
    public class SliderValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int valueFromSource;
            if (Int32.TryParse(value.ToString(), out valueFromSource))
            {
                valueFromSource = valueFromSource * 2;
                return valueFromSource;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
