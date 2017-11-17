namespace NHLGames.WPF.Utilities
{

    public enum GameStateEnum
    {
        Scheduled = 1,
        Pregame = 2,
        InProgress = 3,
        Ending = 4,
        Final = 5
    }

    public enum GameTypeEnum
    {
        Preseason = 1,
        Season = 2,
        Series = 3
    }

    public enum StreamType
    {
        Away,
        Home,
        National,
        French,
        MultiCam1,
        MultiCam2,
        RefCam,
        EndzoneCam1,
        EndzoneCam2
    }

    public enum PlayerTypeEnum
    {
        None = 0,
        Vlc = 1,
        Mpc = 2,
        Mpv = 3
    }

    public enum SettingsEnum
    {
        Version = 1,
        DefaultWatchArgs = 2,
        VlcPath = 3,
        MpcPath = 4,
        MpvPath = 5,
        StreamlinkPath = 6,
        ServerList = 7,
        ShowScores = 8,
        SelectedServer = 9,
        SelectedLanguage = 10,
        ShowLiveScores = 11,
        ShowSeriesRecord = 12,
        LanguageList = 13
    }

    public enum OutputType
    {
        Normal = 0,
        Status = 1,
        Error = 2,
        Cli = 3
    }

    public enum CdnType
    {
        AKC = 0,
        L3C = 1
    }
}
