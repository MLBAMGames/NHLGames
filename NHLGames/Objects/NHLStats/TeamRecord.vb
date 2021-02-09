Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace NHLStats
    Public Class TeamRecord
        Inherits Team

        Public Property season As String
        Public Property asOfGameDate As String
        Public Property DivisionL10Rank As Integer
        Public Property DivisionHomeRank As Integer
        Public Property DivisionRoadRank As Integer
        Public Property ConferenceL10Rank As Integer
        Public Property ConferenceHomeRank As Integer
        Public Property ConferenceRoadRank As Integer
        Public Property LeagueL10Rank As Integer
        Public Property LeagueHomeRank As Integer
        Public Property LeagueRoadRank As Integer
        Public Property clinchIndicator As String

        Public Sub New()
            MyBase.New()
        End Sub
    End Class
End Namespace
