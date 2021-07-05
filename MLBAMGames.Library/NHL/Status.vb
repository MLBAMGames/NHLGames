
Imports MLBAMGames.Library.Utilities

Namespace Objects.NHL
    Public Class Status
        Public Property abstractGameState As String
        Public Property codedGameState As String
        Public Property detailedState As String
        Public Property statusCode As String
        Public Property startTimeTBD As Boolean

        Public ReadOnly Property gameState As GameStateEnum
            Get
                Dim code = Convert.ToInt16(If(statusCode, 0).ToString())
                Return If(code > 10, 11, code)
            End Get
        End Property
    End Class
End Namespace