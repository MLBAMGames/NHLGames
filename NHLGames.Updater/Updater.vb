Imports NHLGames.Updater.Utilities
Imports NHLGames.Updater.Objects
Imports Ionic.Zip
Imports System.IO

Public Class Updater
    Public Const UPDATER_DIRECTORY = "updater"
    Public Const UPDATER_TMP_DIRECTORY = "tmp_updater"
    Public Const NHL_GAMES_APP = "nhlgames.exe"
    Public Shared ProjectDirectory As String = AppDomain.CurrentDomain.BaseDirectory + "..\"
    Public Shared UpdaterTempFullPath As String = $"{ProjectDirectory}{UPDATER_TMP_DIRECTORY}"
    Public Shared NHLGamesFullPath As String = $"{ProjectDirectory}{NHL_GAMES_APP}"

    Public Shared Async Function ProcessUpdateAsync() As Task
        DeleteTempFiles()

        Try
            Dim releases = Await GitHub.GetReleases()

            If Not releases.Any() Then Return

            For Each release As Objects.GitHub.Release In releases
                Console.WriteLine("Updating to release {0}...", release.tag_name)
                Dim fileName = Await DownloadUpdateAsync(release)
                If fileName <> String.Empty Then
                    ExtractDownloadedAsset(fileName)
                    File.Delete(fileName)
                End If
            Next

            Console.WriteLine("Successfully updated!")
            Process.Start(New ProcessStartInfo(NHLGamesFullPath))
        Catch ex As Exception
            Process.Start(New ProcessStartInfo(GitHub.LATEST_RELEASE_LINK))
            LeaveConsole()
        Finally
            Environment.Exit(0)
        End Try
    End Function

    Shared Async Function DownloadUpdateAsync(release As Objects.GitHub.Release) As Task(Of String)
        Try
            Dim asset = GitHub.GetZipAssetFromRelease(release)
            Return Await Web.DownloadFileAsync(asset.browser_download_url, release.tag_name)
        Catch ex As ReleaseAssetNotFoundException
            Return String.Empty
        Catch ex As UnauthorizedAccessException
            Console.WriteLine($"Something went wrong during the download. Make sure it was not blocked by your Antivirus Software.")
            Console.WriteLine("Error Message: {0}", ex.Message)
            Throw ex
        Catch ex As Exception
            Console.WriteLine($"Something went wrong during the download.")
            Console.WriteLine("Error Message: {0}", ex.Message)
            Throw ex
        End Try
    End Function

    Public Shared Sub ExtractDownloadedAsset(fileName As String)
        Dim zip As ZipFile = Nothing
        Try
            zip = ZipFile.Read(fileName)
            Console.WriteLine("Extracting...")
            For Each entry In zip.Entries()
                If Path.GetDirectoryName(entry.FileName) = UPDATER_DIRECTORY Then
                    entry.Extract(UpdaterTempFullPath, ExtractExistingFileAction.OverwriteSilently)
                Else
                    entry.Extract(ProjectDirectory, ExtractExistingFileAction.OverwriteSilently)
                End If
            Next
        Catch ex As UnauthorizedAccessException
            Console.WriteLine("An error occurred while extracting. Make sure NHLGames is not running or Antivirus Software is interferring.")
            Console.WriteLine("You can extract the file manually at: {0}", fileName)
            Console.WriteLine("Error Message: {0}", ex.Message)
            Throw ex
        Catch ex As Exception
            Console.WriteLine("An error occurred while extracting")
            Console.WriteLine("Error Message: {0}", ex.Message)
            Throw ex
        Finally
            DeleteTempFiles()
            If zip IsNot Nothing Then
                zip.Dispose()
            End If
        End Try
    End Sub

    Public Shared Sub LeaveConsole()
        Console.WriteLine("Press any key to exit")
        Console.ReadKey()
    End Sub

    Private Shared Sub DeleteTempFiles()
        For Each filename As String In Directory _
            .EnumerateFiles(ProjectDirectory, "*.*", SearchOption.AllDirectories) _
            .Where(Function(s) {".tmp", ".pendingoverwrite"}.Any(Function(ext) s.ToLower().EndsWith(ext)))
            Try
                File.Delete(filename)
            Catch ex As Exception
            End Try
        Next
    End Sub

End Class
