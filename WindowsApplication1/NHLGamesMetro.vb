Imports System.Globalization
Imports System.IO
Imports System.Security.Permissions
Imports System.Threading
Imports System.Net
Imports MetroFramework
Imports MetroFramework.Forms
Imports Newtonsoft.Json.Linq
Imports NHLGames.AdDetection
Imports NHLGames.TextboxConsoleOutputRediect
Imports System.Drawing.Text

Public Class NHLGamesMetro

    Private AvailableGames As New HashSet(Of String)
    Private ServerIP As String
    Private Const DomainName As String = "mf.svc.nhl.com"
    Private Shared SettingsLoaded As Boolean = False
    Public Shared FormInstance As NHLGamesMetro = Nothing
    Private AdDetectorViewModel As AdDetectorViewModel = Nothing
    Private StatusTimer As Timer
    Private LoadingTimer As Timer
    Public Shared m_progressValue As Integer = 0
    Public Shared m_progressMaxValue As Integer = 1000
    Public Shared m_flpCalendar As FlowLayoutPanel
    Public Shared m_lblDate As Label
    Public Shared m_Date As Date

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

        SettingsToolTip.SetToolTip(rbQual1, "~0.4Go/hr")
        SettingsToolTip.SetToolTip(rbQual2, "~0.5Go/hr")
        SettingsToolTip.SetToolTip(rbQual3, "~0.9Go/hr")
        SettingsToolTip.SetToolTip(rbQual4, "~1.2Go/hr")
        SettingsToolTip.SetToolTip(rbQual5, "~1.5Go/hr")
        SettingsToolTip.SetToolTip(rbQual6, "~2.0Go/hr")
        Dim mpcPath As String = ApplicationSettings.Read(Of String)(ApplicationSettings.Settings.MPCPath, "")
        If mpcPath = "" Then
            'mpcPath = FileAccess.LocateEXE("mpc-hc64.exe", "\MPC-HC")
            'If mpcPath = String.Empty Then
            '    mpcPath = FileAccess.LocateEXE("mpc-hc.exe", "\MPC-HC")
            '    If mpcPath = String.Empty Then
            '        mpcPath = "Unknown"

            If My.Computer.FileSystem.FileExists("C:\Program Files\MPC-HC\mpc-hc64.exe") Then
                mpcPath = "C:\Program Files\MPC-HC\mpc-hc64.exe"
            ElseIf My.Computer.FileSystem.FileExists("C:\Program Files (x86)\MPC-HC\mpc-hc.exe") Then
                mpcPath = "C:\Program Files (x86)\MPC-HC\mpc-hc.exe"
            End If
        End If

        txtMPCPath.Text = mpcPath
        ApplicationSettings.SetValue(ApplicationSettings.Settings.MPCPath, mpcPath)


        Dim vlcPath As String = ApplicationSettings.Read(Of String)(ApplicationSettings.Settings.VLCPath, "")
        If vlcPath = "" Then
            'vlcPath = FileAccess.LocateEXE("vlc.exe", "\VideoLAN\VLC")
            'If vlcPath = String.Empty Then
            '    vlcPath = "Unknown"

            If My.Computer.FileSystem.FileExists("C:\Program Files\VideoLAN\VLC\vlc.exe") Then
                vlcPath = "C:\Program Files\VideoLAN\VLC\vlc.exe"
            ElseIf My.Computer.FileSystem.FileExists("C:\Program Files (x86)\VideoLAN\VLC\vlc.exe") Then
                vlcPath = "C:\Program Files (x86)\VideoLAN\VLC\vlc.exe"
            End If
        End If

        txtVLCPath.Text = vlcPath
        ApplicationSettings.SetValue(ApplicationSettings.Settings.VLCPath, vlcPath)

        Dim mpvPath As String = ApplicationSettings.Read(Of String)(ApplicationSettings.Settings.mpvPath, "")
        If mpvPath = "" Then
            ' First check inside app folder
            mpvPath = Path.Combine(Application.StartupPath, "mpv\mpv.exe")

            'If Not File.Exists(liveStreamerPath) Then
            '    ' If no such file check if we can find one in system
            '    liveStreamerPath = FileAccess.LocateEXE("livestreamer.exe", "\Livestreamer")
            'End If
            ApplicationSettings.SetValue(ApplicationSettings.Settings.mpvPath, mpvPath)
        End If
        txtMpvPath.Text = mpvPath

        Dim liveStreamerPath As String = ApplicationSettings.Read(Of String)(ApplicationSettings.Settings.LiveStreamerPath, "")
        If liveStreamerPath = "" Then
            ' First check inside app folder
            liveStreamerPath = Path.Combine(Application.StartupPath, "livestreamer-v1.12.2\livestreamer.exe")

            'If Not File.Exists(liveStreamerPath) Then
            '    ' If no such file check if we can find one in system
            '    liveStreamerPath = FileAccess.LocateEXE("livestreamer.exe", "\Livestreamer")
            'End If
            ApplicationSettings.SetValue(ApplicationSettings.Settings.LiveStreamerPath, liveStreamerPath)
        End If
        txtLiveStreamPath.Text = liveStreamerPath

        MetroCheckBox1.Checked = ApplicationSettings.Read(Of Boolean)(ApplicationSettings.Settings.ShowScores, True)
        MetroCheckBox2.Checked = ApplicationSettings.Read(Of Boolean)(ApplicationSettings.Settings.ShowLiveScores, True)

        Dim watchArgs As Game.GameWatchArguments = ApplicationSettings.Read(Of Game.GameWatchArguments)(ApplicationSettings.Settings.DefaultWatchArgs)

        If watchArgs Is Nothing Then
            SetEventArgsFromForm(True)
            watchArgs = ApplicationSettings.Read(Of Game.GameWatchArguments)(ApplicationSettings.Settings.DefaultWatchArgs)
        End If

        BindWatchArgsToForm(watchArgs)

        m_Date = DateHelper.GetPacificTime()
        lblDate.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(m_Date.DayOfWeek).Substring(0, 3) + ", " +
            CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(m_Date.Month).Substring(0, 3) + " " +
            Date.Today.Day.ToString + ", " + m_Date.Year.ToString

        SettingsLoaded = True

    End Sub

    Private Sub SetEventArgsFromForm(Optional ForceSet As Boolean = False)
        If SettingsLoaded OrElse ForceSet Then


            Dim WatchArgs As New Game.GameWatchArguments

            WatchArgs.Is60FPS = chk60.Checked

            If rbQual6.Checked Then
                WatchArgs.Quality = "720p"
            ElseIf rbQual5.Checked Then
                WatchArgs.Quality = "540p"
                chk60.Checked = False
                rbQual5.Checked = True
            ElseIf rbQual4.Checked Then
                WatchArgs.Quality = "504p"
                chk60.Checked = False
                rbQual4.Checked = True
            ElseIf rbQual3.Checked Then
                WatchArgs.Quality = "360p"
                chk60.Checked = False
                rbQual3.Checked = True
            ElseIf rbQual2.Checked Then
                WatchArgs.Quality = "288p"
                chk60.Checked = False
                rbQual2.Checked = True
            ElseIf rbQual1.Checked Then
                WatchArgs.Quality = "224p"
                chk60.Checked = False
                rbQual1.Checked = True
            End If

            If rbMPC.Checked Then
                WatchArgs.PlayerType = Game.GameWatchArguments.PlayerTypeEnum.MPC
                WatchArgs.PlayerPath = txtMPCPath.Text
            ElseIf rbMpv.Checked Then
                WatchArgs.PlayerType = Game.GameWatchArguments.PlayerTypeEnum.mpv
                WatchArgs.PlayerPath = txtMpvPath.Text
            Else
                WatchArgs.PlayerType = Game.GameWatchArguments.PlayerTypeEnum.VLC
                WatchArgs.PlayerPath = txtVLCPath.Text
            End If

            WatchArgs.LiveStreamerPath = txtLiveStreamPath.Text

            If rbAkamai.Checked Then
                WatchArgs.CDN = "akc"
            ElseIf rbLevel3.Checked Then
                WatchArgs.CDN = "l3c"
            End If

            WatchArgs.UsePlayerArgs = chkEnablePlayerArgs.Checked
            WatchArgs.PlayerArgs = txtPlayerArgs.Text

            WatchArgs.UseLiveStreamerArgs = chkEnableStreamArgs.Checked
            WatchArgs.LiveStreamerArgs = txtStreamerArgs.Text

            WatchArgs.UseOutputArgs = chkEnableOutput.Checked
            WatchArgs.PlayerOutputPath = txtOutputPath.Text

            progress.Location = New Point((FlowLayoutPanel.Width - progress.Width) / 2, FlowLayoutPanel.Location.Y + 150)
            NoGames.Location = New Point((FlowLayoutPanel.Width - NoGames.Width) / 2, FlowLayoutPanel.Location.Y + 148)

            tmrAnimate.Start()

            ApplicationSettings.SetValue(ApplicationSettings.Settings.DefaultWatchArgs, Serialization.SerializeObject(Of Game.GameWatchArguments)(WatchArgs))
        End If
    End Sub

    Private Sub BindWatchArgsToForm(WatchArgs As Game.GameWatchArguments)

        If WatchArgs IsNot Nothing Then

            chk60.Checked = WatchArgs.Is60FPS
            Select Case WatchArgs.Quality
                Case "720p"
                    rbQual6.Checked = True
                Case "540p"
                    rbQual5.Checked = True
                Case "504p"
                    rbQual4.Checked = True
                Case "360p"
                    rbQual3.Checked = True
                Case "288p"
                    rbQual2.Checked = True
                Case "224p"
                    rbQual1.Checked = True
            End Select

            If WatchArgs.CDN = "akc" Then
                rbAkamai.Checked = True
            ElseIf WatchArgs.CDN = "l3c" Then
                rbLevel3.Checked = True
            End If


            rbVLC.Checked = WatchArgs.PlayerType = Game.GameWatchArguments.PlayerTypeEnum.VLC
            rbMPC.Checked = WatchArgs.PlayerType = Game.GameWatchArguments.PlayerTypeEnum.MPC

            chkEnablePlayerArgs.Checked = WatchArgs.UsePlayerArgs
            txtPlayerArgs.Enabled = WatchArgs.UsePlayerArgs
            txtPlayerArgs.Text = WatchArgs.PlayerArgs

            chkEnableStreamArgs.Checked = WatchArgs.UseLiveStreamerArgs
            txtStreamerArgs.Enabled = WatchArgs.UseLiveStreamerArgs
            txtStreamerArgs.Text = WatchArgs.LiveStreamerArgs

            txtOutputPath.Text = WatchArgs.PlayerOutputPath
            txtOutputPath.Enabled = WatchArgs.UseOutputArgs
            chkEnableOutput.Checked = WatchArgs.UseOutputArgs



        End If
    End Sub

    ' Handle the UI exceptions by showing a dialog box, and asking the user whether
    ' or not they wish to abort execution.
    Private Shared Sub Form1_UIThreadException(ByVal sender As Object, ByVal t As ThreadExceptionEventArgs)
        Console.WriteLine("Error:  " & t.Exception.ToString())
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
            lnkDownload.Visible = True
            Dim strChangeLog = Downloader.DownloadChangelog()
            MetroMessageBox.Show(Me, "Version " & strLatest & " is available! Changes:" & vbCrLf & vbCrLf & strChangeLog, "New Version Available", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            lblVersion.Text = "Version: " & ApplicationSettings.Read(Of String)(ApplicationSettings.Settings.Version)
            lblVersion.ForeColor = Color.Gray
        End If
    End Sub

    Public Sub NewGameFoundHandler(gameObj As Game)

        If InvokeRequired Then
            BeginInvoke(New Action(Of Game)(AddressOf NewGameFoundHandler), gameObj)
        Else
            Dim gameControl As New GameControl(gameObj, ApplicationSettings.Read(Of Boolean)(ApplicationSettings.Settings.ShowScores),
                ApplicationSettings.Read(Of Boolean)(ApplicationSettings.Settings.ShowLiveScores, True), m_Date)
            FlowLayoutPanel.Controls.Add(gameControl)
        End If


    End Sub


    Private Sub NHLGames_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler GameManager.NewGameFound, AddressOf NewGameFoundHandler
        m_flpCalendar = flpCalender
        m_lblDate = lblDate
        AdDetectorViewModel = New AdDetectorViewModel()
        AdDetectionSettingsElementHost.Child = AdDetectorViewModel.SettingsControl
        'dtDate.MaxDate = DateHelper.GetPacificTime()
        TabControl.SelectedIndex = 0
        flpCalender.Controls.Add(New CalenderControl(flpCalender))
        ServerIP = Dns.GetHostEntry("nhl.chickenkiller.com").AddressList.First.ToString()

        If (HostsFile.TestEntry(DomainName, ServerIP) = False) Then
            HostsFile.AddEntry(ServerIP, DomainName, True)
        End If
        VersionCheck()
        IntitializeApplicationSettings()
        LoadGamesAsync(m_Date)
    End Sub


    ''' <summary>
    ''' Wrapper for LoadGames to stop UI locking and slow startup
    ''' </summary>
    ''' <param name="dateTime"></param>
    Private Sub LoadGamesAsync(dateTime As DateTime)
        Dim LoadGamesFunc As New Action(Of DateTime)(Sub(dt As DateTime) LoadGames(dt))
        LoadGamesFunc.BeginInvoke(dateTime, Nothing, Nothing)

    End Sub

    Private Sub ClearGamePanel()
        If InvokeRequired Then
            BeginInvoke(New Action(AddressOf ClearGamePanel))
        Else
            FlowLayoutPanel.Controls.Clear()
            FlowLayoutPanel.Height = 390
        End If

    End Sub

    Private Sub ResizeGamePanel()
        If InvokeRequired Then
            BeginInvoke(New Action(AddressOf ResizeGamePanel))
        Else
            If FlowLayoutPanel.Height > 400 Then
                Me.Height = FlowLayoutPanel.Height + 225
            Else
                Me.Height = 600
            End If
        End If

    End Sub
    Private Sub LoadGames(dateTime As DateTime)
        Try
            NHLGamesMetro.m_progressValue = 0
            SetLoading(True)
            SetFormStatusLabel("Loading Games")

            'If dateTime <> GameManager.GamesListDate Then
            GameManager.ClearGames()
            ClearGamePanel()
            'End If

            Dim JSONSchedule As JObject = Downloader.DownloadJSONSchedule(dateTime)
            AvailableGames = Downloader.DownloadAvailableGames() 'TODO: not download each time?
            GameManager.RefreshGames(dateTime, JSONSchedule, AvailableGames)
            ResizeGamePanel()
            SetFormStatusLabel("Games Found : " + GameManager.GamesList.Count.ToString())
            SetLoading(False)
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadGamesAsync(m_Date)
    End Sub

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
            If String.IsNullOrEmpty(OpenFileDialog.FileName) = False And txtVLCPath.Text <> OpenFileDialog.FileName Then
                ApplicationSettings.SetValue(ApplicationSettings.Settings.VLCPath, OpenFileDialog.FileName)
                txtVLCPath.Text = OpenFileDialog.FileName
            End If

        End If
    End Sub

    Private Sub btnMPCPath_Click(sender As Object, e As EventArgs) Handles btnMPCPath.Click
        OpenFileDialog.Filter = "MPC|mpc-hc64.exe;mpc-hc.exe"
        OpenFileDialog.Multiselect = False
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            If String.IsNullOrEmpty(OpenFileDialog.FileName) = False And txtMPCPath.Text <> OpenFileDialog.FileName Then
                ApplicationSettings.SetValue(ApplicationSettings.Settings.MPCPath, OpenFileDialog.FileName)
                txtMPCPath.Text = OpenFileDialog.FileName
            End If
        End If
    End Sub

    Private Sub btnMpvPath_Click(sender As Object, e As EventArgs) Handles btnMpvPath.Click
        OpenFileDialog.Filter = "MPC|mpv.exe"
        OpenFileDialog.Multiselect = False
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            If String.IsNullOrEmpty(OpenFileDialog.FileName) = False And txtMpvPath.Text <> OpenFileDialog.FileName Then
                ApplicationSettings.SetValue(ApplicationSettings.Settings.mpvPath, OpenFileDialog.FileName)
                txtMpvPath.Text = OpenFileDialog.FileName
            End If
        End If
    End Sub

    Private Sub btnLiveStreamerPath_Click(sender As Object, e As EventArgs) Handles btnLiveStreamerPath.Click
        OpenFileDialog.Filter = "LiveStreamer|"
        OpenFileDialog.Multiselect = False
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            If String.IsNullOrEmpty(OpenFileDialog.FileName) = False And txtLiveStreamPath.Text <> OpenFileDialog.FileName Then
                ApplicationSettings.SetValue(ApplicationSettings.Settings.LiveStreamerPath, OpenFileDialog.FileName)
                txtLiveStreamPath.Text = OpenFileDialog.FileName
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

#Region "Settings Changed Update Settings"


    Private Sub chk60_CheckedChanged(sender As Object, e As EventArgs) Handles chk60.CheckedChanged
        rbQual6.Checked = True
        SetEventArgsFromForm()

    End Sub

    Private Sub txtVLCPath_TextChanged(sender As Object, e As EventArgs) Handles txtVLCPath.TextChanged
        SetEventArgsFromForm()
    End Sub

    Private Sub txtMPCPath_TextChanged(sender As Object, e As EventArgs) Handles txtMPCPath.TextChanged
        SetEventArgsFromForm()
    End Sub

    Private Sub txtLiveStreamPath_TextChanged(sender As Object, e As EventArgs) Handles txtLiveStreamPath.TextChanged
        SetEventArgsFromForm()
    End Sub

    Private Sub rbQual1_CheckedChanged(sender As Object, e As EventArgs) Handles rbQual1.CheckedChanged
        SetEventArgsFromForm()
    End Sub

    Private Sub rbQual2_CheckedChanged(sender As Object, e As EventArgs) Handles rbQual2.CheckedChanged
        SetEventArgsFromForm()
    End Sub

    Private Sub rbQual3_CheckedChanged(sender As Object, e As EventArgs) Handles rbQual3.CheckedChanged
        SetEventArgsFromForm()
    End Sub

    Private Sub rbQual4_CheckedChanged(sender As Object, e As EventArgs) Handles rbQual4.CheckedChanged
        SetEventArgsFromForm()
    End Sub


    Private Sub SetFormStatusLabel(text As String)
        If InvokeRequired Then
            BeginInvoke(New Action(Of String)(AddressOf SetFormStatusLabel), text)
        Else
            Me.StatusLabel.Text = [text]
        End If
    End Sub

    Private Sub SetLoading(visible As Boolean)
        If InvokeRequired Then
            BeginInvoke(New Action(Of Boolean)(AddressOf SetLoading), visible)
        Else
            Me.progress.Visible = [visible]
            LoadingTimer = New Timer(New TimerCallback(Sub() If progress.Visible Then SetLoading(True)), Nothing, 1000, Timeout.Infinite)
        End If
    End Sub

    Private Sub rbQual5_CheckedChanged(sender As Object, e As EventArgs) Handles rbQual5.CheckedChanged
        SetEventArgsFromForm()
    End Sub

    Private Sub rbQual6_CheckedChanged(sender As Object, e As EventArgs) Handles rbQual6.CheckedChanged
        SetEventArgsFromForm()
    End Sub

    Private Sub rbVLC_CheckedChanged(sender As Object, e As EventArgs) Handles rbVLC.CheckedChanged
        SetEventArgsFromForm()
    End Sub

    Private Sub rbMPC_CheckedChanged(sender As Object, e As EventArgs) Handles rbMPC.CheckedChanged
        SetEventArgsFromForm()
    End Sub

    Private Sub rbLevel3_CheckedChanged(sender As Object, e As EventArgs) Handles rbLevel3.CheckedChanged
        SetEventArgsFromForm()
    End Sub

    Private Sub rbAkamai_CheckedChanged(sender As Object, e As EventArgs) Handles rbAkamai.CheckedChanged
        SetEventArgsFromForm()
    End Sub

    Private Sub txtOutputPath_TextChanged(sender As Object, e As EventArgs) Handles txtOutputPath.TextChanged
        SetEventArgsFromForm()
    End Sub

    Private Sub txtPlayerArgs_TextChanged(sender As Object, e As EventArgs) Handles txtPlayerArgs.TextChanged
        SetEventArgsFromForm()
    End Sub

    Private Sub txtStreamerArgs_TextChanged(sender As Object, e As EventArgs) Handles txtStreamerArgs.TextChanged
        SetEventArgsFromForm()
    End Sub

    Private Sub chkEnableOutput_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableOutput.CheckedChanged
        txtOutputPath.Enabled = chkEnableOutput.Checked
        SetEventArgsFromForm()
    End Sub

    Private Sub chkEnablePlayerArgs_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnablePlayerArgs.CheckedChanged
        txtPlayerArgs.Enabled = chkEnablePlayerArgs.Checked
        SetEventArgsFromForm()
    End Sub

    Private Sub chkEnableStreamArgs_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableStreamArgs.CheckedChanged
        txtStreamerArgs.Enabled = chkEnableStreamArgs.Checked
        SetEventArgsFromForm()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        SaveFileDialog.CheckPathExists = True
        If txtOutputPath.Text.Count > 0 Then
            SaveFileDialog.InitialDirectory = Path.GetDirectoryName(txtOutputPath.Text)
            SaveFileDialog.FileName = Path.GetFileName(txtOutputPath.Text)
        Else
            SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
            SaveFileDialog.FileName = "(DATE)_(HOME)_vs_(AWAY)_(TYPE)_(QUAL)"
        End If

        SaveFileDialog.Filter = "MP4 Files (*.mp4)|*.MP4"
        SaveFileDialog.DefaultExt = "mp4"
        SaveFileDialog.AddExtension = True

        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            txtOutputPath.Text = SaveFileDialog.FileName
            SetEventArgsFromForm()
        End If
    End Sub

    Private Sub btnYesterday_Click(sender As Object, e As EventArgs) Handles btnYesterday.Click
        m_Date = m_Date.AddDays(-1)
        lblDate.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(m_Date.DayOfWeek).Substring(0, 3) + ", " +
            CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(m_Date.Month).Substring(0, 3) + " " +
            m_Date.Day.ToString + ", " + m_Date.Year.ToString
    End Sub

    Private Sub btnTomorrow_Click(sender As Object, e As EventArgs) Handles btnTomorrow.Click
        m_Date = m_Date.AddDays(1)
        lblDate.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(m_Date.DayOfWeek).Substring(0, 3) + ", " +
            CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(m_Date.Month).Substring(0, 3) + " " +
            m_Date.Day.ToString + ", " + m_Date.Year.ToString
    End Sub

    Private Sub lblVersion_Click(sender As Object, e As EventArgs) Handles lblVersion.Click

    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        HostsFile.CleanHosts(DomainName, True)
    End Sub

    Private Sub lnkVLCDownload_Click(sender As Object, e As EventArgs) Handles lnkVLCDownload.Click
        Dim sInfo As ProcessStartInfo = New ProcessStartInfo("http://www.videolan.org/vlc/download-windows.html")
        Process.Start(sInfo)
    End Sub

    Private Sub lnkMPCDownload_Click(sender As Object, e As EventArgs) Handles lnkMPCDownload.Click
        Dim sInfo As ProcessStartInfo = New ProcessStartInfo("https://mpc-hc.org/downloads/")
        Process.Start(sInfo)
    End Sub

    Private Sub lnkMpvDownload_Click(sender As Object, e As EventArgs) Handles lnkMpvDownload.Click
        Dim sInfo As ProcessStartInfo = New ProcessStartInfo("https://mpv.io/installation/")
        Process.Start(sInfo)
    End Sub

    Private Sub lnkDownload_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDownload.LinkClicked
        Dim sInfo As ProcessStartInfo = New ProcessStartInfo("https://www.reddit.com/r/nhl_games/wiki/downloads")
        Process.Start(sInfo)
    End Sub

    Private Sub btnAddHosts_Click(sender As Object, e As EventArgs) Handles btnAddHosts.Click
        HostsFile.AddEntry(ServerIP, DomainName, True)
    End Sub

    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        Dim val = If(flpCalender.Visible, False, True)
        flpCalender.Visible = val
    End Sub

    Private Sub lblDate_TextChanged(sender As Object, e As EventArgs) Handles lblDate.TextChanged
        LoadGamesAsync(m_Date)
    End Sub

    Private Sub tmrAnimate_Tick(sender As Object, e As EventArgs) Handles tmrAnimate.Tick
        If NHLGamesMetro.m_progressValue < Me.progress.Maximum Then
            progress.Value = NHLGamesMetro.m_progressValue
        ElseIf progress.Value < Me.progress.Maximum And NHLGamesMetro.m_progressValue <= Me.progress.Maximum Then
            progress.Value = Me.progress.Maximum
        End If

        'I use a timer cause it never fails to hide the progress bar or the <no games> label when the games are loaded
        If progress.Visible Then
            btnDate.Enabled = False
            btnTomorrow.Enabled = False
            btnYesterday.Enabled = False
            NoGames.Visible = False
        Else
            btnDate.Enabled = True
            btnTomorrow.Enabled = True
            btnYesterday.Enabled = True
            If (FlowLayoutPanel.Controls.Count = 0) Then
                Me.NoGames.Visible = True
            Else
                Me.NoGames.Visible = False
            End If
        End If

        If FlowLayoutPanel.Controls.Count <> 0 And (progress.Visible Or NoGames.Visible) Then
            progress.Visible = False
            NoGames.Visible = False
        End If

    End Sub

    Private Sub MetroCheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckBox2.CheckedChanged
        ApplicationSettings.SetValue(ApplicationSettings.Settings.ShowLiveScores, MetroCheckBox2.Checked)
    End Sub

#End Region
End Class
