using System;
using System.Globalization;

namespace NHLGames.WPF.Utilities
{
    public class DateHelper
    {
        public static DateTime GetPacificTime()
        {
            return TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time"));
        }

        public static DateTime GetPacificTime(DateTime utcDate)
        {
            return TimeZoneInfo.ConvertTime(utcDate, TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time"));
        }

        public static string GetFormattedDate(DateTime dt)
        {
            return string.Format(Properties.Resources.formatWeekMonthDayYear, dt.ToString("ddd"), dt.ToString("MMM"), dt.Day, dt.Year);
        }

        public static string GetFormattedWeek(DayOfWeek number)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(number).Length >= 2 ? CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(number).Substring(0, 2) : CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(number).ToString();
        }
    }
}