Namespace NHLStats
    Public Class Team
        Public Property id As Integer
        Public Property name As String
        Public Property link As String

        Public Shared Property TeamAbbreviation As Dictionary(Of String, String) = New Dictionary(Of String, String)
    End Class

    Public Class TeamObject
        Public Property name As String
        Public Property abbreviation As String
    End Class

    Public Class TeamRootobject
        Public Property teams As List(Of TeamObject)

        Public Shared Function GetTeamRootobject() As TeamRootobject
            Return DataAccessLayer.ExecuteAPICall(Of TeamRootobject)(NHLAPIServiceURLs.teams)
        End Function
    End Class


End Namespace

