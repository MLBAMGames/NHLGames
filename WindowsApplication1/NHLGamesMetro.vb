Imports System.Globalization
Imports System.IO
Imports System.Security.Permissions
Imports System.Threading
Imports MetroFramework
Imports MetroFramework.Forms
Imports Newtonsoft.Json.Linq
Imports NHLGames.TextboxConsoleOutputRediect

Public Class NHLGamesMetro

    Private AvailableGames As New List(Of String)
    Private Const ServerIP As String = "146.185.131.14"
    Private Const DomainName As String = "mf.svc.nhl.com"

    Public Shared FormInstance As NHLGamesMetro = Nothing

    ' Starts the application. -- See: https://msdn.microsoft.com/en-us/library/system.windows.forms.application.threadexception(v=vs.110).aspx
    <SecurityPermission(SecurityAction.Demand, Flags:=SecurityPermissionFlag.ControlAppDomain)>
    Public Shared Sub Main()
        ' Add the event handler for handling UI thread exceptions to the event.
        AddHandler Application.ThreadException, AddressOf Form1_UIThreadException

        ' Set the unhandled exception mode to force all Windows Forms errors to go through our handler.
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)

        ' Add the event handler for handling non-UI thread exceptions to the event. 
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException

        Dim form As New NHLGamesMetro()
        FormInstance = form

        'Setup redirecting console.out to 
        Dim _writer = New TextBoxStreamWriter(form.RichTextBox)
        Console.SetOut(_writer)

        '' Runs the application.
        Application.Run(form)
    End Sub

    Private Sub IntitializeApplicationSettings()

        Dim mpcPath As String = ApplicationSettings.Read(Of String)(ApplicationSettings.Settings.MPCPath, "")
        If mpcPath = "" Then
            mpcPath = FileAccess.LocateEXE("mpc-hc64.exe", "\MPC-HC")
            If mpcPath = String.Empty Then
                mpcPath = "Unknown"
            Else
                ApplicationSettings.SetValue(ApplicationSettings.Settings.MPCPath, mpcPath)
            End If
        End If

        txtMPCPath.Text = mpcPath


        Dim vlcPath As String = ApplicationSettings.Read(Of String)(ApplicationSettings.Settings.VLCPath, "")
        If vlcPath = "" Then
            vlcPath = FileAccess.LocateEXE("vlc.exe", "\VideoLAN\VLC")
            If vlcPath = String.Empty Then
                vlcPath = "Unknown"
            Else
                ApplicationSettings.SetValue(ApplicationSettings.Settings.VLCPath, vlcPath)
            End If
        End If
        txtVLCPath.Text = vlcPath


        Dim liveStreamerPath As String = ApplicationSettings.Read(Of String)(ApplicationSettings.Settings.LiveStreamerPath, "")
        If liveStreamerPath = "" Then
            liveStreamerPath = Application.StartupPath & "\livestreamer-v1.12.2\livestreamer.exe"
            ApplicationSettings.SetValue(ApplicationSettings.Settings.LiveStreamerPath, liveStreamerPath)
        End If
        txtLiveStreamPath.Text = liveStreamerPath

        MetroCheckBox1.Checked = ApplicationSettings.Read(Of Boolean)(ApplicationSettings.Settings.ShowScores, True)


    End Sub

    ' Handle the UI exceptions by showing a dialog box, and asking the user whether
    ' or not they wish to abort execution.
    Private Shared Sub Form1_UIThreadException(ByVal sender As Object, ByVal t As ThreadExceptionEventArgs)
        Console.WriteLine("Error: " & t.Exception.ToString())
    End Sub

    Private Shared Sub CurrentDomain_UnhandledException(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
        Console.WriteLine(e.ExceptionObject.ToString())

    End Sub

    Public Sub HandleException(e As Exception)

        Console.WriteLine(e.ToString())

    End Sub
    Private Sub VersionCheck()

        Dim strLatest = Downloader.DownloadApplicationVersion()
        Console.WriteLine("Status: Current version is " & strLatest)
        Dim versionFromSettings = ApplicationSettings.Read(Of String)(ApplicationSettings.Settings.Version, "")
        If strLatest > versionFromSettings Then
            lblVersion.Text = "Version " & strLatest & " available! You are running " & versionFromSettings & "."
            lblVersion.ForeColor = Color.Red
            MetroMessageBox.Show(Me, "You don't have the latest version of this application. Things may not work properly (or at all).", "New Version Available", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'lblVersion.Text = "Up to date! You are running " & settingsReader.GetValue("version", GetType(String)) & "."
            'lblVersion.ForeColor = Color.Green
        End If
    End Sub

    Public Sub NewGameFoundHandler(gameObj As Game)

        Dim gameControl As New GameControl(gameObj, ApplicationSettings.Read(Of Boolean)(ApplicationSettings.Settings.ShowScores, True))
        FlowLayoutPanel.Controls.Add(gameControl)

    End Sub


    Private Sub NHLGames_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler GameManager.NewGameFound, AddressOf NewGameFoundHandler

        dtDate.Value = DateHelper.GetCentralTime()
        dtDate.MaxDate = DateHelper.GetCentralTime()
        TabControl.SelectedIndex = 0

        If (HostsFile.TestEntry(DomainName, ServerIP) = False) Then
            HostsFile.AddEntry(ServerIP, DomainName)
        End If

        VersionCheck()
        IntitializeApplicationSettings()


    End Sub



    Private Sub dtDate_ValueChanged(sender As Object, e As EventArgs) Handles dtDate.ValueChanged

        LoadGames(dtDate.Value)
    End Sub

    Private Sub LoadGames(dateTime As DateTime)

        Try

            'If dateTime <> GameManager.GamesListDate Then
            GameManager.ClearGames()
                FlowLayoutPanel.Controls.Clear()
            'End If

            Dim JSONSchedule As JObject = Downloader.DownloadJSONSchedule(dateTime)
            AvailableGames = Downloader.DownloadAvailableGames() 'TODO: not download each time?
            GameManager.RefreshGames(dateTime, JSONSchedule, AvailableGames)

        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadGames(dtDate.Value)
    End Sub



    Private Sub btnWatch_Click(sender As Object, e As EventArgs)
        'If rbLive.Checked Then
        '    WatchGame(False)
        'Else
        '    WatchGame(True)
        'End If
    End Sub


    'Private Sub WatchGame(isVOD As Boolean, game As Game, streamType As GameStream.StreamType)

    '    Dim args As New Game.GameWatchArguments
    '    args.IsVOD = isVOD
    '    Dim cdn As String = String.Empty


    '    If rbLevel3.Checked Then
    '        args.CDN = "l3c"
    '    ElseIf rbAkamai.Checked Then
    '        args.CDN = "akc"
    '    End If

    '    If rbQual1.Checked Then
    '        args.Quality = "224p"
    '    ElseIf rbQual2.Checked Then
    '        args.Quality = "288p"
    '    ElseIf rbQual3.Checked Then
    '        args.Quality = "360p"
    '    ElseIf rbQual4.Checked Then
    '        args.Quality = "504p"
    '    ElseIf rbQual6.Checked Then
    '        args.Quality = "540p"
    '    ElseIf rbQual6.Checked Then
    '        args.Quality = "720p"
    '        If chk60.Checked Then
    '            args.Is60FPS = True
    '            args.Quality = "best"
    '        End If
    '    End If

    '    If streamType = GameStream.StreamType.Away Then
    '        args.Stream = game.AwayStream
    '    ElseIf streamType = GameStream.StreamType.Home Then
    '        args.Stream = game.HomeStream
    '    ElseIf streamType = GameStream.StreamType.National Then
    '        args.Stream = game.NationalStream
    '    ElseIf streamType = GameStream.StreamType.French Then
    '        args.Stream = game.FrenchStream
    '    End If

    '    If rbMPC.Checked Then
    '        args.PlayerPath = FileAccess.LocateEXE("mpc-hc64.exe", "\MPC-HC")
    '    Else
    '        args.PlayerPath = FileAccess.LocateEXE("vlc.exe", "\VideoLAN\VLC")
    '    End If


    '    Task.Run(Of Boolean)((Function()
    '                              game.Watch(args)
    '                              Return True
    '                          End Function))


    'End Sub

    Private Sub RichTextBox_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox.TextChanged
        RichTextBox.SelectionStart = RichTextBox.Text.Length
        RichTextBox.ScrollToCaret()
    End Sub



    Private Sub btnOpenHostsFile_Click(sender As Object, e As EventArgs) Handles btnOpenHostsFile.Click
        Dim HostsFilePath As String = Environment.SystemDirectory & "\drivers\etc\hosts"
        Process.Start(HostsFilePath)
    End Sub

    Private Sub btnVLCPath_Click(sender As Object, e As EventArgs) Handles btnVLCPath.Click

        OpenFileDialog.Filter = "VLC|vlc.exe"
        OpenFileDialog.Multiselect = False
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            If String.IsNullOrEmpty(OpenFileDialog.FileName) = False Then
                ApplicationSettings.SetValue(ApplicationSettings.Settings.VLCPath, OpenFileDialog.FileName)
            End If

        End If
    End Sub

    Private Sub btnMPCPath_Click(sender As Object, e As EventArgs) Handles btnMPCPath.Click
        OpenFileDialog.Filter = "MPC|mpc-hc64.exe"
        OpenFileDialog.Multiselect = False
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            If String.IsNullOrEmpty(OpenFileDialog.FileName) = False Then
                ApplicationSettings.SetValue(ApplicationSettings.Settings.MPCPath, OpenFileDialog.FileName)
            End If
        End If
    End Sub

    Private Sub btnLiveStreamerPath_Click(sender As Object, e As EventArgs) Handles btnLiveStreamerPath.Click
        OpenFileDialog.Filter = "LiveStreamer|livestreamer.exe"
        OpenFileDialog.Multiselect = False
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            If String.IsNullOrEmpty(OpenFileDialog.FileName) = False Then
                ApplicationSettings.SetValue(ApplicationSettings.Settings.LiveStreamerPath, OpenFileDialog.FileName)
            End If
        End If
    End Sub

    Private Sub MetroCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckBox1.CheckedChanged
        ApplicationSettings.SetValue(ApplicationSettings.Settings.ShowScores, MetroCheckBox1.Checked)
    End Sub

    Private Sub MetroTrackBar1_Scroll(sender As Object, e As ScrollEventArgs)
        'lblRefreshValue.Text = MetroTrackBar1.Value & " Minutes"
        'ApplicationSettings.SetValue(ApplicationSettings.Settings.RefreshIntervalInMin, MetroTrackBar1.Value)
    End Sub

    Private Sub btnClearConsole_Click(sender As Object, e As EventArgs) Handles btnClearConsole.Click
        RichTextBox.Clear()
    End Sub

    Private Sub btnHosts_Click(sender As Object, e As EventArgs) Handles btnHosts.Click
        If HostsFile.TestEntry(DomainName, ServerIP) Then
            MetroMessageBox.Show(Me, "Hosts file looks good!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MetroMessageBox.Show(Me, "Hosts entry doesn't seem to be working :(", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
