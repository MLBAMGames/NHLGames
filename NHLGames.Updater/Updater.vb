Imports NHLGames.Updater.Utilities
Imports Ionic.Zip
Imports System.IO

Public Class Updater
    Public Const UPDATE_FILE = "update.zip"
    Public Const NHL_GAMES_APP = "nhlgames.exe"
    Public Shared ProjectDirectory As String = AppDomain.CurrentDomain.BaseDirectory + "..\"
    Public Shared NHLGamesFullPath As String = ProjectDirectory + NHL_GAMES_APP
    Public Shared UpdateFileFullPath As String = ProjectDirectory + UPDATE_FILE

    Public Shared Async Function ProcessUpdateAsync() As Task
        Try
            Dim succeeded = Await DownloadUpdateAsync()

            If Not succeeded Then
                LeaveConsole()
            End If

            ExtractDownloadedAsset()
            File.Delete(UpdateFileFullPath)
        Catch ex As Exception
            Process.Start(New ProcessStartInfo(GitHub.LATEST_RELEASE_LINK))
        End Try

        Process.Start(New ProcessStartInfo(NHLGamesFullPath))
        Environment.Exit(0)
    End Function

    Shared Async Function DownloadUpdateAsync() As Task(Of Boolean)
        Try
            Dim release = Await GitHub.GetRelease()

            If Not AssemblyInfo.IsNewerVersionThanLatestAsset(release.tag_name) Then
                Console.WriteLine("You are already using the latest version.")
                Return False
            End If

            Dim asset = GitHub.GetZipAssetFromRelease(release)

            Await Web.DownloadFileAsync(asset.browser_download_url)
        Catch ex As UnauthorizedAccessException
            Console.WriteLine($"Something went wrong during the download. Make sure it was not blocked by your Antivirus Software.{vbCrLf}" + "The error was: " + ex.Message)
            Return False
        Catch ex As Exception
            Console.WriteLine($"Something went wrong during the download.{vbCrLf} The error was:" + ex.Message)
            Return False
        End Try

        Return True
    End Function

    Public Shared Sub ExtractDownloadedAsset()
        Try
            Dim zip As ZipFile = ZipFile.Read(UpdateFileFullPath)
            Console.WriteLine("Extracting...")
            zip.ExtractAll(ProjectDirectory, ExtractExistingFileAction.OverwriteSilently)
            zip.Dispose()
        Catch ex As UnauthorizedAccessException
            Console.WriteLine("An error occurred while extracting. Make sure NHLGames is not running or Antivirus Software is interferring.")
            Console.WriteLine("You can extract the file manually at: " + UpdateFileFullPath)
            Console.WriteLine("Error Message: " + ex.Message)
            LeaveConsole()
        Catch ex As Exception
            Console.WriteLine("An error occurred while extracting")
            LeaveConsole()
        End Try

        Console.WriteLine("Successfully updated!")
    End Sub

    Public Shared Sub LeaveConsole()
        Console.WriteLine("Press any key to exit")
        Console.ReadKey()
        Environment.Exit(1)
    End Sub

End Class
