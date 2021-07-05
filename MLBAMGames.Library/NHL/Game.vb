
Namespace Objects.NHL
    Public Class Game
        Public Property gamePk As Integer
        Public Property link As String
        Public Property gameType As String
        Public Property season As String
        Public Property gameDate As DateTime
        Public Property status As Status
        Public Property teams As Teams
        Public Property linescore As Linescore
        Public Property venue As Venue
        Public Property content As Content
        Public Property seriesSummary As SeriesSummary

        Public ReadOnly Property isValidSeriesGame As Boolean
            Get
                Dim hasGameNumber = seriesSummary?.gameNumber IsNot Nothing
                Dim hasStatus = seriesSummary?.seriesStatusShort IsNot Nothing
                Return hasGameNumber And hasStatus
            End Get
        End Property

        Public ReadOnly Property numberOfNHLTVFeeds As Integer
            Get
                Return If (content?.media IsNot Nothing, content.media.numberOfNHLTVFeeds, 0)
            End Get
        End Property

        Public ReadOnly Property NHLTVFeeds As List(Of Item)
            Get
                Return GetFeeds(Epg.NHLTV)
            End Get
        End Property

        Public ReadOnly Property numberOfRecapFeeds As Integer
            Get
                Return If(content?.media IsNot Nothing, content.media.numberOfRecapFeeds, 0)
            End Get
        End Property

        Public ReadOnly Property numberOfNHLTVFeedsWithRecap As Integer
            Get
                Dim streams = numberOfRecapFeeds + numberOfNHLTVFeeds
                Return If(streams > 0, numberOfNHLTVFeeds + 1, numberOfNHLTVFeeds)
            End Get
        End Property

        Public ReadOnly Property RecapFeeds As List(Of Item)
            Get
                Return GetFeeds(Epg.RECAP)
            End Get
        End Property

        Private Function GetFeeds(epgType As String) As List(Of Item)
            Dim [default] = New List(Of Item)
            If content?.media?.epg IsNot Nothing Then
                Return If (content.media.epg.Find(Function(x) x.title = epgType)?.items, [default])
            End If
            Return [default]
        End Function
    End Class
End Namespace