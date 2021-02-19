Imports Newtonsoft.Json.Linq

Namespace NHLStats
    Public Class Season
        Public Property seasonId As String
        Public Property regularSeasonStartDate As String
        Public Property regularSeasonEndDate As String
        Public Property seasonEndDate As String
        Public Property numberOfGames As Integer
        Public Property tiesInUse As Boolean
        Public Property olympicsParticipation As Boolean
        Public Property conferencesInUse As Boolean
        Public Property divisionsInUse As Boolean
        Public Property wildCardInUse As Boolean

        Public Overrides Function ToString() As String
            Return seasonId.Substring(0, 4) & "-" & seasonId.Substring(4, 4)
        End Function
    End Class
End Namespace