Imports System.Globalization
Imports System.IO
Imports System.Threading
Imports Newtonsoft.Json.Linq
Imports NHLGames.TextboxConsoleOutputRediect
Imports System

Public Class NHLGames

    Private AvailableGames As New List(Of String)
    Private Games As New List(Of Game)

    Private ReadOnly Property SelectedGame As Game
        Get
            Dim selectedGameID As String = gridGames.SelectedRows(0).Cells(0).Value
            Return Games.Find(Function(val) val.Id.ToString() = selectedGameID)
        End Get
    End Property
    Private Sub VersionCheck()
        Dim settingsReader As New Configuration.AppSettingsReader

        Dim strLatest = Downloader.DownloadApplicationVersion()

        If strLatest > settingsReader.GetValue("version", GetType(String)) Then
            lblVersion.Text = "Version " & strLatest & " available! You are running " & settingsReader.GetValue("version", GetType(String)) & "."
            lblVersion.ForeColor = Color.Red
        Else
            lblVersion.Text = "Up to date! You are running " & settingsReader.GetValue("version", GetType(String)) & "."
            lblVersion.ForeColor = Color.Green
        End If
    End Sub

    Private Sub NHLGames_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Setup redirecting console.out to 
        Dim _writer = New TextBoxStreamWriter(RichTextBox)
        Console.SetOut(_writer)

        VersionCheck()
        dtDate.Value = DateTime.Now()

    End Sub

    Private Sub dtDate_ValueChanged(sender As Object, e As EventArgs) Handles dtDate.ValueChanged
        LoadGames(dtDate.Value)
    End Sub

    Private Sub LoadGames(dateTime As DateTime)

        SetupBaseColumns()

        Dim row As String()
        Try

            Dim JSONSchedule As JObject = Downloader.DownloadJSONSchedule(dateTime)
            AvailableGames = Downloader.DownloadAvailableGames()
            GameManager.RefreshGames(dateTime, JSONSchedule, AvailableGames)

            For Each game As Game In GameManager.GamesList

                'Dim newRow As DataGridViewRow = gridGames.Rows(0).Clone()

                'newRow.Cells("GameID").Value = game.Id.ToString()
                'newRow.Cells("time").Value = game.Date.ToLocalTime().ToString("h:mm tt")
                'newRow.Cells("away").Value = game.AwayTeam
                'newRow.Cells("awayAbbrev").Value = game.AwayAbbrev
                'newRow.Cells("home").Value = game.HomeTeam
                'newRow.Cells("homeAbbrev").Value = game.HomeAbbrev
                'newRow.Cells("awayLIVE").Value = game.AwayStream.GameURL
                'newRow.Cells("awayVOD").Value = game.AwayStream.VODURL
                'newRow.Cells("awayLIVEStatus").Value = game.AwayStream.Availability
                'newRow.Cells("homeLIVE").Value = game.HomeStream.GameURL
                'newRow.Cells("homeVOD").Value = game.HomeStream.VODURL
                'newRow.Cells("homeLIVEStatus").Value = game.HomeStream.Availability
                'newRow.Cells("nationalLIVE").Value = game.NationalStream.GameURL
                'newRow.Cells("nationalVOD").Value = game.NationalStream.VODURL
                'newRow.Cells("nationalLIVEStatus").Value = game.NationalStream.Availability
                'newRow.Cells("frenchLIVE").Value = game.FrenchStream.GameURL
                'newRow.Cells("frenchVOD").Value = game.FrenchStream.Availability

                ''row = {game.Id.ToString(), game.Date.ToLocalTime().ToString("h:mm tt"), game.AwayTeam, game.AwayAbbrev, game.HomeTeam, game.HomeAbbrev,  game.AwayStream.GameURL, game.AwayStream.VODURL, game.AwayStream.Availability, game.HomeStream.GameURL, game.HomeStream.VODURL, game.HomeStream.Availability, game.NationalStream.GameURL, game.NationalStream.VODURL, game.NationalStream.Availability, game.FrenchStream.GameURL, game.FrenchStream.VODURL, game.FrenchStream.Availability}
                'gridGames.Rows.Add(newRow)
                gridGames.Rows.Insert(gridGames.Rows.Count,
                                      game.Id.ToString(),
                                      game.Date.ToLocalTime().ToString("h:mm tt"),
                                      ImageFetcher.GetEmbeddedImage(game.AwayTeamLogo),
                                        ImageFetcher.GetEmbeddedImage(game.HomeTeamLogo),
                game.AwayTeam,
                                      game.AwayAbbrev,
                                      game.HomeTeam,
                                      game.HomeAbbrev,
                                      game.AwayStream.GameURL,
                                      game.AwayStream.VODURL,
                                      game.AwayStream.Availability,
                                      game.HomeStream.GameURL,
                                      game.HomeStream.VODURL,
                                      game.HomeStream.Availability,
                                      game.NationalStream.GameURL,
                                      game.NationalStream.VODURL,
                                      game.NationalStream.Availability,
                                      game.FrenchStream.GameURL,
                                      game.FrenchStream.VODURL,
                                      game.FrenchStream.Availability
                                      )

            Next



            UpdateCellColors()

        Catch ex As ArgumentOutOfRangeException
            row = {"No Games"}
            gridGames.Rows.Add(row)
        Catch ex As NullReferenceException
            row = {"No Games"}
            gridGames.Rows.Add(row)
        End Try
    End Sub

    Private Sub UpdateCellColors()

        For Each row As DataGridViewRow In gridGames.Rows
            For Each cell As DataGridViewCell In row.Cells
                If TypeOf cell Is DataGridViewTextBoxCell Then
                    If cell.Value = "Available" Then
                        cell.Style.ForeColor = Color.Green
                    ElseIf cell.Value = "Unavailable" Then
                        cell.Style.ForeColor = Color.Red
                    End If
                End If
            Next
        Next

    End Sub

    Private Sub SetupBaseColumns()

        gridGames.Columns.Clear()
        gridGames.Rows.Clear()

        gridGames.CellBorderStyle = DataGridViewCellBorderStyle.None

        gridGames.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "GameID", .HeaderText = "Game ID", .Visible = False, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "time", .HeaderText = "Time", .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})

        gridGames.Columns.Add(New DataGridViewImageColumn() With {.Name = "AwayLogo", .HeaderText = "Away Team", .ImageLayout = DataGridViewImageCellLayout.Zoom, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewImageColumn() With {.Name = "HomeLogo", .HeaderText = "Home Team", .ImageLayout = DataGridViewImageCellLayout.Zoom, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})

        gridGames.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "away", .HeaderText = "Away Team", .Visible = False, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "awayAbbrev", .HeaderText = "Away Abbrev", .Visible = False, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "home", .HeaderText = "Home Team", .Visible = False, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "homeAbbrev", .HeaderText = "Home Abbrev", .Visible = False, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "awayLIVE", .HeaderText = "Away URL", .Visible = False, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "awayVOD", .HeaderText = "Away VOD", .Visible = False, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewLinkColumn() With {.Name = "awayLIVEStatus", .HeaderText = "Away", .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "homeLIVE", .HeaderText = "Home URL", .Visible = False, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "homeVOD", .HeaderText = "Home VOD", .Visible = False, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewLinkColumn() With {.Name = "homeLIVEStatus", .HeaderText = "Home", .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "nationalLIVE", .HeaderText = "National URL", .Visible = False, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "nationalVOD", .HeaderText = "National VOD", .Visible = False, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewLinkColumn() With {.Name = "nationalLIVEStatus", .HeaderText = "National", .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "frenchLIVE", .HeaderText = "French URL", .Visible = False, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "frenchVOD", .HeaderText = "French VOD", .Visible = False, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
        gridGames.Columns.Add(New DataGridViewLinkColumn() With {.Name = "frenchLIVEStatus", .HeaderText = "French", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill})


        'gridGames.Columns.Add(New DataGridViewImageColumn() With {.Name = "frenchVOD", .HeaderText = "French VOD", .Visible = False, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})



        For Each column As DataGridViewColumn In gridGames.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

    End Sub

    Private Sub gridGames_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridGames.CellClick

        If e.RowIndex > -1 AndAlso e.ColumnIndex > -1 Then
            If TypeOf gridGames.Rows(e.RowIndex).Cells(e.ColumnIndex) Is DataGridViewLinkCell Then



                Dim cellText As String = gridGames.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                If cellText = "Watch" Then

                    Dim selectedGameID As String = gridGames.Rows(e.RowIndex).Cells(0).Value
                    Dim game As Game = Games.Find(Function(val) val.Id.ToString() = selectedGameID)


                    If (gridGames.Columns(e.ColumnIndex).Name = "awayLIVEStatus") Then
                        WatchGame(rbLive.Checked = False, game, GameStream.StreamType.Away)
                    ElseIf (gridGames.Columns(e.ColumnIndex).Name = "homeLIVEStatus") Then
                        WatchGame(rbLive.Checked = False, game, GameStream.StreamType.Home)
                    ElseIf (gridGames.Columns(e.ColumnIndex).Name = "nationalLIVEStatus") Then
                        WatchGame(rbLive.Checked = False, game, GameStream.StreamType.National)
                    ElseIf (gridGames.Columns(e.ColumnIndex).Name = "frenchLIVEStatus") Then
                        WatchGame(rbLive.Checked = False, game, GameStream.StreamType.French)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        VersionCheck()
        LoadGames(dtDate.Value)
    End Sub

    Private Sub btnHosts_Click(sender As Object, e As EventArgs) Handles btnHosts.Click

        HostsFile.AddEntry("82.196.2.27", "mf.svc.nhl.com")

    End Sub

    Private Sub btnWatch_Click(sender As Object, e As EventArgs) Handles btnWatch.Click
        'If rbLive.Checked Then
        '    WatchGame(False)
        'Else
        '    WatchGame(True)
        'End If
    End Sub

    Private Sub gridGames_SelectionChanged(sender As Object, e As EventArgs) Handles gridGames.SelectionChanged

        'With inline watch links, not needed anymore
        gridGames.ClearSelection()

    End Sub

    Private Sub WatchGame(isVOD As Boolean, game As Game, streamType As GameStream.StreamType)



        Dim args As New Game.GameWatchArguments
        args.IsVOD = isVOD
        Dim cdn As String = String.Empty


        If rbLevel3.Checked Then
            args.CDN = "l3c"
        ElseIf rbAkamai.Checked Then
            args.CDN = "akc"
        End If

        If rbQual1.Checked Then
            args.Quality = "224p"
        ElseIf rbQual2.Checked Then
            args.Quality = "288p"
        ElseIf rbQual3.Checked Then
            args.Quality = "360p"
        ElseIf rbQual4.Checked Then
            args.Quality = "504p"
        ElseIf rbQual5.Checked Then
            args.Quality = "540p"
        ElseIf rbQual6.Checked Then
            args.Quality = "720p"
            If chk60.Checked Then
                args.Is60FPS = True
                args.Quality = "best"
            End If
        End If

        If streamType = GameStream.StreamType.Away Then
            args.Stream = game.AwayStream
        ElseIf streamType = GameStream.StreamType.Home Then
            args.Stream = game.HomeStream
        ElseIf streamType = GameStream.StreamType.National Then
            args.Stream = game.NationalStream
        ElseIf streamType = GameStream.StreamType.French Then
            args.Stream = game.FrenchStream
        End If

        args.IsMPC = rbMPC.Checked
        If rbMPC.Checked Then
            args.PlayerPath = FileAccess.LocateEXE("mpc-hc64.exe", "\MPC-HC")
        Else
            args.PlayerPath = FileAccess.LocateEXE("vlc.exe", "\VideoLAN\VLC")
        End If


        Task.Run(Of Boolean)((Function()
                                  game.Watch(args)
                                  Return True
                              End Function))


    End Sub


    Private Sub chk60_CheckedChanged(sender As Object, e As EventArgs) Handles chk60.CheckedChanged
        If rbQual6.Checked = False And chk60.Checked = True Then
            rbQual6.Checked = True
        End If
    End Sub

    Private Sub rbQual1_CheckedChanged(sender As Object, e As EventArgs) Handles rbQual1.CheckedChanged
        If rbQual1.Checked = True Then
            chk60.Checked = False
        End If
    End Sub

    Private Sub rbQual2_CheckedChanged(sender As Object, e As EventArgs) Handles rbQual2.CheckedChanged
        If rbQual2.Checked = True Then
            chk60.Checked = False
        End If
    End Sub

    Private Sub rbQual3_CheckedChanged(sender As Object, e As EventArgs) Handles rbQual3.CheckedChanged
        If rbQual3.Checked = True Then
            chk60.Checked = False
        End If
    End Sub

    Private Sub rbQual4_CheckedChanged(sender As Object, e As EventArgs) Handles rbQual4.CheckedChanged
        If rbQual4.Checked = True Then
            chk60.Checked = False
        End If
    End Sub

    Private Sub rbQual5_CheckedChanged(sender As Object, e As EventArgs) Handles rbQual5.CheckedChanged
        If rbQual5.Checked = True Then
            chk60.Checked = False
        End If
    End Sub

    Private Sub btnURL_Click(sender As Object, e As EventArgs) Handles btnURL.Click
        Dim strUrl As String = String.Empty
        Dim strServer As String = String.Empty
        Dim strCDN As String = String.Empty

        If rbLive.Checked Then
            strServer = "LIVE"
        Else
            strServer = "VOD"
        End If

        If rbLevel3.Checked Then
            strCDN = "l3c"
        Else
            strCDN = "akc"
        End If

        'If rbMPC.Checked Then
        '    strUrl = gridGames.SelectedRows(0).Cells("home" & strServer).Value.Replace("CDN", strCDN)
        'ElseIf rbVLC.Checked Then
        '    strUrl = gridGames.SelectedRows(0).Cells("away" & strServer).Value.Replace("CDN", strCDN)
        'ElseIf rbNational.Checked Then
        '    strUrl = gridGames.SelectedRows(0).Cells("national" & strServer).Value.Replace("CDN", strCDN)
        'ElseIf rbFrench.Checked Then
        '    strUrl = gridGames.SelectedRows(0).Cells("french" & strServer).Value.Replace("CDN", strCDN)
        'End If

        'Dim dialogURL As New dlURL(strUrl)
        'dialogURL.ShowDialog()
    End Sub

    Private Sub NHLGames_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        'gridGames.Refresh()
    End Sub

    Private Sub gridGames_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles gridGames.DataBindingComplete
        For Each row As DataGridViewRow In gridGames.Rows
            For Each cell As DataGridViewCell In row.Cells
                If TypeOf cell Is DataGridViewImageCell Then
                    cell.Value = ImageFetcher.GetEmbeddedImage(cell.Value)

                End If
            Next


        Next

    End Sub

    Private Sub gridGames_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles gridGames.CellFormatting
        If TypeOf gridGames.Columns(e.ColumnIndex) Is DataGridViewImageColumn Then
            Dim game As Game = Games.Find(Function(val) val.Id.ToString() = gridGames.Rows(e.RowIndex).Cells(0).Value)

            Dim cell As DataGridViewCell = gridGames.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If gridGames.Columns(e.ColumnIndex).Name = "HomeLogo" Then
                cell.ToolTipText = game.HomeTeam
            ElseIf gridGames.Columns(e.ColumnIndex).Name = "AwayLogo" Then
                cell.ToolTipText = game.AwayTeam
            End If
        End If
    End Sub

    Private Sub RichTextBox_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox.TextChanged
        RichTextBox.SelectionStart = RichTextBox.Text.Length
        RichTextBox.ScrollToCaret()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkVLCDownload.LinkClicked
        Dim sInfo As ProcessStartInfo = New ProcessStartInfo("http://www.videolan.org/vlc/download-windows.html")
        Process.Start(sInfo)
    End Sub

    Private Sub lnkMPCDownload_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkMPCDownload.LinkClicked
        Dim sInfo As ProcessStartInfo = New ProcessStartInfo("https://mpc-hc.org/downloads/")
        Process.Start(sInfo)

    End Sub
End Class
