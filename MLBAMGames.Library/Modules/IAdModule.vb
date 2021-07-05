Imports MLBAMGames.Library.Utilities

Namespace Objects.Modules
    Public Interface IAdModule
        ReadOnly Property Title As AdModulesEnum
        Sub Initialize()
        Sub AdPlaying()
        Sub AdStarted()
        Sub AdEnded()
        Sub DisposeIt()
    End Interface
End Namespace
