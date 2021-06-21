Imports MetroFramework
Imports MetroFramework.Controls
Imports NHLGames.NHLStats

Namespace Utilities

    Public Class StandingsHelper

        Public Shared Sub GenerateStandings(tbStanding As MetroTabControl, season As Season)
            tbStanding.Controls.Clear()
            GenerateLeagueStandings(tbStanding, season)

            If (season.conferencesInUse) Then
                GenerateConferenceStandings(tbStanding, season)
            End If

            If (season.divisionsInUse) Then
                GenerateDivisionStandings(tbStanding, season)
            End If

            If (season.wildCardInUse) Then
                GenerateWildCardStandings(tbStanding, season)
            End If
        End Sub

        Private Shared Sub GenerateLeagueStandings(tbStanding As MetroTabControl, season As Season)
            Dim metroTabPage = GeneratMetroTabPage(StandingTypeEnum.League, season)

            If metroTabPage IsNot Nothing Then
                metroTabPage.Text = NHLGamesMetro.RmText.GetString("tabLeagueStandings")
                tbStanding.Controls.Add(metroTabPage)
            End If
        End Sub

        Private Shared Sub GenerateConferenceStandings(tbStanding As MetroTabControl, season As Season)
            Dim metroTabPage = GeneratMetroTabPage(StandingTypeEnum.Conference, season)

            If metroTabPage IsNot Nothing Then
                metroTabPage.Text = NHLGamesMetro.RmText.GetString("tabConferenceStandings")
                tbStanding.Controls.Add(metroTabPage)
            End If
        End Sub

        Private Shared Sub GenerateDivisionStandings(tbStanding As MetroTabControl, season As Season)
            Dim metroTabPage = GeneratMetroTabPage(StandingTypeEnum.Division, season)

            If metroTabPage IsNot Nothing Then
                metroTabPage.Text = NHLGamesMetro.RmText.GetString("tabDivisionStandings")
                tbStanding.Controls.Add(metroTabPage)
            End If
        End Sub

        Private Shared Sub GenerateWildCardStandings(tbStanding As MetroTabControl, season As Season)
            Dim metroTabPage = GeneratMetroTabPage(StandingTypeEnum.WildCard, season)

            If metroTabPage IsNot Nothing Then
                metroTabPage.Text = NHLGamesMetro.RmText.GetString("tabWildCardStandings")
                tbStanding.Controls.Add(metroTabPage)
            End If

        End Sub

        Private Shared Function GeneratMetroTabPage(standingType As StandingTypeEnum, season As Season) As MetroTabPage

            Dim standing As Standing = Standing.GetCurrentStandings(standingType, season.seasonId)

            If (standing.records.Count <> 0) Then
                Dim metroTabPage As MetroTabPage = New MetroTabPage()
                metroTabPage.Padding = New Padding(5)

                If NHLGamesMetro.IsDarkMode Then
                    metroTabPage.Theme = MetroThemeStyle.Dark
                End If

                Dim tableLayoutPanel As TableLayoutPanel = New TableLayoutPanel()
                tableLayoutPanel.Dock = DockStyle.Fill
                tableLayoutPanel.BorderStyle = BorderStyle.None
                tableLayoutPanel.AutoScroll = True

                metroTabPage.Controls.Add(tableLayoutPanel)

                For Each record As Record In standing.records
                    Dim dataSource = StandingsViewModel.GenerateViewModels(standingType, record)

                    Dim metroGrid As MetroGrid = New MetroGrid()
                    If NHLGamesMetro.IsDarkMode Then
                        metroGrid.Theme = MetroThemeStyle.Dark
                    End If

                    metroGrid.DefaultCellStyle.SelectionBackColor = metroGrid.DefaultCellStyle.BackColor
                    metroGrid.DefaultCellStyle.SelectionForeColor = metroGrid.DefaultCellStyle.ForeColor
                    metroGrid.Dock = DockStyle.Fill
                    metroGrid.RowHeadersVisible = False
                    metroGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    metroGrid.AllowUserToResizeColumns = True
                    metroGrid.EditMode = DataGridViewEditMode.EditProgrammatically
                    metroGrid.Padding = New Padding(0, 0, 0, 20)
                    metroGrid.DataSource = dataSource
                    metroGrid.RowTemplate.Height = 30

                    Dim teamColumn As TeamColumn = New TeamColumn()
                    teamColumn.HeaderText = dataSource(0).RowHeader.ToString()
                    teamColumn.DataPropertyName = NameOf(StandingViewModel.RowHeader)
                    teamColumn.MinimumWidth = 200

                    metroGrid.Columns.Add(teamColumn)
                    Dim height = (dataSource.Count * metroGrid.RowTemplate.Height) + 30
                    metroGrid.MinimumSize = New Size(100, height)

                    AddHandler metroGrid.ColumnAdded, AddressOf ColumnAddedEventHandler
                    AddHandler metroGrid.CellFormatting, AddressOf CellFormatting

                    tableLayoutPanel.Controls.Add(metroGrid)
                Next

                Return metroTabPage
            End If

            Return Nothing
        End Function

        Private Shared Sub ColumnAddedEventHandler(sender As Object, e As DataGridViewColumnEventArgs)
            If (e.Column.Index <> 0) Then
                e.Column.HeaderText = NHLGamesMetro.RmText.GetString(String.Format("grLbl{0}", e.Column.DataPropertyName))
            End If
        End Sub

        Private Shared Sub CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs)
            Dim metroGrid As MetroGrid = CType(sender, MetroGrid)

            If (metroGrid.Columns(e.ColumnIndex).DataPropertyName = NameOf(StandingViewModel.DIFF)) Then
                If (Convert.ToInt32(e.Value) > 0) Then
                    e.CellStyle.ForeColor = Color.Green
                Else
                    e.CellStyle.ForeColor = Color.Red
                End If
            End If
        End Sub

    End Class

End Namespace
