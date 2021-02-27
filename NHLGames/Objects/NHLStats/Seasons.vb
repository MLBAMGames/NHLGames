Namespace NHLStats
    Public Class Seasons
        Public Property copyright As String
        Public Property seasons As List(Of Season)

        Public Shared CurrentSeason As Season

        Public Shared Function GetAllSeasons() As List(Of Season)
            Dim seasons As Seasons =  DataAccessLayer.ExecuteAPICall(Of Seasons)(NHLAPIServiceURLs.seasons)

            seasons.seasons.Reverse()

            CurrentSeason = seasons.seasons.First()

            Return seasons.seasons
        End Function
    End Class
End Namespace

