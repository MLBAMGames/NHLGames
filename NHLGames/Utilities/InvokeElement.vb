Imports MetroFramework
Imports NHLGames.Controls
Imports NHLGames.Objects

Namespace Utilities
    Public Class InvokeElement
        Public Shared Async Sub LoadGames()
            NHLGamesMetro.FormInstance.ClearGamePanel()
            Await Task.Run(AddressOf GameFetcher.LoadGames).ConfigureAwait(False)
        End Sub

        Public Shared Sub SetFormStatusLabel(msg As String)
            If NHLGamesMetro.FormInstance.InvokeRequired Then
                Dim asyncResult =
                        NHLGamesMetro.FormInstance.BeginInvoke(New Action(Of String)(AddressOf SetFormStatusLabel), msg)
                EndInvokeOf(asyncResult)
            Else
                NHLGamesMetro.FormInstance.lblStatus.Text = msg
            End If
        End Sub

        Public Shared Sub SetGameTabControls(enabled As Boolean)
            If NHLGamesMetro.FormInstance.InvokeRequired Then
                Dim asyncResult =
                        NHLGamesMetro.FormInstance.BeginInvoke(New Action(Of Boolean)(AddressOf SetGameTabControls),
                                                               enabled)
                EndInvokeOf(asyncResult)
            Else
                NHLGamesMetro.FormInstance.btnDate.Enabled = enabled
                NHLGamesMetro.FormInstance.btnTomorrow.Enabled = enabled
                NHLGamesMetro.FormInstance.btnYesterday.Enabled = enabled
            End If
        End Sub

        Public Shared Sub ModuleSpotifyOff()
            If NHLGamesMetro.FormInstance.InvokeRequired Then
                Dim asyncResult = NHLGamesMetro.FormInstance.BeginInvoke(New Action(AddressOf ModuleSpotifyOff))
                EndInvokeOf(asyncResult)
            Else
                NHLGamesMetro.FormInstance.tgSpotify.Checked = False
            End If
        End Sub

        Public Shared Sub ModuleObsOff()
            If NHLGamesMetro.FormInstance.InvokeRequired Then
                Dim asyncResult = NHLGamesMetro.FormInstance.BeginInvoke(New Action(AddressOf ModuleObsOff))
                EndInvokeOf(asyncResult)
            Else
                NHLGamesMetro.FormInstance.tgOBS.Checked = False
            End If
        End Sub

        Public Shared Sub AnimateTips()
            If NHLGamesMetro.AnimateTipsTick Mod NHLGamesMetro.AnimateTipsEveryTick <> 0 Then Return

            If NHLGamesMetro.FormInstance.InvokeRequired Then
                 Dim asyncResult = NHLGamesMetro.FormInstance.BeginInvoke(New Action(AddressOf AnimateTips))
                EndInvokeOf(asyncResult)
            Else
                If NHLGamesMetro.FormInstance.lblTip.Text.Contains(NHLGamesMetro.RmText.GetString("lnkNewVersionText")) Then Return

                Dim currentTip = NHLGamesMetro.Tips.FirstOrDefault(Function(x) x.Value = NHLGamesMetro.FormInstance.lblTip.Text)
                If currentTip.Value Is Nothing Then Return

                Dim nextTip = NHLGamesMetro.Tips.FirstOrDefault(Function(x) If(currentTip.Key + 1 > InitializeForm.TotalTipCount, x.Key = 1, x.Key = currentTip.Key + 1))
                If nextTip.Value Is Nothing Then Return

                NHLGamesMetro.FormInstance.lblTip.Text = nextTip.Value
            End If
        End Sub

        Public Shared Sub NewGamesFound(gamesDict As List(Of Game))
            If NHLGamesMetro.FormInstance.InvokeRequired Then
                Dim asyncResult =
                        NHLGamesMetro.FormInstance.BeginInvoke(New Action(Of List(Of Game))(AddressOf NewGamesFound),
                                                               gamesDict)
                EndInvokeOf(asyncResult)
            Else
                NHLGamesMetro.FormInstance.ClearGamePanel()
                NHLGamesMetro.FormInstance.flpGames.Controls.AddRange((From game In gamesDict Select New GameControl(
                    game,
                    ApplicationSettings.Read(Of Boolean)(SettingsEnum.ShowScores, False),
                    ApplicationSettings.Read(Of Boolean)(SettingsEnum.ShowLiveScores, False),
                    ApplicationSettings.Read(Of Boolean)(SettingsEnum.ShowSeriesRecord, False),
                    ApplicationSettings.Read(Of Boolean)(SettingsEnum.ShowTeamCityAbr, False),
                    ApplicationSettings.Read(Of Boolean)(SettingsEnum.ShowLiveTime, False))).ToArray())
            End If
        End Sub

        Public Shared Function MsgBoxRed(message As String, title As String, buttons As MessageBoxButtons) _
            As DialogResult
            Dim result = New DialogResult()
            If NHLGamesMetro.FormInstance.InvokeRequired Then
                Dim asyncResult =
                        NHLGamesMetro.FormInstance.BeginInvoke(
                            New Action(Of String, String, MessageBoxButtons)(AddressOf MsgBoxRed), message, title,
                            buttons)
                EndInvokeOf(asyncResult)
            Else
                NHLGamesMetro.FormInstance.tabMenu.SelectedIndex = 2
                result = MetroMessageBox.Show(NHLGamesMetro.FormInstance,
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
            If NHLGamesMetro.FormInstance.InvokeRequired Then
                Dim asyncResult =
                        NHLGamesMetro.FormInstance.BeginInvoke(
                            New Action(Of String, String, MessageBoxButtons)(AddressOf MsgBoxBlue), message, title,
                            buttons)
                EndInvokeOf(asyncResult)
            Else
                result = MetroMessageBox.Show(NHLGamesMetro.FormInstance,
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
                NHLGamesMetro.FormInstance.EndInvoke(asyncResult)
            Catch
            End Try
        End Sub
    End Class
End Namespace

