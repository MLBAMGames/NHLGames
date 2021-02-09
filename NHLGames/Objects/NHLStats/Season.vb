Imports System
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Linq
Imports System.Security.Cryptography.X509Certificates

Namespace NHLStats
    Public Class Season
        Public Property seasonId As String
        Public Property regularSeasonStartDate As DateTime
        Public Property regularSeasonEndDate As DateTime
        Public Property seasonEndDate As DateTime
        Public Property numberOfGames As Integer
        Public Property tiesInUse As Boolean
        Public Property olympicsParticipation As Boolean
        Public Property conferencesInUse As Boolean
        Public Property divisionsInUse As Boolean
        Public Property wildCardInUse As Boolean

        Public Overrides Function ToString() As String
            Return seasonId.Substring(0, 4) & "-" & seasonId.Substring(4, 4)
        End Function

        Public Sub New()
        End Sub

        Public Shared Function GetAllSeasons() As List(Of Season)
            Dim json = DataAccessLayer.ExecuteAPICall(NHLAPIServiceURLs.seasons)
            Dim SeasonArray = JArray.Parse(json.SelectToken("seasons").ToString())
            Dim listOfSeasons As List(Of Season) = New List(Of Season)()
            Dim tempSeason As Season

            For Each aSeason In SeasonArray
                tempSeason = New Season()
                tempSeason.seasonId = aSeason.SelectToken("seasonId")
                tempSeason.regularSeasonStartDate = Convert.ToDateTime(aSeason.SelectToken("regularSeasonStartDate"))
                tempSeason.regularSeasonEndDate = Convert.ToDateTime(aSeason.SelectToken("regularSeasonEndDate"))
                tempSeason.seasonEndDate = Convert.ToDateTime(aSeason.SelectToken("seasonEndDate"))
                tempSeason.numberOfGames = Convert.ToInt32(aSeason.SelectToken("numberOfGames"))
                tempSeason.tiesInUse = Convert.ToBoolean(aSeason.SelectToken("tiesInUse"))
                tempSeason.olympicsParticipation = Convert.ToBoolean(aSeason.SelectToken("olympicsParticipation"))
                tempSeason.conferencesInUse = Convert.ToBoolean(aSeason.SelectToken("conferencesInUse"))
                tempSeason.divisionsInUse = Convert.ToBoolean(aSeason.SelectToken("divisionsInUse"))
                tempSeason.wildCardInUse = Convert.ToBoolean(aSeason.SelectToken("wildCardInUse"))

                listOfSeasons.Add(tempSeason)
            Next

            listOfSeasons.Reverse()
            Return listOfSeasons
        End Function

    End Class
End Namespace