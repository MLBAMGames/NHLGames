
Namespace Objects.NHL
    Public Class Schedule
        Public Property copyright As String
        Public Property totalItems As Integer
        Public Property totalEvents As Integer
        Public Property totalGames As Integer
        Public Property totalMatches As Integer
        Public Property wait As Integer
        Public Property dates As List(Of [Date])

        Public Readonly Property [date] As [Date]
            Get
                Return dates.FirstOrDefault()
            End Get
        End Property
    End Class
End Namespace