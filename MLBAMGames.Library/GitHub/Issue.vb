Namespace Objects.GitHub

    Public Class Issue
        Public url As String
        Public repository_url As String
        Public labels_url As String
        Public comments_url As String
        Public events_url As String
        Public html_url As String
        Public id As Integer
        Public node_id As String
        Public number As Integer?
        Public title As String
        Public user As User
        Public labels As Label()
        Public state As String
        Public locked As Boolean
        Public assignee As User
        Public assignees As User()
        Public milestone As Milestone
        Public comments As Integer?
        Public created_at As DateTime?
        Public updated_at As DateTime?
        Public closed_at As DateTime?
        Public author_association As String
        Public pull_request As Commit
        Public body As String
    End Class

End Namespace