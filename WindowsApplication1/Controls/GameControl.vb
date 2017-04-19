Imports NHLGames.Game

Public Class GameControl

    Private _Game As Game
    Private _selectedDate As Date

    Public Sub New(Game As Game, showScores As Boolean, showLiveScores As Boolean, selectedDate As Date)
        InitializeComponent()

        _Game = Game
        _selectedDate = selectedDate

        SetInitialProperties(Game)
        UpdateGameStatusProperties(Game)

        If Game.GameIsLive Then
            lblHomeScore.Visible = showLiveScores
            lblAwayScore.Visible = showLiveScores
            If Not showLiveScores And Game.GameIsInPlayoff And Game.Date.ToLocalTime() = Date.Today Then
                lblNotInSeason.Text = "Playoffs"
            End If
        Else
            lblHomeScore.Visible = showScores
            lblAwayScore.Visible = showScores
            If showScores And Game.GameIsFinal And Game.GamePeriod <> "3rd" Then
                lblTime.Text += If(Game.GamePeriod <> "", "/" + Game.GamePeriod, "")
            End If
            If Not showScores And Game.GameIsInPlayoff And Game.GameIsFinal Then
                lblNotInSeason.Text = "Playoffs"
            End If
        End If

        lblLive.Visible = Game.GameIsLive

        AddHandler _Game.GameUpdated, AddressOf GameUpdatedHandler

    End Sub

    Private Sub UpdateGameStatusProperties(Game As Game)
        lblHomeScore.Text = Game.HomeScore
        lblHomeTeam.Text = Game.HomeAbbrev

        lblAwayScore.Text = Game.AwayScore
        lblAwayTeam.Text = Game.AwayAbbrev

        'btnWatch.Enabled = Game.Date <= DateTime.Now 'AndAlso Game.GameIsLive
        If Game.GameIsScheduled And Game.Date.ToLocalTime() <= Date.Today.AddDays(1) Then
            BorderPanel1.BorderColour = Color.FromArgb(255, 0, 175, 220)
        ElseIf Game.GameIsPreGame Then
            BorderPanel1.BorderColour = Color.Lime
        ElseIf Game.GameIsLive Then
            BorderPanel1.BorderColour = Color.Red
        ElseIf Game.GameIsScheduled Then
            BorderPanel1.BorderColour = Color.DarkGray
        End If
    End Sub

    Private Sub SetInitialProperties(Game As Game)
        picAway.SizeMode = PictureBoxSizeMode.StretchImage
        If String.IsNullOrEmpty(Game.HomeTeam) = False Then
            picAway.Image = ImageFetcher.GetEmbeddedImage(Game.AwayTeam)
            TeamToolTip.SetToolTip(picAway, "Away Team: " & Game.AwayTeamName)
        End If


        picHome.SizeMode = PictureBoxSizeMode.StretchImage
        If String.IsNullOrEmpty(Game.AwayTeam) = False Then
            picHome.Image = ImageFetcher.GetEmbeddedImage(Game.HomeTeam)
            TeamToolTip.SetToolTip(picHome, "Home Team: " & Game.HomeTeamName)
        End If

        lblPeriod.Text = ""
        lblNotInSeason.Text = ""
        If Not Game.GameIsInSeason Then
            If Game.GameIsInPlayoff Then
                If Game.GameIsLive Or Game.GameIsPreGame Then
                    lblNotInSeason.Text = "GM " + Game.SeriesGameNumber + ": " + Game.SeriesGameStatus
                Else
                    lblNotInSeason.Text = Game.SeriesGameStatus
                    lblPeriod.Text = "Game" + Game.SeriesGameNumber
                End If
            Else
                lblNotInSeason.Text = "Preseason"
            End If
        End If


        If Game.GameIsLive Then
            lblTime.Text = Game.GameTimeLeft.ToString()
            lblPeriod.Text = Game.GamePeriod.ToString()
        ElseIf Game.GameIsFinal Then
            lblTime.Text = Game.GameState.ToString
        ElseIf Game.GameIsPreGame Then
            lblTime.Text = Game.Date.ToLocalTime().ToString("h:mm tt")
            lblPeriod.Text = Game.GameState.ToString
        Else
            lblTime.Text = Game.Date.ToLocalTime().ToString("h:mm tt")
        End If

        lblNoStream.Visible = If(Not Game.AreAnyStreamsAvailable And Game.Date.ToLocalTime <= Date.Today.AddDays(1), True, False)
        If Not Game.AreAnyStreamsAvailable And Game.Date.ToLocalTime >= Date.Today Then
            lblNoStream.Text = "Streams available during pregame"
        End If

        Dim tip As String = ""

        lblAwayStream.Visible = Game.AwayStream.IsAvailable
        If Game.AwayStream.IsAvailable Then
            tip = Game.Away + " stream"
            If Game.AwayStream.Network <> String.Empty Then
                lblAwayStream.Text += " (" & Game.AwayStream.Network & ")"
                tip += " on " + Game.AwayStream.Network
            End If
            TeamToolTip.SetToolTip(lblAwayStream, tip)
        End If

        lblHomeStream.Visible = Game.HomeStream.IsAvailable
        If Game.HomeStream.IsAvailable Then
            tip = Game.Home + " stream"
            If Game.HomeStream.Network <> String.Empty Then
                lblHomeStream.Text += " (" & Game.HomeStream.Network & ")"
                tip += " on " + Game.HomeStream.Network
            End If
            TeamToolTip.SetToolTip(lblHomeStream, tip)
        End If

        lblFrenchStream.Visible = Game.FrenchStream.IsAvailable
        If Game.FrenchStream.IsAvailable Then
            tip = "French canadians stream"
            If Game.FrenchStream.Network <> String.Empty Then
                lblFrenchStream.Text += " (" & Game.FrenchStream.Network & ")"
                tip += " on " + Game.FrenchStream.Network
            End If
            TeamToolTip.SetToolTip(lblFrenchStream, tip)
        End If

        lblNationalStream.Visible = Game.NationalStream.IsAvailable
        If Game.NationalStream.IsAvailable Then
            tip = "National stream"
            If Game.NationalStream.Network <> String.Empty Then
                lblNationalStream.Text += " (" & Game.NationalStream.Network & ")"
                tip += " on " + Game.NationalStream.Network
            End If
            TeamToolTip.SetToolTip(lblNationalStream, tip)
        End If

        lblMultiCam1.Visible = Game.MultiCam1Stream.IsAvailable

        lblMultiCam2.Visible = Game.MultiCam2Stream.IsAvailable

        lblRefCam.Visible = Game.RefCamStream.IsAvailable

        lblEndzoneCam1.Visible = Game.EndzoneCam1Stream.IsAvailable

        lblEndzoneCam2.Visible = Game.EndzoneCam2Stream.IsAvailable
    End Sub

    Private Sub GameUpdatedHandler(game As Game)
        _Game = game
        UpdateGameStatusProperties(game)
    End Sub

    Private Sub lblHomeStream_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblHomeStream.LinkClicked
        Dim args = WatchArgs()

        If DateHelper.GetPacificTime(_Game.Date).ToShortDateString <> DateHelper.GetPacificTime().ToShortDateString() Then
            _Game.HomeStream.CheckVOD(args.CDN)
            args.IsVOD = _Game.HomeStream.IsVOD
        End If

        'If DateHelper.GetPacificTime(_Game.Date).ToShortDateString = _selectedDate.ToShortDateString() Then
        '    _Game.HomeStream.CheckDuplicate(args.CDN)
        'End If

        args.Stream = _Game.HomeStream
        _Game.Watch(args)
    End Sub

    Private Sub lblAwayStream_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblAwayStream.LinkClicked
        Dim args = WatchArgs()

        If DateHelper.GetPacificTime(_Game.Date).ToShortDateString <> DateHelper.GetPacificTime().ToShortDateString() Then
            _Game.AwayStream.CheckVOD(args.CDN)
            args.IsVOD = _Game.AwayStream.IsVOD
        End If

        'If DateHelper.GetPacificTime(_Game.Date).ToShortDateString = _selectedDate.ToShortDateString() Then
        '    _Game.AwayStream.CheckDuplicate(args.CDN)
        'End If

        args.Stream = _Game.AwayStream
        _Game.Watch(args)
    End Sub

    Private Sub lblFrenchStream_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblFrenchStream.LinkClicked
        Dim args = WatchArgs()

        If DateHelper.GetPacificTime(_Game.Date).ToShortDateString <> DateHelper.GetPacificTime().ToShortDateString() Then
            _Game.FrenchStream.CheckVOD(args.CDN)
            args.IsVOD = _Game.FrenchStream.IsVOD
        End If

        'If DateHelper.GetPacificTime(_Game.Date).ToShortDateString = _selectedDate.ToShortDateString() Then
        '    _Game.FrenchStream.CheckDuplicate(args.CDN)
        'End If

        args.Stream = _Game.FrenchStream
        _Game.Watch(args)
    End Sub

    Private Sub lblNationalStream_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblNationalStream.LinkClicked
        Dim args = WatchArgs()

        If DateHelper.GetPacificTime(_Game.Date).ToShortDateString <> DateHelper.GetPacificTime().ToShortDateString() Then
            _Game.NationalStream.CheckVOD(args.CDN)
            args.IsVOD = _Game.NationalStream.IsVOD
        End If

        'If DateHelper.GetPacificTime(_Game.Date).ToShortDateString = _selectedDate.ToShortDateString() Then
        '    _Game.NationalStream.CheckDuplicate(args.CDN)
        'End If

        args.Stream = _Game.NationalStream
        _Game.Watch(args)
    End Sub

    Private Sub lblMultiCam1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblMultiCam1.LinkClicked
        Dim args = WatchArgs()

        If DateHelper.GetPacificTime(_Game.Date).ToShortDateString <> DateHelper.GetPacificTime().ToShortDateString() Then
            _Game.MultiCam1Stream.CheckVOD(args.CDN)
            args.IsVOD = _Game.MultiCam1Stream.IsVOD
        End If

        'If DateHelper.GetPacificTime(_Game.Date).ToShortDateString = _selectedDate.ToShortDateString() Then
        '    _Game.NationalStream.CheckDuplicate(args.CDN)
        'End If

        args.Stream = _Game.MultiCam1Stream
        _Game.Watch(args)
    End Sub

    Private Sub lblMultiCam2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblMultiCam2.LinkClicked
        Dim args = WatchArgs()

        If DateHelper.GetPacificTime(_Game.Date).ToShortDateString <> DateHelper.GetPacificTime().ToShortDateString() Then
            _Game.MultiCam2Stream.CheckVOD(args.CDN)
            args.IsVOD = _Game.MultiCam2Stream.IsVOD
        End If

        'If DateHelper.GetPacificTime(_Game.Date).ToShortDateString = _selectedDate.ToShortDateString() Then
        '    _Game.NationalStream.CheckDuplicate(args.CDN)
        'End If

        args.Stream = _Game.MultiCam2Stream
        _Game.Watch(args)
    End Sub

    Private Sub lblRefCam_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRefCam.LinkClicked
        Dim args = WatchArgs()

        If DateHelper.GetPacificTime(_Game.Date).ToShortDateString <> DateHelper.GetPacificTime().ToShortDateString() Then
            _Game.RefCamStream.CheckVOD(args.CDN)
            args.IsVOD = _Game.RefCamStream.IsVOD
        End If

        'If DateHelper.GetPacificTime(_Game.Date).ToShortDateString = _selectedDate.ToShortDateString() Then
        '    _Game.NationalStream.CheckDuplicate(args.CDN)
        'End If

        args.Stream = _Game.RefCamStream
        _Game.Watch(args)
    End Sub

    Private Sub lblEndzoneCam1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblEndzoneCam1.LinkClicked
        Dim args = WatchArgs()

        If DateHelper.GetPacificTime(_Game.Date).ToShortDateString <> DateHelper.GetPacificTime().ToShortDateString() Then
            _Game.EndzoneCam1Stream.CheckVOD(args.CDN)
            args.IsVOD = _Game.EndzoneCam1Stream.IsVOD
        End If

        'If DateHelper.GetPacificTime(_Game.Date).ToShortDateString = _selectedDate.ToShortDateString() Then
        '    _Game.NationalStream.CheckDuplicate(args.CDN)
        'End If

        args.Stream = _Game.EndzoneCam1Stream
        _Game.Watch(args)
    End Sub
    Private Sub lblEndzoneCam2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblEndzoneCam2.LinkClicked
        Dim args = WatchArgs()

        If DateHelper.GetPacificTime(_Game.Date).ToShortDateString <> DateHelper.GetPacificTime().ToShortDateString() Then
            _Game.EndzoneCam2Stream.CheckVOD(args.CDN)
            args.IsVOD = _Game.EndzoneCam2Stream.IsVOD
        End If

        'If DateHelper.GetPacificTime(_Game.Date).ToShortDateString = _selectedDate.ToShortDateString() Then
        '    _Game.NationalStream.CheckDuplicate(args.CDN)
        'End If

        args.Stream = _Game.EndzoneCam2Stream
        _Game.Watch(args)
    End Sub

    Private Function WatchArgs() As Game.GameWatchArguments
        Dim args = ApplicationSettings.Read(Of Game.GameWatchArguments)(ApplicationSettings.Settings.DefaultWatchArgs)
        args.GameTitle = _Game.AwayAbbrev & " @ " & _Game.HomeAbbrev
        Return args
    End Function
End Class

