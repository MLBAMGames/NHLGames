Imports System.Configuration
Imports System.Globalization
Imports System.IO
Imports System.Resources
Imports System.Security.Permissions
Imports System.Threading
Imports MetroFramework.Controls
Imports MLBAMGames.Library
Imports MLBAMGames.Library.Controls
Imports MLBAMGames.Library.Objects
Imports MLBAMGames.Library.Objects.Modules
Imports MLBAMGames.Library.Utilities
Imports NHLGames.My.Resources
Imports NHLGames.Utilities

Public Class NHLGamesMetro
    Implements IMLBAMForm


    <SecurityPermission(SecurityAction.Demand, Flags:=SecurityPermissionFlag.ControlAppDomain)>
    Public Shared Sub Main()
        AddHandler Application.ThreadException, AddressOf Form1_UIThreadException
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException

        Updater.UpgradeSettings()

        Parameters.IsDarkMode = My.Settings.UseDarkMode
        Parameters.StartupPath = Application.StartupPath

        Dim form As New NHLGamesMetro()
        Instance.Form = form
        Lang.FrenchhRmText = French.ResourceManager
        Lang.EnglishRmText = English.ResourceManager

        Dim writer = New ConsoleRedirectStreamWriter(form.txtConsole)
        Console.SetOut(writer)
        Application.Run(form)
    End Sub

    Private Shared Sub Form1_UIThreadException(sender As Object, t As ThreadExceptionEventArgs)
        Console.WriteLine(Lang.EnglishRmText.GetString("errorGeneral"), $"Running UI thread", t.Exception.ToString())
    End Sub

    Private Shared Sub CurrentDomain_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs)
        Console.WriteLine(Lang.EnglishRmText.GetString("errorGeneral"), $"Using NHLGames domain", e.ExceptionObject.ToString())
    End Sub

    Public Sub HandleException(e As Exception)
        Console.WriteLine(Lang.EnglishRmText.GetString("errorGeneral"), $"Running main thread", e.ToString())
    End Sub

    Private Async Sub NHLGames_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitializeForm.SetWindow()

        SuspendLayout()

        Lang.GetLanguage()
        tabMenu.SelectedIndex = MainTabsEnum.Matchs
        CalendarControl.FlpCalendar = flpCalendarPanel
        InitializeForm.SetSettings()

        If Proxy.TestHostsEntry() Then
            Parameters.IsHostsRedirectionSet = True
        Else
            Proxy.MLBAMProxy = New Proxy()
        End If

        Await Web.CheckAppCanRun()

        Parameters.UILoaded = True
        ResumeLayout(True)

        tmr.Enabled = True
        InvokeElement.LoadGames(CalendarControl.GameDate)

        InvokeElement.LoadTeamsName()
        InvokeElement.LoadStandings()
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
        If Parameters.UILoaded Then Console.WriteLine(Lang.EnglishRmText.GetString("msgSettingUpdated"), key, value)
    End Sub

    Private Shared Sub tmrAnimate_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        If Parameters.StreamStarted Then
            GameFetcher.StreamingProgress()
        Else
            GameFetcher.LoadingProgress()
        End If
        InvokeElement.AnimateTipsTick += NHLGamesMetro.tmr.Interval
        InvokeElement.AnimateTips()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        flpCalendarPanel.Visible = False
        InvokeElement.LoadGames(MLBAMGames.Library.Controls.CalendarControl.GameDate)
        flpGames.Focus()
    End Sub

    Private Sub txtConsole_TextChanged(sender As Object, e As EventArgs) Handles txtConsole.TextChanged
        txtConsole.SelectionStart = txtConsole.Text.Length
        txtConsole.ScrollToCaret()
    End Sub

    Private Sub btnVLCPath_Click(sender As Object, e As EventArgs) Handles btnVLCPath.Click
        ofd.Filter = $"VLC|vlc.exe|All files (*.*)|*.*"
        ofd.Multiselect = False
        ofd.InitialDirectory = If(txtVLCPath.Text.Equals(String.Empty), "C:\", Path.GetDirectoryName(txtVLCPath.Text))

        If ofd.ShowDialog() = DialogResult.OK Then
            If String.IsNullOrEmpty(ofd.FileName) = False And txtVLCPath.Text <> ofd.FileName Then
                My.Settings.VlcPath = ofd.FileName
                My.Settings.Save()
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
                My.Settings.MpcPath = ofd.FileName
                My.Settings.Save()
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
                My.Settings.MpvPath = ofd.FileName
                My.Settings.Save()
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
                My.Settings.StreamerPath = ofd.FileName
                My.Settings.Save()
                _writeToConsoleSettingsChanged(lblSlPath.Text, ofd.FileName)
                txtStreamerPath.Text = ofd.FileName
            End If

        End If
    End Sub

    Private Sub _writeToConsoleSettingToggleChanged(label As String, checked As Boolean)
        _writeToConsoleSettingsChanged(String.Format(Lang.EnglishRmText.GetString("msgThisEnable"), label),
            If(checked, Lang.EnglishRmText.GetString("msgOn"), Lang.EnglishRmText.GetString("msgOff")))
    End Sub

    Private Sub tgShowFinalScores_CheckedChanged(sender As Object, e As EventArgs) _
        Handles tgShowFinalScores.CheckedChanged
        My.Settings.ShowScores = tgShowFinalScores.Checked
        My.Settings.Save()
        _writeToConsoleSettingToggleChanged(lblShowFinalScores.Text, tgShowFinalScores.Checked)
        For Each game As GameControl In flpGames.Controls
            game.UpdateGame(tgShowFinalScores.Checked,
                            tgShowLiveScores.Checked,
                            tgShowSeriesRecord.Checked,
                            tgShowTeamCityAbr.Checked,
                            tgShowLiveTime.Checked,
                            tgShowStanding.Checked,
                            GameFetcher.Entries(game.GameId))
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
            SetPlayerDefaultArgs(True)
            _writeToConsoleSettingsChanged(lblPlayer.Text, rb.Text)
        End If
    End Sub

    Private Sub tgAlternateCdn_CheckedChanged(sender As Object, e As EventArgs) Handles tgAlternateCdn.CheckedChanged
        Dim cdn = If(tgAlternateCdn.Checked, CdnTypeEnum.L3C, CdnTypeEnum.Akc)
        Player.RenewArgs()
        _writeToConsoleSettingsChanged(lblCdn.Text, cdn.ToString())
        InvokeElement.LoadGames(CalendarControl.GameDate)
    End Sub

    Private Sub txtOutputPath_TextChanged(sender As Object, e As EventArgs) Handles txtOutputArgs.TextChanged
        Player.RenewArgs()
        _writeToConsoleSettingsChanged(lblOutput.Text, txtOutputArgs.Text)
    End Sub

    Private Sub txtPlayerArgs_TextChanged(sender As Object, e As EventArgs) Handles txtPlayerArgs.TextChanged
        Dim playerType = Player.GetPlayerType(Instance.Form)
        Dim args = txtPlayerArgs.Text.Split(New String() {" "}, StringSplitOptions.RemoveEmptyEntries)
        GameWatchArguments.SavedPlayerArgs(playerType) = args
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
        CalendarControl.GameDate = CalendarControl.GameDate.AddDays(-1)
        lblDate.Text = DateHelper.GetFormattedDate(CalendarControl.GameDate)
    End Sub

    Private Sub btnTomorrow_Click(sender As Object, e As EventArgs) Handles btnTomorrow.Click
        CalendarControl.GameDate = CalendarControl.GameDate.AddDays(1)
        lblDate.Text = DateHelper.GetFormattedDate(CalendarControl.GameDate)
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
        InvokeElement.LoadGames(CalendarControl.GameDate)
        flpGames.Focus()
    End Sub

    Private Sub chkShowLiveScores_CheckedChanged(sender As Object, e As EventArgs) _
        Handles tgShowLiveScores.CheckedChanged
        My.Settings.ShowLiveScores = tgShowLiveScores.Checked
        My.Settings.Save()
        _writeToConsoleSettingToggleChanged(lblShowLiveScores.Text, tgShowLiveScores.Checked)
        For Each game As GameControl In flpGames.Controls
            game.UpdateGame(tgShowFinalScores.Checked,
                            tgShowLiveScores.Checked,
                            tgShowSeriesRecord.Checked,
                            tgShowTeamCityAbr.Checked,
                            tgShowLiveTime.Checked,
                            tgShowStanding.Checked,
                            GameFetcher.Entries(game.GameId))
        Next
    End Sub

    Private Sub tgShowStanding_CheckedChanged(sender As Object, e As EventArgs) Handles tgShowStanding.CheckedChanged
        My.Settings.ShowStanding = tgShowStanding.Checked
        My.Settings.Save()
        _writeToConsoleSettingToggleChanged(lblShowStanding.Text, tgShowStanding.Checked)
        For Each game As GameControl In flpGames.Controls
            game.UpdateGame(tgShowFinalScores.Checked,
                            tgShowLiveScores.Checked,
                            tgShowSeriesRecord.Checked,
                            tgShowTeamCityAbr.Checked,
                            tgShowLiveTime.Checked,
                            tgShowStanding.Checked,
                            GameFetcher.Entries(game.GameId))
        Next
    End Sub

    Private Sub lnkReddit_Click(sender As Object, e As EventArgs) Handles lnkReddit.Click
        Dim sInfo As ProcessStartInfo = New ProcessStartInfo(Parameters.SubredditLink)
        Process.Start(sInfo)
    End Sub

    Private Sub lnkRelease_Click(sender As Object, e As EventArgs) Handles lnkRelease.Click
        GitHub.Update()
    End Sub

    Private Sub tgStreamer_CheckedChanged(sender As Object, e As EventArgs) Handles tgStreamer.CheckedChanged
        SetStreamerDefaultArgs()
        txtStreamerArgs.Enabled = tgStreamer.Checked
        Player.RenewArgs()
        _writeToConsoleSettingToggleChanged(lblStreamerArgs.Text, tgStreamer.Checked)
    End Sub

    Private Sub tgOutput_CheckedChanged(sender As Object, e As EventArgs) Handles tgOutput.CheckedChanged
        txtOutputArgs.Enabled = tgOutput.Checked
        If txtOutputArgs.Text = String.Empty Then
            txtOutputArgs.Text =
                $"{Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) _
                    }\(DATE)_(HOME)_vs_(AWAY)_(TYPE)_(NETWORK).mp4"
        End If
        Player.RenewArgs()
        _writeToConsoleSettingToggleChanged(lblOutput.Text, tgOutput.Checked)
    End Sub

    Private Sub chkShowSeriesRecord_CheckedChanged(sender As Object, e As EventArgs) _
        Handles tgShowSeriesRecord.CheckedChanged
        My.Settings.ShowSeriesRecord = tgShowSeriesRecord.Checked
        My.Settings.Save()
        _writeToConsoleSettingToggleChanged(lblShowSeriesRecord.Text, tgShowSeriesRecord.Checked)
        For Each game As GameControl In flpGames.Controls
            game.UpdateGame(tgShowFinalScores.Checked,
                            tgShowLiveScores.Checked,
                            tgShowSeriesRecord.Checked,
                            tgShowTeamCityAbr.Checked,
                            tgShowLiveTime.Checked,
                            tgShowStanding.Checked,
                            GameFetcher.Entries(game.GameId))
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

    Public Sub SetStreamerDefaultArgs()
        If tgStreamer Is Nothing Then Return
        If Not tgStreamer.Checked Then
            SetDefaultArgs(GameWatchArguments.StreamerDefaultArgs, txtStreamerArgs)
        End If
    End Sub

    Public Sub SetPlayerDefaultArgs(Optional overwrite As Boolean = False)
        If txtPlayerArgs Is Nothing Then Return
        Dim gameArgs = SettingsExtensions.ReadGameWatchArgs()
        Dim defaultPlayerArgs = New String() {}
        Select Case gameArgs.PlayerType
            Case PlayerTypeEnum.Vlc
                defaultPlayerArgs = GameWatchArguments.SavedPlayerArgs(PlayerTypeEnum.Vlc)
            Case PlayerTypeEnum.Mpv
                defaultPlayerArgs = GameWatchArguments.SavedPlayerArgs(PlayerTypeEnum.Mpv)
            Case PlayerTypeEnum.Mpc
                defaultPlayerArgs = GameWatchArguments.SavedPlayerArgs(PlayerTypeEnum.Mpc)
        End Select

        SetDefaultArgs(defaultPlayerArgs.ToDictionary(Function(x) x.Split("=").First(), Function(y) y.Substring(y.IndexOf("=") + 1)), txtPlayerArgs, overwrite)
    End Sub

    Private Sub SetDefaultArgs(args As Dictionary(Of String, String), txt As TextBox, Optional overwrite As Boolean = False)
        If overwrite Then txt.Text = ""
        For Each arg In args
            If Not txt.Text.Contains(arg.Key) Then txt.Text &= $" {arg.Key}={arg.Value}"
        Next
        txt.Text = txt.Text.Trim()
    End Sub

    Private Sub NHLGamesMetro_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Dim ResizeDirection = -1
        Dim ResizeBorderWidth = Parameters.ResizeBorderWidth

        If e.Location.X < ResizeBorderWidth And e.Location.Y < ResizeBorderWidth Then
            Cursor = Cursors.SizeNWSE
            ResizeDirection = WindowsCode.HTTOPLEFT
        ElseIf e.Location.X < ResizeBorderWidth And e.Location.Y > Height - ResizeBorderWidth Then
            Cursor = Cursors.SizeNESW
            ResizeDirection = WindowsCode.HTBOTTOMLEFT
        ElseIf e.Location.X > Width - ResizeBorderWidth And e.Location.Y > Height - ResizeBorderWidth Then
            Cursor = Cursors.SizeNWSE
            ResizeDirection = WindowsCode.HTBOTTOMRIGHT
        ElseIf e.Location.X > Width - ResizeBorderWidth And e.Location.Y < ResizeBorderWidth Then
            Cursor = Cursors.SizeNESW
            ResizeDirection = WindowsCode.HTTOPRIGHT
        ElseIf e.Location.X < ResizeBorderWidth Then
            Cursor = Cursors.SizeWE
            ResizeDirection = WindowsCode.HTLEFT
        ElseIf e.Location.X > Width - ResizeBorderWidth Then
            Cursor = Cursors.SizeWE
            ResizeDirection = WindowsCode.HTRIGHT
        ElseIf e.Location.Y < ResizeBorderWidth Then
            Cursor = Cursors.SizeNS
            ResizeDirection = WindowsCode.HTTOP
        ElseIf e.Location.Y > Height - ResizeBorderWidth Then
            Cursor = Cursors.SizeNS
            ResizeDirection = WindowsCode.HTBOTTOM
        Else
            Cursor = Cursors.Default
        End If

        Parameters.ResizeDirection = ResizeDirection
    End Sub

    Private Sub NHLGamesMetro_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left And WindowState <> FormWindowState.Maximized Then
            ResizeForm()
        End If
    End Sub

    Private Sub ResizeForm()
        If Not Parameters.ResizeDirection.Equals(-1) Then
            NativeMethods.ReleaseCaptureOfForm()
            NativeMethods.SendMessageToHandle(Handle, WindowsCode.WM_NCLBUTTONDOWN, Parameters.ResizeDirection, 0)
        End If
    End Sub

    Private Sub NHLGamesMetro_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub cbServers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServers.SelectedIndexChanged
        If Not Parameters.UILoaded Then Return
        Web.SetRedirectionServerInApp()
        InvokeElement.LoadGames(CalendarControl.GameDate)
    End Sub

    Private Sub btnCopyConsole_Click(sender As Object, e As EventArgs) Handles btnCopyConsole.Click
        CopyConsoleToClipBoard()
    End Sub

    Private Sub cbLanguage_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cbLanguage.SelectedIndexChanged
        My.Settings.SelectedLanguage = cbLanguage.SelectedItem.ToString()
        My.Settings.Save()
        _writeToConsoleSettingsChanged(lblLanguage.Text, cbLanguage.SelectedItem.ToString())
        Lang.GetLanguage()
        InitializeForm.SetLanguage()
        For Each game As GameControl In flpGames.Controls
            game.UpdateGame(tgShowFinalScores.Checked,
                            tgShowLiveScores.Checked,
                            tgShowSeriesRecord.Checked,
                            tgShowTeamCityAbr.Checked,
                            tgShowLiveTime.Checked,
                            tgShowStanding.Checked,
                            GameFetcher.Entries(game.GameId))
        Next
    End Sub

    Private Sub tgModules_Click(sender As Object, e As EventArgs) Handles tgModules.CheckedChanged
        Dim tg As MetroToggle = sender

        If tg.Checked Then
            AdDetection.Engine = New AdDetection
        Else
            tgMedia.Checked = False
            tgOBS.Checked = False
        End If

        tgOBS.Enabled = tg.Checked AndAlso txtAdKey.Text <> String.Empty AndAlso txtGameKey.Text <> String.Empty
        tgMedia.Enabled = tg.Checked
        tlpOBSSettings.Enabled = tg.Checked
        flpSpotifyParameters.Enabled = tg.Checked

        AdDetection.Engine.IsEnabled = tg.Checked
        If tg.Checked Then AdDetection.Engine.Start()
        AdDetection.Renew()
        _writeToConsoleSettingToggleChanged(lblModules.Text, tgModules.Checked)
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

            AdDetection.Engine.AddModule(obs)
        ElseIf AdDetection.Engine.IsInAdModulesList(obs.Title) Then
            AdDetection.Engine.RemoveModule(obs.Title)
        End If

        AdDetection.Renew()
        _writeToConsoleSettingToggleChanged(lblOBS.Text, tgOBS.Checked)
    End Sub

    Private Sub tgMedia_CheckedChanged(sender As Object, e As EventArgs) Handles tgMedia.CheckedChanged
        Dim tg As MetroToggle = sender
        Dim spotify As New MediaAndSpotify

        flpSpotifyParameters.Enabled = Not tg.Checked

        If tg.Checked Then
            spotify.ForceToOpen = chkSpotifyForceToStart.Checked
            spotify.PlayNextSong = chkSpotifyPlayNextSong.Checked
            spotify.UseHotkeys = chkSpotifyHotkeys.Checked
            spotify.MediaControlDelay = txtMediaControlDelay.Text
            AdDetection.Engine.AddModule(spotify)
        ElseIf AdDetection.Engine.IsInAdModulesList(spotify.Title) Then
            AdDetection.Engine.RemoveModule(spotify.Title)
        End If

        AdDetection.Renew()
        _writeToConsoleSettingToggleChanged(lblMedia.Text, tgMedia.Checked)
    End Sub

    Private Sub txtMediaControlDelay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMediaControlDelay.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtMediaControlDelay_TextChanged(sender As Object, e As EventArgs) Handles txtMediaControlDelay.TextChanged
        If Not String.IsNullOrEmpty(txtMediaControlDelay.Text) Then
            AdDetection.Renew()
        End If
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
        My.Settings.ShowTeamCityAbr = tgShowTeamCityAbr.Checked
        My.Settings.Save()
        _writeToConsoleSettingToggleChanged(lblShowTeamCityAbr.Text, tgShowTeamCityAbr.Checked)
        For Each game As GameControl In flpGames.Controls
            game.UpdateGame(tgShowFinalScores.Checked,
                            tgShowLiveScores.Checked,
                            tgShowSeriesRecord.Checked,
                            tgShowTeamCityAbr.Checked,
                            tgShowLiveTime.Checked,
                            tgShowStanding.Checked,
                            GameFetcher.Entries(game.GameId))
        Next
    End Sub

    Private Sub txtObsKey_TextChanged(sender As Object, e As EventArgs) _
        Handles txtGameKey.TextChanged, txtAdKey.TextChanged
        tgOBS.Enabled = txtAdKey.Text <> String.Empty AndAlso txtGameKey.Text <> String.Empty AndAlso tgModules.Checked
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
            btnDate.BackColor = If(Parameters.IsDarkMode, Color.DarkGray, Color.FromArgb(80, 80, 80))
        End If
    End Sub

    Private Sub tgShowTodayLiveGamesFirst_CheckedChanged(sender As Object, e As EventArgs) _
        Handles tgShowTodayLiveGamesFirst.CheckedChanged
        My.Settings.ShowTodayLiveGamesFirst = tgShowTodayLiveGamesFirst.Checked
        My.Settings.Save()
        _writeToConsoleSettingToggleChanged(lblShowTodayLiveGamesFirst.Text, tgShowTodayLiveGamesFirst.Checked)
        Parameters.TodayLiveGamesFirst = tgShowTodayLiveGamesFirst.Checked
        InvokeElement.LoadGames(CalendarControl.GameDate)
    End Sub

    Private Async Sub CopyConsoleToClipBoard()
        Dim player As String = If(rbMPV.Checked, "MPV", If(rbMPC.Checked, "MPC", If(rbVLC.Checked, "VLC", "none")))
        Dim x64 As String = If(Environment.Is64BitOperatingSystem, "64 Bits", "32 Bits")
        Dim framework As String = Environment.Version.ToString()
        Dim streamerPath = My.Settings.StreamerPath
        Dim vlcPath = My.Settings.VlcPath
        Dim mpcPath = My.Settings.MpcPath
        Dim mpvPath = My.Settings.MpvPath
        Dim streamerExists = streamerPath <> "" AndAlso File.Exists(streamerPath)
        Dim pingGoogle = Await Web.SendWebRequestAsync("https://www.google.com")
        Dim vlcExists = vlcPath <> "" AndAlso File.Exists(vlcPath)
        Dim mpcExists = mpcPath <> "" AndAlso File.Exists(mpcPath)
        Dim mpvExists = mpvPath <> "" AndAlso File.Exists(mpvPath)
        Dim version = String.Format("v {0}.{1}.{2}.{3}", My.Application.Info.Version.Major,
                                    My.Application.Info.Version.Minor, My.Application.Info.Version.Build,
                                    My.Application.Info.Version.Revision)
        Dim report = $"NHLGames Bug Report {version}{vbCrLf}{vbCrLf}" &
                     $"Operating system: {My.Computer.Info.OSFullName.ToString()} {x64} - .Net build {framework}{vbTab}{vbCrLf}" &
                     $"Internet: Connection test {If(My.Computer.Network.IsAvailable, "succeeded", "failed") _
                         }, ping google.com {If(pingGoogle, "succeeded", "failed")}{vbTab}{vbCrLf}" &
                     $"Streamer args {If(tgStreamer.Checked, "enabled", "disabled")}:{txtStreamerArgs.Text}{vbTab}{vbCrLf}" &
                     $"Player args {If(tgPlayer.Checked, "enabled", "disabled")}:{txtPlayerArgs.Text}{vbTab}{vbCrLf}" &
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
        If WindowState = FormWindowState.Normal Then
            My.Settings.LastWindowSize = Width & ";" & Height
            My.Settings.Save()
        End If
        Proxy.StopProxy()
    End Sub

    Private Sub tbLiveRewind_MouseUp(sender As Object, e As MouseEventArgs) Handles tbLiveRewind.MouseUp
        _writeToConsoleSettingsChanged(lblLiveRewind.Text, tbLiveRewind.Value * 5)
    End Sub

    Private Sub tbLiveRewind_ValueChanged(sender As Object, e As EventArgs) Handles tbLiveRewind.ValueChanged
        Dim minutesBehind = tbLiveRewind.Value * 5
        lblLiveRewindDetails.Text = String.Format(
            Lang.RmText.GetString("lblLiveRewindDetails"),
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
        My.Settings.ShowLiveTime = tgShowLiveTime.Checked
        My.Settings.Save()
        _writeToConsoleSettingToggleChanged(lblShowLiveTime.Text, tgShowLiveTime.Checked)
        For Each game As GameControl In flpGames.Controls
            game.UpdateGame(tgShowFinalScores.Checked,
                            tgShowLiveScores.Checked,
                            tgShowSeriesRecord.Checked,
                            tgShowTeamCityAbr.Checked,
                            tgShowLiveTime.Checked,
                            tgShowStanding.Checked,
                            GameFetcher.Entries(game.GameId))
        Next
    End Sub

    Private Sub tgDarkMode_CheckedChanged(sender As Object, e As EventArgs) Handles tgDarkMode.CheckedChanged
        Dim darkMode = My.Settings.UseDarkMode
        If Not darkMode.Equals(tgDarkMode.Checked) AndAlso InvokeElement.MsgBoxBlue(
            Lang.RmText.GetString("msgAcceptToRestart"),
            Lang.RmText.GetString("lblDark"),
            MessageBoxButtons.YesNo) = DialogResult.Yes Then
            RestartNHLGames()
        End If
        My.Settings.UseDarkMode = tgDarkMode.Checked
        My.Settings.Save()
        _writeToConsoleSettingToggleChanged(lblDarkMode.Text, tgDarkMode.Checked)
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
        My.Settings.ProxyPort = value
        My.Settings.Save()
        _writeToConsoleSettingsChanged(lblProxyPort.Text, value.ToString())
    End Sub

    Private Sub cbSeasons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSeasons.SelectedIndexChanged
        Dim season As NHLStats.Season = cbSeasons.Items(cbSeasons.SelectedIndex)
        StandingsHelper.GenerateStandings(tbStanding, season)
    End Sub

    Private Sub tgReset_CheckedChanged(sender As Object, e As EventArgs) Handles tgReset.CheckedChanged
        If tgReset.Checked = False Then Return

        If InvokeElement.MsgBoxBlue(
            Lang.RmText.GetString("msgAcceptToRestart"),
            Lang.RmText.GetString("lblReset"),
            MessageBoxButtons.YesNo) = DialogResult.Yes Then
            My.Settings.Reset()
            My.Settings.Save()
            Dim x = My.Settings.LastBuildVersionSkipped
            RestartNHLGames()
        End If

        tgReset.Checked = False
    End Sub

#Region "Implements IMLBAMForm"
    Private Function IMLBAMForm_BeginInvoke(method As [Delegate], ParamArray args() As Object) As IAsyncResult Implements IMLBAMForm.BeginInvoke
        Return BeginInvoke(method, args)
    End Function

    Private Function IMLBAMForm_EndInvoke(asyncResult As IAsyncResult) As Object Implements IMLBAMForm.EndInvoke
        Return EndInvoke(asyncResult)
    End Function

    Private Sub IMLBAMForm_Close() Implements IMLBAMForm.Close
        Close()
    End Sub

    Private Sub IMLBAMForm_ClearGamePanel() Implements IMLBAMForm.ClearGamePanel
        ClearGamePanel()
    End Sub

    Private Property IMLBAMForm_tgModules As MetroToggle Implements IMLBAMForm.tgModules
        Get
            Return tgModules
        End Get
        Set(value As MetroToggle)
            tgModules = value
        End Set
    End Property

    Private Property IMLBAMForm_tgMedia As MetroToggle Implements IMLBAMForm.tgMedia
        Get
            Return tgMedia
        End Get
        Set(value As MetroToggle)
            tgMedia = value
        End Set
    End Property

    Private Property IMLBAMForm_tgOBS As MetroToggle Implements IMLBAMForm.tgOBS
        Get
            Return tgOBS
        End Get
        Set(value As MetroToggle)
            tgOBS = value
        End Set
    End Property

    Private Property IMLBAMForm_tgOutput As MetroToggle Implements IMLBAMForm.tgOutput
        Get
            Return tgOutput
        End Get
        Set(value As MetroToggle)
            tgOutput = value
        End Set
    End Property

    Private Property IMLBAMForm_spnStreaming As MetroProgressSpinner Implements IMLBAMForm.spnStreaming
        Get
            Return spnStreaming
        End Get
        Set(value As MetroProgressSpinner)
            spnStreaming = value
        End Set
    End Property

    Private Property IMLBAMForm_spnLoading As MetroProgressSpinner Implements IMLBAMForm.spnLoading
        Get
            Return spnLoading
        End Get
        Set(value As MetroProgressSpinner)
            spnLoading = value
        End Set
    End Property

    Private Property IMLBAMForm_tabMenu As MetroTabControl Implements IMLBAMForm.tabMenu
        Get
            Return tabMenu
        End Get
        Set(value As MetroTabControl)
            tabMenu = value
        End Set
    End Property

    Private Property IMLBAMForm_lblNoGames As Label Implements IMLBAMForm.lblNoGames
        Get
            Return lblNoGames
        End Get
        Set(value As Label)
            lblNoGames = value
        End Set
    End Property

    Private Property IMLBAMForm_lblStatus As MetroLabel Implements IMLBAMForm.lblStatus
        Get
            Return lblStatus
        End Get
        Set(value As MetroLabel)
            lblStatus = value
        End Set
    End Property

    Private Property IMLBAMForm_lblTip As MetroLabel Implements IMLBAMForm.lblTip
        Get
            Return lblTip
        End Get
        Set(value As MetroLabel)
            lblTip = value
        End Set
    End Property

    Private Property IMLBAMForm_lnkRelease As MetroLink Implements IMLBAMForm.lnkRelease
        Get
            Return lnkRelease
        End Get
        Set(value As MetroLink)
            lnkRelease = value
        End Set
    End Property

    Private Property IMLBAMForm_chkSpotifyForceToStart As MetroCheckBox Implements IMLBAMForm.chkSpotifyForceToStart
        Get
            Return chkSpotifyForceToStart
        End Get
        Set(value As MetroCheckBox)
            chkSpotifyForceToStart = value
        End Set
    End Property

    Private Property IMLBAMForm_chkSpotifyPlayNextSong As MetroCheckBox Implements IMLBAMForm.chkSpotifyPlayNextSong
        Get
            Return chkSpotifyPlayNextSong
        End Get
        Set(value As MetroCheckBox)
            chkSpotifyPlayNextSong = value
        End Set
    End Property

    Private Property IMLBAMForm_chkSpotifyHotkeys As MetroCheckBox Implements IMLBAMForm.chkSpotifyHotkeys
        Get
            Return chkSpotifyHotkeys
        End Get
        Set(value As MetroCheckBox)
            chkSpotifyHotkeys = value
        End Set
    End Property

    Private Property IMLBAMForm_chkGameCtrl As MetroCheckBox Implements IMLBAMForm.chkGameCtrl
        Get
            Return chkGameCtrl
        End Get
        Set(value As MetroCheckBox)
            chkGameCtrl = value
        End Set
    End Property

    Private Property IMLBAMForm_chkGameAlt As MetroCheckBox Implements IMLBAMForm.chkGameAlt
        Get
            Return chkGameAlt
        End Get
        Set(value As MetroCheckBox)
            chkGameAlt = value
        End Set
    End Property

    Private Property IMLBAMForm_chkGameShift As MetroCheckBox Implements IMLBAMForm.chkGameShift
        Get
            Return chkGameShift
        End Get
        Set(value As MetroCheckBox)
            chkGameShift = value
        End Set
    End Property

    Private Property IMLBAMForm_chkAdCtrl As MetroCheckBox Implements IMLBAMForm.chkAdCtrl
        Get
            Return chkAdCtrl
        End Get
        Set(value As MetroCheckBox)
            chkAdCtrl = value
        End Set
    End Property

    Private Property IMLBAMForm_chkAdAlt As MetroCheckBox Implements IMLBAMForm.chkAdAlt
        Get
            Return chkAdAlt
        End Get
        Set(value As MetroCheckBox)
            chkAdAlt = value
        End Set
    End Property

    Private Property IMLBAMForm_chkAdShift As MetroCheckBox Implements IMLBAMForm.chkAdShift
        Get
            Return chkAdShift
        End Get
        Set(value As MetroCheckBox)
            chkAdShift = value
        End Set
    End Property

    Private Property IMLBAMForm_flpGames As FlowLayoutPanel Implements IMLBAMForm.flpGames
        Get
            Return flpGames
        End Get
        Set(value As FlowLayoutPanel)
            flpGames = value
        End Set
    End Property

    Private Property IMLBAMForm_rbMPV As MetroRadioButton Implements IMLBAMForm.rbMPV
        Get
            Return rbMPV
        End Get
        Set(value As MetroRadioButton)
            rbMPV = value
        End Set
    End Property

    Private Property IMLBAMForm_rbMPC As MetroRadioButton Implements IMLBAMForm.rbMPC
        Get
            Return rbMPC
        End Get
        Set(value As MetroRadioButton)
            rbMPC = value
        End Set
    End Property

    Private Property IMLBAMForm_rbVLC As MetroRadioButton Implements IMLBAMForm.rbVLC
        Get
            Return rbVLC
        End Get
        Set(value As MetroRadioButton)
            rbVLC = value
        End Set
    End Property

    Private Property IMLBAMForm_txtMediaControlDelay As MetroTextBox Implements IMLBAMForm.txtMediaControlDelay
        Get
            Return txtMediaControlDelay
        End Get
        Set(value As MetroTextBox)
            txtMediaControlDelay = value
        End Set
    End Property

    Private Property IMLBAMForm_txtGameKey As MetroTextBox Implements IMLBAMForm.txtGameKey
        Get
            Return txtGameKey
        End Get
        Set(value As MetroTextBox)
            txtGameKey = value
        End Set
    End Property

    Private Property IMLBAMForm_txtAdKey As MetroTextBox Implements IMLBAMForm.txtAdKey
        Get
            Return txtAdKey
        End Get
        Set(value As MetroTextBox)
            txtAdKey = value
        End Set
    End Property

    Private Property IMLBAMForm_txtPlayerArgs As TextBox Implements IMLBAMForm.txtPlayerArgs
        Get
            Return txtPlayerArgs
        End Get
        Set(value As TextBox)
            txtPlayerArgs = value
        End Set
    End Property

    Private Property IMLBAMForm_cbSeasons As MetroComboBoxNoMW Implements IMLBAMForm.cbSeasons
        Get
            Return cbSeasons
        End Get
        Set(value As MetroComboBoxNoMW)
            cbSeasons = value
        End Set
    End Property

    Private Property IMLBAMForm_cbServers As MetroComboBoxNoMW Implements IMLBAMForm.cbServers
        Get
            Return cbServers
        End Get
        Set(value As MetroComboBoxNoMW)
            cbServers = value
        End Set
    End Property

    Private Property IMLBAMForm_btnDate As Button Implements IMLBAMForm.btnDate
        Get
            Return btnDate
        End Get
        Set(value As Button)
            btnDate = value
        End Set
    End Property

    Private Property IMLBAMForm_btnTomorrow As Button Implements IMLBAMForm.btnTomorrow
        Get
            Return btnTomorrow
        End Get
        Set(value As Button)
            btnTomorrow = value
        End Set
    End Property

    Private Property IMLBAMForm_btnYesterday As Button Implements IMLBAMForm.btnYesterday
        Get
            Return btnYesterday
        End Get
        Set(value As Button)
            btnYesterday = value
        End Set
    End Property

    Private ReadOnly Property IMLBAMForm_InvokeRequired As Boolean Implements IMLBAMForm.InvokeRequired
        Get
            Return InvokeRequired
        End Get
    End Property

    Private Property IMLBAMForm_tgAlternateCdn As MetroToggle Implements IMLBAMForm.tgAlternateCdn
        Get
            Return tgAlternateCdn
        End Get
        Set(value As MetroToggle)
            tgAlternateCdn = value
        End Set
    End Property

    Private Property IMLBAMForm_tgPlayer As MetroToggle Implements IMLBAMForm.tgPlayer
        Get
            Return tgPlayer
        End Get
        Set(value As MetroToggle)
            tgPlayer = value
        End Set
    End Property

    Private Property IMLBAMForm_tgStreamer As MetroToggle Implements IMLBAMForm.tgStreamer
        Get
            Return tgStreamer
        End Get
        Set(value As MetroToggle)
            tgStreamer = value
        End Set
    End Property

    Private Property IMLBAMForm_tbLiveRewind As MetroTrackBarNoMW Implements IMLBAMForm.tbLiveRewind
        Get
            Return tbLiveRewind
        End Get
        Set(value As MetroTrackBarNoMW)
            tbLiveRewind = value
        End Set
    End Property

    Private Property IMLBAMForm_txtMpvPath As TextBox Implements IMLBAMForm.txtMpvPath
        Get
            Return txtMpvPath
        End Get
        Set(value As TextBox)
            txtMpvPath = value
        End Set
    End Property

    Private Property IMLBAMForm_txtMPCPath As TextBox Implements IMLBAMForm.txtMPCPath
        Get
            Return txtMPCPath
        End Get
        Set(value As TextBox)
            txtMPCPath = value
        End Set
    End Property

    Private Property IMLBAMForm_txtVLCPath As TextBox Implements IMLBAMForm.txtVLCPath
        Get
            Return txtVLCPath
        End Get
        Set(value As TextBox)
            txtVLCPath = value
        End Set
    End Property

    Private Property IMLBAMForm_txtStreamerPath As TextBox Implements IMLBAMForm.txtStreamerPath
        Get
            Return txtStreamerPath
        End Get
        Set(value As TextBox)
            txtStreamerPath = value
        End Set
    End Property

    Private Property IMLBAMForm_txtStreamerArgs As TextBox Implements IMLBAMForm.txtStreamerArgs
        Get
            Return txtStreamerArgs
        End Get
        Set(value As TextBox)
            txtStreamerArgs = value
        End Set
    End Property

    Private Property IMLBAMForm_txtOutputArgs As TextBox Implements IMLBAMForm.txtOutputArgs
        Get
            Return txtOutputArgs
        End Get
        Set(value As TextBox)
            txtOutputArgs = value
        End Set
    End Property

    Private Property IMLBAMForm_cbStreamQuality As MetroComboBoxNoMW Implements IMLBAMForm.cbStreamQuality
        Get
            Return cbStreamQuality
        End Get
        Set(value As MetroComboBoxNoMW)
            cbStreamQuality = value
        End Set
    End Property

    Private Property IMLBAMForm_cbLiveReplay As MetroComboBoxNoMW Implements IMLBAMForm.cbLiveReplay
        Get
            Return cbLiveReplay
        End Get
        Set(value As MetroComboBoxNoMW)
            cbLiveReplay = value
        End Set
    End Property

    Private Function GetSetting(name As String) Implements IMLBAMForm.GetSetting
        Return My.Settings(name)
    End Function

    Private Sub SetSetting(name As String, value As Object) Implements IMLBAMForm.SetSetting
        My.Settings(name) = value
        My.Settings.Save()
    End Sub
#End Region
End Class
