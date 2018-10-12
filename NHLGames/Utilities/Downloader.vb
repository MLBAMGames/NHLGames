Imports System.Globalization
Imports System.IO
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports NHLGames.My.Resources

Namespace Utilities
    Public Class Downloader
        Private Const ApiUrl As String = "http://statsapi.web.nhl.com/api/v1/schedule"
        Private Shared ReadOnly Regex As New Regex("(\d+\.)(\d+\.)?(\d+\.)?(\*|\d+)")
        Private Const ScheduleApiurl As String = ApiUrl &
                                                 "?startDate={0}&endDate={1}&expand=schedule.teams,schedule.linescore,schedule.game.seriesSummary,schedule.game.content.media.epg"

        Public Shared Async Function DownloadJsonScheduleAsync(startDate As DateTime) As Task(Of JObject)
            Dim returnValue As JObject
            Dim dateTimeString As String = startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
            Dim url As String = String.Format(ScheduleApiurl, dateTimeString, dateTimeString)

            Console.WriteLine(English.msgGettingSchedule, English.msgFetching,
                              startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture))

            Dim data = Await Common.SendWebRequestAndGetContentAsync(url)

            If data.Equals(String.Empty) Then
                Console.WriteLine(English.msgServerSeemsDown, ApiUrl)
                Return New JObject()
            End If

            Dim reader As New JsonTextReader(New StringReader(data))
            reader.DateParseHandling = DateParseHandling.None
            returnValue = If(reader Is Nothing, New JObject(), JObject.Load(reader))

            Return returnValue
        End Function
    End Class
End Namespace
