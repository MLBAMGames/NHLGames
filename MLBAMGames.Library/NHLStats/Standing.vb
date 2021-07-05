Imports MLBAMGames.Library.Utilities

Namespace NHLStats
    Public Class Standing
        Public Property records As List(Of Record)

        Private Shared Property LastFetchTime As DateTime = DateTime.Now

        Private Shared Property CurrentStandings As Dictionary(Of String, Dictionary(Of StandingTypeEnum, Standing)) = New Dictionary(Of String, Dictionary(Of StandingTypeEnum, Standing))

        Public Shared Function GetCurrentStandings(ByVal standingType As StandingTypeEnum, ByVal season As String) As Standing

            If CurrentStandings.ContainsKey(season) = False OrElse
                CurrentStandings(season).ContainsKey(standingType) = False OrElse
                LastFetchTime.AddHours(1) < DateTime.Now Then

                Dim standingsAPICall As String = GetStandingsAPICall(standingType, season)

                If (CurrentStandings.ContainsKey(season) = False) Then
                    CurrentStandings.Add(season, New Dictionary(Of StandingTypeEnum, Standing))
                End If
                CurrentStandings(season)(standingType) = DataAccessLayer.ExecuteAPICall(Of Standing)(standingsAPICall)

            End If

            Return CurrentStandings(season)(standingType)
        End Function

        Public Shared Function GetCurrentStandings(ByVal standingType As StandingTypeEnum, ByVal season As String, ByVal teamName As String) As String

            Dim standing As Standing = GetCurrentStandings(standingType, season)
            Dim teamRecord As Teamrecord = standing.records.First().teamRecords.FirstOrDefault(Function(n) n.team.name.Contains(teamName))

            If (standingType = StandingTypeEnum.League) Then
                Return teamRecord.leagueRank
            ElseIf (standingType = StandingTypeEnum.Conference) Then
                Return teamRecord.conferenceRank
            ElseIf (standingType = StandingTypeEnum.Division) Then
                Return teamRecord.divisionRank
            End If

            Return 0
        End Function


        Private Shared Function GetStandingsAPICall(ByVal standingType As StandingTypeEnum, ByVal season As String) As String
            Dim standingsAPICall As String = String.Empty

            If (standingType = StandingTypeEnum.League) Then
                If season <> "" Then
                    standingsAPICall = String.Format(NHLAPIServiceURLs.leagueStandings, season)
                End If
            ElseIf (standingType = StandingTypeEnum.Conference) Then
                If season <> "" Then
                    standingsAPICall = String.Format(NHLAPIServiceURLs.conferenceStandings, season)
                End If
            ElseIf (standingType = StandingTypeEnum.Division) Then
                If season <> "" Then
                    standingsAPICall = String.Format(NHLAPIServiceURLs.divisionStandings, season)
                End If
            ElseIf (standingType = StandingTypeEnum.WildCard) Then
                If season <> "" Then
                    standingsAPICall = String.Format(NHLAPIServiceURLs.wildCardStandings, season)
                End If
            End If

            Return standingsAPICall
        End Function
    End Class
End Namespace
