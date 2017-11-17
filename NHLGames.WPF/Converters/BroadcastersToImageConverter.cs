using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using NHLGames.WPF.Utilities;

namespace NHLGames.WPF.Converters
{
    public class BroadcastersToImageConverter : IMultiValueConverter
    {
        private readonly Dictionary<string,string> _broadcasters = new Dictionary<string, string>();

        public BroadcastersToImageConverter()
        {
            GetAllBroadcasters();
        }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string broadcaster = (string)values[0];
            StreamType streamType = (StreamType)values[1];

            if (!string.IsNullOrWhiteSpace(broadcaster))
            {
                return new BitmapImage(new Uri($"../Broadcasters/{GetBroadcasterPicFor(broadcaster)}.gif", UriKind.Relative));
            }

            switch (streamType)
            {
                case StreamType.MultiCam1:
                    return new BitmapImage(new Uri("../Icons/threec.gif", UriKind.Relative));
                case StreamType.MultiCam2:
                    return new BitmapImage(new Uri("../Icons/sixc.gif", UriKind.Relative));
                case StreamType.RefCam:
                    return new BitmapImage(new Uri("../Icons/refc.gif", UriKind.Relative));
                case StreamType.EndzoneCam1:
                    return new BitmapImage(new Uri("../Icons/endz1.gif", UriKind.Relative));
                case StreamType.EndzoneCam2:
                    return new BitmapImage(new Uri("../Icons/endz2.gif", UriKind.Relative));
            }

            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private string GetBroadcasterPicFor(string network)
        {
            string value = _broadcasters.Where(kvp => network.ToUpper().StartsWith(kvp.Key.ToString())).Select(kvp => kvp.Value).FirstOrDefault();
            return value?.ToLower();
        }

        private void GetAllBroadcasters()
        {
            _broadcasters.Add("ALT", "ALT");
            _broadcasters.Add("CBC", "CBC");
            _broadcasters.Add("CSN", "CSN");
            _broadcasters.Add("ESPN", "ESPN");
            _broadcasters.Add("FS", "FS");
            _broadcasters.Add("MSG", "MSG");
            _broadcasters.Add("NBC", "NBC");
            _broadcasters.Add("NESN", "NESN");
            _broadcasters.Add("RDS", "RDS");
            _broadcasters.Add("ROOT", "ROOT");
            _broadcasters.Add("SN", "SN");
            _broadcasters.Add("TSN", "TSN");
            _broadcasters.Add("TVAS", "TVAS");
            _broadcasters.Add("SUN", "FS");
            _broadcasters.Add("CITY", "CBC");
            _broadcasters.Add("WGN", "WGN");
            _broadcasters.Add("PRIM", "FS");
            _broadcasters.Add("CNBC", "NBC");
            _broadcasters.Add("KCOP", "FS");
            _broadcasters.Add("TCN", "CSN");
            _broadcasters.Add("USA", "NBC");
            _broadcasters.Add("ATT", "ATT");
        }
    }
}
