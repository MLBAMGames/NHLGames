
Namespace Objects.NHL
    Public Class Epg
        Public Const NHLTV As String = "NHLTV"
        Public Const AUDIO As String = "Audio"
        Public Const EXTHIGHLIGHTS As String = "Extended Highlights"
        Public Const RECAP As String = "Recap"
        Public Const POWERPLAY As String = "Power Play"

        Public Property title As String
        Public Property platform As String
        Public Property items As List(Of Item)
        Public Property topicList As String

        Public Readonly Property numberOfNHLTVfeeds As Integer
            Get
                Return If (title = NHLTV, items.Count(), 0)
            End Get
        End Property

        Public Readonly Property numberOfRecapFeeds As Integer
            Get
                Return If (title = RECAP, items.Count(), 0)
            End Get
        End Property
    End Class
End Namespace