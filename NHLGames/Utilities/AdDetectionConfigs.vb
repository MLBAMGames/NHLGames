Imports NHLGames.Objects.Modules

Namespace Utilities
    Public Class AdDetectionConfigs
        Public Property IsEnabled As Boolean = False
        Public Property EnabledSpotifyModule As Boolean = False
        Public Property EnabledObsModule As Boolean = False
        Public Property EnabledObsGameSceneHotKey As Hotkey = New Hotkey()
        Public Property EnabledObsAdSceneHotKey As Hotkey = New Hotkey()
        Public Property EnabledSpotifyForceToOpen As Boolean = False
        Public Property EnabledSpotifyPlayNextSong As Boolean = False
        Public Property EnabledSpotifyAndAnyMediaPlayer As Boolean = False
        Public Property MediaControlDelay As Integer = 100
    End Class
End Namespace