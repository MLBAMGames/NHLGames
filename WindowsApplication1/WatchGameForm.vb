Imports System.ComponentModel
Imports NHLGames.Game

Public Class WatchGameForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(game As Game, watchArgs As GameWatchArguments)


        ' This call is required by the designer.
        InitializeComponent()

        _Game = game
        _WatchArgs = watchArgs

    End Sub
    Private _WatchArgs As GameWatchArguments
    Public Property WatchArgs As GameWatchArguments
        Get
            Return _WatchArgs
        End Get
        Set(value As GameWatchArguments)
            If value IsNot Nothing Then
                _WatchArgs = value
                BindForm()
            End If
        End Set
    End Property

    Private _Game As Game
    Public Property Game As Game
        Get
            Return _Game
        End Get
        Set(value As Game)
            If value IsNot Nothing Then
                _Game = value
                BindForm()
            End If
        End Set
    End Property

    Private Sub BindForm()

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

            If WatchArgs.IsVOD Then
                rbVOD.Checked = True
            Else
                rbLive.Checked = True
            End If

            If WatchArgs.Stream IsNot Nothing Then
                Dim streamType As GameStream.StreamType = WatchArgs.Stream.Type
                Select Case streamType
                    Case GameStream.StreamType.Away
                        rbAway.Checked = True
                    Case GameStream.StreamType.French
                        rbFrench.Checked = True
                    Case GameStream.StreamType.Home
                        rbHome.Checked = True
                    Case GameStream.StreamType.National
                        rbNational.Checked = True
                End Select
            End If

            rbVLC.Checked = WatchArgs.PlayerType = GameWatchArguments.PlayerTypeEnum.VLC
            rbMPC.Checked = WatchArgs.PlayerType = GameWatchArguments.PlayerTypeEnum.MPC

            If WatchArgs.UsePlayerArgs Then
                chkEnablePlayerArgs.Checked = True
                txtPlayerArgs.Text = WatchArgs.PlayerArgs
            Else
                txtPlayerArgs.Enabled = False
            End If

            If WatchArgs.UseLiveStreamerArgs Then
                chkEnableStreamArgs.Checked = True
                txtStreamerArgs.Text = WatchArgs.LiveStreamerArgs
            Else
                txtStreamerArgs.Enabled = False
            End If

            If WatchArgs.UseOutputArgs Then
                chkEnableOutput.Checked = True
                txtOutputPath.Text = WatchArgs.PlayerOutputPath
            Else
                txtOutputPath.Enabled = False
            End If


        End If

        If Game IsNot Nothing Then
            rbAway.Enabled = Game.AwayStream.IsAvailable
            rbNational.Enabled = Game.NationalStream.IsAvailable
            rbFrench.Enabled = Game.FrenchStream.IsAvailable
            rbHome.Enabled = Game.HomeStream.IsAvailable
        End If

        pnlAdvanced.Visible = ApplicationSettings.Read(Of Boolean)(ApplicationSettings.Settings.ShowAdvancedWatchPanel, False)

    End Sub
    Private Sub SetEventArgsFromForm()

        WatchArgs.Is60FPS = chk60.Checked

        If rbQual6.Checked Then
            WatchArgs.Quality = "720p"
        ElseIf rbQual5.Checked
            WatchArgs.Quality = "540p"
        ElseIf rbQual4.Checked
            WatchArgs.Quality = "504p"
        ElseIf rbQual3.Checked
            WatchArgs.Quality = "360p"
        ElseIf rbQual2.Checked
            WatchArgs.Quality = "288p"
        ElseIf rbQual1.Checked
            WatchArgs.Quality = "224p"
        End If

        WatchArgs.IsVOD = rbVOD.Checked

        rbAway.Enabled = _Game.AwayStream.IsAvailable
        rbNational.Enabled = _Game.NationalStream.IsAvailable
        rbFrench.Enabled = _Game.FrenchStream.IsAvailable
        rbHome.Enabled = _Game.HomeStream.IsAvailable

        If rbAway.Checked = True Then
            WatchArgs.Stream = Game.AwayStream
        ElseIf rbNational.Checked = True
            WatchArgs.Stream = Game.NationalStream
        ElseIf rbFrench.Checked = True
            WatchArgs.Stream = Game.FrenchStream
        ElseIf rbHome.Checked = True
            WatchArgs.Stream = Game.HomeStream
        End If

        If rbMPC.Checked Then

            WatchArgs.PlayerType = GameWatchArguments.PlayerTypeEnum.MPC
            WatchArgs.PlayerPath = ApplicationSettings.Read(Of String)(ApplicationSettings.Settings.MPCPath)
        Else

            WatchArgs.PlayerType = GameWatchArguments.PlayerTypeEnum.VLC
            WatchArgs.PlayerPath = ApplicationSettings.Read(Of String)(ApplicationSettings.Settings.VLCPath)
        End If

        If rbAkamai.Checked Then
            WatchArgs.CDN = "akc"
        ElseIf rbLevel3.Checked
            WatchArgs.CDN = "l3c"
        End If

        WatchArgs.UsePlayerArgs = chkEnablePlayerArgs.Checked
        WatchArgs.PlayerArgs = txtPlayerArgs.Text

        WatchArgs.UseLiveStreamerArgs = chkEnableStreamArgs.Checked
        WatchArgs.LiveStreamerArgs = txtStreamerArgs.Text

        WatchArgs.UseOutputArgs = chkEnableOutput.Checked
        WatchArgs.PlayerOutputPath = txtOutputPath.Text

        ApplicationSettings.SetValue(ApplicationSettings.Settings.ShowAdvancedWatchPanel, pnlAdvanced.Visible)
        ApplicationSettings.SetValue(ApplicationSettings.Settings.DefaultWatchArgs, Serialization.SerializeObject(Of GameWatchArguments)(WatchArgs))

    End Sub

    'Public Sub New(game As Game, args As GameWatchArguments)
    '    InitializeComponent()
    '    'WatchGameControl1.WatchArgs = args
    '    'WatchGameControl1.Game = game
    '    'Me.Text = "Watch Game"
    '    'Me.Focus()
    '    'WatchGameControl1.btnWatch.Focus()



    'End Sub


    Private Sub lnkVLCDownload_Click(sender As Object, e As EventArgs) Handles lnkVLCDownload.Click
        Dim sInfo As ProcessStartInfo = New ProcessStartInfo("http://www.videolan.org/vlc/download-windows.html")
        Process.Start(sInfo)
    End Sub

    Private Sub lnkMPCDownload_Click(sender As Object, e As EventArgs) Handles lnkMPCDownload.Click
        Dim sInfo As ProcessStartInfo = New ProcessStartInfo("https://mpc-hc.org/downloads/")
        Process.Start(sInfo)
    End Sub

    Private Sub lnkShowAdvanced_Click(sender As Object, e As EventArgs) Handles lnkShowAdvanced.Click
        pnlAdvanced.Visible = Not pnlAdvanced.Visible
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub WatchGameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnWatch.Focus()

        ' Add any initialization after the InitializeComponent() call.

        Dim watchArgsStr As String = ApplicationSettings.Read(Of String)(ApplicationSettings.Settings.DefaultWatchArgs)
        Dim watchArgs As GameWatchArguments = New GameWatchArguments

        If String.IsNullOrEmpty(watchArgsStr) = False Then
            Try
                watchArgs = Serialization.DeserializeObject(Of GameWatchArguments)(watchArgsStr)
            Catch ex As Exception
                Console.WriteLine("Error: Failed to re-create watch args" & vbCr & ex.ToString())
            End Try

        End If

        _WatchArgs = watchArgs
        BindForm()
    End Sub

    Private Sub btnWatch_Click(sender As Object, e As EventArgs) Handles btnWatch.Click
        SetEventArgsFromForm()
        Game.Watch(WatchArgs)
        Me.Close()
    End Sub

    Private Sub WatchGameForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SetEventArgsFromForm()
    End Sub

    Private Sub chkEnableOutput_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableOutput.CheckedChanged
        txtOutputPath.Enabled = chkEnableOutput.Checked
    End Sub

    Private Sub chkEnablePlayerArgs_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnablePlayerArgs.CheckedChanged
        txtPlayerArgs.Enabled = chkEnablePlayerArgs.Checked
    End Sub

    Private Sub chkEnableStreamArgs_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableStreamArgs.CheckedChanged
        txtStreamerArgs.Enabled = chkEnableStreamArgs.Checked
    End Sub
End Class