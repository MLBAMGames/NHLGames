Imports System.Globalization
Imports System.Net
Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class GameStream

    Public GameURL As String = ""
    Public VODURL As String = ""
    Public PlayBackID As String = ""
    Public Type As StreamType

    Public Enum StreamType
        Away
        Home
        National
        French
    End Enum

    Public ReadOnly Property Availability As String
        Get
            If IsAvailable Then
                Return "Watch"
            Else
                'Return "Unavailable"
                Return ""
            End If
        End Get
    End Property

    Public Property IsAvailable As Boolean = False

    Public Property IsVOD As Boolean = False

    Public Property Network As String

    Public Sub New()

    End Sub
    Public Sub New(game As Game, stream As JObject, availableGameIds As HashSet(Of String), type As StreamType)
        Dim dateString As String = game.Date.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture).Replace("-", "/")
        Dim dateString2 As String = game.Date.ToString("yyyyMMdd", CultureInfo.InvariantCulture)
        Dim feedType As String = stream.Property("mediaFeedType").Value.ToString().Replace("AWAY", "VISIT")

        Me.PlayBackID = stream.Property("mediaPlaybackId").Value.ToString()
        'Me.GameURL = "http://hlslive-CDN.med2.med.nhl.com/ls04/nhl/" & dateString & "/NHL_GAME_VIDEO_" & game.AwayAbbrev & game.HomeAbbrev & "_M2_" & feedType & "_" & dateString2 & "/master_wired60.m3u8"

        If availableGameIds.Contains(PlayBackID) OrElse availableGameIds.Contains(PlayBackID & "akc") OrElse availableGameIds.Contains(PlayBackID & "l3c") Then
            IsAvailable = True
        End If

        Dim args = ApplicationSettings.Read(Of Game.GameWatchArguments)(ApplicationSettings.Settings.DefaultWatchArgs)
        Dim address As String = "http://107.6.175.181/m3u8/" & GameManager.GamesListDate.ToString("yyyy-MM-dd") & "/" & Me.PlayBackID & args.CDN

        If IsAvailable Then
            If CheckURL(address) Then
                Dim client As WebClient = New WebClient()
                client.Headers.Set("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, Like Gecko) Chrome/48.0.2564.82 Safari/537.36 Edge/14.14316")
                Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
                Me.GameURL = reader.ReadToEnd()
            Else
                IsAvailable = False
            End If
        End If

        Me.VODURL = "http://hlsvod-akc.med2.med.nhl.com/ps01/nhl/" & dateString & "/NHL_GAME_VIDEO_" & game.AwayAbbrev & game.HomeAbbrev & "_M2_" & feedType & "_" & dateString2 & "/master_wired60.m3u8"
        Me.Type = type
        Me.Network = stream.Property("callLetters")
    End Sub

    Public Sub CheckVOD(ByVal strCDN As String)

        Try
            Dim myHttpWebRequest As HttpWebRequest = CType(WebRequest.Create(Me.VODURL.Replace("CDN", strCDN)), HttpWebRequest)
            myHttpWebRequest.CookieContainer = New CookieContainer()
            myHttpWebRequest.CookieContainer.Add(New Cookie("mediaAuth", Common.GetRandomString(240), String.Empty, "nhl.com"))
            myHttpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, Like Gecko) Chrome/48.0.2564.82 Safari/537.36 Edge/14.14316"

            Dim myHttpWebResponse As HttpWebResponse = CType(myHttpWebRequest.GetResponse(), HttpWebResponse)
            If myHttpWebResponse.StatusCode = HttpStatusCode.OK Then
                IsVOD = True
            End If
            myHttpWebResponse.Close()
        Catch e As Exception
            Console.WriteLine("Trying VOD : {0}", e.Message)
        End Try
    End Sub

    Public Sub CheckDuplicate(ByVal strCDN As String)
        Dim duplicate As String = If(IsVOD, VODURL.Replace("CDN", strCDN), GameURL.Replace("CDN", strCDN))
        duplicate = duplicate.Substring(0, duplicate.LastIndexOf("/")) & "_1" & duplicate.Substring(duplicate.LastIndexOf("/"), duplicate.Length - duplicate.LastIndexOf("/"))

        Try
            Dim myHttpWebRequest As HttpWebRequest = CType(WebRequest.Create(duplicate), HttpWebRequest)
            myHttpWebRequest.CookieContainer = New CookieContainer()
            myHttpWebRequest.CookieContainer.Add(New Cookie("mediaAuth", Common.GetRandomString(240), String.Empty, "nhl.com"))
            myHttpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, Like Gecko) Chrome/48.0.2564.82 Safari/537.36 Edge/14.14316"

            Dim myHttpWebResponse As HttpWebResponse = CType(myHttpWebRequest.GetResponse(), HttpWebResponse)
            If myHttpWebResponse.StatusCode = HttpStatusCode.OK Then
                If IsVOD Then
                    VODURL = duplicate
                Else
                    GameURL = duplicate
                End If
            End If
            myHttpWebResponse.Close()
        Catch e As Exception
            Console.WriteLine("Trying Duplicate : {0}", e.Message)
        End Try
    End Sub

    Private Function CheckURL(ByVal address As String)
        Try
            Dim myHttpWebRequest As HttpWebRequest = CType(WebRequest.Create(address), HttpWebRequest)
            myHttpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, Like Gecko) Chrome/48.0.2564.82 Safari/537.36 Edge/14.14316"
            Dim myHttpWebResponse As HttpWebResponse = CType(myHttpWebRequest.GetResponse(), HttpWebResponse)
            myHttpWebResponse.Close()

            If myHttpWebResponse.StatusCode = HttpStatusCode.OK Then
                Return True
            End If

            Return False
        Catch e As Exception
            Return False
        End Try
    End Function

End Class
