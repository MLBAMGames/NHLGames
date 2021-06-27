Imports NHLGames.Updater.Utilities
Imports NHLGames.Updater.Objects
Imports Ionic.Zip
Imports System.IO

Public Class Updater
    Public Const NHL_GAMES_APP = "nhlgames.exe"
    Public Shared ProjectDirectory As String = AppDomain.CurrentDomain.BaseDirectory + "..\"
    Public Shared NHLGamesFullPath As String = ProjectDirectory + NHL_GAMES_APP

    Public Shared Async Function ProcessUpdateAsync() As Task
        Try
            Dim releases = Await GitHub.GetReleases()
            For Each release As Objects.GitHub.Release In releases
                Dim fileName = Await DownloadUpdateAsync(release)
                ExtractDownloadedAsset(fileName)
                File.Delete(fileName)
            Next
        Catch ex As Exception
            LeaveConsole()
            Process.Start(New ProcessStartInfo(GitHub.LATEST_RELEASE_LINK))
        End Try

        Console.WriteLine("Successfully updated!")
        Process.Start(New ProcessStartInfo(NHLGamesFullPath))
        Environment.Exit(0)
    End Function

    Shared Async Function DownloadUpdateAsync(release As Objects.GitHub.Release) As Task(Of String)
        Try
            Dim asset = GitHub.GetZipAssetFromRelease(release)
            Return Await Web.DownloadFileAsync(asset.browser_download_url, release.tag_name)
        Catch ex As UnauthorizedAccessException
            Console.WriteLine($"Something went wrong during the download. Make sure it was not blocked by your Antivirus Software.{vbCrLf}Error Message: " + ex.Message)
            Throw ex
        Catch ex As Exception
            Console.WriteLine($"Something went wrong during the download.{vbCrLf}Error Message: " + ex.Message)
            Throw ex
        End Try
    End Function

    Public Shared Sub ExtractDownloadedAsset(fileName As String)
        Try
            Dim zip As ZipFile = ZipFile.Read(fileName)
            Console.WriteLine("Extracting...")
            zip.ExtractAll(ProjectDirectory, ExtractExistingFileAction.OverwriteSilently)
            zip.Dispose()
        Catch ex As UnauthorizedAccessException
            Console.WriteLine("An error occurred while extracting. Make sure NHLGames is not running or Antivirus Software is interferring.")
            Console.WriteLine("You can extract the file manually at: " + fileName)
            Console.WriteLine("Error Message: " + ex.Message)
            Throw ex
        Catch ex As Exception
            Console.WriteLine("An error occurred while extracting")
            Throw ex
        End Try
    End Sub

    Public Shared Sub LeaveConsole()
        Console.WriteLine("Press any key to exit")
        Console.ReadKey()
        Environment.Exit(1)
    End Sub

End Class
