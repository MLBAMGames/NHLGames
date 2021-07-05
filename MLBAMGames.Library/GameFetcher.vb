Imports MLBAMGames.Library.Objects

Namespace Utilities
    Public Class GameFetcher
        Public Shared ReadOnly Entries As New Dictionary(Of String, Game)

        Public Shared Sub StreamingProgress()
            ResetLoadingProgress()
            Instance.Form.spnStreaming.Visible = Parameters.SpnStreamingVisible
            If Parameters.SpnStreamingValue < Instance.Form.spnStreaming.Maximum And
               Parameters.SpnStreamingValue >= 0 Then
                Instance.Form.spnStreaming.Value = Parameters.SpnStreamingValue
            End If

            If Instance.Form.spnStreaming.Value > 0 Then
                Instance.Form.spnStreaming.Visible = True
            Else
                Parameters.SpnStreamingVisible = False
                Instance.Form.spnStreaming.Visible = Parameters.SpnStreamingVisible
            End If
        End Sub

        Private Shared Sub ResetStreaminProgress()
            Parameters.SpnStreamingVisible = False
            Parameters.SpnStreamingValue = 0
            Instance.Form.spnStreaming.Value = 0
            Instance.Form.spnStreaming.Visible = False
        End Sub

        Private Shared Sub ResetLoadingProgress()
            Parameters.SpnLoadingVisible = False
            Parameters.SpnLoadingValue = 0
            Instance.Form.spnLoading.Value = 0
            Instance.Form.spnLoading.Visible = False
        End Sub

        Public Shared Sub LoadingProgress()
            ResetStreaminProgress()
            Instance.Form.spnLoading.Visible = Parameters.SpnLoadingVisible
            If Parameters.SpnLoadingValue < Instance.Form.spnLoading.Maximum And
               Parameters.SpnLoadingValue >= 0 Then
                Instance.Form.spnLoading.Value = Parameters.SpnLoadingValue
            End If

            If Instance.Form.spnLoading.Value > 0 Then
                InvokeElement.SetGameTabControls(False)
                Instance.Form.lblNoGames.Visible = False
            Else
                Parameters.SpnLoadingVisible = False
                Instance.Form.spnLoading.Visible = Parameters.SpnLoadingVisible
                InvokeElement.SetGameTabControls(True)
                If (Instance.Form.flpGames.Controls.Count = 0) Then
                    Instance.Form.lblNoGames.Visible = True
                Else
                    Instance.Form.lblNoGames.Visible = False
                End If
            End If
        End Sub

        Public Shared Async Function LoadGames(gameDate As Date) As Task

            Parameters.SpnLoadingValue = 1
            Parameters.SpnLoadingVisible = True

            If Not Parameters.UILoaded Then
                Parameters.SpnLoadingVisible = False
                Parameters.SpnLoadingValue = 0
                Return
            End If

            Entries.Clear()

            Dim games As Game()

            InvokeElement.SetFormStatusLabel(Lang.RmText.GetString("msgLoadingGames"))

            Dim gm = New GameManager()
            Try
                games = Await gm.GetGamesAsync(gameDate)

                Parameters.SpnLoadingValue = Parameters.SpnLoadingMaxValue - 1
                Await Task.Delay(100)

                If games IsNot Nothing Then
                    AddGamesToDict(SortGames(games))
                End If

                InvokeElement.NewGamesFound(Entries.Values.ToList())
                InvokeElement.SetFormStatusLabel(String.Format(Lang.RmText.GetString("msgGamesFound"),
                                                               Entries.Values.Count.ToString()))

            Catch ex As Exception
                Console.WriteLine(ex.ToString())
                Return
            Finally
                gm.Dispose()
            End Try

            Parameters.SpnLoadingVisible = False
            Parameters.SpnLoadingValue = 0
        End Function

        Private Shared Function SortGames(games As Game()) As List(Of Game)
            If Parameters.TodayLiveGamesFirst Then
                Return games.OrderBy(Of Boolean)(Function(val) val.IsUnplayable).
                    ThenBy(Of Boolean)(Function(val) val.IsEnded).
                    ThenBy(Of Long)(Function(val) val.gameDate.Ticks).ToList()
            Else
                Return games.OrderBy(Of Boolean)(Function(val) val.IsUnplayable).
                    ThenBy(Of Long)(Function(val) val.gameDate.Ticks).ToList()
            End If
        End Function

        Private Shared Sub AddGamesToDict(games As List(Of Game))
            For Each game As Game In games
                If Entries.Keys.Contains(game.GameId) Then Continue For
                Entries.Add(game.GameId, game)
            Next
        End Sub
    End Class
End Namespace
