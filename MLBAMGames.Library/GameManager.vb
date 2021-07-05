Imports System.Text.RegularExpressions
Imports MLBAMGames.Library.My.Resources
Imports MLBAMGames.Library.Objects.NHL
Imports MLBAMGames.Library.Utilities

Namespace Objects
    Public Class GameManager
        Implements IDisposable
        Private _disposedValue As Boolean

        Private Shared ReadOnly DictStreamType As Dictionary(Of String, StreamTypeEnum) = New Dictionary(Of String, StreamTypeEnum)() From {
            {"HOME", StreamTypeEnum.Home}, {"AWAY", StreamTypeEnum.Away}, {"NATIONAL", StreamTypeEnum.National},
            {"FRENCH", StreamTypeEnum.French},
            {"MULTICAM1", StreamTypeEnum.MultiCam1}, {"MULTICAM2", StreamTypeEnum.MultiCam2},
            {"ENDZONECAM1", StreamTypeEnum.EndzoneCam1}, {"ENDZONECAM2", StreamTypeEnum.EndzoneCam2},
            {"REFCAM", StreamTypeEnum.RefCam}, {"STARCAM", StreamTypeEnum.StarCam}}

        Private Const MediaOff = "MEDIA_OFF"

        Public Async Function GetGamesAsync(gameDate As Date) As Task(Of Game())
            Dim schedule As Schedule = Await Web.GetScheduleAsync(gameDate)

            If schedule Is Nothing Then
                Console.WriteLine(English.errorFetchingGames)
                Return Nothing
            End If

            If Not Parameters.IsServerUp Then
                Console.WriteLine(String.Format(Lang.RmText.GetString($"msgServerSeemsDown"), Parameters.HostName))
            End If

            Dim gamesArray As Game()
            Dim lstStreamsTask As Task()
            Dim currentGameIndex = 0
            Dim currentStreamIndex = 0

            Dim numberOfGames = (Convert.ToInt32(schedule.totalGames))
            Dim numberOfStreams = If(schedule.date?.numberOfNHLTVFeeds, 0)
            If numberOfGames = 0 Then Return Nothing

            gamesArray = New Game(numberOfGames - 1) {}
            lstStreamsTask = If(Parameters.IsServerUp, New Task(numberOfStreams - 1) {}, New Task() {})

            Dim progressPerGame = Convert.ToInt32(((Parameters.SpnLoadingMaxValue - 1) - Parameters.SpnLoadingValue) / numberOfGames)
            Dim currentGame As Game

            For Each game As NHL.Game In schedule.date.games

                currentGame = New Game With {
                    .GameDate = game.gameDate.ToUniversalTime(), ' Must use universal time to always get correct date for stream
                    .GameId = game.gamePk.ToString(),
                    .GameType = Convert.ToInt16(GetChar(game.gamePk.ToString(), 6)) - 48,
                    .Home = If(game.teams?.home?.team?.locationName, String.Empty),
                    .HomeAbbrev = If(game.teams?.home?.team?.abbreviation, String.Empty),
                    .HomeTeam = If(game.teams?.home?.team?.teamName, String.Empty),
                    .Away = If(game.teams?.away?.team?.locationName, String.Empty),
                    .AwayAbbrev = If(game.teams?.away?.team?.abbreviation, String.Empty),
                    .AwayTeam = If(game.teams?.away?.team?.teamName, String.Empty),
                    .GameState = game.status.gameState,
                    .GameStateDetailed = game.status.detailedState
                }

                If currentGame.GameType = GameTypeEnum.Series AndAlso game.seriesSummary?.gameNumber IsNot Nothing Then
                    currentGame.SeriesGameNumber = game.seriesSummary?.gameNumber
                    currentGame.SeriesGameStatus = If(game.seriesSummary?.seriesStatusShort, String.Empty)
                End If

                If currentGame.GameDate.AddDays(1) < Date.UtcNow AndAlso currentGame.GameState > 0 AndAlso currentGame.GameState < 7 Then
                    currentGame.GameState = GameStateEnum.StreamEnded
                End If

                If currentGame.IsStreamable Then
                    currentGame.SetStatsInfo(game)
                End If

                If Parameters.IsServerUp Then
                    Dim progressPerStream = If(game.numberOfNHLTVFeedsWithRecap <> 0, Convert.ToInt32(progressPerGame / game.numberOfNHLTVFeedsWithRecap), progressPerGame)
                    For Each feed In game.NHLTVFeeds
                        Parameters.SpnLoadingValue += progressPerStream
                        Dim streamType As StreamTypeEnum = GetStreamType(feed.streamTypeSelected)
                        If Not feed.mediaState.Equals(MediaOff) AndAlso numberOfStreams > 0 Then
                            Dim tCurrentGame = currentGame
                            Dim tInnerStream = feed
                            Dim tStreamType = streamType
                            Dim tCurrentGameIndex = currentGameIndex
                            Dim tStreamTypeSelected = feed.streamTypeSelected
                            lstStreamsTask(currentStreamIndex) =
                                Task.Run(Async Function()
                                             Dim newStream = Await SetNewGameStream(tCurrentGame, tInnerStream, tStreamType, tStreamTypeSelected)
                                             If streamType <> StreamTypeEnum.Unknown Then
                                                 gamesArray(tCurrentGameIndex).StreamsDict.Add(streamType, newStream)
                                             Else
                                                 gamesArray(tCurrentGameIndex).StreamsUnknown.Add(newStream)
                                             End If
                                         End Function)

                            If streamType = StreamTypeEnum.Unknown Then
                                Console.WriteLine(English.errorStreamTypeUnknown, currentGame.AwayAbbrev,
                                                    currentGame.HomeAbbrev,
                                                    feed.mediaFeedType,
                                                    feed.feedName)
                            End If
                        Else
                            lstStreamsTask(currentStreamIndex) = Task.Run(Sub() Return)
                        End If
                        currentStreamIndex += 1
                    Next

                    If currentGame.IsEnded AndAlso game.numberOfRecapFeeds <> 0 Then
                        currentGame.Recap = SetGameRecap(game)
                        Parameters.SpnLoadingValue += progressPerStream
                    End If
                End If

                gamesArray(currentGameIndex) = currentGame
                currentGameIndex += 1
            Next

            Try
                Await Task.WhenAll(lstStreamsTask).ContinueWith(Sub(x) x.Dispose())
            Catch ex As AggregateException
                Console.WriteLine(English.errorGeneral, $"Getting streams in manager", ex.Message)
            End Try

            Return gamesArray
        End Function

        Private Shared Function SetGameRecap(currentGame As NHL.Game)
            Dim recap = currentGame.RecapFeeds.First()
            Return New GameStream With {
                .Title = recap.title,
                .StreamUrl = recap.recapLink,
                .StreamTypeSelected = StreamTypeEnum.Unknown
            }
        End Function

        Private Shared Async Function SetNewGameStream(currentGame As Game, innerStream As NHL.Item,
                                                       streamType As StreamTypeEnum, streamTypeSelected As String) As Task(Of GameStream)
            Dim gs = New GameStream(currentGame, innerStream, streamType, streamTypeSelected)
            gs.StreamUrl = Await GetGameFeedUrlAsync(gs)

            If gs.StreamUrl.Equals(String.Empty) Then
                Console.WriteLine(English.msgGettingStreamFailed, gs.Title)
            End If

            Return gs
        End Function

        Private Shared Function GetStreamType(streamTypeSelected As String) As StreamTypeEnum
            Dim streamTypeAsText = Regex.Replace(streamTypeSelected.ToUpper(), "[^A-Z0-9]", "")

            If DictStreamType.ContainsKey(streamTypeAsText) Then
                Return DictStreamType(streamTypeAsText)
            Else
                Return StreamTypeEnum.Unknown
            End If
        End Function

        Private Shared Async Function GetGameFeedUrlAsync(gameStream As GameStream) As Task(Of String)
            If gameStream.GameUrl.Equals(String.Empty) Then Return String.Empty

            Dim streamUrlReturned = Await Web.SendWebRequestAndGetContentAsync(gameStream.GameUrl)

            ' Recover old streams
            If gameStream.Game.GameDate.ToLocalTime() < DateTime.Today.AddDays(-2) And streamUrlReturned.StartsWith("https://hlslive") Then
                Dim network = gameStream.CdnParameter.ToString().ToLower()
                Dim newServerUrl = streamUrlReturned _
                .Replace($"hlslive-{network}.med2.med", $"hlslive-{network}.med") _
                .Replace($"hlslive-{network}", $"vod-{network}-na1")
                Dim matches = Regex.Match(newServerUrl, "(.*nhl.com)(.*)(\/[a-z]{2}[0-9]{2}\/)(nhl\/.*)").Groups
                If matches.Count < 5 Then Return streamUrlReturned
                streamUrlReturned = $"{matches(1)}/ps01/{matches(4)}"
            End If

#If DEBUG Then
            Console.WriteLine("{0}", streamUrlReturned)
#End If
            If streamUrlReturned.Equals(String.Empty) Then Return String.Empty

            Return If(Await Web.SendWebRequestAsync(streamUrlReturned), streamUrlReturned, String.Empty)
        End Function

        Protected Overridable Sub Dispose(disposing As Boolean)
            _disposedValue = True
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

        Protected Overrides Sub Finalize()
            Dispose(False)
        End Sub
    End Class
End Namespace
