Imports System.Globalization
Imports System.IO
Imports System.Resources
Imports System.Security.Permissions
Imports System.Threading
Imports MetroFramework.Controls
Imports NHLGames.Controls
Imports NHLGames.My.Resources
Imports NHLGames.Objects
Imports NHLGames.Objects.Modules
Imports NHLGames.Utilities

Public Class NHLGamesMetro
    Public Const DomainName As String = "mf.svc.nhl.com"
    Public Shared HostName As String = String.Empty
    Public Shared FormInstance As NHLGamesMetro = Nothing
    Public Shared StreamStarted As Boolean = False
    Public Shared SpnLoadingValue As Integer = 0
    Public Shared SpnLoadingMaxValue As Integer = 1000
    Public Shared SpnLoadingVisible As Boolean = False
    Public Shared SpnStreamingValue As Integer = 0
    Public Shared SpnStreamingMaxValue As Integer = 1000
    Public Shared SpnStreamingVisible As Boolean = False
    Public Shared FlpCalendar As FlowLayoutPanel
    Public Shared LabelDate As Label
    Private Const SubredditLink As String = "https://www.reddit.com/r/nhl_games/"
    Private Const LatestReleaseLink As String = "https://github.com/NHLGames/NHLGames/releases/latest"
    Public Shared GameDate As Date = DateHelper.GetPacificTime()
    Private _resizeDirection As Integer = -1
    Private Const ResizeBorderWidth As Integer = 8
    Public Shared RmText As ResourceManager = English.ResourceManager
    Public Shared FormLoaded As Boolean = False
    Public Shared TodayLiveGamesFirst As Boolean = False
    Private Shared _adDetectionEngine As AdDetection
    Public Shared ReadOnly GamesDict As New Dictionary(Of String, Game)
    Public Shared IsDarkMode As Boolean = False
    Public Shared AnimateTipsTick As Integer = 0
    Public Const AnimateTipsEveryTick As Integer = 10000
    Public Shared Tips As New Dictionary(Of Integer, String)
    Public Shared MLBAMProxy As Proxy
    Public ProxyListening As Task(Of Boolean) = Nothing

    <SecurityPermission(SecurityAction.Demand, Flags:=SecurityPermissionFlag.ControlAppDomain)>
    Public Shared Sub Main()
        AddHandler Application.ThreadException, AddressOf Form1_UIThreadException
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException

        IsDarkMode = ApplicationSettings.Read(Of Boolean)(SettingsEnum.DarkMode, False)

        Dim form As New NHLGamesMetro()
        FormInstance = form

        Dim writer = New ConsoleRedirectStreamWriter(form.txtConsole)
        Console.SetOut(writer)
        Application.Run(form)
    End Sub

    Private Shared Sub Form1_UIThreadException(sender As Object, t As ThreadExceptionEventArgs)
        Console.WriteLine(English.errorGeneral, $"Running UI thread", t.Exception.ToString())
    End Sub

    Private Shared Sub CurrentDomain_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs)
        Console.WriteLine(English.errorGeneral, $"Using NHLGames domain", e.ExceptionObject.ToString())
    End Sub

    Public Sub HandleException(e As Exception)
        Console.WriteLine(English.errorGeneral, $"Running main thread", e.ToString())
    End Sub

    Private Async Sub NHLGames_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitializeForm.SetWindow()

        SuspendLayout()

        Common.GetLanguage()
        tabMenu.SelectedIndex = 0
        FlpCalendar = flpCalendarPanel
        InitializeForm.SetSettings()

        MLBAMProxy = New Proxy()

        HostsFile.ResetHost() 'TODO: Remove when we remove hosts class
        Await Common.CheckAppCanRun()

        FormLoaded = True
        ResumeLayout(True)

        tmr.Enabled = True
        InvokeElement.LoadGames()
    End Sub

    Public Sub ClearGamePanel()
        SyncLock flpGames.Controls
            If flpGames.Controls.Count > 0 Then
                For index = flpGames.Controls.Count - 1 To 0 Step -1
                    CType(flpGames.Controls(index), GameControl).Dispose()
                Next
            End If
        End SyncLock
    End Sub

    Private Shared Sub _writeToConsoleSettingsChanged(key As String, value As String)
        If FormLoaded Then Console.WriteLine(English.msgSettingUpdated, key, value)
    End Sub

    Private Shared Sub tmrAnimate_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        If StreamStarted Then
            GameFetcher.StreamingProgress()
        Else
            GameFetcher.LoadingProgress()
        End If
        AnimateTipsTick += NHLGamesMetro.tmr.Interval
        InvokeElement.AnimateTips()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        flpCalendarPanel.Visible = False
        InvokeElement.LoadGames()
        flpGames.Focus()
    End Sub

    Private Sub RichTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtConsole.TextChanged
        txtConsole.SelectionStart = txtConsole.Text.Length
        txtConsole.ScrollToCaret()
    End Sub

    Private Sub btnVLCPath_Click(sender As Object, e As EventArgs) Handles btnVLCPath.Click
        ofd.Filter = $"VLC|vlc.exe|All files (*.*)|*.*"
        ofd.Multiselect = False
        ofd.InitialDirectory = If(txtVLCPath.Text.Equals(String.Empty), "C:\", Path.GetDirectoryName(txtVLCPath.Text))

        If ofd.ShowDialog() = DialogResult.OK Then
            If String.IsNullOrEmpty(ofd.FileName) = False And txtVLCPath.Text <> ofd.FileName Then
                ApplicationSettings.SetValue(SettingsEnum.VlcPath, ofd.FileName)
                _writeToConsoleSettingsChanged(lblVlcPath.Text, ofd.FileName)
                txtVLCPath.Text = ofd.FileName
            End If
        End If
    End Sub

    Private Sub btnMPCPath_Click(sender As Object, e As EventArgs) Handles btnMPCPath.Click
        ofd.Filter = $"MPC|mpc-hc64.exe;mpc-hc.exe|All files (*.*)|*.*"
        ofd.Multiselect = False
        ofd.InitialDirectory = If(txtMPCPath.Text.Equals(String.Empty), "C:\", Path.GetDirectoryName(txtMPCPath.Text))

        If ofd.ShowDialog() = DialogResult.OK Then

            If String.IsNullOrEmpty(ofd.FileName) = False And txtMPCPath.Text <> ofd.FileName Then
                ApplicationSettings.SetValue(SettingsEnum.MpcPath, ofd.FileName)
                _writeToConsoleSettingsChanged(lblMpcPath.Text, ofd.FileName)
                txtMPCPath.Text = ofd.FileName
            End If

        End If
    End Sub

    Private Sub btnMpvPath_Click(sender As Object, e As EventArgs) Handles btnMpvPath.Click
        ofd.Filter = $"mpv|mpv.exe|All files (*.*)|*.*"
        ofd.Multiselect = False
        ofd.InitialDirectory = If(txtMpvPath.Text.Equals(String.Empty), "C:\", Path.GetDirectoryName(txtMpvPath.Text))

        If ofd.ShowDialog() = DialogResult.OK Then

            If String.IsNullOrEmpty(ofd.FileName) = False And txtMpvPath.Text <> ofd.FileName Then
                ApplicationSettings.SetValue(SettingsEnum.MpvPath, ofd.FileName)
                _writeToConsoleSettingsChanged(lblMpvPath.Text, ofd.FileName)
                txtMpvPath.Text = ofd.FileName
            End If

        End If
    End Sub

    Private Sub btnstreamerPath_Click(sender As Object, e As EventArgs) Handles btnStreamerPath.Click
        ofd.Filter = $"streamer|streamlink.exe;livestreamer.exe|All files (*.*)|*.*"
        ofd.Multiselect = False
        ofd.InitialDirectory =
            If(txtStreamerPath.Text.Equals(String.Empty), "C:\", Path.GetDirectoryName(txtStreamerPath.Text))

        If ofd.ShowDialog() = DialogResult.OK Then

            If String.IsNullOrEmpty(ofd.FileName) = False And txtStreamerPath.Text <> ofd.FileName Then
                ApplicationSettings.SetValue(SettingsEnum.StreamerPath, ofd.FileName)
                _writeToConsoleSettingsChanged(lblSlPath.Text, ofd.FileName)
                txtStreamerPath.Text = ofd.FileName
            End If

        End If
    End Sub

    Private Sub tgShowFinalScores_CheckedChanged(sender As Object, e As EventArgs) _
        Handles tgShowFinalScores.CheckedChanged
        ApplicationSettings.SetValue(SettingsEnum.ShowScores, tgShowFinalScores.Checked)
        _writeToConsoleSettingsChanged(String.Format(English.msgThisEnable, lblShowFinalScores.Text),
                                       If(tgShowFinalScores.Checked, English.msgOn, English.msgOff))
        For Each game As GameControl In flpGames.Controls
            game.UpdateGame(tgShowFinalScores.Checked,
                            tgShowLiveScores.Checked,
                            tgShowSeriesRecord.Checked,
                            tgShowTeamCityAbr.Checked,
                            tgShowLiveTime.Checked,
                            GamesDict(game.GameId))
        Next
    End Sub

    Private Sub btnClearConsole_Click(sender As Object, e As EventArgs) Handles btnClearConsole.Click
        txtConsole.Clear()
    End Sub

    Private Sub txtVLCPath_TextChanged(sender As Object, e As EventArgs) Handles txtVLCPath.TextChanged
        If Not rbVLC.Enabled Then rbVLC.Enabled = True
        Player.RenewArgs()
    End Sub

    Private Sub txtMPCPath_TextChanged(sender As Object, e As EventArgs) Handles txtMPCPath.TextChanged
        If Not rbMPC.Enabled Then rbMPC.Enabled = True
        Player.RenewArgs()
    End Sub

    Private Sub txtMpvPath_TextChanged(sender As Object, e As EventArgs) Handles txtMpvPath.TextChanged
        If Not rbMPV.Enabled Then rbMPV.Enabled = True
        Player.RenewArgs()
    End Sub

    Private Sub txtStreamerPath_TextChanged(sender As Object, e As EventArgs) Handles txtStreamerPath.TextChanged
        Player.RenewArgs()
    End Sub

    Private Sub player_CheckedChanged(sender As Object, e As EventArgs) _
        Handles rbVLC.CheckedChanged, rbMPV.CheckedChanged, rbMPC.CheckedChanged
        Dim rb As RadioButton = sender
        If rb.Checked Then
            Player.RenewArgs()
            _writeToConsoleSettingsChanged(lblPlayer.Text, rb.Text)
        End If
    End Sub

    Private Sub tgAlternateCdn_CheckedChanged(sender As Object, e As EventArgs) Handles tgAlternateCdn.CheckedChanged
        Dim cdn = If(tgAlternateCdn.Checked, CdnTypeEnum.L3C, CdnTypeEnum.Akc)
        Player.RenewArgs()
        _writeToConsoleSettingsChanged(lblCdn.Text, cdn.ToString())
        InvokeElement.LoadGames()
    End Sub

    Private Sub txtOutputPath_TextChanged(sender As Object, e As EventArgs) Handles txtOutputArgs.TextChanged
        Player.RenewArgs()
        _writeToConsoleSettingsChanged(lblOutput.Text, txtOutputArgs.Text)
    End Sub

    Private Sub txtPlayerArgs_TextChanged(sender As Object, e As EventArgs) Handles txtPlayerArgs.TextChanged
        Player.RenewArgs()
        _writeToConsoleSettingsChanged(lblPlayerArgs.Text, txtPlayerArgs.Text)
    End Sub

    Private Sub txtStreamerArgs_TextChanged(sender As Object, e As EventArgs) Handles txtStreamerArgs.TextChanged
        Player.RenewArgs()
        _writeToConsoleSettingsChanged(lblStreamerArgs.Text, txtStreamerArgs.Text)
    End Sub

    Private Sub btnOuput_Click(sender As Object, e As EventArgs) Handles btnOutput.Click
        fbd.SelectedPath = If(txtOutputArgs.Text <> String.Empty,
                               Path.GetDirectoryName(txtOutputArgs.Text),
                               Environment.GetFolderPath(Environment.SpecialFolder.MyVideos))
        If fbd.ShowDialog() = DialogResult.OK Then
            txtOutputArgs.Text = fbd.SelectedPath & $"\(DATE)_(HOME)_vs_(AWAY)_(TYPE)_(NETWORK).mp4"
            Player.RenewArgs()
            _writeToConsoleSettingsChanged(lblOutput.Text, txtOutputArgs.Text)
        End If
    End Sub

    Private Sub btnYesterday_Click(sender As Object, e As EventArgs) Handles btnYesterday.Click
        GameDate = GameDate.AddDays(-1)
        lblDate.Text = DateHelper.GetFormattedDate(GameDate)
    End Sub

    Private Sub btnTomorrow_Click(sender As Object, e As EventArgs) Handles btnTomorrow.Click
        GameDate = GameDate.AddDays(1)
        lblDate.Text = DateHelper.GetFormattedDate(GameDate)
    End Sub

    Private Sub lnkVLCDownload_Click(sender As Object, e As EventArgs) Handles lnkGetVlc.Click
        Dim sInfo = New ProcessStartInfo("http://www.videolan.org/vlc/download-windows.html")
        Process.Start(sInfo)
    End Sub

    Private Sub lnkMPCDownload_Click(sender As Object, e As EventArgs) Handles lnkGetMpc.Click
        Dim sInfo = New ProcessStartInfo("https://mpc-hc.org/downloads/")
        Process.Start(sInfo)
    End Sub

    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        flpCalendarPanel.Visible = Not flpCalendarPanel.Visible
    End Sub

    Private Sub lblDate_TextChanged(sender As Object, e As EventArgs) Handles lblDate.TextChanged
        flpCalendarPanel.Visible = False
        InvokeElement.LoadGames()
        flpGames.Focus()
    End Sub

    Private Sub chkShowLiveScores_CheckedChanged(sender As Object, e As EventArgs) _
        Handles tgShowLiveScores.CheckedChanged
        ApplicationSettings.SetValue(SettingsEnum.ShowLiveScores, tgShowLiveScores.Checked)
        _writeToConsoleSettingsChanged(String.Format(English.msgThisEnable, lblShowLiveScores.Text),
                                    If(tgShowLiveScores.Checked, English.msgOn, English.msgOff))
        For Each game As GameControl In flpGames.Controls
            game.UpdateGame(tgShowFinalScores.Checked,
                            tgShowLiveScores.Checked,
                            tgShowSeriesRecord.Checked,
                            tgShowTeamCityAbr.Checked,
                            tgShowLiveTime.Checked,
                            GamesDict(game.GameId))
        Next
    End Sub

    Private Sub lnkReddit_Click(sender As Object, e As EventArgs) Handles lnkReddit.Click
        Dim sInfo As ProcessStartInfo = New ProcessStartInfo(SubredditLink)
        Process.Start(sInfo)
    End Sub

    Private Sub lnkRelease_Click(sender As Object, e As EventArgs) Handles lnkRelease.Click
        Dim sInfo As ProcessStartInfo = New ProcessStartInfo(LatestReleaseLink)
        Process.Start(sInfo)
    End Sub

    Private Sub tgStreamer_CheckedChanged(sender As Object, e As EventArgs) Handles tgStreamer.CheckedChanged
        txtStreamerArgs.Enabled = tgStreamer.Checked
        Player.RenewArgs()
        _writeToConsoleSettingsChanged(String.Format(English.msgThisEnable, lblStreamerArgs.Text),
                                       If(tgStreamer.Checked, English.msgOn, English.msgOff))
    End Sub

    Private Sub tgPlayer_CheckedChanged(sender As Object, e As EventArgs) Handles tgPlayer.CheckedChanged
        txtPlayerArgs.Enabled = tgPlayer.Checked
        Player.RenewArgs()
        _writeToConsoleSettingsChanged(String.Format(English.msgThisEnable, lblPlayerArgs.Text),
                                       If(tgPlayer.Checked, English.msgOn, English.msgOff))
    End Sub

    Private Sub tgOutput_CheckedChanged(sender As Object, e As EventArgs) Handles tgOutput.CheckedChanged
        txtOutputArgs.Enabled = tgOutput.Checked
        If txtOutputArgs.Text = String.Empty Then
            txtOutputArgs.Text =
                $"{Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) _
                    }\(DATE)_(HOME)_vs_(AWAY)_(TYPE)_(NETWORK).mp4"
        End If
        Player.RenewArgs()
        _writeToConsoleSettingsChanged(String.Format(English.msgThisEnable, lblOutput.Text),
                                       If(tgOutput.Checked, English.msgOn, English.msgOff))
    End Sub

    Private Sub chkShowSeriesRecord_CheckedChanged(sender As Object, e As EventArgs) _
        Handles tgShowSeriesRecord.CheckedChanged
        ApplicationSettings.SetValue(SettingsEnum.ShowSeriesRecord, tgShowSeriesRecord.Checked)
        _writeToConsoleSettingsChanged(String.Format(English.msgThisEnable, lblShowSeriesRecord.Text),
                                       If(tgShowSeriesRecord.Checked, English.msgOn, English.msgOff))
        For Each game As GameControl In flpGames.Controls
            game.UpdateGame(tgShowFinalScores.Checked,
                            tgShowLiveScores.Checked,
                            tgShowSeriesRecord.Checked,
                            tgShowTeamCityAbr.Checked,
                            tgShowLiveTime.Checked,
                            GamesDict(game.GameId))
        Next
    End Sub

    Private Shared Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Dim sInfo = New ProcessStartInfo("https://github.com/NHLGames/NHLGames/wiki")
        Process.Start(sInfo)
    End Sub

    Private Sub NHLGamesMetro_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Refresh()
        RefreshFocus()
    End Sub

    Private Sub RefreshFocus()
        If tabGames.Visible Then
            flpGames.Focus()
        ElseIf tabSettings.Visible Then
            tlpSettings.Focus()
        ElseIf tabConsole.Visible Then
            txtConsole.Focus()
        Else
            tabMenu.Focus()
        End If
    End Sub

    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabMenu.SelectedIndexChanged
        RefreshFocus()
    End Sub

    Private Sub NHLGamesMetro_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        _resizeDirection = -1
        If e.Location.X < ResizeBorderWidth And e.Location.Y < ResizeBorderWidth Then
            Cursor = Cursors.SizeNWSE
            _resizeDirection = WindowsCode.HTTOPLEFT
        ElseIf e.Location.X < ResizeBorderWidth And e.Location.Y > Height - ResizeBorderWidth Then
            Cursor = Cursors.SizeNESW
            _resizeDirection = WindowsCode.HTBOTTOMLEFT
        ElseIf e.Location.X > Width - ResizeBorderWidth And e.Location.Y > Height - ResizeBorderWidth Then
            Cursor = Cursors.SizeNWSE
            _resizeDirection = WindowsCode.HTBOTTOMRIGHT
        ElseIf e.Location.X > Width - ResizeBorderWidth And e.Location.Y < ResizeBorderWidth Then
            Cursor = Cursors.SizeNESW
            _resizeDirection = WindowsCode.HTTOPRIGHT
        ElseIf e.Location.X < ResizeBorderWidth Then
            Cursor = Cursors.SizeWE
            _resizeDirection = WindowsCode.HTLEFT
        ElseIf e.Location.X > Width - ResizeBorderWidth Then
            Cursor = Cursors.SizeWE
            _resizeDirection = WindowsCode.HTRIGHT
        ElseIf e.Location.Y < ResizeBorderWidth Then
            Cursor = Cursors.SizeNS
            _resizeDirection = WindowsCode.HTTOP
        ElseIf e.Location.Y > Height - ResizeBorderWidth Then
            Cursor = Cursors.SizeNS
            _resizeDirection = WindowsCode.HTBOTTOM
        Else
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub NHLGamesMetro_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left And WindowState <> FormWindowState.Maximized Then
            ResizeForm()
        End If
    End Sub

    Private Sub ResizeForm()
        If Not _resizeDirection.Equals(-1) Then
            NativeMethods.ReleaseCaptureOfForm()
            NativeMethods.SendMessageToHandle(Handle, WindowsCode.WM_NCLBUTTONDOWN, _resizeDirection, 0)
        End If
    End Sub

    Private Sub NHLGamesMetro_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub cbServers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServers.SelectedIndexChanged
        If Not FormLoaded Then Return
        Common.SetRedirectionServerInApp()
        InvokeElement.LoadGames()
    End Sub

    Private Sub btnCopyConsole_Click(sender As Object, e As EventArgs) Handles btnCopyConsole.Click
        CopyConsoleToClipBoard()
    End Sub

    Private Sub cbLanguage_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cbLanguage.SelectedIndexChanged
        ApplicationSettings.SetValue(SettingsEnum.SelectedLanguage, cbLanguage.SelectedItem.ToString())
        _writeToConsoleSettingsChanged(lblLanguage.Text, cbLanguage.SelectedItem.ToString())
        Common.GetLanguage()
        InitializeForm.SetLanguage()
        For Each game As GameControl In flpGames.Controls
            game.UpdateGame(tgShowFinalScores.Checked,
                            tgShowLiveScores.Checked,
                            tgShowSeriesRecord.Checked,
                            tgShowTeamCityAbr.Checked,
                            tgShowLiveTime.Checked,
                            GamesDict(game.GameId))
        Next
    End Sub

    Private Sub tgModules_Click(sender As Object, e As EventArgs) Handles tgModules.CheckedChanged
        Dim tg As MetroToggle = sender

        If tg.Checked Then
            _adDetectionEngine = New AdDetection
        Else
            tgSpotify.Checked = False
            tgOBS.Checked = False
        End If

        tgOBS.Enabled = tg.Checked AndAlso txtAdKey.Text <> String.Empty AndAlso txtGameKey.Text <> String.Empty
        tgSpotify.Enabled = tg.Checked
        tlpOBSSettings.Enabled = tg.Checked
        flpSpotifyParameters.Enabled = tg.Checked

        _adDetectionEngine.IsEnabled = tg.Checked
        If tg.Checked Then _adDetectionEngine.Start()
        AdDetection.Renew()
        _writeToConsoleSettingsChanged(String.Format(English.msgThisEnable, lblModules.Text),
                                       If(tgModules.Checked, English.msgOn, English.msgOff))
    End Sub

    Private Sub tgOBS_CheckedChanged(sender As Object, e As EventArgs) Handles tgOBS.CheckedChanged
        Dim tg As MetroToggle = sender
        Dim obs As New Obs

        tlpOBSSettings.Enabled = Not tg.Checked

        If tg.Checked Then
            obs.HotkeyAd.Key = txtAdKey.Text
            obs.HotkeyAd.Ctrl = chkAdCtrl.Checked
            obs.HotkeyAd.Alt = chkAdAlt.Checked
            obs.HotkeyAd.Shift = chkAdShift.Checked

            obs.HotkeyGame.Key = txtGameKey.Text
            obs.HotkeyGame.Ctrl = chkGameCtrl.Checked
            obs.HotkeyGame.Alt = chkGameAlt.Checked
            obs.HotkeyGame.Shift = chkGameShift.Checked

            _adDetectionEngine.AddModule(obs)
        ElseIf _adDetectionEngine.IsInAdModulesList(obs.Title) Then
            _adDetectionEngine.RemoveModule(obs.Title)
        End If

        AdDetection.Renew()
        _writeToConsoleSettingsChanged(String.Format(English.msgThisEnable, lblOBS.Text),
                                       If(tgOBS.Checked, English.msgOn, English.msgOff))
    End Sub

    Private Sub tgSpotify_CheckedChanged(sender As Object, e As EventArgs) Handles tgSpotify.CheckedChanged
        Dim tg As MetroToggle = sender
        Dim spotify As New Spotify

        flpSpotifyParameters.Enabled = Not tg.Checked

        If tg.Checked Then
            spotify.ForceToOpen = chkSpotifyForceToStart.Checked
            spotify.PlayNextSong = chkSpotifyPlayNextSong.Checked
            spotify.AnyMediaPlayer = chkSpotifyAnyMediaPlayer.Checked
            _adDetectionEngine.AddModule(spotify)
        ElseIf _adDetectionEngine.IsInAdModulesList(spotify.Title) Then
            _adDetectionEngine.RemoveModule(spotify.Title)
        End If

        AdDetection.Renew()
        _writeToConsoleSettingsChanged(String.Format(English.msgThisEnable, lblSpotify.Text),
                                       If(tgSpotify.Checked, English.msgOn, English.msgOff))
    End Sub

    Private Sub cbStreamQuality_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cbStreamQuality.SelectedIndexChanged
        Player.RenewArgs()
        _writeToConsoleSettingsChanged(lblQuality.Text, cbStreamQuality.SelectedItem)
    End Sub

    Private Sub txtGameKey_TextChanged(sender As Object, e As EventArgs) Handles txtGameKey.TextChanged
        txtGameKey.Text = txtGameKey.Text.ToUpper()
        If txtGameKey.Text = String.Empty Then
            tgOBS.Enabled = False
        End If
    End Sub

    Private Sub txtAdKey_TextChanged(sender As Object, e As EventArgs) Handles txtAdKey.TextChanged
        txtAdKey.Text = txtAdKey.Text.ToUpper()
        If txtAdKey.Text = String.Empty Then
            tgOBS.Enabled = False
        End If
    End Sub

    Private Sub tgTeamNamesAbr_CheckedChanged(sender As Object, e As EventArgs) Handles tgShowTeamCityAbr.CheckedChanged
        ApplicationSettings.SetValue(SettingsEnum.ShowTeamCityAbr, tgShowTeamCityAbr.Checked)
        _writeToConsoleSettingsChanged(String.Format(English.msgThisEnable, lblShowTeamCityAbr.Text),
                                       If(tgShowTeamCityAbr.Checked, English.msgOn, English.msgOff))
        For Each game As GameControl In flpGames.Controls
            game.UpdateGame(tgShowFinalScores.Checked,
                            tgShowLiveScores.Checked,
                            tgShowSeriesRecord.Checked,
                            tgShowTeamCityAbr.Checked,
                            tgShowLiveTime.Checked,
                            GamesDict(game.GameId))
        Next
    End Sub

    Private Sub txtObsKey_TextChanged(sender As Object, e As EventArgs) _
        Handles txtGameKey.TextChanged, txtAdKey.TextChanged
        tgOBS.Enabled = txtAdKey.Text <> String.Empty AndAlso txtGameKey.Text <> String.Empty AndAlso tgModules.Checked
    End Sub

    Private Sub chkSpotifyAnyMediaPlayer_CheckedChanged(sender As Object, e As EventArgs) _
        Handles chkSpotifyAnyMediaPlayer.CheckedChanged
        If chkSpotifyAnyMediaPlayer.Checked Then
            chkSpotifyForceToStart.Checked = False
        End If
        chkSpotifyForceToStart.Enabled = Not chkSpotifyAnyMediaPlayer.Checked
    End Sub

    Private Sub pnlCalendar_MouseLeave(sender As Object, e As EventArgs) Handles flpCalendarPanel.MouseLeave
        flpCalendarPanel.Visible =
            flpCalendarPanel.ClientRectangle.Contains(flpCalendarPanel.PointToClient(Cursor.Position))
    End Sub

    Private Sub flpCalendarPanel_VisibleChanged(sender As Object, e As EventArgs) _
        Handles flpCalendarPanel.VisibleChanged
        If flpCalendarPanel.Visible Then
            btnDate.BackColor = Color.FromArgb(0, 170, 210)
        Else
            btnDate.BackColor = If(IsDarkMode, Color.DarkGray, Color.FromArgb(80, 80, 80))
        End If
    End Sub

    Private Sub tgShowTodayLiveGamesFirst_CheckedChanged(sender As Object, e As EventArgs) _
        Handles tgShowTodayLiveGamesFirst.CheckedChanged
        ApplicationSettings.SetValue(SettingsEnum.ShowTodayLiveGamesFirst, tgShowTodayLiveGamesFirst.Checked)
        _writeToConsoleSettingsChanged(String.Format(English.msgThisEnable, lblShowTodayLiveGamesFirst.Text),
                                       If(tgShowTodayLiveGamesFirst.Checked, English.msgOn, English.msgOff))
        TodayLiveGamesFirst = tgShowTodayLiveGamesFirst.Checked
        InvokeElement.LoadGames()
    End Sub

    Private Async Sub CopyConsoleToClipBoard()
        Dim player As String = If(rbMPV.Checked, "MPV", If(rbMPC.Checked, "MPC", If(rbVLC.Checked, "VLC", "none")))
        Dim x64 As String = If(Environment.Is64BitOperatingSystem, "64 Bits", "32 Bits")
        Dim framework As String = Environment.Version.ToString()
        Dim streamerPath = ApplicationSettings.Read(Of String)(SettingsEnum.StreamerPath, String.Empty).ToString()
        Dim vlcPath = ApplicationSettings.Read(Of String)(SettingsEnum.VlcPath, String.Empty).ToString()
        Dim mpcPath = ApplicationSettings.Read(Of String)(SettingsEnum.MpcPath, String.Empty).ToString()
        Dim mpvPath = ApplicationSettings.Read(Of String)(SettingsEnum.MpvPath, String.Empty).ToString()
        Dim streamerExists = streamerPath <> "" AndAlso File.Exists(streamerPath)
        Dim pingGoogle = Await Common.SendWebRequestAsync("https://www.google.com")
        Dim vlcExists = vlcPath <> "" AndAlso File.Exists(vlcPath)
        Dim mpcExists = mpcPath <> "" AndAlso File.Exists(mpcPath)
        Dim mpvExists = mpvPath <> "" AndAlso File.Exists(mpvPath)
        Dim version = String.Format("v {0}.{1}.{2}.{3}", My.Application.Info.Version.Major,
                                    My.Application.Info.Version.Minor, My.Application.Info.Version.Build,
                                    My.Application.Info.Version.Revision)
        Dim report = $"NHLGames Bug Report {version}{vbCrLf}{vbCrLf}" &
                     $"Operating system: {My.Computer.Info.OSFullName.ToString()} {x64} - .Net build {framework}{vbTab}{vbCrLf}" &
                     $"Internet: Connection test {If(My.Computer.Network.IsAvailable, "succeeded", "failed") _
                         }, ping google.com {If(pingGoogle, "succeeded", "failed")}{ vbTab}{vbCrLf}" &
                     $"Form: {If(Not String.IsNullOrEmpty(lblDate.Text), "loaded", "not loaded")}, " &
                     $"{flpGames.Controls.Count} games currently on form, " &
                     $"Selected player: {player.ToString()}{vbTab}{vbCrLf}" &
                     $"Streamer path: {streamerPath.ToString()} [{ _
                         If(streamerPath.Equals(txtStreamerPath.Text), "on form", "not on form")}] [{ _
                         If(streamerExists, "exe found", "exe not found")}]{vbTab}{vbCrLf}" &
                     $"VLC path: {vlcPath.ToString()} [{If(vlcPath.Equals(txtVLCPath.Text), "on form", "not on form") _
                         }] [{If(vlcExists, "exe found", "exe not found")}]{vbTab}{vbCrLf}" &
                     $"MPC path: {mpcPath.ToString()} [{If(mpcPath.Equals(txtMPCPath.Text), "on form", "not on form") _
                         }] [{If(mpcExists, "exe found", "exe not found")}]{vbTab}{vbCrLf}" &
                     $"MPV path: {mpvPath.ToString()} [{If(mpvPath.Equals(txtMpvPath.Text), "on form", "not on form") _
                         }] [{If(mpvExists, "exe found", "exe not found")}]{vbCrLf}{vbCrLf}" &
                     $"Console log: {vbTab}{txtConsole.Text.Replace($"{vbLf}{vbLf}", $"{vbTab}{vbCrLf}").ToString()}"
        Clipboard.SetText(report)
    End Sub

    Private Sub NHLGamesMetro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If WindowState = FormWindowState.Normal Then ApplicationSettings.SetValue(SettingsEnum.LastWindowSize, Width & ";" & Height)
        Proxy.StopProxy()
    End Sub

    Private Sub tbLiveRewind_MouseUp(sender As Object, e As MouseEventArgs) Handles tbLiveRewind.MouseUp
        _writeToConsoleSettingsChanged(lblLiveRewind.Text, tbLiveRewind.Value * 5)
    End Sub

    Private Sub tbLiveRewind_ValueChanged(sender As Object, e As EventArgs) Handles tbLiveRewind.ValueChanged
        Dim minutesBehind = tbLiveRewind.Value * 5
        lblLiveRewindDetails.Text = String.Format(
            RmText.GetString("lblLiveRewindDetails"),
            minutesBehind, Now.AddMinutes(-minutesBehind).ToString("h:mm tt", CultureInfo.InvariantCulture))
        Player.RenewArgs()

        For Each game As GameControl In flpGames.Controls
            If game.LiveReplayCode = LiveStatusCodeEnum.Rewind Then
                game.SetLiveStatusIcon()
            End If
        Next
    End Sub

    Private Sub cbLiveReplay_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cbLiveReplay.SelectedIndexChanged
        Player.RenewArgs()
        _writeToConsoleSettingsChanged(_lblLiveReplay.Text, cbLiveReplay.SelectedItem)
    End Sub

    Private Sub tgShowLiveTime_CheckedChanged(sender As Object, e As EventArgs) Handles tgShowLiveTime.CheckedChanged
        ApplicationSettings.SetValue(SettingsEnum.ShowLiveTime, tgShowLiveTime.Checked)
        _writeToConsoleSettingsChanged(String.Format(English.msgThisEnable, lblShowLiveTime.Text),
                                       If(tgShowLiveTime.Checked, English.msgOn, English.msgOff))
        For Each game As GameControl In flpGames.Controls
            game.UpdateGame(tgShowFinalScores.Checked,
                            tgShowLiveScores.Checked,
                            tgShowSeriesRecord.Checked,
                            tgShowTeamCityAbr.Checked,
                            tgShowLiveTime.Checked,
                            GamesDict(game.GameId))
        Next
    End Sub

    Private Sub tgDarkMode_CheckedChanged(sender As Object, e As EventArgs) Handles tgDarkMode.CheckedChanged
        Dim darkMode = ApplicationSettings.Read(Of Boolean)(SettingsEnum.DarkMode, False)
        If Not darkMode.Equals(tgDarkMode.Checked) AndAlso InvokeElement.MsgBoxBlue(
            RmText.GetString("msgAcceptToRestart"),
            RmText.GetString("lblDark"),
            MessageBoxButtons.YesNo) = DialogResult.Yes Then
            RestartNHLGames()
        End If
        ApplicationSettings.SetValue(SettingsEnum.DarkMode, tgDarkMode.Checked)
        _writeToConsoleSettingsChanged(String.Format(English.msgThisEnable, lblDarkMode.Text),
                                       If(tgDarkMode.Checked, English.msgOn, English.msgOff))
    End Sub

    Private Sub RestartNHLGames()
        Dim exeName = Process.GetCurrentProcess().MainModule.FileName
        Dim startInfo = New ProcessStartInfo(exeName)
        Try
            Process.Start(startInfo)
            Application.Exit()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub tbProxyPort_ValueChanged(sender As Object, e As EventArgs) Handles tbProxyPort.ValueChanged
        Dim value = tbProxyPort.Value * 10
        lblProxyPortNumber.Text = value.ToString()
    End Sub

    Private Sub tbProxyPort_Scroll(sender As Object, e As ScrollEventArgs) Handles tbProxyPort.Scroll
        Dim value = tbProxyPort.Value * 10
        lblProxyPortNumber.Text = value.ToString()
        ApplicationSettings.SetValue(SettingsEnum.ProxyPort, value)
        _writeToConsoleSettingsChanged(lblProxyPort.Text, value.ToString())
    End Sub

End Class
