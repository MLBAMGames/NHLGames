using System;
using System.Windows;
using System.Windows.Data;

namespace NHLGames.WPF.Converters
{
    public class ReverseBooleanToVisibilityConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var visibility = Visibility.Collapsed;
            if (parameter != null)
            {
                visibility = (Visibility) parameter;
            }

            var b = (bool)value;
            if (b)
            {
                return visibility;
            }
            else
            {
                return Visibility.Visible;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return false;
        }
    }
}
