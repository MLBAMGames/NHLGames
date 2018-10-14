Imports System.Globalization
Imports System.IO
Imports MetroFramework
Imports MetroFramework.Controls
Imports NHLGames.Controls
Imports NHLGames.Objects

Namespace Utilities
    Public Class InitializeForm
        Private Shared ReadOnly Form As NHLGamesMetro = NHLGamesMetro.FormInstance
        Public Shared ReadOnly TotalTipCount As Integer = 10

        Public Shared Sub SetLanguage()
            Dim lstStreamQualities = New String() {
                                                      NHLGamesMetro.RmText.GetString("cbQualitySuperb60fps"),
                                                      NHLGamesMetro.RmText.GetString("cbQualitySuperb"),
                                                      NHLGamesMetro.RmText.GetString("cbQualityGreat"),
                                                      NHLGamesMetro.RmText.GetString("cbQualityGood"),
                                                      NHLGamesMetro.RmText.GetString("cbQualityNormal"),
                                                      NHLGamesMetro.RmText.GetString("cbQualityLow"),
                                                      NHLGamesMetro.RmText.GetString("cbQualityMobile")
                                                  }

            Dim lstLiveReplayPreferences = New String() {
                                                            NHLGamesMetro.RmText.GetString("cbLiveReplayPuckDrop"),
                                                            NHLGamesMetro.RmText.GetString("cbLiveReplayGameTime"),
                                                            NHLGamesMetro.RmText.GetString("cbLiveReplayFeedStart")
                                                        }

            'Main
            Form.tabMenu.TabPages.Item(0).Text = NHLGamesMetro.RmText.GetString("tabGames")
            Form.tabMenu.TabPages.Item(1).Text = NHLGamesMetro.RmText.GetString("tabSettings")
            Form.tabMenu.TabPages.Item(2).Text = NHLGamesMetro.RmText.GetString("tabConsole")
            Form.tt.SetToolTip(Form.btnHelp, NHLGamesMetro.RmText.GetString("tipHelp"))

            Form.lblNoGames.Text = NHLGamesMetro.RmText.GetString("lblNoGames")
            Form.lblStatus.Text = String.Format(NHLGamesMetro.RmText.GetString("msgGamesFound"),
                                                NHLGamesMetro.FormInstance.flpGames.Controls.Count())

            'Games
            Form.tt.SetToolTip(Form.btnYesterday, NHLGamesMetro.RmText.GetString("tipDayLeft"))
            Form.tt.SetToolTip(Form.btnDate, NHLGamesMetro.RmText.GetString("tipCalendar"))
            Form.tt.SetToolTip(Form.btnTomorrow, NHLGamesMetro.RmText.GetString("tipDayRight"))
            Form.tt.SetToolTip(Form.btnRefresh, NHLGamesMetro.RmText.GetString("tipRefresh"))

            'Settings
            Dim minutesBehind = Form.tbLiveRewind.Value * 5
            Form.lblGamePanel.Text = NHLGamesMetro.RmText.GetString("lblShowScores")
            Form.lblPlayer.Text = NHLGamesMetro.RmText.GetString("lblPlayer")
            Form.lblQuality.Text = NHLGamesMetro.RmText.GetString("lblQuality")
            Form.lblCdn.Text = NHLGamesMetro.RmText.GetString("lblCdn")
            Form.lblDarkMode.Text = NHLGamesMetro.RmText.GetString("lblDark")
            Form.lblHostname.Text = NHLGamesMetro.RmText.GetString("lblHostname")
            Form.lblProxyPort.Text = NHLGamesMetro.RmText.GetString("lblProxyPort")
            Form.lblVlcPath.Text = NHLGamesMetro.RmText.GetString("lblVlcPath")
            Form.lblMpcPath.Text = NHLGamesMetro.RmText.GetString("lblMpcPath")
            Form.lblMpvPath.Text = NHLGamesMetro.RmText.GetString("lblMpvPath")
            Form.lblSlPath.Text = NHLGamesMetro.RmText.GetString("lblSlPath")
            Form.lblOutput.Text = NHLGamesMetro.RmText.GetString("lblOutput")
            Form.lblPlayerArgs.Text = NHLGamesMetro.RmText.GetString("lblPlayerArgs")
            Form.lblStreamerArgs.Text = NHLGamesMetro.RmText.GetString("lblStreamerArgs")
            Form.lblLanguage.Text = NHLGamesMetro.RmText.GetString("lblLanguage")
            Form.lblShowLiveTime.Text = NHLGamesMetro.RmText.GetString("lblShowLiveTime")
            Form.lblUseAlternateCdn.Text = NHLGamesMetro.RmText.GetString("lblAlternateCdn")
            Form.lblLiveReplay.Text = NHLGamesMetro.RmText.GetString("lblLiveReplay")
            Form.lblLiveRewind.Text = NHLGamesMetro.RmText.GetString("lblLiveRewind")
            Form.lblLiveRewindDetails.Text = String.Format(
                NHLGamesMetro.RmText.GetString("lblLiveRewindDetails"),
                minutesBehind, Now.AddMinutes(-minutesBehind).ToString("h:mm tt", CultureInfo.InvariantCulture))

            Form.lblGamePanel.Text = NHLGamesMetro.RmText.GetString("lblGamePanel")
            Form.lblShowFinalScores.Text = NHLGamesMetro.RmText.GetString("lblShowFinalScores")
            Form.lblShowLiveScores.Text = NHLGamesMetro.RmText.GetString("lblShowLiveScores")
            Form.lblShowSeriesRecord.Text = NHLGamesMetro.RmText.GetString("lblShowSeriesRecord")
            Form.lblShowTeamCityAbr.Text = NHLGamesMetro.RmText.GetString("lblShowTeamCityAbr")
            Form.lblShowTodayLiveGamesFirst.Text = NHLGamesMetro.RmText.GetString("lblShowTodayLiveGamesFirst")

            Form.cbStreamQuality.Items.Clear()
            Form.cbStreamQuality.Items.AddRange(lstStreamQualities)
            Form.cbStreamQuality.SelectedIndex = 0

            Form.cbLiveReplay.Items.Clear()
            Form.cbLiveReplay.Items.AddRange(lstLiveReplayPreferences)
            Form.cbLiveReplay.SelectedIndex = 0

            Form.tt.SetToolTip(Form.lnkGetVlc, NHLGamesMetro.RmText.GetString("tipGetVlc"))
            Form.tt.SetToolTip(Form.lnkGetMpc, NHLGamesMetro.RmText.GetString("tipGetMpc"))
            Form.tt.SetToolTip(Form.btnMPCPath, NHLGamesMetro.RmText.GetString("tipBrowse"))
            Form.tt.SetToolTip(Form.btnMpvPath, NHLGamesMetro.RmText.GetString("tipBrowse"))
            Form.tt.SetToolTip(Form.btnMPCPath, NHLGamesMetro.RmText.GetString("tipBrowse"))
            Form.tt.SetToolTip(Form.btnStreamerPath, NHLGamesMetro.RmText.GetString("tipBrowse"))
            Form.tt.SetToolTip(Form.btnOutput, NHLGamesMetro.RmText.GetString("tipBrowse"))
            Form.tt.SetToolTip(Form.tbProxyPort, NHLGamesMetro.RmText.GetString("tipTrackBarMove"))
            Form.tt.SetToolTip(Form.tbLiveRewind, NHLGamesMetro.RmText.GetString("tipTrackBarMove"))

            Form.lblModules.Text = NHLGamesMetro.RmText.GetString("lblModules")
            Form.lblModulesDesc.Text = NHLGamesMetro.RmText.GetString("lblModulesDesc")
            Form.lblSpotify.Text = NHLGamesMetro.RmText.GetString("lblSpotify")
            Form.lblSpotifyDesc.Text = NHLGamesMetro.RmText.GetString("lblSpotifyDesc")
            Form.lblOBS.Text = NHLGamesMetro.RmText.GetString("lblObs")
            Form.lblOBSDesc.Text = NHLGamesMetro.RmText.GetString("lblObsDesc")
            Form.lblObsAdEndingHotkey.Text = NHLGamesMetro.RmText.GetString("lblObsAdEndingHotkey")
            Form.lblObsAdStartingHotkey.Text = NHLGamesMetro.RmText.GetString("lblObsAdStartingHotkey")
            Form.chkSpotifyForceToStart.Text = NHLGamesMetro.RmText.GetString("chkSpotifyForceToStart")
            Form.chkSpotifyPlayNextSong.Text = NHLGamesMetro.RmText.GetString("chkSpotifyPlayNextSong")
            Form.chkSpotifyAnyMediaPlayer.Text = NHLGamesMetro.RmText.GetString("chkSpotifyAnyMediaPlayer")

            'Console
            Form.btnCopyConsole.Text = NHLGamesMetro.RmText.GetString("btnCopyConsole")
            Form.btnClearConsole.Text = NHLGamesMetro.RmText.GetString("btnClearConsole")

            'Calendar
            Form.flpCalendarPanel.Controls.Clear()
            Form.flpCalendarPanel.Controls.Add(New CalendarControl())

            'Tips
            NHLGamesMetro.Tips.Clear()
            For index As Integer = 1 To TotalTipCount
                NHLGamesMetro.Tips.Add(index, NHLGamesMetro.RmText.GetString($"tipMessage{index}"))
            Next
            Form.lblTip.Text = NHLGamesMetro.Tips.First().Value

            SetThemeAndSvgOnForm()
        End Sub

        Public Shared Sub SetWindow()
            Dim windowSize = Split(ApplicationSettings.Read(Of String)(SettingsEnum.LastWindowSize, "990;655"), ";")
            Form.Width = If(windowSize.Length = 2, Convert.ToInt32(windowSize(0)), 990)
            Form.Height = If(windowSize.Length = 2, Convert.ToInt32(windowSize(1)), 655)
        End Sub

        Public Shared Sub SetSettings()
            Dim lstLanguages = New String() {
                                                NHLGamesMetro.RmText.GetString("cbEnglish"),
                                                NHLGamesMetro.RmText.GetString("cbFrench")
                                            }
            Dim livestreamerPath = GetApplication(SettingsEnum.StreamerPath,
                                                       Path.Combine(Application.StartupPath,
                                                                    "livestreamer\livestreamer.exe"))
            Dim streamlinkPath = GetApplication(SettingsEnum.StreamerPath,
                                                       Path.Combine(Application.StartupPath,
                                                                    "streamlink\streamlink.exe"))

            Form.cbLanguage.Items.Clear()
            Form.cbLanguage.Items.AddRange(lstLanguages)
            Form.cbLanguage.SelectedItem = ApplicationSettings.Read(Of String)(SettingsEnum.SelectedLanguage, "English")

            Form.lblVersion.Text = String.Format("v {0}.{1}.{2}",
                                                 My.Application.Info.Version.Major,
                                                 My.Application.Info.Version.Minor,
                                                 My.Application.Info.Version.Build)

            Form.txtMPCPath.Text = GetApplication(SettingsEnum.MpcPath, PathFinder.GetPathOfMpc())
            Form.txtVLCPath.Text = GetApplication(SettingsEnum.VlcPath, PathFinder.GetPathOfVlc())
            Form.txtMpvPath.Text = GetApplication(SettingsEnum.MpvPath,
                                                  Path.Combine(Application.StartupPath, "mpv\mpv.exe"))

            Form.txtStreamerPath.Text = If (livestreamerPath.Equals(String.Empty), streamlinkPath, livestreamerPath)

            Dim proxyPort = ApplicationSettings.Read(Of Integer)(SettingsEnum.ProxyPort, 8080)
            Form.tbProxyPort.Value = proxyPort /10
            Form.lblProxyPortNumber.Text = proxyPort.ToString()

            Form.tgDarkMode.Checked = NHLGamesMetro.IsDarkMode

            Form.tgShowFinalScores.Checked = ApplicationSettings.Read(Of Boolean)(SettingsEnum.ShowScores, False)
            Form.tgShowLiveScores.Checked = ApplicationSettings.Read(Of Boolean)(SettingsEnum.ShowLiveScores, False)
            Form.tgShowSeriesRecord.Checked = ApplicationSettings.Read(Of Boolean)(SettingsEnum.ShowSeriesRecord, False)
            Form.tgShowTeamCityAbr.Checked = ApplicationSettings.Read(Of Boolean)(SettingsEnum.ShowTeamCityAbr, False)
            Form.tgShowLiveTime.Checked = ApplicationSettings.Read(Of Boolean)(SettingsEnum.ShowLiveTime, False)
            Form.tgShowTodayLiveGamesFirst.Checked =
                ApplicationSettings.Read(Of Boolean)(SettingsEnum.ShowTodayLiveGamesFirst, False)

            Dim playersPath = New String() {Form.txtMpvPath.Text, Form.txtMPCPath.Text, Form.txtVLCPath.Text}
            Dim watchArgs = ApplicationSettings.Read(Of GameWatchArguments)(SettingsEnum.DefaultWatchArgs, Nothing)

            If ValidWatchArgs(watchArgs, playersPath, Form.txtStreamerPath.Text) Then
                Player.RenewArgs(True)
                watchArgs = ApplicationSettings.Read(Of GameWatchArguments)(SettingsEnum.DefaultWatchArgs,
                                                                             New GameWatchArguments)
            End If

            PopulateComboBox(Form.cbServers, SettingsEnum.SelectedServer, SettingsEnum.ServerList, String.Empty)
            Common.SetRedirectionServerInApp()

            BindWatchArgsToForm(watchArgs)

            Dim adDetectionConfigs = ApplicationSettings.Read(Of AdDetectionConfigs)(SettingsEnum.AdDetection, Nothing)

            If adDetectionConfigs Is Nothing Then
                AdDetection.Renew(True)
                adDetectionConfigs = ApplicationSettings.Read(Of AdDetectionConfigs)(SettingsEnum.AdDetection,
                                                                                      New AdDetectionConfigs)
            End If

            BindAdDetectionConfigsToForm(adDetectionConfigs)

            Form.lblNoGames.Location = New Point(((Form.tabGames.Width - Form.lblNoGames.Width) / 2),
                                                 Form.tabGames.Height / 2)
            Form.spnLoading.Location = New Point(((Form.tabGames.Width - Form.lblNoGames.Width) / 2) + 40,
                                                 (Form.tabGames.Height / 2) - 20)

            Form.spnLoading.Value = NHLGamesMetro.SpnLoadingValue
            Form.spnLoading.Maximum = NHLGamesMetro.SpnLoadingMaxValue
            Form.spnStreaming.Value = NHLGamesMetro.SpnStreamingValue
            Form.spnStreaming.Maximum = NHLGamesMetro.SpnStreamingMaxValue
            Form.lblDate.Text = DateHelper.GetFormattedDate(NHLGamesMetro.GameDate)

            NHLGamesMetro.LabelDate = Form.lblDate
        End Sub

        Private Shared Function GetApplication(varPath As SettingsEnum, currentPath As String)
            Dim savedPathFromConfig = ApplicationSettings.Read(Of String)(varPath, String.Empty)
            Dim currentPathIfFound As String = currentPath

            If File.Exists(savedPathFromConfig) Then Return savedPathFromConfig

            If File.Exists(currentPathIfFound) Then
                ApplicationSettings.SetValue(varPath, currentPathIfFound)
                Return currentPathIfFound
            Else
                ApplicationSettings.SetValue(varPath, String.Empty)
                Return String.Empty
            End If
        End Function

        Private Shared Sub PopulateComboBox(cb As MetroComboBox, selectedItem As SettingsEnum, items As SettingsEnum,
                                            defaultValue As String)
            Dim cbItemsFromConfig = ApplicationSettings.Read(Of String)(items, defaultValue)

            cb.Items.AddRange(cbItemsFromConfig.Split(";"))

            cb.SelectedItem = ApplicationSettings.Read(Of String)(selectedItem, String.Empty)
            If cb.SelectedItem Is Nothing Then
                cb.SelectedItem = cb.Items(0)
            End If
        End Sub

        Private Shared Function ValidWatchArgs(watchArgs As GameWatchArguments, playersPath As String(),
                                               streamerPath As String) As Boolean
            If watchArgs Is Nothing Then Return True

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

        Private Shared Sub BindWatchArgsToForm(watchArgs As GameWatchArguments)
            If watchArgs IsNot Nothing Then
                Form.cbStreamQuality.SelectedIndex = CType(watchArgs.Quality, Integer)

                Form.tgAlternateCdn.Checked = watchArgs.Cdn = CdnTypeEnum.L3C

                Form.tbLiveRewind.Value = If(watchArgs.StreamLiveRewind Mod 5 = 0, watchArgs.StreamLiveRewind / 5, 1)

                Form.rbMPV.Checked = watchArgs.PlayerType = PlayerTypeEnum.Mpv AndAlso Form.rbMPV.Enabled
                Form.rbVLC.Checked = watchArgs.PlayerType = PlayerTypeEnum.Vlc AndAlso Form.rbVLC.Enabled
                Form.rbMPC.Checked = watchArgs.PlayerType = PlayerTypeEnum.Mpc AndAlso Form.rbMPC.Enabled

                If Form.rbVLC.Checked AndAlso watchArgs.PlayerPath <> Form.txtVLCPath.Text Then
                    Player.RenewArgs()
                ElseIf Form.rbMPC.Checked AndAlso watchArgs.PlayerPath <> Form.txtMPCPath.Text Then
                    Player.RenewArgs()
                ElseIf Form.rbMPV.Checked AndAlso watchArgs.PlayerPath <> Form.txtMpvPath.Text Then
                    Player.RenewArgs()
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
        End Sub

        Private Shared Sub BindAdDetectionConfigsToForm(configs As AdDetectionConfigs)
            If configs IsNot Nothing Then

                Form.tgModules.Checked = configs.IsEnabled

                Form.chkSpotifyForceToStart.Checked = configs.EnabledSpotifyForceToOpen
                Form.chkSpotifyPlayNextSong.Checked = configs.EnabledSpotifyPlayNextSong
                Form.chkSpotifyAnyMediaPlayer.Checked = configs.EnabledSpotifyAndAnyMediaPlayer

                Form.txtAdKey.Text = configs.EnabledObsAdSceneHotKey.Key
                Form.chkAdCtrl.Checked = configs.EnabledObsAdSceneHotKey.Ctrl
                Form.chkAdAlt.Checked = configs.EnabledObsAdSceneHotKey.Alt
                Form.chkAdShift.Checked = configs.EnabledObsAdSceneHotKey.Shift

                Form.txtGameKey.Text = configs.EnabledObsGameSceneHotKey.Key
                Form.chkGameCtrl.Checked = configs.EnabledObsGameSceneHotKey.Ctrl
                Form.chkGameAlt.Checked = configs.EnabledObsGameSceneHotKey.Alt
                Form.chkGameShift.Checked = configs.EnabledObsGameSceneHotKey.Shift

                Form.tgSpotify.Checked = configs.EnabledSpotifyModule
                Form.tgOBS.Checked = configs.EnabledObsModule

            End If
        End Sub

        Private Shared Sub SetThemeAndSvgOnForm()
            Dim themeChar = "l"
            Dim colorMetroThemeDark = Color.FromArgb(17, 17, 17)
            If NHLGamesMetro.IsDarkMode Then
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
                Form.lblShowTodayLiveGamesFirst.Theme = MetroThemeStyle.Dark
                Form.lblShowLiveTime.Theme = MetroThemeStyle.Dark
                Form.lblShowLiveScores.Theme = MetroThemeStyle.Dark
                Form.lblShowSeriesRecord.Theme = MetroThemeStyle.Dark
                Form.lblShowTeamCityAbr.Theme = MetroThemeStyle.Dark
                Form.lblShowFinalScores.Theme = MetroThemeStyle.Dark
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
                Form.lblSpotify.Theme = MetroThemeStyle.Dark
                Form.tgSpotify.Theme = MetroThemeStyle.Dark
                Form.lblSpotifyDesc.Theme = MetroThemeStyle.Dark
                Form.chkSpotifyForceToStart.Theme = MetroThemeStyle.Dark
                Form.chkSpotifyPlayNextSong.Theme = MetroThemeStyle.Dark
                Form.chkSpotifyAnyMediaPlayer.Theme = MetroThemeStyle.Dark
                Form.lblOBS.Theme = MetroThemeStyle.Dark
                Form.tgOBS.Theme = MetroThemeStyle.Dark
                Form.lblOBSDesc.Theme = MetroThemeStyle.Dark
                Form.lblObsAdStartingHotkey.Theme = MetroThemeStyle.Dark
                Form.lblObsAdEndingHotkey.Theme = MetroThemeStyle.Dark
                Form.txtAdKey.Theme = MetroThemeStyle.Dark
                Form.txtGameKey.Theme = MetroThemeStyle.Dark
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
                Form.btnYesterday.FlatAppearance.BorderColor =  Color.FromArgb(80, 80, 80)
                Form.btnDate.BackColor = Color.DarkGray
                Form.btnDate.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80)
                Form.btnTomorrow.BackColor = Color.DarkGray
                Form.btnTomorrow.FlatAppearance.BorderColor =  Color.FromArgb(80, 80, 80)
                Form.btnRefresh.BackColor = Color.DarkGray
                Form.btnRefresh.FlatAppearance.BorderColor =  Color.FromArgb(80, 80, 80)
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
