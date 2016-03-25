Imports System.IO
Imports System.Net
Imports System.Security.Principal
Imports MetroFramework

Public Class HostsFile

    Public Shared Function TestEntry(domain As String, ip As String) As Boolean
        Dim resolvedIP As String = Dns.GetHostAddresses(domain)(0).ToString()
        Return ip = resolvedIP
    End Function

    Private Shared Function RemoveOldEntries(ip As String, host As String, contents As String) As String

        Dim entry As String = ip & " " & host

        If contents.IndexOf(ip) > -1 Then
            Console.WriteLine("Removing existing entries from hosts file")
            Return contents.Replace(ip, "# " & ip)
        Else
            Return contents
        End If

    End Function

    Private Shared Sub Backup(path As String)
        Console.WriteLine("Backing up file: " & path)
        File.Copy(path, path & ".bak", True)
    End Sub

    Public Shared Sub AddEntry(ip As String, host As String)

        If EnsureAdmin() Then

            Dim HostsFilePath As String = Environment.SystemDirectory & "\drivers\etc\hosts"

            Dim fileIsReadonly As Boolean = FileAccess.IsFileReadonly(HostsFilePath)

            If fileIsReadonly Then
                FileAccess.RemoveReadOnly(HostsFilePath)
            End If

            Backup(HostsFilePath)

            Dim input As String = ""
            Using sr As New StreamReader(HostsFilePath)
                input = sr.ReadToEnd()
            End Using

            Dim output As String = RemoveOldEntries(ip, host, input)

            output = output + vbNewLine + ip & " " & host

            Using sw As New StreamWriter(HostsFilePath)
                sw.Write(output)
                sw.Close()
            End Using

            If fileIsReadonly Then
                FileAccess.AddReadonly(HostsFilePath)
            End If


            If MetroMessageBox.Show(NHLGamesMetro.FormInstance, "Do you wish to view the Hosts file confim the changes?", "Open Hosts File", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Process.Start(HostsFilePath)
            End If

        End If

    End Sub

    Public Shared Function EnsureAdmin() As Boolean

        If IsAdministrator() = False Then

            If MetroMessageBox.Show(NHLGamesMetro.FormInstance, "This application is missing the required hosts file entry. Do you want to restart this this application as an Administrator and add the required entry?", "Admin Access Required", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                'ApplicationSettings.SetValue(ApplicationSettings.Settings.InAdminModeToSetHostsEntry, True)
                ' Restart program And run as admin
                Dim exeName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName
                Dim startInfo As ProcessStartInfo = New ProcessStartInfo(exeName)
                startInfo.Verb = "runas"
                startInfo.UseShellExecute = True
                Try
                    System.Diagnostics.Process.Start(startInfo)
                    Application.Exit()
                Catch ex As Exception

                End Try

            End If
            Return False
        End If
        Return True

    End Function
    Public Shared Function IsAdministrator() As Boolean
        Dim identity As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim principal As WindowsPrincipal = New WindowsPrincipal(identity)
        Return principal.IsInRole(WindowsBuiltInRole.Administrator)
    End Function



End Class
