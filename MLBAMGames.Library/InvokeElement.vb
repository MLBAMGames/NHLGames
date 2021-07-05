Imports System.Windows.Forms
Imports MetroFramework
Imports MLBAMGames.Library.Controls
Imports MLBAMGames.Library.NHLStats
Imports MLBAMGames.Library.Objects
Imports Newtonsoft.Json

Namespace Utilities
    Public Class InvokeElement
        Public Shared AnimateTipsTick As Integer = 0
        Public Const AnimateTipsEveryTick As Integer = 10000

        Public Shared Async Sub LoadGames(gameDate As Date)
            Instance.Form.ClearGamePanel()
            Await Task.Run(Async Function()
                               Await GameFetcher.LoadGames(gameDate)
                           End Function).ConfigureAwait(False)
        End Sub

        Public Shared Sub SetFormStatusLabel(msg As String)
            If Instance.Form.InvokeRequired Then
                Dim asyncResult =
                        Instance.Form.BeginInvoke(New Action(Of String)(AddressOf SetFormStatusLabel), msg)
                EndInvokeOf(asyncResult)
            Else
                Instance.Form.lblStatus.Text = msg
            End If
        End Sub

        Public Shared Sub SetGameTabControls(enabled As Boolean)
            If Instance.Form.InvokeRequired Then
                Dim asyncResult =
                        Instance.Form.BeginInvoke(New Action(Of Boolean)(AddressOf SetGameTabControls),
                                                               enabled)
                EndInvokeOf(asyncResult)
            Else
                Instance.Form.btnDate.Enabled = enabled
                Instance.Form.btnTomorrow.Enabled = enabled
                Instance.Form.btnYesterday.Enabled = enabled
            End If
        End Sub

        Public Shared Sub ModuleSpotifyOff()
            If Instance.Form.InvokeRequired Then
                Dim asyncResult = Instance.Form.BeginInvoke(New Action(AddressOf ModuleSpotifyOff))
                EndInvokeOf(asyncResult)
            Else
                Instance.Form.tgMedia.Checked = False
            End If
        End Sub

        Public Shared Sub ModuleObsOff()
            If Instance.Form.InvokeRequired Then
                Dim asyncResult = Instance.Form.BeginInvoke(New Action(AddressOf ModuleObsOff))
                EndInvokeOf(asyncResult)
            Else
                Instance.Form.tgOBS.Checked = False
            End If
        End Sub

        Public Shared Sub AnimateTips()
            If AnimateTipsTick Mod AnimateTipsEveryTick <> 0 Then Return

            If Instance.Form.InvokeRequired Then
                Dim asyncResult = Instance.Form.BeginInvoke(New Action(AddressOf AnimateTips))
                EndInvokeOf(asyncResult)
            Else
                If Instance.Form.lblTip.Text.Contains(Lang.RmText.GetString("lnkNewVersionText")) Then Return

                Dim currentTip = Parameters.Tips.FirstOrDefault(Function(x) x.Value = Instance.Form.lblTip.Text)
                If currentTip.Value Is Nothing Then Return

                Dim nextTip = Parameters.Tips.FirstOrDefault(Function(x) If(currentTip.Key + 1 > InitializeForm.TotalTipCount, x.Key = 1, x.Key = currentTip.Key + 1))
                If nextTip.Value Is Nothing Then Return

                Instance.Form.lblTip.Text = nextTip.Value
            End If
        End Sub

        Public Shared Sub NewGamesFound(gamesDict As List(Of Game))
            If Instance.Form.InvokeRequired Then
                Dim asyncResult =
                        Instance.Form.BeginInvoke(New Action(Of List(Of Game))(AddressOf NewGamesFound),
                                                               gamesDict)
                EndInvokeOf(asyncResult)
            Else
                Instance.Form.ClearGamePanel()
                Instance.Form.flpGames.Controls.AddRange((From game In gamesDict Select New GameControl(
                                                                                                  game,
                                                                                                  Instance.Form.GetSetting("ShowScores"),
                                                                                                  Instance.Form.GetSetting("ShowLiveScores"),
                                                                                                  Instance.Form.GetSetting("ShowSeriesRecord"),
                                                                                                  Instance.Form.GetSetting("ShowTeamCityAbr"),
                                                                                                  Instance.Form.GetSetting("ShowLiveTime"),
                                                                                                  Instance.Form.GetSetting("ShowStanding")
                                                                                     )).ToArray())
            End If
        End Sub

        Public Shared Function MsgBoxRed(message As String, title As String, buttons As MessageBoxButtons) _
            As DialogResult
            Dim result = New DialogResult()
            If Instance.Form.InvokeRequired Then
                Dim asyncResult =
                        Instance.Form.BeginInvoke(
                            New Action(Of String, String, MessageBoxButtons)(AddressOf MsgBoxRed), message, title,
                            buttons)
                EndInvokeOf(asyncResult)
            Else
                Instance.Form.tabMenu.SelectedIndex = MainTabsEnum.Settings
                result = MetroMessageBox.Show(Instance.Form,
                                              message,
                                              title,
                                              buttons,
                                              MessageBoxIcon.Error)
            End If
            Return result
        End Function

        Public Shared Function MsgBoxBlue(message As String, title As String, buttons As MessageBoxButtons) _
            As DialogResult
            Dim result = New DialogResult()
            If Instance.Form.InvokeRequired Then
                Dim asyncResult =
                        Instance.Form.BeginInvoke(
                            New Action(Of String, String, MessageBoxButtons)(AddressOf MsgBoxBlue), message, title,
                            buttons)
                EndInvokeOf(asyncResult)
            Else
                result = MetroMessageBox.Show(Instance.Form,
                                              message,
                                              title,
                                              buttons,
                                              MessageBoxIcon.Information)
            End If
            Return result
        End Function

        Private Shared Sub EndInvokeOf(asyncResult As IAsyncResult)
            Try
                asyncResult.AsyncWaitHandle.WaitOne()
                Instance.Form.EndInvoke(asyncResult)
            Catch
            End Try
        End Sub

        Public Shared Sub LoadStandings()
            If Instance.Form.InvokeRequired Then
                Dim asyncResult =
                        Instance.Form.BeginInvoke(New Action(AddressOf LoadStandings))
                EndInvokeOf(asyncResult)
            Else
                Instance.Form.cbSeasons.DataSource = Seasons.GetAllSeasons()
                Instance.Form.cbSeasons.SelectedIndex = 0
            End If
        End Sub

        Public Shared Sub LoadTeamsName()
            If Instance.Form.InvokeRequired Then
                Dim asyncResult =
                        Instance.Form.BeginInvoke(New Action(AddressOf LoadTeamsName))
                EndInvokeOf(asyncResult)
            Else
                Dim teamRootobject As TeamRootobject = TeamRootobject.GetTeamRootobject()

                For Each item As TeamObject In teamRootobject.teams
                    Team.TeamAbbreviation.Add(item.name, item.abbreviation)
                Next
            End If
        End Sub

    End Class
End Namespace

