using System;
using System.Globalization;
using Xamarin.Forms;

namespace Taksoo
{
    class BackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString().ToLower())
            {
                case "yes":
                    return "#00B0AE";
                case "no":
                    return "#304558";
               
            }
            return Color.Gray;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}