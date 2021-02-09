Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Newtonsoft.Json.Linq

Namespace NHLStats
    Public Class Conference
        Public Property conferenceID As Integer
        Public Property conferenceName As String
        Public Property conferenceAbbreviation As String
        Public Property shortName As String
        Public Property active As String
        Public Property conferenceJson As JObject

        Public Sub New()
        End Sub

        Public Sub New(ByVal theConferenceID As Integer)
            If theConferenceID = 0 Then
                conferenceID = theConferenceID
                conferenceName = "No Conference"
                conferenceAbbreviation = "NC"
                shortName = "NoConf"
                active = "N/A"
            Else
                Dim conferenceLink As String = NHLAPIServiceURLs.conferences & theConferenceID.ToString()
                Dim json = DataAccessLayer.ExecuteAPICall(conferenceLink)
                conferenceJson = json
                conferenceID = theConferenceID
                Dim detailsJson As JObject = New JObject()
                detailsJson = json.SelectToken("conferences[0]").ToObject(Of JObject)()

                If detailsJson("name") IsNot Nothing Then
                    conferenceName = json.SelectToken("conferences[0].name").ToString()
                End If

                If detailsJson("abbreviation")  IsNot Nothing Then
                    conferenceAbbreviation = json.SelectToken("conferences[0].abbreviation").ToString()
                End If

                If detailsJson("shortName") IsNot Nothing Then
                    shortName = json.SelectToken("conferences[0].shortName").ToString()
                End If

                If detailsJson("active")  IsNot Nothing Then
                    active = json.SelectToken("conferences[0].active").ToString()
                End If
            End If
        End Sub

        Public Shared Function GetAllConferences() As List(Of Conference)
            Dim json = DataAccessLayer.ExecuteAPICall(NHLAPIServiceURLs.conferences)
            Dim conferenceArray = JArray.Parse(json.SelectToken("conferences").ToString())
            Dim listOfConferences As List(Of Conference) = New List(Of Conference)()
            Dim tempConference As Conference

            For Each aConference In conferenceArray
                tempConference = New Conference(Convert.ToInt32(aConference.SelectToken("id")))
                listOfConferences.Add(tempConference)
            Next

            Return listOfConferences
        End Function
    End Class
End Namespace
