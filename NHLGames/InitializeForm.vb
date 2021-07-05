Imports System.Globalization
Imports System.IO
Imports MetroFramework
Imports MetroFramework.Controls
Imports MLBAMGames.Library
Imports MLBAMGames.Library.Utilities
Imports MLBAMGames.Library.Controls
Imports MLBAMGames.Library.Objects

Namespace Utilities
    Public Class InitializeForm
        Private Shared ReadOnly Form As NHLGamesMetro = Instance.Form
        Public Shared ReadOnly TotalTipCount As Integer = 10

        Public Shared Sub SetLanguage()
            Dim lstStreamQualities = New String() {
                                                      Lang.RmText.GetString("cbQualitySuperb60fps"),
                                                      Lang.RmText.GetString("cbQualitySuperb"),
                                                      Lang.RmText.GetString("cbQualityGreat"),
                                                      Lang.RmText.GetString("cbQualityGood"),
                                                      Lang.RmText.GetString("cbQualityNormal"),
                                                      Lang.RmText.GetString("cbQualityLow"),
                                                      Lang.RmText.GetString("cbQualityMobile")
                                                  }

            Dim lstLiveReplayPreferences = New String() {
                                                            Lang.RmText.GetString("cbLiveReplayPuckDrop"),
                                                            Lang.RmText.GetString("cbLiveReplayGameTime"),
                                                            Lang.RmText.GetString("cbLiveReplayFeedStart")
                                                        }

            'Main
            Form.tabMenu.TabPages.Item(0).Text = Lang.RmText.GetString("tabGames")
            Form.tabMenu.TabPages.Item(1).Text = Lang.RmText.GetString("tabStandings")
            Form.tabMenu.TabPages.Item(2).Text = Lang.RmText.GetString("tabSettings")
            Form.tabMenu.TabPages.Item(3).Text = Lang.RmText.GetString("tabConsole")
            Form.tt.SetToolTip(Form.btnHelp, Lang.RmText.GetString("tipHelp"))

            Form.lblNoGames.Text = Lang.RmText.GetString("lblNoGames")
            Form.lblStatus.Text = String.Format(Lang.RmText.GetString("msgGamesFound"),
                                                Instance.Form.flpGames.Controls.Count())

            'Games
            Form.tt.SetToolTip(Form.btnYesterday, Lang.RmText.GetString("tipDayLeft"))
            Form.tt.SetToolTip(Form.btnDate, Lang.RmText.GetString("tipCalendar"))
            Form.tt.SetToolTip(Form.btnTomorrow, Lang.RmText.GetString("tipDayRight"))
            Form.tt.SetToolTip(Form.btnRefresh, Lang.RmText.GetString("tipRefresh"))

            'Standings
            Form.lblSeason.Text = Lang.RmText.GetString("lblSeason")

            'Settings
            Dim minutesBehind = Form.tbLiveRewind.Value * 5
            Form.lblGamePanel.Text = Lang.RmText.GetString("lblShowScores")
            Form.lblPlayer.Text = Lang.RmText.GetString("lblPlayer")
            Form.lblQuality.Text = Lang.RmText.GetString("lblQuality")
            Form.lblCdn.Text = Lang.RmText.GetString("lblCdn")
            Form.lblDarkMode.Text = Lang.RmText.GetString("lblDark")
            Form.lblHostname.Text = Lang.RmText.GetString("lblHostname")
            Form.lblProxyPort.Text = Lang.RmText.GetString("lblProxyPort")
            Form.lblVlcPath.Text = Lang.RmText.GetString("lblVlcPath")
            Form.lblMpcPath.Text = Lang.RmText.GetString("lblMpcPath")
            Form.lblMpvPath.Text = Lang.RmText.GetString("lblMpvPath")
            Form.lblSlPath.Text = Lang.RmText.GetString("lblSlPath")
            Form.lblOutput.Text = Lang.RmText.GetString("lblOutput")
            Form.lblPlayerArgs.Text = Lang.RmText.GetString("lblPlayerArgs")
            Form.lblStreamerArgs.Text = Lang.RmText.GetString("lblStreamerArgs")
            Form.lblLanguage.Text = Lang.RmText.GetString("lblLanguage")
            Form.lblShowLiveTime.Text = Lang.RmText.GetString("lblShowLiveTime")
            Form.lblUseAlternateCdn.Text = Lang.RmText.GetString("lblAlternateCdn")
            Form.lblLiveReplay.Text = Lang.RmText.GetString("lblLiveReplay")
            Form.lblLiveRewind.Text = Lang.RmText.GetString("lblLiveRewind")
            Form.lblLiveRewindDetails.Text = String.Format(
                Lang.RmText.GetString("lblLiveRewindDetails"),
                minutesBehind, Now.AddMinutes(-minutesBehind).ToString("h:mm tt", CultureInfo.InvariantCulture))

            Form.lblGamePanel.Text = Lang.RmText.GetString("lblGamePanel")
            Form.lblShowFinalScores.Text = Lang.RmText.GetString("lblShowFinalScores")
            Form.lblShowLiveScores.Text = Lang.RmText.GetString("lblShowLiveScores")
            Form.lblShowSeriesRecord.Text = Lang.RmText.GetString("lblShowSeriesRecord")
            Form.lblShowTeamCityAbr.Text = Lang.RmText.GetString("lblShowTeamCityAbr")
            Form.lblShowTodayLiveGamesFirst.Text = Lang.RmText.GetString("lblShowTodayLiveGamesFirst")
            Form.lblShowStanding.Text = Lang.RmText.GetString("lblShowStanding")

            Form.cbStreamQuality.Items.Clear()
            Form.cbStreamQuality.Items.AddRange(lstStreamQualities)
            Form.cbStreamQuality.SelectedIndex = 0

            Form.cbLiveReplay.Items.Clear()
            Form.cbLiveReplay.Items.AddRange(lstLiveReplayPreferences)
            Form.cbLiveReplay.SelectedIndex = 0

            Form.tt.SetToolTip(Form.lnkGetVlc, Lang.RmText.GetString("tipGetVlc"))
            Form.tt.SetToolTip(Form.lnkGetMpc, Lang.RmText.GetString("tipGetMpc"))
            Form.tt.SetToolTip(Form.btnMPCPath, Lang.RmText.GetString("tipBrowse"))
            Form.tt.SetToolTip(Form.btnMpvPath, Lang.RmText.GetString("tipBrowse"))
            Form.tt.SetToolTip(Form.btnMPCPath, Lang.RmText.GetString("tipBrowse"))
            Form.tt.SetToolTip(Form.btnStreamerPath, Lang.RmText.GetString("tipBrowse"))
            Form.tt.SetToolTip(Form.btnOutput, Lang.RmText.GetString("tipBrowse"))
            Form.tt.SetToolTip(Form.tbProxyPort, Lang.RmText.GetString("tipTrackBarMove"))
            Form.tt.SetToolTip(Form.tbLiveRewind, Lang.RmText.GetString("tipTrackBarMove"))
            Form.tt.SetToolTip(Form.lblMediaControlDelay, Lang.RmText.GetString("tipMediaControlDelay"))

            Form.lblModules.Text = Lang.RmText.GetString("lblModules")
            Form.lblModulesDesc.Text = Lang.RmText.GetString("lblModulesDesc")
            Form.lblMedia.Text = Lang.RmText.GetString("lblMedia")
            Form.lblMediaDesc.Text = Lang.RmText.GetString("lblMediaDesc")
            Form.lblMediaControlDelay.Text = Lang.RmText.GetString("lblMediaControlDelay")
            Form.lblOBS.Text = Lang.RmText.GetString("lblObs")
            Form.lblOBSDesc.Text = Lang.RmText.GetString("lblObsDesc")
            Form.lblObsAdEndingHotkey.Text = Lang.RmText.GetString("lblObsAdEndingHotkey")
            Form.lblObsAdStartingHotkey.Text = Lang.RmText.GetString("lblObsAdStartingHotkey")
            Form.chkSpotifyForceToStart.Text = Lang.RmText.GetString("chkSpotifyForceToStart")
            Form.chkSpotifyPlayNextSong.Text = Lang.RmText.GetString("chkSpotifyPlayNextSong")
            Form.chkSpotifyHotkeys.Text = Lang.RmText.GetString("chkSpotifyHotkeys")

            Form.lblReset.Text = Lang.RmText.GetString("lblReset")
            Form.lblResetDesc.Text = Lang.RmText.GetString("lblResetDesc")

            'Console
            Form.btnCopyConsole.Text = MLBAMGames.Library.Lang.RmText.GetString("btnCopyConsole")
            Form.btnClearConsole.Text = MLBAMGames.Library.Lang.RmText.GetString("btnClearConsole")

            'Calendar
            Form.flpCalendarPanel.Controls.Clear()
            Form.flpCalendarPanel.Controls.Add(New MLBAMGames.Library.Controls.CalendarControl())

            'Tips
            MLBAMGames.Library.Parameters.Tips.Clear()
            For index As Integer = 1 To TotalTipCount
                MLBAMGames.Library.Parameters.Tips.Add(index, MLBAMGames.Library.Lang.RmText.GetString($"tipMessage{index}"))
            Next
            Form.lblTip.Text = MLBAMGames.Library.Parameters.Tips.First().Value

            SetThemeAndSvgOnForm()
        End Sub

        Public Shared Sub SetWindow()
            Dim windowSize = Split(If(My.Settings.LastWindowSize, "990;655"), ";")
            Form.Width = If(windowSize.Length = 2, Convert.ToInt32(windowSize(0)), 990)
            Form.Height = If(windowSize.Length = 2, Convert.ToInt32(windowSize(1)), 655)
        End Sub

        Public Shared Sub SetSettings()
            Dim lstLanguages = New String() {
                                                Lang.RmText.GetString("cbEnglish"),
                                                Lang.RmText.GetString("cbFrench")
                                            }
            Dim livestreamerPath = GetApplication(SettingsEnum.StreamerPath,
                                                       Path.Combine(Application.StartupPath,
                                                                    "livestreamer\livestreamer.exe"))
            Dim streamlinkPath = GetApplication(SettingsEnum.StreamerPath,
                                                       Path.Combine(Application.StartupPath,
                                                                    "streamlink\streamlink.exe"))

            Form.cbLanguage.Items.Clear()
            Form.cbLanguage.Items.AddRange(lstLanguages)
            Form.cbLanguage.SelectedItem = If(My.Settings.SelectedLanguage, "English")

            Form.lblVersion.Text = String.Format("v {0}.{1}.{2}",
                                                 My.Application.Info.Version.Major,
                                                 My.Application.Info.Version.Minor,
                                                 My.Application.Info.Version.Build)

            Form.txtMPCPath.Text = GetApplication(SettingsEnum.MpcPath, PathFinder.GetPathOfMpc())
            Form.txtVLCPath.Text = GetApplication(SettingsEnum.VlcPath, PathFinder.GetPathOfVlc())
            Form.txtMpvPath.Text = GetApplication(SettingsEnum.MpvPath,
                                                  Path.Combine(Application.StartupPath, $"mpv\{If(Environment.Is64BitOperatingSystem, "64bit", "32bit")}\mpv.exe"))

            Form.txtStreamerPath.Text = If(livestreamerPath.Equals(String.Empty), streamlinkPath, livestreamerPath)

            Dim proxyPort = If(My.Settings.ProxyPort = 0, My.Settings.ProxyPort, 17070)
            Form.tbProxyPort.Value = proxyPort / 10
            Form.lblProxyPortNumber.Text = proxyPort.ToString()

            Form.tgDarkMode.Checked = Parameters.IsDarkMode

            Form.tgShowFinalScores.Checked = My.Settings.ShowScores
            Form.tgShowLiveScores.Checked = My.Settings.ShowLiveScores
            Form.tgShowSeriesRecord.Checked = My.Settings.ShowSeriesRecord
            Form.tgShowTeamCityAbr.Checked = My.Settings.ShowTeamCityAbr
            Form.tgShowLiveTime.Checked = My.Settings.ShowLiveTime
            Form.tgShowStanding.Checked = My.Settings.ShowStanding
            Form.tgShowTodayLiveGamesFirst.Checked = My.Settings.ShowTodayLiveGamesFirst

            Dim playersPath = New String() {Form.txtMpvPath.Text, Form.txtMPCPath.Text, Form.txtVLCPath.Text}
            Dim watchArgs = SettingsExtensions.ReadGameWatchArgs()

            If ValidWatchArgs(watchArgs, playersPath, Form.txtStreamerPath.Text) Then
                watchArgs = Player.RenewArgs(True)
            End If

            PopulateComboBox(Form.cbServers, SettingsEnum.SelectedServer, SettingsEnum.ServerList, String.Empty)
            Web.SetRedirectionServerInApp()

            Parameters.WatchArgs = BindWatchArgsToForm(watchArgs)

            Dim adDetectionConfigs = SettingsExtensions.ReadAdDetectionConfigs()

            If adDetectionConfigs Is Nothing Then
                adDetectionConfigs = AdDetection.Renew(True)
            End If

            Form.SetStreamerDefaultArgs()
            Form.SetPlayerDefaultArgs()

            BindAdDetectionConfigsToForm(adDetectionConfigs)

            Form.lblNoGames.Location = New Point(((Form.tabGames.Width - Form.lblNoGames.Width) / 2),
                                                 Form.tabGames.Height / 2)
            Form.spnLoading.Location = New Point(((Form.tabGames.Width - Form.lblNoGames.Width) / 2) + 40,
                                                 (Form.tabGames.Height / 2) - 20)

            Form.spnLoading.Value = Parameters.SpnLoadingValue
            Form.spnLoading.Maximum = Parameters.SpnLoadingMaxValue
            Form.spnStreaming.Value = Parameters.SpnStreamingValue
            Form.spnStreaming.Maximum = Parameters.SpnStreamingMaxValue
            Form.lblDate.Text = DateHelper.GetFormattedDate(CalendarControl.GameDate)

            CalendarControl.LabelDate = Form.lblDate
        End Sub

        Private Shared Function GetApplication(varSetting As SettingsEnum, currentPath As String)
            Dim savedPathFromConfig = My.Settings(varSetting.ToString())
            Dim currentPathIfFound As String = currentPath

            If File.Exists(savedPathFromConfig) Then Return savedPathFromConfig

            If File.Exists(currentPathIfFound) Then
                My.Settings(varSetting.ToString()) = currentPathIfFound
                Return currentPathIfFound
            Else
                My.Settings(varSetting.ToString()) = String.Empty
                Return String.Empty
            End If
        End Function

        Private Shared Sub PopulateComboBox(cb As MetroComboBox, varSelectedServer As SettingsEnum, varServersList As SettingsEnum, defaultValue As String)
            Dim cbItemsFromConfig = If(My.Settings(varServersList.ToString()), defaultValue)

            cb.Items.AddRange(cbItemsFromConfig.Split(";"))

            cb.SelectedItem = If(My.Settings(varSelectedServer.ToString()), String.Empty)
            If cb.SelectedItem Is Nothing Then
                cb.SelectedItem = cb.Items(0)
            End If
        End Sub

        Public Shared Function GetSelectedPlayerType(watchArgs As GameWatchArguments) As PlayerTypeEnum
            If watchArgs.PlayerType.Equals(PlayerTypeEnum.Mpv) AndAlso Not String.IsNullOrEmpty(Form.txtMpvPath.Text) Then Return PlayerTypeEnum.Mpv
            If watchArgs.PlayerType.Equals(PlayerTypeEnum.Vlc) AndAlso Not String.IsNullOrEmpty(Form.txtVLCPath.Text) Then Return PlayerTypeEnum.Vlc
            If watchArgs.PlayerType.Equals(PlayerTypeEnum.Mpc) AndAlso Not String.IsNullOrEmpty(Form.txtMPCPath.Text) Then Return PlayerTypeEnum.Mpc
            Return watchArgs.PlayerType = PlayerTypeEnum.None
        End Function

        Public Shared Sub ResetSelectedPlayer(watchArgs As GameWatchArguments)
            If Not String.IsNullOrEmpty(Form.txtMpvPath.Text) Then
                watchArgs.PlayerType = PlayerTypeEnum.Mpv
            ElseIf Not String.IsNullOrEmpty(Form.txtVLCPath.Text) Then
                watchArgs.PlayerType = PlayerTypeEnum.Vlc
            ElseIf Not String.IsNullOrEmpty(Form.txtMPCPath.Text) Then
                watchArgs.PlayerType = PlayerTypeEnum.Mpc
            Else
                watchArgs.PlayerType = PlayerTypeEnum.None
            End If

            My.Settings.DefaultWatchArgs = Serialization.SerializeObject(watchArgs)
            My.Settings.Save()
        End Sub

        Private Shared Function ValidWatchArgs(watchArgs As GameWatchArguments, playersPath As String(),
                                               streamerPath As String) As Boolean
            If watchArgs Is Nothing Then Return True

            Dim selectedPlayerType = GetSelectedPlayerType(watchArgs)
            If Not selectedPlayerType.Equals(watchArgs.PlayerType) OrElse selectedPlayerType.Equals(PlayerTypeEnum.None) Then
                ResetSelectedPlayer(watchArgs)
            End If

            Dim hasPlayerSet As Boolean = playersPath.Any(Function(x) x = watchArgs.PlayerPath)
            If Not watchArgs.StreamerPath.Equals(streamerPath) Then Return True
            If Not hasPlayerSet Then
                watchArgs.PlayerType = PlayerTypeEnum.None
                watchArgs.StreamerType = StreamerTypeEnum.None
                watchArgs.PlayerPath = String.Empty
                watchArgs.StreamerPath = String.Empty
                Form.rbMPC.Enabled = False
                Form.rbVLC.Enabled = False
                Form.rbMPV.Enabled = False
                Return True
            End If

            Return False
        End Function

        Private Shared Function BindWatchArgsToForm(watchArgs As GameWatchArguments) As GameWatchArguments
            If watchArgs IsNot Nothing Then
                Form.cbStreamQuality.SelectedIndex = CType(watchArgs.Quality, Integer)

                Form.tgAlternateCdn.Checked = watchArgs.Cdn = CdnTypeEnum.L3C

                Form.tbLiveRewind.Value = If(watchArgs.StreamLiveRewind Mod 5 = 0, watchArgs.StreamLiveRewind / 5, 1)

                Dim selectedPlayerType = GetSelectedPlayerType(watchArgs)
                If Not selectedPlayerType.Equals(watchArgs.PlayerType) OrElse selectedPlayerType.Equals(PlayerTypeEnum.None) Then
                    ResetSelectedPlayer(watchArgs)
                End If

                Form.rbMPV.Checked = watchArgs.PlayerType = PlayerTypeEnum.Mpv AndAlso Form.rbMPV.Enabled
                Form.rbVLC.Checked = watchArgs.PlayerType = PlayerTypeEnum.Vlc AndAlso Form.rbVLC.Enabled
                Form.rbMPC.Checked = watchArgs.PlayerType = PlayerTypeEnum.Mpc AndAlso Form.rbMPC.Enabled

                Dim isVLCPathOutdated = Form.rbVLC.Checked AndAlso watchArgs.PlayerPath <> Form.txtVLCPath.Text
                Dim isMPCPathOutdated = Form.rbMPC.Checked AndAlso watchArgs.PlayerPath <> Form.txtMPCPath.Text
                Dim isMPVPathOutdated = Form.rbMPV.Checked AndAlso watchArgs.PlayerPath <> Form.txtMpvPath.Text

                If isVLCPathOutdated OrElse isMPCPathOutdated OrElse isMPVPathOutdated Then
                    watchArgs = Player.RenewArgs(True)
                End If

                Form.tgPlayer.Checked = watchArgs.UseCustomPlayerArgs
                Form.txtPlayerArgs.Enabled = watchArgs.UseCustomPlayerArgs
                Form.txtPlayerArgs.Text = watchArgs.CustomPlayerArgs

                Form.tgStreamer.Checked = watchArgs.UseCustomStreamerArgs
                Form.txtStreamerArgs.Enabled = watchArgs.UseCustomStreamerArgs
                Form.txtStreamerArgs.Text = watchArgs.CustomStreamerArgs

                Form.txtOutputArgs.Text = watchArgs.PlayerOutputPath
                Form.txtOutputArgs.Enabled = watchArgs.UseOutputArgs
                Form.tgOutput.Checked = watchArgs.UseOutputArgs
            End If

            Return watchArgs
        End Function

        Private Shared Sub BindAdDetectionConfigsToForm(configs As AdDetectionConfigs)
            If configs IsNot Nothing Then

                Form.tgModules.Checked = configs.IsEnabled

                Form.chkSpotifyForceToStart.Checked = configs.EnabledSpotifyForceToOpen
                Form.chkSpotifyPlayNextSong.Checked = configs.EnabledSpotifyPlayNextSong
                Form.chkSpotifyHotkeys.Checked = configs.EnabledSpotifyHotkeys
                Form.txtMediaControlDelay.Text = configs.MediaControlDelay

                Form.txtAdKey.Text = configs.EnabledObsAdSceneHotKey.Key
                Form.chkAdCtrl.Checked = configs.EnabledObsAdSceneHotKey.Ctrl
                Form.chkAdAlt.Checked = configs.EnabledObsAdSceneHotKey.Alt
                Form.chkAdShift.Checked = configs.EnabledObsAdSceneHotKey.Shift

                Form.txtGameKey.Text = configs.EnabledObsGameSceneHotKey.Key
                Form.chkGameCtrl.Checked = configs.EnabledObsGameSceneHotKey.Ctrl
                Form.chkGameAlt.Checked = configs.EnabledObsGameSceneHotKey.Alt
                Form.chkGameShift.Checked = configs.EnabledObsGameSceneHotKey.Shift

                Form.tgMedia.Checked = configs.EnabledSpotifyModule
                Form.tgOBS.Checked = configs.EnabledObsModule

            End If
        End Sub

        Private Shared Sub SetThemeAndSvgOnForm()
            Dim themeChar = "l"
            Dim colorMetroThemeDark = Color.FromArgb(17, 17, 17)
            If MLBAMGames.Library.Parameters.IsDarkMode Then
                themeChar = "d"
                Form.Theme = MetroThemeStyle.Dark
                Form.lblNoGames.BackColor = Color.FromArgb(60, 60, 60)
                Form.lblNoGames.ForeColor = Color.DarkGray
                Form.flpCalendarPanel.BackColor = Color.FromArgb(60, 60, 60)
                Form.tabMenu.Theme = MetroThemeStyle.Dark
                Form.tabGames.Theme = MetroThemeStyle.Dark
                Form.tabSettings.Theme = MetroThemeStyle.Dark
                Form.tabConsole.Theme = MetroThemeStyle.Dark
                Form.btnHelp.Theme = MetroThemeStyle.Dark
                Form.pnlBottom.BackColor = Color.FromArgb(80, 80, 80)
                Form.pnlGameBar.BackColor = Color.FromArgb(80, 80, 80)
                Form.flpGames.BackColor = colorMetroThemeDark
                Form.tlpSettings.BackColor = colorMetroThemeDark
                Form.spnLoading.Theme = MetroThemeStyle.Dark
                Form.spnStreaming.Theme = MetroThemeStyle.Dark
                Form.lblDate.ForeColor = Color.DarkGray
                Form.lblDate.BackColor = Color.FromArgb(80, 80, 80)
                Form.lblVersion.ForeColor = Color.LightGray
                Form.lblStatus.ForeColor = Color.LightGray
                Form.lblTip.ForeColor = Color.LightGray
                Form.lblGamePanel.Theme = MetroThemeStyle.Dark
                Form.tgShowTodayLiveGamesFirst.Theme = MetroThemeStyle.Dark
                Form.tgShowLiveTime.Theme = MetroThemeStyle.Dark
                Form.tgShowLiveScores.Theme = MetroThemeStyle.Dark
                Form.tgShowSeriesRecord.Theme = MetroThemeStyle.Dark
                Form.tgShowTeamCityAbr.Theme = MetroThemeStyle.Dark
                Form.tgShowFinalScores.Theme = MetroThemeStyle.Dark
                Form.tgShowStanding.Theme = MetroThemeStyle.Dark
                Form.lblShowTodayLiveGamesFirst.Theme = MetroThemeStyle.Dark
                Form.lblShowLiveTime.Theme = MetroThemeStyle.Dark
                Form.lblShowLiveScores.Theme = MetroThemeStyle.Dark
                Form.lblShowSeriesRecord.Theme = MetroThemeStyle.Dark
                Form.lblShowTeamCityAbr.Theme = MetroThemeStyle.Dark
                Form.lblShowFinalScores.Theme = MetroThemeStyle.Dark
                Form.lblShowStanding.Theme = MetroThemeStyle.Dark
                Form.lblQuality.Theme = MetroThemeStyle.Dark
                Form.cbStreamQuality.Theme = MetroThemeStyle.Dark
                Form.lblLiveReplay.Theme = MetroThemeStyle.Dark
                Form.cbLiveReplay.Theme = MetroThemeStyle.Dark
                Form.lblLiveRewind.Theme = MetroThemeStyle.Dark
                Form.tbLiveRewind.Theme = MetroThemeStyle.Dark
                Form.lblLiveRewindDetails.Theme = MetroThemeStyle.Dark
                Form.lblCdn.Theme = MetroThemeStyle.Dark
                Form.tgAlternateCdn.Theme = MetroThemeStyle.Dark
                Form.lblUseAlternateCdn.Theme = MetroThemeStyle.Dark
                Form.lblHostname.Theme = MetroThemeStyle.Dark
                Form.cbServers.Theme = MetroThemeStyle.Dark
                Form.lblProxyPort.Theme = MetroThemeStyle.Dark
                Form.lblProxyPortNumber.Theme = MetroThemeStyle.Dark
                Form.tbProxyPort.Theme = MetroThemeStyle.Dark
                Form.lblPlayer.Theme = MetroThemeStyle.Dark
                Form.rbVLC.Theme = MetroThemeStyle.Dark
                Form.rbMPC.Theme = MetroThemeStyle.Dark
                Form.rbMPV.Theme = MetroThemeStyle.Dark
                Form.lnkGetVlc.Theme = MetroThemeStyle.Dark
                Form.lblVlcPath.Theme = MetroThemeStyle.Dark
                Form.txtVLCPath.BackColor = Color.FromArgb(80, 80, 80)
                Form.txtVLCPath.ForeColor = Color.LightGray
                Form.btnVLCPath.Theme = MetroThemeStyle.Dark
                Form.lnkGetMpc.Theme = MetroThemeStyle.Dark
                Form.lblMpcPath.Theme = MetroThemeStyle.Dark
                Form.txtMPCPath.BackColor = Color.FromArgb(80, 80, 80)
                Form.txtMPCPath.ForeColor = Color.LightGray
                Form.btnMPCPath.Theme = MetroThemeStyle.Dark
                Form.lblMpvPath.Theme = MetroThemeStyle.Dark
                Form.txtMpvPath.BackColor = Color.FromArgb(80, 80, 80)
                Form.txtMpvPath.ForeColor = Color.LightGray
                Form.btnMpvPath.Theme = MetroThemeStyle.Dark
                Form.lblSlPath.Theme = MetroThemeStyle.Dark
                Form.txtStreamerPath.BackColor = Color.FromArgb(80, 80, 80)
                Form.txtStreamerPath.ForeColor = Color.LightGray
                Form.btnStreamerPath.Theme = MetroThemeStyle.Dark
                Form.lblDarkMode.Theme = MetroThemeStyle.Dark
                Form.tgDarkMode.Theme = MetroThemeStyle.Dark
                Form.lblLanguage.Theme = MetroThemeStyle.Dark
                Form.cbLanguage.Theme = MetroThemeStyle.Dark
                Form.lblOutput.Theme = MetroThemeStyle.Dark
                Form.tgOutput.Theme = MetroThemeStyle.Dark
                Form.btnOutput.Theme = MetroThemeStyle.Dark
                Form.txtOutputArgs.BackColor = Color.FromArgb(80, 80, 80)
                Form.txtOutputArgs.ForeColor = Color.LightGray
                Form.lblPlayerArgs.Theme = MetroThemeStyle.Dark
                Form.tgPlayer.Theme = MetroThemeStyle.Dark
                Form.txtPlayerArgs.BackColor = Color.FromArgb(80, 80, 80)
                Form.txtPlayerArgs.ForeColor = Color.LightGray
                Form.lblStreamerArgs.Theme = MetroThemeStyle.Dark
                Form.tgStreamer.Theme = MetroThemeStyle.Dark
                Form.txtStreamerArgs.BackColor = Color.FromArgb(80, 80, 80)
                Form.txtStreamerArgs.ForeColor = Color.LightGray
                Form.lblModules.Theme = MetroThemeStyle.Dark
                Form.tgModules.Theme = MetroThemeStyle.Dark
                Form.lblModulesDesc.Theme = MetroThemeStyle.Dark
                Form.lblMedia.Theme = MetroThemeStyle.Dark
                Form.tgMedia.Theme = MetroThemeStyle.Dark
                Form.lblMediaDesc.Theme = MetroThemeStyle.Dark
                Form.lblMediaControlDelay.Theme = MetroThemeStyle.Dark
                Form.txtMediaControlDelay.BackColor = Color.FromArgb(80, 80, 80)
                Form.txtMediaControlDelay.ForeColor = Color.LightGray
                Form.lblMediaControlDelayMs.Theme = MetroThemeStyle.Dark
                Form.chkSpotifyForceToStart.Theme = MetroThemeStyle.Dark
                Form.chkSpotifyPlayNextSong.Theme = MetroThemeStyle.Dark
                Form.chkSpotifyHotkeys.Theme = MetroThemeStyle.Dark
                Form.lblOBS.Theme = MetroThemeStyle.Dark
                Form.tgOBS.Theme = MetroThemeStyle.Dark
                Form.lblOBSDesc.Theme = MetroThemeStyle.Dark
                Form.lblObsAdStartingHotkey.Theme = MetroThemeStyle.Dark
                Form.lblObsAdEndingHotkey.Theme = MetroThemeStyle.Dark
                Form.txtAdKey.Theme = MetroThemeStyle.Dark
                Form.txtGameKey.Theme = MetroThemeStyle.Dark
                Form.lblReset.Theme = MetroThemeStyle.Dark
                Form.tgReset.Theme = MetroThemeStyle.Dark
                Form.lblResetDesc.Theme = MetroThemeStyle.Dark
                Form.lblPlus1.Theme = MetroThemeStyle.Dark
                Form.lblPlus2.Theme = MetroThemeStyle.Dark
                Form.lblPlus3.Theme = MetroThemeStyle.Dark
                Form.lblPlus4.Theme = MetroThemeStyle.Dark
                Form.lblPlus5.Theme = MetroThemeStyle.Dark
                Form.lblPlus6.Theme = MetroThemeStyle.Dark
                Form.chkAdAlt.Theme = MetroThemeStyle.Dark
                Form.chkAdCtrl.Theme = MetroThemeStyle.Dark
                Form.chkAdShift.Theme = MetroThemeStyle.Dark
                Form.chkGameAlt.Theme = MetroThemeStyle.Dark
                Form.chkGameCtrl.Theme = MetroThemeStyle.Dark
                Form.chkGameShift.Theme = MetroThemeStyle.Dark
                Form.btnClearConsole.Theme = MetroThemeStyle.Dark
                Form.btnCopyConsole.Theme = MetroThemeStyle.Dark
                Form.btnYesterday.BackColor = Color.DarkGray
                Form.btnYesterday.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80)
                Form.btnDate.BackColor = Color.DarkGray
                Form.btnDate.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80)
                Form.btnTomorrow.BackColor = Color.DarkGray
                Form.btnTomorrow.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80)
                Form.btnRefresh.BackColor = Color.DarkGray
                Form.btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80)
                Form.tabStandings.Theme = MetroThemeStyle.Dark
                Form.tlpStandings.BackColor = colorMetroThemeDark
                Form.lblSeason.Theme = MetroThemeStyle.Dark
                Form.cbSeasons.Theme = MetroThemeStyle.Dark
                Form.tbStanding.Theme = MetroThemeStyle.Dark
            End If
            Form.pnlLogo.BackgroundImage = ImageFetcher.GetEmbeddedImage("nhlgames")
            Form.lblVLCLogo.Image = ImageFetcher.GetEmbeddedImage("vlc")
            Form.lblMPVLogo.Image = ImageFetcher.GetEmbeddedImage("mpv")
            Form.lvlMPCHCLogo.Image = ImageFetcher.GetEmbeddedImage("mpc")
            Form.btnRefresh.BackgroundImage = ImageFetcher.GetEmbeddedImage($"refresh_{themeChar}")
            Form.btnTomorrow.BackgroundImage = ImageFetcher.GetEmbeddedImage($"right_{themeChar}")
            Form.btnYesterday.BackgroundImage = ImageFetcher.GetEmbeddedImage($"left_{themeChar}")
            Form.btnDate.BackgroundImage = ImageFetcher.GetEmbeddedImage($"date_{themeChar}")
            Form.lnkGetVlc.Image = ImageFetcher.GetEmbeddedImage($"download")
            Form.lnkGetMpc.Image = ImageFetcher.GetEmbeddedImage($"download")
        End Sub
    End Class
End Namespace
