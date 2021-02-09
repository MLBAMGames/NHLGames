Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace NHLStats
    Module Utilities
        Function GetSeasonFromDate(ByVal inDate As String) As String
            Dim inYear As String = inDate.Substring(0, 4)
            Dim inMonth As String = inDate.Substring(5, 2)
            Dim inDay As String = inDate.Substring(8, 2)

            If (Convert.ToInt32(inMonth) > 6) Then
                Return inYear & (Convert.ToInt32(inYear) + 1).ToString()
            Else
                Return (Convert.ToInt32(inYear) - 1).ToString() & inYear
            End If
        End Function

        Function ConvertPeriodTimeToSeconds(ByVal periodTime As String) As Integer
            Dim minutesSeconds As String() = periodTime.Split(":"c)
            Dim minutes As Integer = 0
            Dim seconds As Integer = 0
            Dim isANumber As Boolean = False

            If Integer.TryParse(minutesSeconds(0), minutes) = False Then
                minutes = 0
            End If

            If Integer.TryParse(minutesSeconds(1), seconds) = False Then
                seconds = 0
            End If

            Return (minutes * 60) + seconds
        End Function

        Function ConvertSecondsToPeriodTime(ByVal inSeconds As Integer) As String
            Dim minutes As Integer = 0
            Dim seconds As Integer = 0
            Dim periodTime As String = ""
            minutes = inSeconds / 60
            seconds = inSeconds Mod 60
            periodTime = minutes.ToString() & ":" & seconds.ToString()
            Return periodTime
        End Function
    End Module
End Namespace
