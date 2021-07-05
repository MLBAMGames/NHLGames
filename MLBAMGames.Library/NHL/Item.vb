
Namespace Objects.NHL
    Public Class Item
        Public Property id As String
        Public Property guid As String
        Public Property mediaState As String
        Public Property mediaPlaybackId As String
        Public Property mediaFeedType As String
        Public Property callLetters As String
        Public Property eventId As String
        Public Property language As String
        Public Property freeGame As Boolean
        Public Property feedName As String
        Public Property gamePlus As Boolean
        Public Property type As String
        Public Property [date] As DateTime
        Public Property title As String
        Public Property blurb As String
        Public Property description As String
        Public Property duration As String
        Public Property authFlow As Boolean
        Public Property keywords As List(Of Keyword)
        Public Property image As Image
        Public Property playbacks As List(Of Playback)

        Public ReadOnly Property streamTypeSelected As String
            Get
                Return If(feedName.Equals(String.Empty), mediaFeedType, feedName)
            End Get
        End Property

        Public ReadOnly Property recapLink As String
            Get
                Dim recap = playbacks.Where(Function(x) x.name.Contains("HTTP_CLOUD_WIRED")).OrderByDescending(Function(y) y.name.Length).First()
                Return If(recap Is Nothing, String.Empty, recap.url)
            End Get
        End Property
    End Class
End Namespace