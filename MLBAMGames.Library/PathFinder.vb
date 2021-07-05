Imports System.IO

Namespace Utilities
    Public Class PathFinder
        Private Shared Function _ProgramFiles(programPath As String) As String
            Dim drives As String() = Environment.GetLogicalDrives
            Dim dirPrgFiles = New ArrayList
            For Each d As String In drives
                Try
                    Dim dType = New DriveInfo(d.Substring(0, 1).ToUpper)
                    If dType.DriveType <> DriveType.CDRom Then
                        dirPrgFiles.Add(Directory.GetDirectories(d, "Program Files"))
                        If (_is64bits()) Then dirPrgFiles.Add(Directory.GetDirectories(d, "Program Files (x86)"))
                    End If
                Catch
                End Try
            Next
            Return (From dirFound As Object In dirPrgFiles Where dirFound.Length <> 0
                    Where My.Computer.FileSystem.FileExists(dirFound(0) & programPath)
                    Select dirFound(0) & programPath).FirstOrDefault()
        End Function

        Private Shared Function _is64bits() As Boolean
            Return Environment.Is64BitOperatingSystem
        End Function

        Public Shared Function GetPathOfVlc() As String
            Dim path =
                    My.Computer.Registry.GetValue(
                        "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\vlc.exe", "", Nothing)
            If path = Nothing Then
                path = _ProgramFiles("\VideoLAN\VLC\vlc.exe")
            End If
            If path = Nothing Then path = String.Empty
            Return path
        End Function

        Public Shared Function GetPathOfMpc() As String
            Dim path = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\MPC-HC\MPC-HC", "ExePath", Nothing)
            If path = Nothing Then
                Dim x64 As String = If(_is64bits(), "64", "")
                path = _ProgramFiles(String.Format("\MPC-HC\mpc-hc{0}.exe", x64))
            End If
            If path = Nothing Then path = String.Empty
            Return path
        End Function
    End Class
End Namespace
