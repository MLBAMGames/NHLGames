Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Newtonsoft.Json.Linq

Namespace NHLStats
    Public Class Division
        Public Property divisionId As Integer
        Public Property divisionName As String
        Public Property shortName As String
        Public Property abbreviation As String
        Public Property conference As Conference
        Public Property active As String
        Public Property divisionJson As JObject

        Public Sub New()
        End Sub

        Public Sub New(ByVal theDivisionId As Integer)
            If theDivisionId = 0 Then
                divisionId = theDivisionId
                divisionName = "No Division"
                shortName = "NoDiv"
                abbreviation = "ND"
                active = "N/A"
                conference = New Conference(0)
            Else
                divisionId = theDivisionId
                Dim divisionLink As String = NHLAPIServiceURLs.divisions & divisionId.ToString()
                Dim json = DataAccessLayer.ExecuteAPICall(divisionLink)
                divisionJson = json
                Dim keyCheckJson = json.SelectToken("divisions[0]").ToObject(Of JObject)()
                divisionName = json.SelectToken("divisions[0].name").ToString()

                If keyCheckJson("nameShort") IsNot Nothing Then
                    shortName = json.SelectToken("divisions[0].nameShort").ToString()
                End If

                If keyCheckJson("abbreviation") IsNot Nothing Then
                    abbreviation = json.SelectToken("divisions[0].abbreviation").ToString()
                End If

                If keyCheckJson("conference") IsNot Nothing Then
                    Dim theConference As Conference = New Conference(Convert.ToInt32(json.SelectToken("divisions[0].conference.id")))
                    conference = theConference
                End If

                If keyCheckJson("active") IsNot Nothing Then
                    active = json.SelectToken("divisions[0].active").ToString()
                End If
            End If
        End Sub

        Public Shared Function GetAllDivisions() As List(Of Division)
            Dim json = DataAccessLayer.ExecuteAPICall(NHLAPIServiceURLs.divisions)
            Dim divisionArray = JArray.Parse(json.SelectToken("divisions").ToString())
            Dim listOfDivisions As List(Of Division) = New List(Of Division)()
            Dim tempDivision As Division

            For Each aDivision In divisionArray
                tempDivision = New Division(Convert.ToInt32(aDivision.SelectToken("id")))
                listOfDivisions.Add(tempDivision)
            Next

            Return listOfDivisions
        End Function
    End Class
End Namespace
