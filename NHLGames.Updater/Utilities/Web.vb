Imports System.Net
Imports System.Text
Imports System.IO
Imports System.ComponentModel

Namespace Utilities
    Public Class Web
        Public Const USER_AGENT = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.84 Safari/537.36"
        Const BYTES_IN_MEGABYTE = 1000000

        Shared WithEvents _wc As WebClient = New WebClient()

        Public Shared Async Function DownloadFileAsync(url As String, tag As String) As Task(Of String)
            Dim uri As Uri = New Uri(url)
            Console.WriteLine("Downloading update {0}...", tag)
            Dim fileName = Updater.ProjectDirectory + "update-" + tag + ".zip"
            Await _wc.DownloadFileTaskAsync(uri, fileName)
            Return fileName
        End Function

        Private Shared Sub WebClient_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles _wc.DownloadProgressChanged
            SyncLock e.UserState
                Console.SetCursorPosition(0, Console.CursorTop - 1)
                Console.WriteLine("{0} % completed ({1} of {2} Mo.)",
                              e.ProgressPercentage,
                              ToMo(e.BytesReceived),
                              ToMo(e.TotalBytesToReceive))
            End SyncLock
        End Sub

        Private Shared Sub WebClient_DownloadFileCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs) Handles _wc.DownloadFileCompleted
            If e.Cancelled Then
                Console.WriteLine("File download cancelled.")
            End If

            If e.Error IsNot Nothing Then
                Console.WriteLine(e.Error.ToString())
            End If
        End Sub

        Public Shared Function SetHttpWebRequest(address As String) As HttpWebRequest
            Dim uriGitHub = Nothing

            If Not Uri.TryCreate(address, UriKind.Absolute, result:=uriGitHub) Then Return Nothing

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            Dim request = CType(WebRequest.Create(uriGitHub), HttpWebRequest)
            request.Method = WebRequestMethods.Http.Get
            request.UserAgent = "NHLGames"

            Return request
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
            Catch
                content.Dispose()
                Return String.Empty
            End Try

            Dim result = Encoding.UTF8.GetString(content.ToArray())
            content.Dispose()

            Return result
        End Function

        Private Shared Function ToMo(bytes As Long) As String
            Return Math.Round((bytes / BYTES_IN_MEGABYTE), 2).ToString("0.00")
        End Function
    End Class
End Namespace
