Imports System.Text.RegularExpressions

Public Class AssemblyInfo
    Public Shared Function IsNewerVersionThanCurrent(name As String) As Boolean
        Dim m As Match = Regex.Match(name, "v(\.)?((?:\d+\.)*\d+?)")

        If m.Groups(2).Success Then
            Dim availableVersion As Version = New Version(m.Groups(2).Value)
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
