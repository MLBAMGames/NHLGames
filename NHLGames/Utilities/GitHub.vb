
Imports System.Net
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports NHLGames.Objects.GitHub

Namespace Utilities

    Public Class GitHub

        Private Shared ReadOnly _regexVersion As Regex = New Regex($"(\d+\.)(\d+\.)?(\d+\.)?(\*|\d+)")
        Private Shared ReadOnly _regexTag As Regex = New Regex($"[^0-9.]")
        Private Const _repoLink As String = "https://api.github.com/repos/NHLGames/NHLGames"

        Public Shared Async Function GetVersion() As Task
            Dim request = GetGitHubApiRequest($"{_repoLink}/releases/latest")

            If request Is Nothing Then Return

            Dim content = Await Common.SendWebRequestAndGetContentAsync(Nothing, request)
            Dim release = JsonConvert.DeserializeObject(Of Release)(content)

            If release Is Nothing Then Return

            Dim versionTag = ParseTagToVersionString(release.tag_name)

            If Not _regexVersion.IsMatch(versionTag) Then Return

            Dim gitHubTagVersion = New Version(versionTag)
            Dim assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version

            If gitHubTagVersion <= assemblyVersion Then Return

            NHLGamesMetro.FormInstance.lnkDownload.Text = String.Format(
                    NHLGamesMetro.RmText.GetString("msgNewVersionText"),
                    gitHubTagVersion.ToString())
            NHLGamesMetro.FormInstance.lnkDownload.Width = 700

            If GetLastBuildVersionSkipped() = assemblyVersion Then Return

            Dim dialogTitle = String.Format(NHLGamesMetro.RmText.GetString("msgNewVersionAvailable"), gitHubTagVersion)
            Dim dialogMessage = String.Empty

            If Not String.IsNullOrWhiteSpace(release.body) Then
                Dim releaseBodySplitted = release.body.Split(New Char() {"\r\n", "\r", "\n"})
                dialogMessage = releaseBodySplitted.Take(5).Aggregate(Function(c, n) $"{c}\n{n}")
            End If

            Dim dialogResult = InvokeElement.MsgBoxBlue(
                dialogMessage,
                dialogTitle,
                MessageBoxButtons.OKCancel)

            If dialogResult = dialogResult.OK Then
                Process.Start(New ProcessStartInfo(release.html_url))
            Else
                ApplicationSettings.SetValue(SettingsEnum.LastBuildVersionSkipped, assemblyVersion.ToString())
            End If
        End Function

        Public Shared Async Function GetAccouncement() As Task
            Dim request = GetGitHubApiRequest($"{_repoLink}/issues?state=open&labels=announcement")

            If request Is Nothing Then Return

            Dim content = Await Common.SendWebRequestAndGetContentAsync(Nothing, request)
            Dim issues = JsonConvert.DeserializeObject(Of Issue())(content)

            If issues.Count = 0 Then Return
            Dim issue = issues.First()

            If String.IsNullOrWhiteSpace(issue.title) OrElse String.IsNullOrWhiteSpace(issue.body) Then Return

            Dim issueBodySplitted = issue.body.Split(New Char() {"\r\n", "\r", "\n"})
            Dim dialogMessage = issueBodySplitted.Take(5).Aggregate(Function(c, n) $"{c}\n{n}")

            Dim dialogResult = InvokeElement.MsgBoxBlue(
                dialogMessage,
                NHLGamesMetro.RmText.GetString("msgAnnouncement"),
                MessageBoxButtons.OK)
        End Function

        Private Shared Function GetGitHubApiRequest(url As String) As HttpWebRequest
            Dim uriGitHub = Nothing

            If Not Uri.TryCreate(url, UriKind.Absolute, result:=uriGitHub) Then Return Nothing

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            Dim request = CType(WebRequest.Create(uriGitHub), HttpWebRequest)
            request.Method = WebRequestMethods.Http.Get
            request.UserAgent = "NHLGames"

            Return request
        End Function

        Private Shared Function GetLastBuildVersionSkipped() As Version
            Dim lastBuildVersionSkipped = ApplicationSettings.Read(Of String)(SettingsEnum.LastBuildVersionSkipped, String.Empty)
            If Not _regexVersion.IsMatch(lastBuildVersionSkipped) Then Return Nothing

            Return New Version(lastBuildVersionSkipped)
        End Function

        Private Shared Function ParseTagToVersionString(tag As String) As String
            Return If(String.IsNullOrEmpty(tag), String.Empty, _regexTag.Replace(tag, String.Empty))
        End Function

    End Class

End Namespace
