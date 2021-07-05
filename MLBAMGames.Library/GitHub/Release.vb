Namespace Objects.GitHub

    Class Release
        Public url As String
        Public assets_url As String
        Public upload_url As String
        Public html_url As String
        Public id As Integer
        Public node_id As String
        Public tag_name As String
        Public target_commitish As String
        Public draft As Boolean
        Public author As User
        Public prerelease As Boolean
        Public created_at As DateTime?
        Public published_at As DateTime?
        Public assets As Asset()
        Public tarball_url As String
        Public zipball_url As String
        Public body As String
    End Class
    
End Namespace
