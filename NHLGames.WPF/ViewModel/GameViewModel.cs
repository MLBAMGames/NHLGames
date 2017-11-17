using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using GalaSoft.MvvmLight;
using NHLGames.WPF.Objects;
using NHLGames.WPF.Utilities;

namespace NHLGames.WPF.ViewModel
{
    [DebuggerDisplay("{HomeTeam} vs. {AwayTeam} at {GameDate}")]
    public class GameViewModel : ViewModelBase
    {
        public event GameUpdatedEventHandler GameUpdated;
        public delegate void GameUpdatedEventHandler(object sender);

        private readonly Dictionary<StreamType, GameStreamViewModel> _streams;
        private Game _gameObj;
        private GameTypeEnum _gameType;
        private Guid _id;
        private string _gameId = string.Empty;
        private DateTime _gameDate;
        private GameStateEnum _gameState;
        private string _gamePeriod = string.Empty;
        private string _gameTimeLeft = string.Empty;
        private int _seriesGameNumber;
        private string _seriesGameStatus = string.Empty;
        private string _away = string.Empty;
        private string _awayAbbrev = string.Empty;
        private string _awayTeam = string.Empty;
        private string _home = string.Empty;
        private string _homeAbbrev = string.Empty;
        private string _homeTeam = string.Empty;
        private string _homeScore = string.Empty;
        private string _awayScore = string.Empty;
        private string _gameTitle = string.Empty;
        private string _toolTipHomeTeam;
        private string _toolTipAwayTeam;

        public Guid Id
        {
            get => _id;
            set { Set(() => Id, ref _id, value); }
        }

        public string GameId
        {
            get => _gameId;
            set { Set(() => GameId, ref _gameId, value); }
        }

        public DateTime GameDate
        {
            get => _gameDate;
            set { Set(() => GameDate, ref _gameDate, value); }
        }

        public GameStateEnum GameState
        {
            get => _gameState;
            set { Set(() => GameState, ref _gameState, value); }
        }

        public string GamePeriod
        {
            get => _gamePeriod;
            set { Set(() => GamePeriod, ref _gamePeriod, value); }
        }

        public string GameTimeLeft
        {
            get => _gameTimeLeft;
            set { Set(() => GameTimeLeft, ref _gameTimeLeft, value); }
        }

        public int SeriesGameNumber
        {
            get => _seriesGameNumber;
            set { Set(() => SeriesGameNumber, ref _seriesGameNumber, value); }
        }

        public string SeriesGameStatus
        {
            get => _seriesGameStatus;
            set { Set(() => SeriesGameStatus, ref _seriesGameStatus, value); }
        }

        public string Away
        {
            get => _away;
            set { Set(() => Away, ref _away, value); }
        }

        public string AwayAbbrev
        {
            get => _awayAbbrev;
            set { Set(() => AwayAbbrev, ref _awayAbbrev, value); }
        }

        public string AwayTeam
        {
            get => _awayTeam;
            set { Set(() => AwayTeam, ref _awayTeam, value); }
        }

        public string Home
        {
            get => _home;
            set { Set(() => Home, ref _home, value); }
        }

        public string HomeAbbrev
        {
            get => _homeAbbrev;
            set { Set(() => HomeAbbrev, ref _homeAbbrev, value); }
        }

        public string HomeTeam
        {
            get => _homeTeam;
            set { Set(() => HomeTeam, ref _homeTeam, value); }
        }

        public string HomeScore
        {
            get => _homeScore;
            set { Set(() => HomeScore, ref _homeScore, value); }
        }

        public string AwayScore
        {
            get => _awayScore;
            set { Set(() => AwayScore, ref _awayScore, value); }
        }

        public string GameTitle
        {
            get => _gameTitle;
            set { Set(() => GameTitle, ref _gameTitle, value); }
        }
        public string ToolTipHomeTeam
        {
            get => _toolTipHomeTeam;
            set { Set(() => ToolTipHomeTeam, ref _toolTipHomeTeam, value); }
        }
        
        public string ToolTipAwayTeam
        {
            get => _toolTipAwayTeam;
            set { Set(() => ToolTipAwayTeam, ref _toolTipAwayTeam, value); }
        }

        public GameStreamViewModel AwayStream => _streams[StreamType.Away];

