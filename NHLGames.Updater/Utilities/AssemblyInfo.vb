Imports System.Text.RegularExpressions

Public Class AssemblyInfo
    Public Shared Function IsNewerVersionThanCurrent(name As String) As Boolean
        Dim m As Match = Regex.Match(name, "v(\.)?((?:\d+\.)*\d+?)")
        Dim version = m.Groups(m.Groups.Count - 1)

        If version.Success Then
            Dim availableVersion As Version = New Version(version.Value)
            Dim currentVersion As Version
            Try
                currentVersion = New Version(FileVersionInfo.GetVersionInfo(Updater.NHLGamesFullPath).FileVersion)
            Catch ex As Exception
                Return True
            End Try

            If availableVersion > currentVersion Then
                Return True
            End If

            Return False
        End If

        Return False
    End Function
End Class
