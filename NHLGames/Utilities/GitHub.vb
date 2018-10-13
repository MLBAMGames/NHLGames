
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

            NHLGamesMetro.FormInstance.lnkRelease.Text = NHLGamesMetro.RmText.GetString("lnkNewVersionText")
            NHLGamesMetro.FormInstance.lnkRelease.Visible = True
            NHLGamesMetro.FormInstance.lblTip.Visible = False

            If GetLastBuildVersionSkipped() = gitHubTagVersion Then Return

            Dim changelog = BuildChangeLog(release.body)

            Dim dialogTitle = String.Format(NHLGamesMetro.RmText.GetString("msgNewVersionAvailable"), gitHubTagVersion)
            Dim dialogMessage = If (string.IsNullOrEmpty(changelog), 
                NHLGamesMetro.RmText.GetString("msgChangeLogNone"), 
                String.Format(NHLGamesMetro.RmText.GetString("msgChangeLog"), vbCrLf, changelog))
            Dim dialogResult = InvokeElement.MsgBoxBlue(
                dialogMessage,
                dialogTitle,
                MessageBoxButtons.OKCancel)

            If dialogResult = dialogResult.OK Then
                Process.Start(New ProcessStartInfo(release.html_url))
            End If

            ApplicationSettings.SetValue(SettingsEnum.LastBuildVersionSkipped, gitHubTagVersion.ToString())
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

        Private Shared Function BuildChangeLog(body As String) As String
            If String.IsNullOrWhiteSpace(body) Then Return String.Empty

            Dim releaseBodySplitted = body.Split(New Char() {vbCrLf, vbCr, vbLf})
            If Not releaseBodySplitted.Any() Then Return String.Empty

            Dim filteredBodySplitted = releaseBodySplitted.Where(Function(x) Not String.IsNullOrWhiteSpace(x) AndAlso (x.StartsWith("- ") OrElse x.StartsWith("#")))
            If Not filteredBodySplitted.Any() Then Return String.Empty

            Dim skipLeftOfChangeLog = filteredBodySplitted.SkipWhile(Function(x) Not x.Replace(" ", String.Empty).ToUpperInvariant().Contains("CHANGELOG"))
            If skipLeftOfChangeLog.Count() <= 1 Then Return String.Empty
            skipLeftOfChangeLog = skipLeftOfChangeLog.Skip(1)

            Dim skipRightOfChangeLog = skipLeftOfChangeLog.TakeWhile(Function(x) x.StartsWith("- "))
            If Not skipRightOfChangeLog.Any() Then
                skipRightOfChangeLog = skipLeftOfChangeLog
            End If

            Return skipRightOfChangeLog.Take(5).Aggregate(Function(c, n) $"{c}{vbCrLf}{n}")
        End Function

    End Class

End Namespace
