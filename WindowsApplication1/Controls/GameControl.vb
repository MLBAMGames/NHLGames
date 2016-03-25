Imports NHLGames.Game

Public Class GameControl

    Private _Game As Game
    Public Sub New(Game As Game, showScores As Boolean)
        InitializeComponent()

        _Game = Game

        SetInitialProperties(Game)
        UpdateGameStatusProperties(Game)

        lblAwayScore.Visible = showScores
        lblHomeScore.Visible = showScores

        AddHandler _Game.GameUpdated, AddressOf GameUpdatedHandler

    End Sub

    Private Sub UpdateGameStatusProperties(Game As Game)
        lblAwayScore.Text = Game.AwayScore
        lblAwayTeam.Text = Game.AwayAbbrev

        lblHomeScore.Text = Game.HomeScore
        lblHomeTeam.Text = Game.HomeAbbrev

        btnWatch.Enabled = Game.Date <= DateTime.Now 'AndAlso Game.GameIsLive

        If Game.Date <= DateTime.Now AndAlso Game.GameIsLive Then
            BorderPanel1.BorderColour = Color.Green
            'lblVS.Visible = True
        ElseIf Game.Date <= DateTime.Now
            BorderPanel1.BorderColour = Color.LightGray
            'lblVS.Visible = True
        Else
            BorderPanel1.BorderColour = Color.DarkGray
            'lblVS.Visible = False
        End If
    End Sub

    Private Sub SetInitialProperties(Game As Game)
        picHome.SizeMode = PictureBoxSizeMode.StretchImage
        If String.IsNullOrEmpty(Game.HomeTeamLogo) = False Then
            picHome.Image = ImageFetcher.GetEmbeddedImage(Game.HomeTeamLogo)
        End If


        picAway.SizeMode = PictureBoxSizeMode.StretchImage
        If String.IsNullOrEmpty(Game.AwayTeamLogo) = False Then
            picAway.Image = ImageFetcher.GetEmbeddedImage(Game.AwayTeamLogo)
        End If

        lblTime.Text = Game.Date.ToString("h:mm tt")
    End Sub

    Private Sub btnWatch_Click(sender As Object, e As EventArgs) Handles btnWatch.Click
        Dim newForm As New WatchGameForm(_Game, New GameWatchArguments())
        newForm.ShowDialog(Me)
        'newForm.WatchGameControl.btnWatch.Focus()
    End Sub

    Private Sub GameUpdatedHandler(game As Game)
        _Game = game
        UpdateGameStatusProperties(game)
    End Sub
End Class

