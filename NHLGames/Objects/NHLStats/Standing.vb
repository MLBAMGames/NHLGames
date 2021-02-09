Imports System
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Linq
Imports System.Security.Cryptography.X509Certificates
Imports NHLGames.Utilities

Namespace NHLStats
    Public Class Standing
        Public Sub New()
        End Sub

        Public Shared Function GetCurrentStandings(ByVal standingType As StandingTypeEnum, ByVal season As String) As List(Of TeamRecord)
            Dim leagueJson As JObject
            Dim standingsAPICall As String = GetStandingsAPICall(standingType, season)

            Dim teamList As List(Of TeamRecord) = New List(Of TeamRecord)()
            Dim json = DataAccessLayer.ExecuteAPICall(standingsAPICall)
            leagueJson = json
            Dim newTeam As TeamRecord = New TeamRecord()
            Dim results As IList(Of JToken) = json("records")(0)("teamRecords").Children().ToList()
            Dim keyTest As JObject
            Dim seasonYear As String
            Dim seasonMonth As String
            Dim seasonDay As String
            Dim dtString As DateTime

            For Each result As JToken In results
                keyTest = result.ToObject(Of JObject)()
                newTeam.NHLTeamID = Convert.ToInt32(result("team")("id"))
                newTeam.TeamName = result("team")("name").ToString()
                newTeam.Wins = Convert.ToInt32(result("leagueRecord")("wins"))
                newTeam.Losses = Convert.ToInt32(result("leagueRecord")("losses"))
                newTeam.OvertimeLosses = Convert.ToInt32(result("leagueRecord")("ot"))
                newTeam.regulationWins = Convert.ToInt32(result("regulationWins"))
                newTeam.GoalsAgainst = Convert.ToInt32(result("goalsAgainst"))
                newTeam.GoalsScored = Convert.ToInt32(result("goalsScored"))
                newTeam.Points = Convert.ToInt32(result("points"))
                newTeam.DivisionRank = Convert.ToInt32(result("divisionRank"))
                newTeam.DivisionL10Rank = Convert.ToInt32(result("divisionL10Rank"))
                newTeam.DivisionHomeRank = Convert.ToInt32(result("divisionHomeRank"))
                newTeam.DivisionRoadRank = Convert.ToInt32(result("divisionRoadRank"))
                newTeam.ConferenceRank = Convert.ToInt32(result("conferenceRank"))
                newTeam.ConferenceL10Rank = Convert.ToInt32(result("conferenceL10Rank"))
                newTeam.ConferenceHomeRank = Convert.ToInt32(result("conferenceHomeRank"))
                newTeam.ConferenceRoadRank = Convert.ToInt32(result("conferenceRoadRank"))
                newTeam.LeagueRank = Convert.ToInt32(result("leagueRank"))
                newTeam.WildcardRank = Convert.ToInt32(result("wildcardRank"))
                newTeam.ROW = Convert.ToInt32(result("row"))
                newTeam.GamesPlayed = Convert.ToInt32(result("gamesPlayed"))
                newTeam.StreakType = result("streak")("streakType").ToString()
                newTeam.StreakNumber = Convert.ToInt32(result("streak")("streakNumber"))
                newTeam.StreakCode = result("streak")("streakCode").ToString()

                If keyTest("clinchIndicator") IsNot Nothing Then
                    newTeam.clinchIndicator = result("clinchIndicator").ToString()
                Else
                    newTeam.clinchIndicator = "N/A"
                End If

                newTeam.LastUpdated = result("lastUpdated").ToString()
                dtString = Convert.ToDateTime(newTeam.LastUpdated)

                If season <> "" Then
                    newTeam.season = season
                Else
                    seasonYear = dtString.Year.ToString()

                    If dtString.Month < 10 Then
                        seasonMonth = "0" & dtString.Month.ToString()
                    Else
                        seasonMonth = dtString.Month.ToString()
                    End If

                    If dtString.Day < 10 Then
                        seasonDay = "0" & dtString.Day.ToString()
                    Else
                        seasonDay = dtString.Day.ToString()
                    End If

                    newTeam.season = Utilities.GetSeasonFromDate(seasonYear & "-" & seasonMonth & "-" & seasonDay)
                End If

                teamList.Add(newTeam)
                newTeam = New TeamRecord()
            Next

            Return teamList
        End Function

        Private Shared Function GetStandingsAPICall(ByVal standingType As StandingTypeEnum, ByVal season As String) As String
            Dim standingsAPICall As String

            If (standingType = StandingTypeEnum.League) Then
                If season <> "" Then
                    standingsAPICall = NHLAPIServiceURLs.leagueStandings + NHLAPIServiceURLs.leagueStandings_season_extension & season
                Else
                    standingsAPICall = NHLAPIServiceURLs.leagueStandings
                End If
            ElseIf (standingType = StandingTypeEnum.Division) Then
                If season <> "" Then
                    standingsAPICall = NHLAPIServiceURLs.divisionStandings + NHLAPIServiceURLs.divisionStandings_season_extension & season
                Else
                    standingsAPICall = NHLAPIServiceURLs.divisionStandings
                End If
            ElseIf (standingType = StandingTypeEnum.Conference) Then
                If season <> "" Then
                    standingsAPICall = NHLAPIServiceURLs.conferenceStandings + NHLAPIServiceURLs.conferenceStandings_season_extension & season
                Else
                    standingsAPICall = NHLAPIServiceURLs.conferenceStandings
                End If
            ElseIf (standingType = StandingTypeEnum.WildCard) Then
                If season <> "" Then
                    standingsAPICall = NHLAPIServiceURLs.wildCardStandings + NHLAPIServiceURLs.wildCardStandings_season_extension & season
                Else
                    standingsAPICall = NHLAPIServiceURLs.wildCardStandings
                End If
            End If

            Return standingsAPICall
        End Function
    End Class
End Namespace
