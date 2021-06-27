Imports System.Text.RegularExpressions

Public Class AssemblyInfo
    Public Shared Function IsNewerVersionThanLatestAsset(name As String) As Boolean
        Dim m As Match = Regex.Match(name, "v(\.)?((?:\d+\.)*\d+?).zip$")

        If m.Groups(1).Success Then
            Dim currentVersion As String
            Try
                currentVersion = FileVersionInfo.GetVersionInfo(Updater.NHLGamesFullPath).FileVersion
            Catch ex As Exception
                Return True
            End Try

            If currentVersion.StartsWith(m.Groups(1).Value) Then
                Return False
            End If

            Return True
        End If

        Return True
    End Function
End Class
