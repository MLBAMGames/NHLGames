using System;
using System.Globalization;
using System.Windows.Data;

namespace NHLGames.WPF.Converters
{
    public class TeamNameToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return $"../Logos/{value}.gif".Replace(" ", "");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
