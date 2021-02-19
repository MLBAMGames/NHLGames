Namespace NHLStats
    Public Class Team
        Public Property id As Integer
        Public Property name As String
        Public Property link As String

        Public Shared Property TeamAbbreviation As Dictionary(Of String, String) = New Dictionary(Of String, String)
    End Class

    Public Class TeamObject
        'Public Property id As Integer
        Public Property name As String
        'Public Property link As String
        Public Property abbreviation As String
        'Public Property teamName As String
        'Public Property locationName As String
        'Public Property firstYearOfPlay As String
        'Public Property shortName As String
        'Public Property officialSiteUrl As String
        'Public Property franchiseId As Integer
        'Public Property active As Boolean
    End Class

     Public Class TeamRootobject
        'Public Property copyright As String
        Public Property teams As List(Of TeamObject)

        Public Shared Function GetTeamRootobject() As TeamRootobject
            Return DataAccessLayer.ExecuteAPICall(Of TeamRootobject)(NHLAPIServiceURLs.teams)
        End Function
    End Class


End Namespace