        public GameStreamViewModel HomeStream => _streams[StreamType.Home];

        public GameStreamViewModel NationalStream => _streams[StreamType.National];

        public GameStreamViewModel FrenchStream => _streams[StreamType.French];

        public GameStreamViewModel MultiCam1Stream => _streams[StreamType.MultiCam1];

        public GameStreamViewModel MultiCam2Stream => _streams[StreamType.MultiCam2];

        public GameStreamViewModel EndzoneCam1Stream => _streams[StreamType.EndzoneCam1];

        public GameStreamViewModel EndzoneCam2Stream => _streams[StreamType.EndzoneCam2];

        public GameStreamViewModel RefCamStream => _streams[StreamType.RefCam];
        
        public bool GameIsFinal => GameState == GameStateEnum.Final;

        public bool GameIsLive => GameState == GameStateEnum.InProgress || GameState == GameStateEnum.Ending;

        public bool GameIsPreGame => GameState == GameStateEnum.Pregame;

        public bool GameIsScheduled => GameState == GameStateEnum.Scheduled;

        public bool GameIsInPlayoff => _gameType == GameTypeEnum.Series;

        public bool GameIsInSeason => _gameType == GameTypeEnum.Season;

        public bool GameIsInPreSeason => _gameType == GameTypeEnum.Preseason;

        public bool AreAnyStreamsAvailable => AwayStream.IsAvailable || HomeStream.IsAvailable || NationalStream.IsAvailable || FrenchStream.IsAvailable;

        public List<GameStreamViewModel> AvailableStreams => _streams.Values.Where(g => g.IsDefined).ToList();

        public GameViewModel()
        {
            _streams = new Dictionary<StreamType, GameStreamViewModel>();
            foreach (StreamType type in Enum.GetValues(typeof(StreamType)))
            {
                var gameStreamViewModel = new GameStreamViewModel();
                gameStreamViewModel.PropertyChanged += (sender, args) =>
                {
                    if (args.PropertyName == nameof(GameStreamViewModel.GameUrl))
                    {
                        RaisePropertyChanged(nameof(AreAnyStreamsAvailable));
                    }
                };
                _streams.Add(type, gameStreamViewModel);
            }
        }

        public GameViewModel(Game game) 
            : this()
        {
            _gameObj = game;
            LoadGameData(game);
            UpdateGame(true, false, false);
        }
        
        public void Update(GameViewModel game)
        {
            if (_gameObj.GetHashCode() != game.GetHashCode())
            {
                if (GameIsLive)
                {
                    _awayScore = game.AwayScore;
                    _homeScore = game.HomeScore;
                }

                GameUpdated?.Invoke(this);
            }
        }

        public void Update(Game game)
        {
            if (_gameObj.ToString() != game.ToString())
            {
                _gameObj = game;
                GetGameInfos(game);
                GetGameStreams(game);
            }
        }


        public void UpdateGame(bool showScores, bool showLiveScores, bool showSeriesRecord)
        {
            if (GameIsLive)
            {
               // lblHomeScore.Visible = showLiveScores;
               // lblAwayScore.Visible = showLiveScores;
                if (((!showLiveScores & GameDate.ToLocalTime() == DateTime.Today) || !showSeriesRecord) & GameIsInPlayoff)
                {
                    GameTitle = Properties.Resources.lblPlayoffs;
                }
            }
            else
            {
               // lblHomeScore.Visible = showScores;
                //lblAwayScore.Visible = showScores;
                if (showScores & GameIsFinal & !String.Equals(GamePeriod, Properties.Resources.gamePeriod3, StringComparison.CurrentCultureIgnoreCase))
                {
                    if (!string.IsNullOrEmpty(GamePeriod))
                    {
                        GameTimeLeft = Properties.Resources.ResourceManager.GetString("enum" + GameState.ToString().ToLower()).ToUpper() + "/" + GamePeriod;
                    }
                }
                else if (GamePeriod.Contains(Properties.Resources.gamePeriodOt))
                {
                    GameTimeLeft = Properties.Resources.gamePeriodFinal.ToUpper();
                }
                if (((!showScores & GameIsFinal) || !showSeriesRecord) & GameIsInPlayoff)
                {
                    GameTitle = Properties.Resources.lblPlayoffs.ToUpper();
                }
                else
                {
                    SetGameTitle();
                }
            }

           // live1.Visible = GameIsLive;
            //live2.Visible = GameIsLive;
        }

