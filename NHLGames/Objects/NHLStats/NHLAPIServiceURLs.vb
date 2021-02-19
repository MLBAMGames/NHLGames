Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace NHLStats
    Public Class NHLAPIServiceURLs
        Public Shared seasons As String = "https://statsapi.web.nhl.com/api/v1/seasons"

        Public Shared leagueStandings As String = "https://statsapi.web.nhl.com/api/v1/standings/byLeague?season={0}&expand=standings.record"
        Public Shared conferenceStandings As String = "https://statsapi.web.nhl.com/api/v1/standings/byConference?season={0}&expand=standings.record"
        Public Shared divisionStandings As String = "https://statsapi.web.nhl.com/api/v1/standings/byDivision?season={0}&expand=standings.record"
        Public Shared wildCardStandings As String = "https://statsapi.web.nhl.com/api/v1/standings/wildCard?season={0}&expand=standings.record"

        Public Shared todaysGames As String = "https://statsapi.web.nhl.com/api/v1/schedule"
        Public Shared specificGame As String = "https://statsapi.web.nhl.com/api/v1/game/###/feed/live"
        Public Shared specificGameContent As String = "https://statsapi.web.nhl.com/api/v1/game/###/content"
        Public Shared teams As String = "https://statsapi.web.nhl.com/api/v1/teams/"
        Public Shared team As String = "https://statsapi.web.nhl.com/api/v1/teams/{0}"
        Public Shared teams_roster_extension As String = "?expand=team.roster"
        Public Shared teams_nextgame_extension As String = "?expand=team.schedule.next"
        Public Shared teamsStandings As String = "https://statsapi.web.nhl.com/api/v1/standings/byLeague/"
        Public Shared venues As String = "http://statsapi.web.nhl.com/api/v1/venues/"
        Public Shared conferences As String = "https://statsapi.web.nhl.com/api/v1/conferences/"
        Public Shared divisions As String = "https://statsapi.web.nhl.com/api/v1/divisions/"
        Public Shared specificplayer As String = "http://statsapi.web.nhl.com/api/v1/people/"
        Public Shared specificplayer_currentyearstats_extension As String = "stats?stats=gameLog"
        Public Shared specificplayer_specificseasonstats_extension As String = "stats?stats=gameLog&season="
        Public Shared specificplayer_yearbyyearstats_extension As String = "stats?expand=person.stats&stats=yearByYear"
        Public Shared playerImage As String = "https://nhl.bamcontent.com/images/headshots/current/168x168/###.jpg"
        Public Shared playerImage2x As String = "https://nhl.bamcontent.com/images/headshots/current/168x168/###@2x.jpg"
        Public Shared playerImage3x As String = "https://nhl.bamcontent.com/images/headshots/current/168x168/###@3x.jpg"
        Public Shared schedule As String = "https://statsapi.web.nhl.com/api/v1/schedule"
        Public Shared schedule_betweendates_extension As String = "?teamId=##&startDate=@@@@@@@@@@&endDate=^^^^^^^^^^"
        Public Shared schedule_tickets_extension As String = "?expand=schedule.ticket"

        Function GetPlayerPictureURL(ByVal playerID As String, ByVal size As Integer) As String
            Dim theURL As String

            If size = 2 Then
                theURL = playerImage2x.Replace("###", playerID)
            ElseIf size = 3 Then
                theURL = playerImage3x.Replace("###", playerID)
            Else
                theURL = playerImage.Replace("###", playerID)
            End If

            Return theURL
        End Function
    End Class
End Namespace
