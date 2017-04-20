Imports Microsoft.Win32

Public Class PathFinder
    Public Shared Function GetPathOfVLC() As String
        Dim vlcValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\VideoLAN\VLC", "InstallDir", Nothing)
        If vlcValue.Substring(vlcValue.Length - 4, 4) <> ".exe" Then
            vlcValue += "\vlc.exe"
        End If
        Return vlcValue
    End Function

    Public Shared Function GetPathOfMPC() As String
        Return My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\MPC-HC\MPC-HC", "ExePath", Nothing)
    End Function

End Class