        private void LoadGameData(Game game)
        {
            //GameTitle = string.Empty;
            //GamePeriod = string.Empty;

            string dateTimeStr = game.GameDate;
            //"2016-03-20T21:00:00Z"

            if (DateTime.TryParseExact(dateTimeStr, "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dateTimeVal))
            {
                dateTimeVal = DateTime.Parse(game.GameDate);
            }

            GameDate = dateTimeVal.ToUniversalTime();
            // Must use universal time to always get correct date for stream

            GameId = game.GamePk.ToString();
            dynamic status = Convert.ToInt16(game.Status.StatusCode);
            dynamic statusId = status >= 5 ? 5 : status;

            //if (!(game.TryGetValue("teams", "home") & game.TryGetValue("teams", "away") & game.TryGetValue("linescore", "currentPeriodOrdinal") & game.TryGetValue("linescore", "currentPeriodTimeRemaining") & game.TryGetValue("content", "media")))
            //{
            //   // messageError = English.errorUnableToDecodeJson;
            //}

            _gameType = (GameTypeEnum)Convert.ToInt16(GameId[7]) - 48;
            //Get type of the game : 1 preseason, 2 regular, 3 series
            GameState = (GameStateEnum)statusId;

            if (_gameType == GameTypeEnum.Series)
            {
                //if (!game.TryGetValue("seriesSummary", "gameNumber") & game.TryGetValue("seriesSummary", "seriesStatusShort"))
                //{
                //    messageError = English.errorUnableToDecodeJson;
                //}
            }

            Home = game.Teams.Home.Team.LocationName;
            HomeAbbrev = game.Teams.Home.Team.Abbreviation;
            HomeTeam = game.Teams.Home.Team.TeamName;

            Away = game.Teams.Away.Team.LocationName;
            AwayAbbrev = game.Teams.Away.Team.Abbreviation;
            AwayTeam = game.Teams.Away.Team.TeamName;

            ToolTipAwayTeam = String.Format(Properties.Resources.lblAwayTeam, Away, AwayTeam);
            ToolTipHomeTeam = String.Format(Properties.Resources.lblHomeTeam, Home, HomeTeam);

            GetGameInfos(game);
            GetGameStreams(game);

            if (GameIsLive)
            {
                GameTimeLeft = GameTimeLeft.ToUpper();
                GamePeriod = GamePeriod.ToUpper();
            }
            else if (GameIsFinal)
            {
                GameTimeLeft = Properties.Resources.ResourceManager.GetString("enum" + GameState.ToString().ToLower()).ToUpper();
            }
            else if (GameIsPreGame)
            {
                GameTimeLeft = GameDate.ToLocalTime().ToString("h:mm tt");
                GamePeriod = Properties.Resources.ResourceManager.GetString("enum" + GameState.ToString().ToLower()).ToUpper();
            }
            else
            {
                GameTimeLeft = GameDate.ToLocalTime().ToString("h:mm tt");
            }
        }

        private void GetGameInfos(Game game)
        {
            if (_gameType == GameTypeEnum.Series)
            {
               // SeriesGameNumber = game["seriesSummary"]["gameNumber"].ToString();
               // SeriesGameStatus = game["seriesSummary"]["seriesStatusShort"].ToString().ToLower().Replace("tied", Properties.Resources.gameSeriesTied).Replace("wins", Properties.Resources.gameSeriesWin).Replace("leads", Properties.Resources.gameSeriesLead).ToUpper();
                //Team wins 4-2, Tied 2-2, Team leads 1-0
            }

            if (GameState >= GameStateEnum.InProgress)
            {
                 GamePeriod = game.Linescore.CurrentPeriodOrdinal.Replace("1st", Properties.Resources.gamePeriod1).Replace("2nd", Properties.Resources.gamePeriod2).Replace("3rd", Properties.Resources.gamePeriod3).Replace("OT", Properties.Resources.gamePeriodOt).ToUpper();
                //1st 2nd 3rd OT 2OT ...
                if (GamePeriod.Contains(Properties.Resources.gamePeriodOt))
                {
                    if (char.IsDigit(GamePeriod[0]))
                    {
                        GamePeriod = string.Format(Properties.Resources.gamePeriodOtMore, GamePeriod[0]);
                    }
                }
                GameTimeLeft = game.Linescore.CurrentPeriodTimeRemaining.Replace("Final", Properties.Resources.gamePeriodFinal).ToUpper();
                //Final, 12:34, 20:00
            }

            if (GameDate <= DateTime.Now.ToUniversalTime())
            {
                HomeScore = game.Teams.Home.Score.ToString();
                AwayScore = game.Teams.Away.Score.ToString();
            }

            SetGameTitle();
        }

        private void GetGameStreams(Game game)
        {
            if (game.Content.Media != null)
            {
                foreach (Epg stream in game.Content.Media.Epg)
                {
                    if (stream.Title == "NHLTV")
                    {
                        if (stream.Items.Count == 0)
                            return;

                        foreach (var innerStream in stream.Items)
                        {
                            string strType = innerStream.MediaFeedType;
                            if (strType == "AWAY")
                            {
                                _streams[StreamType.Away].UpdateGameStream(this, innerStream, StreamType.Away);
                            }
                            else if (strType == "HOME")
                            {
                                _streams[StreamType.Home].UpdateGameStream(this, innerStream, StreamType.Home);
                            }
                            else if (strType == "NATIONAL")
                            {
                                _streams[StreamType.National].UpdateGameStream(this, innerStream, StreamType.National);
                            }
                            else if (strType == "FRENCH")
                            {
                                _streams[StreamType.French].UpdateGameStream(this, innerStream, StreamType.French);
                            }
                            else if (strType == "COMPOSITE")
                            {
                                if (innerStream.FeedName.Equals("Multi-Cam 1"))
                                {
                                    _streams[StreamType.MultiCam1].UpdateGameStream(this, innerStream, StreamType.MultiCam1);
                                }
                                else if (innerStream.FeedName.Equals("Multi-Cam 2"))
                                {
                                    _streams[StreamType.MultiCam2].UpdateGameStream(this, innerStream, StreamType.MultiCam2);
                                }
                            }
                            else if (strType == "ISO")
                            {
                                if (innerStream.FeedName.Equals("Endzone Cam 1"))
                                {
                                    _streams[StreamType.EndzoneCam1].UpdateGameStream(this, innerStream, StreamType.EndzoneCam1);
                                }
                                else if (innerStream.FeedName.Equals("Endzone Cam 2"))
                                {
                                    _streams[StreamType.EndzoneCam2].UpdateGameStream(this, innerStream, StreamType.EndzoneCam2);
                                }
                                else if (innerStream.FeedName.Equals("Ref Cam"))
                                {
                                    _streams[StreamType.RefCam].UpdateGameStream(this, innerStream, StreamType.RefCam);
                                }
                            }
                        }
                    }
                }
            }

            foreach (KeyValuePair<StreamType, GameStreamViewModel> stream in _streams)
            {
                if (stream.Value.IsDefined)
                {
                    var thread = new Thread(stream.Value.GetRightGameStream);
                    thread.SetApartmentState(ApartmentState.MTA);
                    thread.IsBackground = true;
                    thread.Priority = ThreadPriority.Normal;
                    thread.Start();
                }
            }
        }

        private void SetGameTitle()
        {
            if (!GameIsInSeason)
            {
                if (GameIsInPlayoff)
                {
                    if (GameIsLive | GameIsPreGame)
                    {
                        GameTitle = SeriesGameNumber != 1 ? 
                            string.Format(Properties.Resources.lblGameAbv, SeriesGameNumber, SeriesGameStatus).ToUpper() : 
                            string.Format(Properties.Resources.lblGame, SeriesGameNumber).ToUpper();
                    }
                    else
                    {
                        GameTitle = SeriesGameStatus;
                        GamePeriod = string.Format(Properties.Resources.lblGame, SeriesGameNumber).ToUpper();
                    }
                }
                else
                {
                    GameTitle = Properties.Resources.lblPreseason.ToUpper();
                }
            }
        }

        public override string ToString()
        {
            return string.Format(Properties.Resources.msgTeamVsTeam, HomeTeam, AwayTeam);
        }
    }
}
