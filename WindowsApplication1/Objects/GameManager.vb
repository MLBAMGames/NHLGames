Imports Newtonsoft.Json.Linq

Public Class GameManager

    Public Shared Event NewGameFound(gameObj As Game)
    Public Shared Event GamesLoaded(gameObj As List(Of Game))

    Shared _GamesList As New Dictionary(Of String, Game)

    Public Shared Property GamesListDate As DateTime = DateTime.MinValue
    Public Shared ReadOnly Property GamesList As List(Of Game)
        Get
            Return _GamesList.Values.ToList()
        End Get
    End Property

    Public Shared Sub ClearGames()
        _GamesList.Clear()
        GamesListDate = DateTime.MinValue
    End Sub


    Public Shared Sub RefreshGames(dateTime As DateTime, jsonObj As JToken, availableGames As List(Of String))

        Dim tempList As New List(Of Game)
        GamesListDate = dateTime
        For Each o As JToken In jsonObj.Children(Of JToken)
            If o.Path = "dates" Then
                For Each game As JObject In o.Children.Item(0)("games").Children(Of JObject)

                    tempList.Add(New Game(game, availableGames))
                Next
            End If
        Next

        tempList = tempList.OrderBy(Of Long)(Function(val) val.Date.Ticks).ToList()

        For Each game As Game In tempList
            If (_GamesList.ContainsKey(game.GameID)) Then
                _GamesList(game.GameID).Update(game)
            Else
                _GamesList.Add(game.GameID, game)
                'AddHandler game.GameUpdated, AddressOf GameUpdatedHandler
                RaiseEvent NewGameFound(game)
            End If
        Next

    End Sub

    'Private Shared Sub GameUpdatedHandler(game As Game)
    '    RaiseEvent GameUpdated(game)
    'End Sub



End Class
