Imports Microsoft.Win32

Public Class PathFinder
    Public Shared Function GetPathOfVLC() As String
        Return My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\vlc.exe",
                                             "", "C:\Program Files\VideoLAN\VLC\vlc.exe")
    End Function

    Public Shared Function GetPathOfMPC() As String
        Return My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\MPC-HC\MPC-HC", "ExePath", "C:\Program Files\MPC-HC\mpc-hc64.exe")
    End Function

End Class
