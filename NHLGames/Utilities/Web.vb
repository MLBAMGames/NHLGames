Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports NHLGames.My.Resources
Imports NHLGames.NHLStats
Imports NHLGames.Objects.NHL

Namespace Utilities
    Public Class Web
        Public Const UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.84 Safari/537.36"
        Private Const s = "abcdefghijklmnopqrstuvwxyz0123456789"
        Private Shared r As New Random

        Public Shared Function GetRandomString(intLength As Integer)
            Dim sb As New StringBuilder

            For i = 1 To intLength
                Dim idx As Integer = r.Next(0, 35)
                sb.Append(s.Substring(idx, 1))
            Next

            Return sb.ToString()
        End Function

        Public Shared Async Function GetScheduleAsync(startDate As DateTime) As Task(Of Schedule)
            Dim dateTimeString As String = startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
            Dim url As String = String.Format(NHLAPIServiceURLs.scheduleGames, dateTimeString, dateTimeString)

            Console.WriteLine(English.msgGettingSchedule, English.msgFetching,
                              startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture))

            Dim data = Await Web.SendWebRequestAndGetContentAsync(url)
            If data.Equals(String.Empty) Then Return Nothing

            Return JsonConvert.DeserializeObject(Of Schedule)(data)
        End Function

        Public Shared Function SetHttpWebRequest(address As String) As HttpWebRequest
            Dim defaultHttpWebRequest = CType(WebRequest.Create(New Uri(address)), HttpWebRequest)
            defaultHttpWebRequest.UserAgent = UserAgent
            defaultHttpWebRequest.Method = WebRequestMethods.Http.Head
            defaultHttpWebRequest.Proxy = WebRequest.DefaultWebProxy
            defaultHttpWebRequest.CookieContainer = New CookieContainer()
            defaultHttpWebRequest.CookieContainer.Add(New Cookie("mediaAuth", GetRandomString(240), String.Empty, "nhl.com"))

            Return defaultHttpWebRequest
        End Function

        Public Shared Async Function SendWebRequestAsync(address As String, Optional httpWebRequest As HttpWebRequest = Nothing) As Task(Of Boolean)
            If address Is Nothing AndAlso httpWebRequest Is Nothing Then Return False

            Dim myHttpWebRequest As HttpWebRequest
            Dim result = False

            myHttpWebRequest = If(httpWebRequest, SetHttpWebRequest(address))

            Try
                Using _
                    myHttpWebResponse As HttpWebResponse =
                        Await myHttpWebRequest.GetResponseAsync().ConfigureAwait(False)
                    result = (myHttpWebResponse.StatusCode = HttpStatusCode.OK)
                End Using
            Catch
            End Try

            Return result
        End Function

        Public Shared Async Function SendWebRequestAndGetContentAsync(address As String, Optional httpWebRequest As HttpWebRequest = Nothing) As Task(Of String)
            Dim content = New MemoryStream()
            Dim myHttpWebRequest As HttpWebRequest

            myHttpWebRequest = If(httpWebRequest, SetHttpWebRequest(address))
            myHttpWebRequest.Method = WebRequestMethods.Http.Get

            Try
                Using myHttpWebResponse As HttpWebResponse = Await myHttpWebRequest.GetResponseAsync().ConfigureAwait(False)
                    If myHttpWebResponse.StatusCode = HttpStatusCode.OK Then
                        Using reader As Stream = myHttpWebResponse.GetResponseStream()
                            reader.CopyTo(content)
                        End Using
                    End If
                End Using
            Catch ex As Exception
                content.Dispose()
                Return String.Empty
            End Try

            Dim result = Encoding.UTF8.GetString(content.ToArray())
            content.Dispose()

            Return result
        End Function

        Public Shared Sub GetLanguage()
            Dim language = If(My.Settings.SelectedLanguage, "English")
            If language = Lang.RmText.GetString("cbEnglish") Then
                Lang.RmText = English.ResourceManager
            ElseIf language = Lang.RmText.GetString("cbFrench") Then
                Lang.RmText = French.ResourceManager
            End If
        End Sub

        Public Shared Async Function CheckAppCanRun() As Task(Of Boolean)
            InvokeElement.SetFormStatusLabel(Lang.RmText.GetString("msgChekingRequirements"))

            Dim errorMessage = String.Empty

            If Environment.Version < New Version(4, 0, 30319, 0) Then
                errorMessage = "missingFramework"
            ElseIf Not Await SendWebRequestAsync("https://www.google.com") Then
                errorMessage = "noWebAccess"
            End If

            Await GitHub.GetVersion()
            Await GitHub.GetAccouncement()

            Dim hostName As String = Parameters.HostName
            Parameters.IsServerUp = If(Not hostName.Equals(String.Empty), Await SendWebRequestAsync($"http://{hostName}"), False)

            If Not errorMessage.Equals(String.Empty) Then
                FatalError(Lang.RmText.GetString(errorMessage))
                Console.WriteLine($"Status: {English.ResourceManager.GetString(errorMessage)}")
            End If

            Return errorMessage.Equals(String.Empty)
        End Function

        Public Shared Sub SetRedirectionServerInApp()
            Parameters.HostName = Instance.Form.cbServers.SelectedItem.ToString()
            My.Settings.SelectedServer = Parameters.HostName
            My.Settings.Save()
            Console.WriteLine(English.msgSettingUpdated, Lang.RmText.GetString("lblHostname"), Parameters.HostName)
        End Sub

        Private Shared Sub FatalError(message As String)
            If InvokeElement.MsgBoxRed($"{message} {Lang.RmText.GetString("msgNotStarting")}",
                                       Lang.RmText.GetString("msgFailure"),
                                       MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Instance.Form.Close()
            End If
        End Sub
    End Class
End Namespace
