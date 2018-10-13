Imports System.Globalization
Imports System.Text
Imports MetroFramework
Imports MetroFramework.Drawing
Imports NHLGames.Objects
Imports NHLGames.Utilities

Namespace Controls
    Public Class GameControl
        Inherits UserControl
        Implements IDisposable
        Private _game As Game
        Private ReadOnly _showLiveScores As Boolean
        Private ReadOnly _showScores As Boolean
        Private ReadOnly _showSeriesRecord As Boolean
        Private ReadOnly _showTeamCityAbr As Boolean
        Private ReadOnly _showLiveTime As Boolean
        Private ReadOnly _broadcasters As Dictionary(Of String, String)
        Public LiveReplayCode As LiveStatusCodeEnum = LiveStatusCodeEnum.Live
        Private _lnkUnknowns() As Button
        Private _themeChar = "l"
        Private _defaultBackColor = Color.FromArgb(224, 224, 224)

        Public ReadOnly Property GameId As String
            Get
                Return _game.GameId
            End Get
        End Property

        Public Sub UpdateGame(showScores As Boolean, showLiveScores As Boolean, showSeriesRecord As Boolean,
                              showTeamCityAbr As Boolean, showLiveTime As Boolean, Optional gameUpdated As Game = Nothing)

            If gameUpdated IsNot Nothing Then
                If gameUpdated.StreamsDict Is Nothing Then Return
                _game = gameUpdated
                gameUpdated.Dispose()
            End If

            lblPeriod.Text = String.Empty
            lblGameStatus.Text = String.Empty
            lblNotInSeason.Text = String.Empty
            lblStreamStatus.Text = String.Empty
            Dim gameState = NHLGamesMetro.RmText.GetString($"enumGameState{Convert.ToInt32(_game.GameState)}").ToUpper()

            If _game.IsLive Then
                btnLiveReplay.Visible = True
                tt.SetToolTip(btnLiveReplay, NHLGamesMetro.RmText.GetString("tipLiveGame"))
                lblGameStatus.Visible = Not showLiveScores
                lblHomeScore.Visible = showLiveScores
                lblAwayScore.Visible = showLiveScores
                lblPeriod.BackColor = Color.FromArgb(255, 0, 170, 210)
                lblPeriod.ForeColor = Color.White

                If showLiveTime Then
                    If _game.IsInIntermission Then
                        lblPeriod.Text =
                            $"{NHLGamesMetro.RmText.GetString("gameIntermission")} { _
                                _game.IntermissionTimeRemaining.ToString("mm:ss")}".ToUpper()
                    Else
                        lblPeriod.Text = $"{_game.GamePeriod.
                            Replace($"1st", NHLGamesMetro.RmText.GetString("gamePeriod1")).
                            Replace($"2nd", NHLGamesMetro.RmText.GetString("gamePeriod2")).
                            Replace($"3rd", NHLGamesMetro.RmText.GetString("gamePeriod3")).
                            Replace($"OT", NHLGamesMetro.RmText.GetString("gamePeriodOt")).
                            Replace($"SO", NHLGamesMetro.RmText.GetString("gamePeriodSo")).
                            ToUpper()}              {_game.GameTimeLeft.ToLower().Replace("end", "00:00")}".ToUpper() '1st 2nd 3rd OT SO... Final, 12:34, 20:00 

                        If _game.GameTimeLeft.ToLower() = "final" Then
                            lblPeriod.Text = NHLGamesMetro.RmText.GetString("gamePeriodFinal").ToUpper()
                            If _game.HomeScore < _game.AwayScore Then
                                lblHomeScore.ForeColor = Color.Gray
                            Else
                                lblAwayScore.ForeColor = Color.Gray
                            End If
                        End If

                        If _game.GamePeriod.Contains(NHLGamesMetro.RmText.GetString("gamePeriodOt")) And
                            IsNumeric(_game.GamePeriod(0)) Then
                            lblPeriod.Text =
                                String.Format(NHLGamesMetro.RmText.GetString("gamePeriodOtMore"), _game.GamePeriod(0)).
                                    ToUpper() '2OT..
                        End If
                    End If
                End If

                If Not showLiveScores Then
                    lblGameStatus.Text = String.Format("{0}{1}{2}",
                                                       _game.GameDate.ToLocalTime().ToString("h:mm tt"),
                                                       vbCrLf,
                                                       gameState)
                End If

            ElseIf _game.GameState = GameStateEnum.StreamEnded Then
                lblHomeScore.Visible = showScores
                lblAwayScore.Visible = showScores
                lblGameStatus.Visible = Not showScores

                If _game.HomeScore < _game.AwayScore Then
                    lblHomeScore.ForeColor = Color.Gray
                Else
                    lblAwayScore.ForeColor = Color.Gray
                End If

                If showScores Then
                    lblPeriod.Text = gameState
                    If Not String.Equals(_game.GamePeriod, $"3rd", StringComparison.CurrentCultureIgnoreCase) And _game.GamePeriod <> "" Then
                        lblPeriod.Text = (gameState & $"/" &
                                          _game.GamePeriod.
                                          Replace($"OT", NHLGamesMetro.RmText.GetString("gamePeriodOt")).
                                          Replace($"SO", NHLGamesMetro.RmText.GetString("gamePeriodSo"))).
                                          ToUpper() 'FINAL/SO.. OT.. 2OT
                    End If
                Else
                    lblGameStatus.Text = String.Format("{0}{1}{2}",
                                                       _game.GameDate.ToLocalTime().ToString("h:mm tt"),
                                                       vbCrLf,
                                                       gameState)
                    If lblPeriod.Text.Contains(NHLGamesMetro.RmText.GetString("gamePeriodOt")) Then
                        lblGameStatus.Text = String.Format("{0}{1}{2}",
                                                           _game.GameDate.ToLocalTime().ToString("h:mm tt"),
                                                           vbCrLf,
                                                           NHLGamesMetro.RmText.GetString("gamePeriodFinal").ToUpper())
                    End If
                End If
            ElseIf _game.GameState <= GameStateEnum.Pregame  Then
                lblDivider.Visible = False
                lblGameStatus.Visible = True
                lblGameStatus.Text = _game.GameDate.ToLocalTime().ToString("h:mm tt")

                If _game.GameState.Equals(GameStateEnum.Pregame) OrElse _game.AreAnyStreamsAvailable() Then
                    lblPeriod.BackColor = Color.FromArgb(255, 0, 170, 210)
                    If showLiveScores Then
                        lblPeriod.ForeColor = Color.White
                        lblPeriod.Text = gameState
                    Else
                        lblGameStatus.Text &= String.Format("{0}{1}", vbCrLf, gameState)
                    End If
                End If
            ElseIf _game.IsUnplayable Then
                lblDivider.Visible = False
                lblGameStatus.Visible = True
                lblPeriod.Text = _game.GameStateDetailed.ToUpper()
                lblGameStatus.Text = gameState
                lblPeriod.BackColor = Color.FromKnownColor(KnownColor.DarkOrange)

                If showLiveScores Then
                    lblPeriod.ForeColor = Color.White
                    lblPeriod.Text = _game.GameStateDetailed.ToUpper()
                End If
            End If

            If _game.GameType.Equals(GameTypeEnum.Preseason) Then
                lblNotInSeason.Text = NHLGamesMetro.RmText.GetString("lblPreseason").ToUpper()
            ElseIf _game.GameType.Equals(GameTypeEnum.Series) Then
                Dim seriesStatusShort =
                        String.Format(NHLGamesMetro.RmText.GetString("lblGame"), _game.SeriesGameNumber.ToString()).
                        ToUpper() 'Game 1
                Dim seriesStatusLong = If(_game.SeriesGameNumber <> 1,
                    String.Format(NHLGamesMetro.RmText.GetString("lblGameAbv"),
                                  _game.SeriesGameNumber.ToString(), 'Game 2.. 7
                                  _game.SeriesGameStatus.ToString().ToLower().
                                  Replace("tied", NHLGamesMetro.RmText.GetString("gameSeriesTied")).
                                  Replace("wins", NHLGamesMetro.RmText.GetString("gameSeriesWin")).
                                  Replace("leads", NHLGamesMetro.RmText.GetString("gameSeriesLead"))).
                                  ToUpper(), seriesStatusShort)
                Dim isSeriesRecordVisible = showSeriesRecord AndAlso _game.SeriesGameStatus.Length > 0 AndAlso (showScores OrElse Not _game.IsOffTheAir)
                lblNotInSeason.Text = If(isSeriesRecordVisible, seriesStatusLong, seriesStatusShort)
            End If

            If Not _game.AreAnyStreamsAvailable Then
                If _game.GameDate.ToLocalTime() > Date.UtcNow.ToLocalTime() And _game.GameState < GameStateEnum.InProgress Then
                    lblStreamStatus.Text = NHLGamesMetro.RmText.GetString("lblStreamAvailableAtGameTime")
                Else
                    lblStreamStatus.Text = NHLGamesMetro.RmText.GetString("lblNoStreamAvailable")
                End If
                flpStreams.Visible = False
            End If

            lblHomeTeam.Visible = showTeamCityAbr
            lblAwayTeam.Visible = showTeamCityAbr

            tt.SetToolTip(picAway,
                          String.Format(NHLGamesMetro.RmText.GetString("lblAwayTeam"), _game.Away, _game.AwayTeam))
            tt.SetToolTip(picHome,
                          String.Format(NHLGamesMetro.RmText.GetString("lblHomeTeam"), _game.Home, _game.HomeTeam))

            SetLiveStatusIcon()
        End Sub

        Public Sub New(game As Game, showScores As Boolean, showLiveScores As Boolean, showSeriesRecord As Boolean,
                       showTeamCityAbr As Boolean, showLiveTime As Boolean)

            InitializeComponent()
            _broadcasters = New Dictionary(Of String, String)() From {
                {"ALT", "ALT"},
                {"ATT", "ATT"},
                {"CBC", "CBC"},
                {"CITY", "CBC"},
                {"CNBC", "NBC"},
                {"CSN", "NBC"},
                {"ESPN", "ESPN"},
                {"FS", "FS"},
                {"GOLF", "NBC"},
                {"KCOP", "FS"},
                {"MSG", "MSG"},
                {"NBC", "NBC"},
                {"NESN", "NESN"},
                {"PRIM", "FS"},
                {"RDS", "RDS"},
                {"ROOT", "ROOT"},
                {"SN", "SN"},
                {"SUN", "FS"},
                {"TCN", "CSN"},
                {"TSN", "TSN"},
                {"TVAS", "TVAS"},
                {"USA", "NBC"},
                {"WGN", "WGN"}}
            _showScores = showScores
            _showLiveScores = showLiveScores
            _showSeriesRecord = showSeriesRecord
            _showTeamCityAbr = showTeamCityAbr
            _showLiveTime = showLiveTime
            _game = game

            SetThemeAndSvgOnControl()

            SetWholeGamePanel()
        End Sub

        Private Sub UpdateGameStreams()
            lblHomeScore.Text = _game.HomeScore
            lblHomeTeam.Text = _game.HomeAbbrev

            lblAwayScore.Text = _game.AwayScore
            lblAwayTeam.Text = _game.AwayAbbrev

            lnkAway.Visible = _game.IsStreamDefined(StreamTypeEnum.Away)
            lnkHome.Visible = _game.IsStreamDefined(StreamTypeEnum.Home)
            lnkFrench.Visible = _game.IsStreamDefined(StreamTypeEnum.French)
            lnkNational.Visible = _game.IsStreamDefined(StreamTypeEnum.National)

            lnkThree.Visible = _game.IsStreamDefined(StreamTypeEnum.MultiCam1)
            lnkSix.Visible = _game.IsStreamDefined(StreamTypeEnum.MultiCam2)

            lnkRef.Visible = _game.IsStreamDefined(StreamTypeEnum.RefCam)
            lnkStar.Visible = _game.IsStreamDefined(StreamTypeEnum.StarCam)

            lnkEnd1.Visible = _game.IsStreamDefined(StreamTypeEnum.EndzoneCam1)
            lnkEnd2.Visible = _game.IsStreamDefined(StreamTypeEnum.EndzoneCam2)

            If _game.StreamsUnknown IsNot Nothing Then
                Dim unknownStreams = _game.StreamsUnknown
                ReDim _lnkUnknowns(unknownStreams.Count() - 1)
                For i = 0 To unknownStreams.Count() - 1
                    _lnkUnknowns(i) = New Button()
                    With _lnkUnknowns(i)
                        .Height = 26
                        .Width = 26
                        .Margin = New Padding(4, 6, 4, 6)
                        .FlatStyle = FlatStyle.Flat
                        .FlatAppearance.BorderSize = 0
                        .FlatAppearance.BorderColor = _defaultBackColor
                        .FlatAppearance.MouseOverBackColor = Color.White
                        .BackgroundImageLayout = ImageLayout.Zoom
                        .BackColor = _defaultBackColor
                        .BackgroundImage = ImageFetcher.GetEmbeddedImage("cam")
                        .Name = "lnk" & i
                        .Tag = unknownStreams(i)
                    End With
                    SetStreamButtonLink(unknownStreams(i), _lnkUnknowns(i), unknownStreams(i).StreamTypeSelected)
                    AddHandler _lnkUnknowns(i).Click, AddressOf WatchStream
                    flpStreams.Controls.Add(_lnkUnknowns(i))
                Next
            End If

            If Not _game.IsUnplayable Then
                If _game.GameState < GameStateEnum.Ended And _game.GameDate.ToLocalTime() <= Date.Today.AddDays(1) Then
                    bpGameControl.BorderColour = Color.FromArgb(255, 0, 170, 210)
                Else
                    bpGameControl.BorderColour = Color.FromArgb(255, 100, 100, 100)
                End If
            Else
                bpGameControl.BorderColour = Color.DarkOrange
            End If

            UpdateGame(_showScores, _showLiveScores, _showSeriesRecord, _showTeamCityAbr, _showLiveTime)
        End Sub

        Private Sub SetWholeGamePanel()
            SetTeamLogo(picAway, $"{_game.AwayAbbrev}_{_themeChar}")
            SetTeamLogo(picHome, $"{_game.HomeAbbrev}_{_themeChar}")

            SetStreamButtonLink(_game.GetStream(StreamTypeEnum.Away), lnkAway,
                                String.Format(NHLGamesMetro.RmText.GetString("lblTeamStream"), _game.AwayAbbrev))
            SetStreamButtonLink(_game.GetStream(StreamTypeEnum.Home), lnkHome,
                                String.Format(NHLGamesMetro.RmText.GetString("lblTeamStream"), _game.HomeAbbrev))
            SetStreamButtonLink(_game.GetStream(StreamTypeEnum.French), lnkFrench, NHLGamesMetro.RmText.GetString("lblFrenchNetwork"))
            SetStreamButtonLink(_game.GetStream(StreamTypeEnum.National), lnkNational,
                                NHLGamesMetro.RmText.GetString("lblNationalNetwork"))

            SetStreamButtonLink(_game.GetStream(StreamTypeEnum.MultiCam1), lnkThree,
                                String.Format(NHLGamesMetro.RmText.GetString("lblCamViews"), 3))
            SetStreamButtonLink(_game.GetStream(StreamTypeEnum.MultiCam2), lnkSix,
                                String.Format(NHLGamesMetro.RmText.GetString("lblCamViews"), 6))

            SetStreamButtonLink(_game.GetStream(StreamTypeEnum.EndzoneCam1), lnkEnd1,
                                String.Format(NHLGamesMetro.RmText.GetString("lblEndzoneCam"), _game.AwayAbbrev))
            SetStreamButtonLink(_game.GetStream(StreamTypeEnum.EndzoneCam2), lnkEnd2,
                                String.Format(NHLGamesMetro.RmText.GetString("lblEndzoneCam"), _game.HomeAbbrev))

            SetStreamButtonLink(_game.GetStream(StreamTypeEnum.RefCam), lnkRef, NHLGamesMetro.RmText.GetString("lblRefCam"))
            SetStreamButtonLink(_game.GetStream(StreamTypeEnum.StarCam), lnkStar, NHLGamesMetro.RmText.GetString("lblStarCam"))
            UpdateGameStreams()
        End Sub

        Private Sub SetStreamButtonLink(stream As GameStream, btnLink As Button, tooltip As String)
            If stream Is Nothing Then Return
            If stream.IsBroken Then
                Dim brokenImage = ImageFetcher.GetEmbeddedImage("broken")
                If btnLink.BackgroundImage IsNot Nothing Then btnLink.BackgroundImage.Dispose()
                If brokenImage IsNot Nothing Then btnLink.BackgroundImage = brokenImage
                btnLink.FlatAppearance.MouseOverBackColor = _defaultBackColor
                btnLink.FlatAppearance.MouseDownBackColor = _defaultBackColor
                tt.SetToolTip(btnLink, String.Format(NHLGamesMetro.RmText.GetString("tipBrokenStream")))
            Else
                If stream.Type <= StreamTypeEnum.French Then
                    Dim img As String = GetBroadcasterPicFor(stream.Network)
                    If img <> "" Then
                        Dim networkImage = ImageFetcher.GetEmbeddedImage(img)
                        If btnLink.BackgroundImage IsNot Nothing Then btnLink.BackgroundImage.Dispose()
                        If networkImage IsNot Nothing Then btnLink.BackgroundImage = networkImage
                    End If
                    tooltip &= String.Format(NHLGamesMetro.RmText.GetString("lblOnNetwork"), stream.Network)
                End If
                tt.SetToolTip(btnLink, tooltip)
            End If
        End Sub

        Private Sub SetTeamLogo(pic As PictureBox, team As String)
            pic.SizeMode = PictureBoxSizeMode.Zoom
            If String.IsNullOrEmpty(team) = False Then
                Dim img As Bitmap = ImageFetcher.GetEmbeddedImage(team)
                If Not img Is Nothing Then
                    If pic.BackgroundImage IsNot Nothing Then pic.BackgroundImage.Dispose()
                    If img IsNot Nothing Then pic.BackgroundImage = img
                End If
            End If
        End Sub

        Private Function GetBroadcasterPicFor(network As String) As String
            Dim value As String = _broadcasters.Where(Function(kvp) network.ToUpper().StartsWith(kvp.Key.ToString())).Select(
                        Function(kvp) kvp.Value).FirstOrDefault()
            Return If(value <> Nothing, value.ToLower, String.Empty)
        End Function

        Public Sub SetLiveStatusIcon(Optional increase As Boolean = False)
            If increase Then
                LiveReplayCode = If(LiveReplayCode + 1 > LiveStatusCodeEnum.Replay, 0, LiveReplayCode + 1)
            End If

            btnLiveReplay.BackColor = If(LiveReplayCode.Equals(LiveStatusCodeEnum.Live), Color.Red, Color.White)

            If btnLiveReplay.BackgroundImage IsNot Nothing Then btnLiveReplay.BackgroundImage.Dispose()
            btnLiveReplay.BackgroundImage = ImageFetcher.GetEmbeddedImage($"live_{CType(LiveReplayCode, Integer)}")

            Dim type = LiveReplayCode.ToString()
            If Not LiveReplayCode.Equals(LiveStatusCodeEnum.Rewind) Then
                tt.SetToolTip(btnLiveReplay, NHLGamesMetro.RmText.GetString("tipLiveStatus" & type))
            Else
                tt.SetToolTip(btnLiveReplay, String.Format(NHLGamesMetro.RmText.GetString("tipLiveStatus" & type),
                                                           WatchArgs().StreamLiveRewind))
            End If
        End Sub

        Private Function WatchArgs() As GameWatchArguments
            Return ApplicationSettings.Read(Of GameWatchArguments)(SettingsEnum.DefaultWatchArgs, New GameWatchArguments)
        End Function

        Private Sub WatchStream(streamType As StreamerTypeEnum)
            Dim args = WatchArgs()
            args.GameDate = _game.GameDate
            args.Stream = _game.GetStream(streamType)
            args.GameTitle = _game.AwayAbbrev & " @ " & _game.HomeAbbrev
            args.StreamLiveReplayCode = LiveReplayCode
            args.GameIsOnAir = _game.GameState < GameStateEnum.StreamEnded AndAlso
                               _game.GameState > GameStateEnum.Pregame
            If Not args.Stream?.IsBroken Then Player.Watch(args)
        End Sub

        Private Sub WatchStream(sender As Object, e As EventArgs)
            Dim args = WatchArgs()
            args.GameDate = _game.GameDate
            args.Stream = CType(sender, Button).Tag
            args.GameTitle = _game.AwayAbbrev & " @ " & _game.HomeAbbrev
            args.StreamLiveReplayCode = LiveReplayCode
            args.GameIsOnAir = _game.GameState < GameStateEnum.StreamEnded AndAlso
                               _game.GameState > GameStateEnum.Pregame
            If Not args.Stream?.IsBroken Then Player.Watch(args)
        End Sub

        Private Sub lnkAway_Click(sender As Object, e As EventArgs) Handles lnkAway.Click
            WatchStream(StreamTypeEnum.Away)
        End Sub

        Private Sub lnkFrench_Click(sender As Object, e As EventArgs) Handles lnkFrench.Click
            WatchStream(StreamTypeEnum.French)
        End Sub

        Private Sub lnkNational_Click(sender As Object, e As EventArgs) Handles lnkNational.Click
            WatchStream(StreamTypeEnum.National)
        End Sub

        Private Sub lnkHome_Click(sender As Object, e As EventArgs) Handles lnkHome.Click
            WatchStream(StreamTypeEnum.Home)
        End Sub

        Private Sub lnkThree_Click(sender As Object, e As EventArgs) Handles lnkThree.Click
            WatchStream(StreamTypeEnum.MultiCam1)
        End Sub

        Private Sub lnkSix_Click(sender As Object, e As EventArgs) Handles lnkSix.Click
            WatchStream(StreamTypeEnum.MultiCam2)
        End Sub

        Private Sub lnkEnd1_Click(sender As Object, e As EventArgs) Handles lnkEnd1.Click
            WatchStream(StreamTypeEnum.EndzoneCam1)
        End Sub

        Private Sub lnkEnd2_Click(sender As Object, e As EventArgs) Handles lnkEnd2.Click
            WatchStream(StreamTypeEnum.EndzoneCam2)
        End Sub

        Private Sub lnkRef_Click(sender As Object, e As EventArgs) Handles lnkRef.Click
            WatchStream(StreamTypeEnum.RefCam)
        End Sub

        Private Sub lnkStar_Click(sender As Object, e As EventArgs) Handles lnkStar.Click
            WatchStream(StreamTypeEnum.StarCam)
        End Sub

        Protected Overloads Overrides Sub Dispose(disposing As Boolean)
            Try
                If disposing Then
                    If _game.IsStreamDefined(StreamTypeEnum.Unknown) Then
                        For Each lnk In _lnkUnknowns
                            RemoveHandler lnk.Click, AddressOf WatchStream
                        Next
                    End If
                    If tt IsNot Nothing Then tt.Dispose()
                    If btnLiveReplay IsNot Nothing Then btnLiveReplay.Dispose()
                    If lblGameStatus IsNot Nothing Then lblGameStatus.Dispose()
                    If lblDivider IsNot Nothing Then lblDivider.Dispose()
                    If picAway IsNot Nothing Then picAway.Dispose()
                    If lblHomeScore IsNot Nothing Then lblHomeScore.Dispose()
                    If lblAwayScore IsNot Nothing Then lblAwayScore.Dispose()
                    If lblAwayTeam IsNot Nothing Then lblAwayTeam.Dispose()
                    If picHome IsNot Nothing Then picHome.Dispose()
                    If lblHomeTeam IsNot Nothing Then lblHomeTeam.Dispose()
                    If lblPeriod IsNot Nothing Then lblPeriod.Dispose()
                    If flpStreams IsNot Nothing Then flpStreams.Dispose()
                    If lnkHome IsNot Nothing Then lnkHome.Dispose()
                    If lnkAway IsNot Nothing Then lnkAway.Dispose()
                    If lnkNational IsNot Nothing Then lnkNational.Dispose()
                    If lnkFrench IsNot Nothing Then lnkFrench.Dispose()
                    If lnkThree IsNot Nothing Then lnkThree.Dispose()
                    If lnkSix IsNot Nothing Then lnkSix.Dispose()
                    If lnkEnd1 IsNot Nothing Then lnkEnd1.Dispose()
                    If lnkEnd2 IsNot Nothing Then lnkEnd2.Dispose()
                    If lnkRef IsNot Nothing Then lnkRef.Dispose()
                    If lnkStar IsNot Nothing Then lnkStar.Dispose()
                    If lblNotInSeason IsNot Nothing Then lblNotInSeason.Dispose()
                    If lblStreamStatus IsNot Nothing Then lblStreamStatus.Dispose()
                    If bpGameControl IsNot Nothing Then
                        bpGameControl.Controls.Clear()
                        bpGameControl.Dispose()
                    End If
                    If components IsNot Nothing Then components.Dispose()
                    _broadcasters.Clear()
                    _game.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        Private Sub btnLiveReplay_Click(sender As Object, e As EventArgs) Handles btnLiveReplay.Click
            SetLiveStatusIcon(True)
        End Sub

        Private Sub SetThemeAndSvgOnControl()
            If NHLGamesMetro.IsDarkMode Then
                _defaultBackColor = Color.FromArgb(80, 80, 80)
                _themeChar = "d"
                BackColor = Color.FromArgb(60, 60, 60)
                flpStreams.BackColor = Color.FromArgb(80, 80, 80)
                lblPeriod.BackColor = Color.FromArgb(80, 80, 80)
                lblStreamStatus.BackColor = Color.FromArgb(80, 80, 80)
                lblStreamStatus.ForeColor =  Color.LightGray
                lblAwayTeam.Theme = MetroThemeStyle.Dark
                lblHomeTeam.Theme = MetroThemeStyle.Dark
                lblGameStatus.Theme = MetroThemeStyle.Dark
                lblPeriod.ForeColor = Color.White
                lblAwayScore.ForeColor = Color.LightGray
                lblHomeScore.ForeColor = Color.LightGray
                lblNotInSeason.Theme = MetroThemeStyle.Dark
                lblDivider.BackColor = Color.Black
                For Each lnk In New Button() {lnkHome, lnkAway, lnkFrench, lnkNational, lnkEnd1, lnkEnd2, lnkRef, lnkStar, lnkThree, lnkSix}
                    lnk.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80)
                    lnk.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100)
                Next
            End If

            Dim nhl = $"nhl_{_themeChar}"
            picHome.BackgroundImage = ImageFetcher.GetEmbeddedImage(nhl)
            picAway.BackgroundImage = ImageFetcher.GetEmbeddedImage(nhl)
            lnkHome.BackgroundImage = ImageFetcher.GetEmbeddedImage(nhl)
            lnkAway.BackgroundImage = ImageFetcher.GetEmbeddedImage(nhl)
            lnkFrench.BackgroundImage = ImageFetcher.GetEmbeddedImage(nhl)
            lnkNational.BackgroundImage = ImageFetcher.GetEmbeddedImage(nhl)
            lnkEnd1.BackgroundImage = ImageFetcher.GetEmbeddedImage("cam_left")
            lnkEnd2.BackgroundImage = ImageFetcher.GetEmbeddedImage("cam_right")
            lnkRef.BackgroundImage = ImageFetcher.GetEmbeddedImage("cam_ref")
            lnkStar.BackgroundImage = ImageFetcher.GetEmbeddedImage("cam_star")
            lnkThree.BackgroundImage = ImageFetcher.GetEmbeddedImage("cam3way")
            lnkSix.BackgroundImage = ImageFetcher.GetEmbeddedImage("cam6way")
        End Sub
    End Class
End Namespace
