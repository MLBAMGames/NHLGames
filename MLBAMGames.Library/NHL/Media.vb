
Namespace Objects.NHL
    Public Class Media
        Public Property epg As List(Of Epg)

        Public Readonly Property numberOfNHLTVFeeds As Integer
            Get
                Return epg.Sum(Function(x) x.numberOfNHLTVFeeds)
            End Get
        End Property

        Public Readonly Property numberOfRecapFeeds As Integer
            Get
                Return epg.Sum(Function(x) x.numberOfRecapFeeds)
            End Get
        End Property
    End Class
End Namespace