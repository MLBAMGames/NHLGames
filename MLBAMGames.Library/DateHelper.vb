Imports System.Globalization

Namespace Utilities
    Public Class DateHelper
        Public Shared Function GetPacificTime() As DateTime
            Return _
                TimeZoneInfo.ConvertTime(DateTime.Now(), TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time"))
        End Function

        Public Shared Function GetPacificTime(utcDate As DateTime) As DateTime
            Return TimeZoneInfo.ConvertTime(utcDate, TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time"))
        End Function

        Public Shared Function GetFormattedDate(dt As Date) As String
            Return String.Format(Lang.RmText.GetString("lblFormatWeekMonthDayYear"), dt.ToString("ddd"),
                                 dt.ToString("MMM"), dt.Day.ToString, dt.Year.ToString)
        End Function

        Public Shared Function GetFormattedWeek(number As DayOfWeek) As String
            Return If(CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(number).Length >= 2,
                      CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(number).Substring(0, 2),
                      CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(number).ToString())
        End Function
    End Class
End Namespace
