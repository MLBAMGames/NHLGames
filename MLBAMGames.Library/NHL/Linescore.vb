
Namespace Objects.NHL
    Public Class Linescore
        Public Property currentPeriod As Integer
        Public Property currentPeriodOrdinal As String
        Public Property currentPeriodTimeRemaining As String
        Public Property periods As List(Of Period)
        Public Property shootoutInfo As Teams
        Public Property teams As Teams
        Public Property powerPlayStrength As String
        Public Property hasShootout As Boolean
        Public Property intermissionInfo As IntermissionInfo
        Public Property powerPlayInfo As PowerPlayInfo
    End Class
End Namespace