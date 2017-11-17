using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using NHLGames.WPF.Utilities;

namespace NHLGames.WPF.Converters
{
    public class GameStateColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var gameStateEnum = (GameStateEnum?)values[0];
            var dateTime = (DateTime) values[1];
            if (gameStateEnum == GameStateEnum.Scheduled && dateTime.ToLocalTime().Date == DateTime.Now.Date)
            {
                return new BrushConverter().ConvertFrom("#41B1E1") as SolidColorBrush;
            }

            if (gameStateEnum == GameStateEnum.Scheduled)
            {
                return new SolidColorBrush(Colors.DarkGray);
            }

            if (gameStateEnum == GameStateEnum.Pregame)
            {
                return new SolidColorBrush(Colors.Green);
            }

            if (gameStateEnum == GameStateEnum.InProgress)
            {
                return new SolidColorBrush(Colors.Red);
            }

            if (gameStateEnum == GameStateEnum.Final)
            {
                return new SolidColorBrush(Colors.Gray);
            }

            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
