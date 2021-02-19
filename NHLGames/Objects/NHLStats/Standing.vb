Imports NHLGames.Utilities

Namespace NHLStats
    Public Class Standing
        Public Property copyright As String
        Public Property records As List(Of Record)

        Public Shared Function GetCurrentStandings(ByVal standingType As StandingTypeEnum, ByVal season As String) As Standing
            Dim standingsAPICall As String = GetStandingsAPICall(standingType, season)
            Return DataAccessLayer.ExecuteAPICall(Of Standing)(standingsAPICall)
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
