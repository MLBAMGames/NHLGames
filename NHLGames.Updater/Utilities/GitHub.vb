
Imports System.Net
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports NHLGames.Updater.Objects.GitHub

Namespace Utilities

    Public Class GitHub

        Public Const API_LATEST_RELEASE_LINK As String = "https://api.github.com/repos/NHLGames/NHLGames/releases/latest"
        Public Const LATEST_RELEASE_LINK As String = "https://github.com/NHLGames/NHLGames/releases/latest"

        Public Shared Async Function GetRelease() As Task(Of Release)
            Dim request = Web.SetHttpWebRequest(API_LATEST_RELEASE_LINK)

            Console.WriteLine("Getting latest release...")

            Dim content = Await Web.SendWebRequestAndGetContentAsync(Nothing, request)
            Dim release = JsonConvert.DeserializeObject(Of Release)(content)

            If release Is Nothing Then
                Console.WriteLine("Latest release not found.")
                Return Nothing
            End If

            Console.WriteLine("Latest release: {0}", release.tag_name)

            Return release
        End Function

        Public Shared Function GetZipAssetFromRelease(release As Release) As Asset
            Dim asset = release.assets.Where(Function(a) Regex.IsMatch(a.name, "^NHLGames(-|\.)(v?)(\.)?\d+(\.\d+)?(\.\d+)?(-simplified)?.zip$")).FirstOrDefault()
            If asset Is Nothing Then
                Console.WriteLine("This Release did not have any suitable asset to download. Try again later.")
            Else
                Console.WriteLine("Release asset found: {0}", asset.name)
            End If
            Return asset
        End Function

    End Class

End Namespace
