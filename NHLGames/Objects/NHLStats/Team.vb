Imports Newtonsoft.Json.Linq
Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace NHLStats
    Public Class Team
        Public Property NHLTeamID As Integer
        Public Property TeamName As String
        Public Property TeamCity As String
        Public Property TeamAbbreviation As String
        Public Property TeamVenue As Venue
        Public Property FirstYearOfPlay As String
        Public Property teamDivision As Division
        Public Property teamConference As Conference
        Public Property webSite As String
        Public Property Wins As Integer
        Public Property regulationWins As Integer
        Public Property Losses As Integer
        Public Property OvertimeLosses As Integer
        Public Property GoalsScored As Integer
        Public Property GoalsAgainst As Integer
        Public Property Points As Integer
        Public Property DivisionRank As Integer
        Public Property ConferenceRank As Integer
        Public Property LeagueRank As Integer
        Public Property WildcardRank As Integer
        Public Property ROW As Integer
        Public Property GamesPlayed As Integer
        Public Property StreakType As String
        Public Property StreakNumber As Integer
        Public Property StreakCode As String
        Public Property LastUpdated As String
        Public Property teamJson As JObject

        Public Sub New()
        End Sub

        Public Sub New(ByVal teamID As String)
            NHLTeamID = Convert.ToInt32(teamID)
            Dim teamLink As String = NHLAPIServiceURLs.teams & teamID
            Dim json = DataAccessLayer.ExecuteAPICall(teamLink)
            Dim specificTeam = json.SelectToken("teams[0]").ToObject(Of JObject)()
            teamJson = specificTeam

            If specificTeam("teamName") IsNot Nothing Then
                TeamName = json.SelectToken("teams[0].teamName").ToString()
            End If

            If specificTeam("abbreviation") IsNot Nothing Then
                TeamAbbreviation = json.SelectToken("teams[0].abbreviation").ToString()
            End If

            If specificTeam("locationName") IsNot Nothing Then
                TeamCity = json.SelectToken("teams[0].locationName").ToString()
            End If

            If specificTeam("firstYearOfPlay") IsNot Nothing Then
                FirstYearOfPlay = json.SelectToken("teams[0].firstYearOfPlay").ToString()
            End If

            If specificTeam("conference") IsNot Nothing Then
                teamConference = New Conference(Convert.ToInt32(json.SelectToken("teams[0].conference.id")))
            End If

            If specificTeam("division") IsNot Nothing Then
                teamDivision = New Division(Convert.ToInt32(json.SelectToken("teams[0].division.id")))
            End If

            If specificTeam("venue") IsNot Nothing Then
                Dim venueJson = json.SelectToken("teams[0].venue").ToObject(Of JObject)()

                If venueJson("id") IsNot Nothing Then
                    TeamVenue = New Venue(json.SelectToken("teams[0].venue.id").ToString())
                End If
            End If

            If specificTeam("officialSiteUrl") IsNot Nothing Then
                webSite = json.SelectToken("teams[0].officialSiteUrl").ToString()
            End If
        End Sub

        Public Sub New(ByVal teamID As String, ByVal featureFlag As Integer)
            NHLTeamID = Convert.ToInt32(teamID)
            Dim teamLink As String = NHLAPIServiceURLs.teams & teamID
            Dim json = DataAccessLayer.ExecuteAPICall(teamLink)
            Dim specificTeam = json.SelectToken("teams[0]").ToObject(Of JObject)()
            teamJson = specificTeam

            If specificTeam("teamName") IsNot Nothing Then
                TeamName = json.SelectToken("teams[0].teamName").ToString()
            End If

            If specificTeam("abbreviation") IsNot Nothing Then
                TeamAbbreviation = json.SelectToken("teams[0].abbreviation").ToString()
            End If

            If specificTeam("locationName") IsNot Nothing Then
                TeamCity = json.SelectToken("teams[0].locationName").ToString()
            End If

            If specificTeam("firstYearOfPlay") IsNot Nothing Then
                FirstYearOfPlay = json.SelectToken("teams[0].firstYearOfPlay").ToString()
            End If

            If specificTeam("conference") IsNot Nothing Then
                teamConference = New Conference(Convert.ToInt32(json.SelectToken("teams[0].conference.id")))
            End If

            If specificTeam("division") IsNot Nothing Then
                teamDivision = New Division(Convert.ToInt32(json.SelectToken("teams[0].division.id")))
            End If

            Dim venueJson = json.SelectToken("teams[0].venue").ToObject(Of JObject)()

            If venueJson("id") IsNot Nothing Then
                TeamVenue = New Venue(json.SelectToken("teams[0].venue.id").ToString())
            End If

            webSite = json.SelectToken("teams[0].officialSiteUrl").ToString()
        End Sub

        Public Shared Function GetAllTeams() As List(Of Team)
            Dim json = DataAccessLayer.ExecuteAPICall(NHLAPIServiceURLs.teams)
            Dim teamArray = JArray.Parse(json.SelectToken("teams").ToString())
            Dim listOfTeams As List(Of Team) = New List(Of Team)()
            Dim tempTeam As Team

            For Each aTeam In teamArray
                tempTeam = New Team(aTeam.SelectToken("id").ToString())
                listOfTeams.Add(tempTeam)
            Next

            Return listOfTeams
        End Function
    End Class
End Namespace
