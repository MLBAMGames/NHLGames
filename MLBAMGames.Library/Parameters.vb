Imports MLBAMGames.Library.Objects

Public Class Parameters
    Public Const DomainName As String = "mf.svc.nhl.com"
    Public Const SubredditLink As String = "https://www.reddit.com/r/nhl_games/"
    Public Const LatestReleaseLink As String = "https://github.com/NHLGames/NHLGames/releases/latest"

    Public Const ResizeBorderWidth As Integer = 8

    Public Shared HostName As String = String.Empty
    Public Shared IsDarkMode As Boolean = False
    Public Shared IsServerUp As Boolean = Nothing
    Public Shared IsProxyListening As Task(Of Boolean) = Nothing
    Public Shared IsHostsRedirectionSet As Boolean = False
    Public Shared ResizeDirection As Integer = -1
    Public Shared UILoaded As Boolean = False
    Public Shared TodayLiveGamesFirst As Boolean = False
    Public Shared StreamStarted As Boolean = False

    Public Shared SpnLoadingValue As Integer = 0
    Public Shared SpnLoadingMaxValue As Integer = 1000
    Public Shared SpnLoadingVisible As Boolean = False
    Public Shared SpnStreamingValue As Integer = 0
    Public Shared SpnStreamingMaxValue As Integer = 1000
    Public Shared SpnStreamingVisible As Boolean = False

    Public Shared Tips As New Dictionary(Of Integer, String)
    Public Shared WatchArgs As GameWatchArguments = New GameWatchArguments
End Class
