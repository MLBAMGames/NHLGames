Imports System.IO

Public Class Updater
    Public Const UPDATER_TMP_DIRECTORY = "tmp_updater"
    Public Const UPDATER_DIRECTORY = "updater"
    Public Shared ProjectDirectory As String = AppDomain.CurrentDomain.BaseDirectory

    Public Shared UpdaterExtractedTempDirectoryPath = $"{ProjectDirectory}{UPDATER_TMP_DIRECTORY}"
    Public Shared UpdaterExtractedContentDirectoryPath = $"{UpdaterExtractedTempDirectoryPath}\{UPDATER_DIRECTORY}"
    Public Shared UpdaterDirectoryPath = $"{ProjectDirectory}{UPDATER_DIRECTORY}"

    Public Shared Sub UpgradeSettings()
        If Directory.Exists(UpdaterExtractedContentDirectoryPath) Then
            My.Settings.Upgrade()
            My.Settings.Save()
            UpdateDirectoryContent()
        End If
    End Sub

    Private Shared Sub UpdateDirectoryContent()
        Try
            Directory.Delete(UpdaterDirectoryPath, recursive:=True)
            Directory.Move(UpdaterExtractedContentDirectoryPath, UpdaterDirectoryPath)
            Directory.Delete(UpdaterExtractedTempDirectoryPath)
        Catch
        End Try
    End Sub
End Class
