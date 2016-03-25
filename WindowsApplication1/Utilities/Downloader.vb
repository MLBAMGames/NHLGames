Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq


Public Class Downloader

    Private Shared GamesTxtURL = "http://showtimes.ninja/static/games.txt"
    Private Shared ScheduleAPIURL = "http://statsapi.web.nhl.com/api/v1/schedule?startDate={0}&endDate={1}&expand=schedule.teams,schedule.game.content.media.epg"
    Private Shared ApplicationVersionURL = " http://showtimes.ninja/static/version.txt"

    Private Shared ApplicationVersionFileName As String = "version.txt"
    Private Shared GamesTextFileName As String = "games.txt"

    Private Shared LocalFileDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)

    Private Shared Function DownloadContents(URL As String) As String
        Dim client As New WebClient
        client.Encoding = Encoding.UTF8 'Support french chars. I'm looking at you Montreal
        Return client.DownloadString(URL)
    End Function
    Private Shared Sub DownloadFile(URL As String, fileName As String, Optional checkIfExists As Boolean = False, Optional overwrite As Boolean = True)
        Dim fullPath As String = Path.Combine(LocalFileDirectory, fileName)


        If (checkIfExists = False) OrElse (checkIfExists AndAlso My.Computer.FileSystem.FileExists(fullPath) = False) Then
            Console.WriteLine("Downloading File: " & URL & " to " & fullPath)
            My.Computer.Network.DownloadFile(URL, fullPath, "", "", False, 10000, overwrite)
        Else
            Console.WriteLine("Status: File aready exists at " & fullPath)

        End If
    End Sub

    Private Shared Function ReadFileContents(fileName As String) As String
        Dim returnValue As String = ""
        Dim filePath As String = Path.Combine(LocalFileDirectory, fileName)
        Try
            Using streamReader As IO.StreamReader = New IO.StreamReader(filePath)
                returnValue = streamReader.ReadToEnd()
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return returnValue
    End Function

    Public Shared Function DownloadApplicationVersion() As String

        Console.WriteLine("Checking: Application version")

        DownloadFile(ApplicationVersionURL, ApplicationVersionFileName)
        Return ReadFileContents(ApplicationVersionFileName).Trim()

    End Function

    Public Shared Function DownloadAvailableGames() As List(Of String)

        Console.WriteLine("Checking: Available games")

        DownloadFile(GamesTxtURL, GamesTextFileName)
        Return ReadFileContents(GamesTextFileName).Split(New Char() {vbLf}).ToList()

    End Function



    Public Shared Function DownloadJSONSchedule(startDate As DateTime) As JObject

        Console.WriteLine("Checking: Fetching game schedule for " & startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture))

        Dim returnValue As New JObject

        Dim IsTodaysSchedule = (startDate.Date.Ticks = DateHelper.GetCentralTime.Date.Ticks)
        Dim dateTimeString As String = startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        Dim fileName As String = dateTimeString & ".json"
        Dim URL As String = String.Format(ScheduleAPIURL, dateTimeString, dateTimeString)

        Dim data As String = ""

        If IsTodaysSchedule Then
            Console.WriteLine("Status: Downloading todays current schedule from " & URL)
            data = DownloadContents(URL)
        Else
            DownloadFile(URL, fileName, True)
            data = ReadFileContents(fileName)
        End If

        'returnValue = JObject.Parse(fileContent) 'Don't use above, so we can manually parse out datetime since there may be some issues there with different regions

        Dim reader As New JsonTextReader(New StringReader(data))
        reader.DateParseHandling = DateParseHandling.None
        returnValue = JObject.Load(reader)

        Return returnValue

    End Function

End Class
