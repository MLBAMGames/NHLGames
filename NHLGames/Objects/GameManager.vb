Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq
Imports NHLGames.My.Resources
Imports NHLGames.Utilities

Namespace Objects
    Public Class GameManager
        Implements IDisposable
        Private _disposedValue As Boolean

        Private Shared ReadOnly DictStreamType = New Dictionary(Of String, StreamTypeEnum)() From {
            {"HOME", StreamTypeEnum.Home}, {"AWAY", StreamTypeEnum.Away}, {"NATIONAL", StreamTypeEnum.National},
            {"FRENCH", StreamTypeEnum.French},
            {"MULTICAM1", StreamTypeEnum.MultiCam1}, {"MULTICAM2", StreamTypeEnum.MultiCam2},
            {"ENDZONECAM1", StreamTypeEnum.EndzoneCam1}, {"ENDZONECAM2", StreamTypeEnum.EndzoneCam2},
            {"REFCAM", StreamTypeEnum.RefCam}, {"STARCAM", StreamTypeEnum.StarCam}}

        Private Const MediaOff = "MEDIA_OFF"

        Public Async Function GetGamesAsync() As Task(Of Game())

            Dim jsonSchedule As JObject = Await Downloader.DownloadJsonScheduleAsync(NHLGamesMetro.GameDate)

            If Not jsonSchedule.HasValues Then
                Console.WriteLine(English.errorFetchingGames)
                Return Nothing
            End If

            Dim gamesArray As Game()
            Dim lstStreamsTask As Task()
            Dim currentGameIndex = 0
            Dim currentStreamIndex = 0

            Try
                Dim numberOfGames = (Convert.ToInt32(jsonSchedule("totalGames").ToString()))
                If numberOfGames = 0 Then Return Nothing

                Dim numberOfStreams = GetNumberOfStreams(jsonSchedule.SelectToken("dates[0].games").Children(Of JObject))

                gamesArray = New Game(numberOfGames - 1) {}
                lstStreamsTask = New Task(numberOfStreams - 1) {}

                Dim progressPerGame = Convert.ToInt32(((NHLGamesMetro.SpnLoadingMaxValue - 1) - NHLGamesMetro.SpnLoadingValue) / numberOfGames)
                Dim currentGame As Game

                For Each game As JObject In jsonSchedule.SelectToken("dates[0].games").Children(Of JObject)
                    currentGame = New Game()

                    If Not ValidJsonGame(game) Then
                        Console.WriteLine(English.errorUnableToDecodeJson)
                        NHLGamesMetro.SpnLoadingValue += progressPerGame
                        Return Nothing
                    End If

                    'fill up current game info
                    currentGame.SetGameDate(game.Property("gameDate").Value.ToString())
                    currentGame.GameId = game.Property("gamePk").Value.ToString()
                    currentGame.GameType = CType(Convert.ToInt16(GetChar(currentGame.GameId, 6)) - 48, GameTypeEnum)

                    If currentGame.GameType = GameTypeEnum.Series AndAlso Not currentGame.SetSeriesInfo(game) Then
                        NHLGamesMetro.SpnLoadingValue += progressPerGame
                        Return Nothing
                    End If

                    currentGame.Home = game.SelectToken("teams.home.team.locationName")?.ToString()
                    currentGame.HomeAbbrev = game.SelectToken("teams.home.team.abbreviation")?.ToString()
                    currentGame.HomeTeam = game.SelectToken("teams.home.team.teamName")?.ToString()

                    currentGame.Away = game.SelectToken("teams.away.team.locationName")?.ToString()
                    currentGame.AwayAbbrev = game.SelectToken("teams.away.team.abbreviation")?.ToString()
                    currentGame.AwayTeam = game.SelectToken("teams.away.team.teamName")?.ToString()

                    Dim statusCode = Convert.ToInt16(If(game.SelectToken("status.statusCode"), 0).ToString())
                    currentGame.GameState = CType(If(statusCode > 10, 11, statusCode), GameStateEnum)
                    If currentGame.GameDate.AddDays(1) < Date.UtcNow AndAlso currentGame.GameState > 0 AndAlso currentGame.GameState < 7 Then
                        currentGame.GameState = GameStateEnum.StreamEnded
                    End If
                    currentGame.GameStateDetailed = game.SelectToken("status.detailedState")?.ToString()

                    If currentGame.IsStreamable Then
                        currentGame.SetStatsInfo(game)
                    End If

                    'set stream feeds for the current game
                    If game.SelectToken("content.media") IsNot Nothing Then
                        For Each stream As JObject In game.SelectToken("content.media.epg")
                            If _
                                stream.SelectToken("title").ToString().Equals("NHLTV") AndAlso
                                stream.Property("items").Value.Count > 0 Then
                                For Each item As JArray In stream.Property("items")
                                    Dim progressPerStream = Convert.ToInt32(progressPerGame / item.Count)
                                    For Each innerStream As JObject In item.Children(Of JObject)
                                        NHLGamesMetro.SpnLoadingValue += progressPerStream
                                        Dim streamOff = innerStream.SelectToken("mediaState").ToString().Equals(MediaOff)
                                        Dim streamTypeSelected = If(innerStream.Property("feedName").Value.ToString() = String.Empty, innerStream.Property("mediaFeedType").Value.ToString(), innerStream.Property("feedName").Value.ToString())
                                        Dim streamType As StreamTypeEnum = GetStreamType(streamTypeSelected)
                                        If Not streamOff AndAlso numberOfStreams <> 0 Then
                                            Dim tCurrentGame = currentGame
                                            Dim tInnerStream = innerStream
                                            Dim tStreamType = streamType
                                            Dim tCurrentGameIndex = currentGameIndex
                                            Dim tStreamTypeSelected = streamTypeSelected
                                            Dim t = Task.Run(Async Function()
                                                                 Dim newStream = Await SetNewGameStream(tCurrentGame, tInnerStream, tStreamType, tStreamTypeSelected)
                                                                 If streamType <> StreamTypeEnum.Unknown Then
                                                                     gamesArray(tCurrentGameIndex).StreamsDict.Add(streamType, newStream)
                                                                 Else
                                                                     gamesArray(tCurrentGameIndex).StreamsUnknown.Add(newStream)
                                                                 End If
                                                             End Function)
                                            lstStreamsTask(currentStreamIndex) = t

                                            If streamType = StreamTypeEnum.Unknown Then
                                                Console.WriteLine(English.errorStreamTypeUnknown, currentGame.AwayAbbrev,
                                                                  currentGame.HomeAbbrev,
                                                                  innerStream.Property("mediaFeedType").Value.ToString(),
                                                                  innerStream.Property("feedName").Value)
                                            End If
                                        Else
                                            lstStreamsTask(currentStreamIndex) = Task.Run(Sub() Return)
                                        End If
                                        currentStreamIndex += 1
                                    Next
                                Next
                            End If
                        Next
                    End If

                    'Await Task.Delay(50)
                    gamesArray(currentGameIndex) = currentGame
                    currentGameIndex += 1
                Next

                Try
                    Await Task.WhenAll(lstStreamsTask).ContinueWith(Sub(x) x.Dispose())
                Catch ex As AggregateException
                    Console.WriteLine(English.errorGeneral, $"Getting streams in manager", ex.Message)
                End Try

            Catch ex As Exception
                Console.WriteLine(English.errorGeneral, $"Getting games in manager", ex.Message)
                Return Nothing
            End Try

            Return gamesArray
        End Function

        Private Shared Function GetNumberOfStreams(gamesJson As JEnumerable(Of JObject)) As Integer
            Return (From game In gamesJson Where game.SelectToken("content.media") IsNot Nothing).
                Sum(Function(game) _
                       (From stream As JObject In game.SelectToken("content.media.epg")
                        Where stream.SelectToken("title").ToString().Equals("NHLTV")).
                       Sum(Function(stream) stream.Property("items").Value.Count))
        End Function

        Private Shared Async Function SetNewGameStream(currentGame As Game, innerStream As JObject,
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

            Dim streamUrlReturned = Await Common.SendWebRequestAndGetContentAsync(gameStream.GameUrl)
            If streamUrlReturned.Equals(String.Empty) Then Return String.Empty

            Return If(Await Common.SendWebRequestAsync(streamUrlReturned), streamUrlReturned, String.Empty)
        End Function

        Private Shared Function ValidJsonGame(game As JObject)
            Return (game.TryGetValue("teams", "home") And game.TryGetValue("teams", "away") And
                    game.TryGetValue("linescore", "currentPeriodOrdinal") And
                    game.TryGetValue("linescore", "currentPeriodTimeRemaining") And
                    game.TryGetValue("content", "media"))
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
