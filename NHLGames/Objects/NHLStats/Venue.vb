Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Newtonsoft.Json.Linq

Namespace NHLStats
    Public Class Venue
        Public Property venueID As String
        Public Property venueName As String
        Public Property venueJson As JObject

        Public Sub New()
        End Sub

        Public Sub New(ByVal theVenueID As String)
            venueID = theVenueID
            Dim venueLink As String = NHLAPIServiceURLs.venues & theVenueID
            Dim json = DataAccessLayer.ExecuteAPICall(venueLink)
            venueJson = json
            venueName = json.SelectToken("venues[0].name").ToString()
        End Sub
    End Class
End Namespace
