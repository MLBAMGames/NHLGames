Imports NAudio.CoreAudioApi
Imports NHLGames.Utilities

Namespace Objects.Modules
    Public Interface IAdModule
        ReadOnly Property Title As AdModulesEnum
        Sub Initialize()
        Sub AdStarted()
        Sub AdEnded()
        Sub Dispose()
    End Interface
End Namespace
