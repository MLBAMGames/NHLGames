Imports NHLGames.Utilities
Imports System.Globalization

Namespace NHLStats

    Public Class StandingsViewModel
        Public Shared Function GenerateViewModels(standingType As StandingTypeEnum, record As Record) As List(Of StandingViewModel)
            Dim standings As List(Of StandingViewModel) = New List(Of StandingViewModel)

            For index As Integer = 0 To record.teamRecords.Count() - 1

                Dim teamRecord As Teamrecord = record.teamRecords(index)

                Dim standingRowHeaderViewModel As StandingRowHeaderViewModel = New StandingRowHeaderViewModel(standingType, record)
                standingRowHeaderViewModel.Rank = index + 1
                standingRowHeaderViewModel.TeamName = teamRecord.team.name

                Dim standingViewModel As StandingViewModel = New StandingViewModel()
                standingViewModel.RowHeader = standingRowHeaderViewModel
                standingViewModel.GP = teamRecord.gamesPlayed
                standingViewModel.W = teamRecord.leagueRecord.wins
                standingViewModel.L = teamRecord.leagueRecord.losses
                standingViewModel.OT = teamRecord.leagueRecord.ot
                standingViewModel.PTS = teamRecord.points
                standingViewModel.Perc = Math.Round(teamRecord.pointsPercentage, 3).ToString("F3", CultureInfo.InvariantCulture)
                standingViewModel.RW = teamRecord.regulationWins
                standingViewModel.ROW = teamRecord.row
                standingViewModel.GF = teamRecord.goalsScored
                standingViewModel.GA = teamRecord.goalsAgainst

                Dim diff = teamRecord.goalsScored - teamRecord.goalsAgainst
                If (diff > 0) Then
                    standingViewModel.DIFF = "+" + diff.ToString()
                Else
                    standingViewModel.DIFF = diff.ToString()
                End If

                standingViewModel.HOME = GetOverallRecords(teamRecord, "home")
                standingViewModel.AWAY = GetOverallRecords(teamRecord, "away")
                standingViewModel.ShootOut = GetOverallRecords(teamRecord, "shootOuts")
                standingViewModel.L10 = GetOverallRecords(teamRecord, "lastTen")

                standingViewModel.STRK = teamRecord.streak.streakCode

                standings.Add(standingViewModel)
            Next
            Return standings
        End Function

        Private Shared Function GetOverallRecords(teamRecord As Teamrecord, overallRecordType As String) As String
            Dim first = teamRecord.records.overallRecords.FirstOrDefault(Function(overallRecord) overallRecord.type = overallRecordType)

            Return String.Format("{0}-{1}-{2}", first.wins, first.losses, first.ot)
        End Function
    End Class

    Public Class StandingRowHeaderViewModel
        Public Sub New(standingType As StandingTypeEnum, teamRecord As Record)
            Me.Header = GetHeader(standingType, teamRecord)
        End Sub

        Public Property Rank As Integer
        Public Property TeamLogo As Image
        Public Property TeamName As String

        Private Property Header As String

        Public Overrides Function ToString() As String
            Return Header
        End Function

        Private Shared Function GetHeader(standingType As StandingTypeEnum, teamRecord As Record) As String
            If (standingType = StandingTypeEnum.League) Then
                If (teamRecord.league IsNot Nothing) Then
                    Return teamRecord.league.name
                End If
            ElseIf (standingType = StandingTypeEnum.Conference) Then
                If (teamRecord.conference IsNot Nothing) Then
                    Return teamRecord.conference.name
                End If
            ElseIf (standingType = StandingTypeEnum.Division Or standingType = StandingTypeEnum.WildCard) Then
                If (teamRecord.division IsNot Nothing) Then
                    Return teamRecord.division.name
                End If
            End If

            Return String.Empty
        End Function
    End Class

    Public Class StandingViewModel
        Public Property RowHeader As StandingRowHeaderViewModel
        Public Property GP As Integer
        Public Property W As Integer
        Public Property L As Integer
        Public Property OT As Integer
        Public Property PTS As Integer
        Public Property Perc As String
        Public Property RW As Integer
        Public Property ROW As Integer
        Public Property GF As Integer
        Public Property GA As Integer
        Public Property DIFF As String
        Public Property HOME As String
        Public Property AWAY As String
        Public Property ShootOut As String
        Public Property L10 As String
        Public Property STRK As String
    End Class

End Namespace