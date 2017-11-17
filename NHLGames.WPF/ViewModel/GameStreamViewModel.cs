using System;
using System.Globalization;
using System.IO;
using System.Net;
using GalaSoft.MvvmLight;
using NHLGames.WPF.Objects;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using NHLGames.WPF.Utilities;

namespace NHLGames.WPF.ViewModel
{
    public class GameStreamViewModel : ViewModelBase
    {
        private bool _isVod;
        private string _gameUrl;
        private string _vodurl;
        private ICommand _startPlayerCommand;

        public StreamType Type { get; private set; }
        public GameViewModel Game { get; private set; }
        public bool IsDefined { get; private set; }
        public string Network { get; private set; }
        public string PlayBackId { get; private set; }
        public bool IsAvailable => !string.IsNullOrEmpty(GameUrl);
        public string Tooltip => GetToolTip();
        
        public bool IsVod
        {
            get => _isVod;
            set { Set(() => IsVod, ref _isVod, value); }
        }

        public string GameUrl
        {
            get => _gameUrl;
            set { Set(() => GameUrl, ref _gameUrl, value); }
        }

        public string Vodurl
        {
            get => _vodurl;
            set { Set(() => Vodurl, ref _vodurl, value); }
        }

        public ICommand StartPlayerCommand => _startPlayerCommand ?? (_startPlayerCommand = new RelayCommand(OnStartPlayerCommand));
       
        public void UpdateGameStream(GameViewModel game, Item stream, StreamType type)
        {
            Game = game;
            IsDefined = true;
            Network = stream.CallLetters;
            PlayBackId = stream.MediaPlaybackId;
            Type = type;
        }

        public void CheckVod(string strCdn)
        {
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(Vodurl.Replace("CDN", strCdn));
                myHttpWebRequest.CookieContainer = new CookieContainer();
                myHttpWebRequest.CookieContainer.Add(new Cookie("mediaAuth", Common.GetRandomString(240).ToString(), string.Empty, "nhl.com"));
                myHttpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, Like Gecko) Chrome/48.0.2564.82 Safari/537.36 Edge/14.14316";
                IsVod = Common.CheckUrl(Vodurl.Replace("CDN", strCdn), myHttpWebRequest);
            }
            catch (Exception e)
            {
                Console.WriteLine(Properties.Resources.msgVOD, e.Message);
            }
        }
        
        public void GetRightGameStream()
        {
            dynamic client = new WebClient();
            StreamReader reader;

            client.Headers.Set("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, Like Gecko) Chrome/48.0.2564.82 Safari/537.36 Edge/14.14316");

            var args = ApplicationSettings.Read<GameWatchArguments>(SettingsEnum.DefaultWatchArgs);
            var hostName = ApplicationSettings.Read<string>(SettingsEnum.SelectedServer);
            
            string address = $"http://{hostName}/m3u8/{Services.GameManager.GamesListDate:yyyy-MM-dd}/{PlayBackId}{args.Cdn}";
            string legacyAddress = $"http://{hostName}/m3u8/{Services.GameManager.GamesListDate:yyyy-MM-dd}/{PlayBackId}";

            try
            {
                reader = new StreamReader(client.OpenRead(address));
                GameUrl = reader.ReadToEnd();
            }
            catch (WebException ex)
            {
                try
                {
                    reader = new StreamReader(client.OpenRead(legacyAddress));
                    GameUrl = reader.ReadToEnd();
                }
                catch (Exception ex2)
                {
                    if (!ex2.Message.Contains("404"))
                    {
                        Console.WriteLine(Properties.Resources.errorGeneral, ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(Properties.Resources.errorGeneral, ex.Message);
            }
            finally
            {
                client.Dispose();
                SetVideoOnDemandLink();
            }

        }

        private void SetVideoOnDemandLink()
        {
            if (GameUrl != null && GameUrl.Contains("http://hlslive"))
            {
                dynamic spliter = GameUrl.Split('/');
                foreach (string split in spliter)
                {
                    if (split.StartsWith("NHL_GAME_VIDEO_"))
                    {
                        Vodurl = $"http://hlsvod-akc.med2.med.nhl.com/ps01/nhl/{DateTime.Now.Date.ToString(CultureInfo.InvariantCulture)}/{split}/master_wired60.m3u8";
                    }
                }
            }
        }

        private void OnStartPlayerCommand()
        {
            var args = WatchArgs();
            args.IsVod = IsGameVod(Game.AwayStream, args.Cdn);
            args.Stream = Game.AwayStream;
            Services.Player.Watch(args);
        }

        private GameWatchArguments WatchArgs()
        {
            dynamic args = ApplicationSettings.Read<GameWatchArguments>(SettingsEnum.DefaultWatchArgs);
            args.GameTitle = Game.AwayAbbrev + " @ " + Game.HomeAbbrev;
            return args;
        }

        private bool IsGameVod(GameStreamViewModel stream, string cdn)
        {
            bool isVod = false;
            if (DateHelper.GetPacificTime(Game.GameDate) != DateHelper.GetPacificTime())
            {
                if (!ReferenceEquals(stream.Vodurl, string.Empty))
                {
                    stream.CheckVod(cdn);
                    isVod = stream.IsVod;
                }
            }
            return isVod;
        }

        private string GetToolTip()
        {           
            string toolTip;
            switch (Type)
            {
                case StreamType.Away:
                    toolTip = String.Format(Properties.Resources.lblTeamStream, Game.AwayAbbrev);
                    toolTip += String.Format(Properties.Resources.lblOnNetwork, Game.AwayStream.Network);
                    return toolTip;
                case StreamType.Home:
                    toolTip = String.Format(Properties.Resources.lblTeamStream, Game.HomeAbbrev);
                    toolTip += String.Format(Properties.Resources.lblOnNetwork, Game.HomeStream.Network);
                    return toolTip;
                case StreamType.French:
                    toolTip = Properties.Resources.lblFrenchNetwork;
                    toolTip += String.Format(Properties.Resources.lblOnNetwork, Game.FrenchStream.Network);
                    return toolTip;
                case StreamType.National:
                    toolTip = Properties.Resources.lblNationalNetwork;
                    toolTip += String.Format(Properties.Resources.lblOnNetwork, Game.NationalStream.Network);
                    return toolTip;
                case StreamType.RefCam:
                    toolTip = Properties.Resources.lblRefCam;
                    return toolTip;
                case StreamType.MultiCam1:
                    toolTip = String.Format(Properties.Resources.lblCamViews, 3);
                    return toolTip;
                case StreamType.MultiCam2:
                    toolTip = String.Format(Properties.Resources.lblCamViews, 6);
                    return toolTip;
                case StreamType.EndzoneCam1:
                    toolTip = String.Format(Properties.Resources.lblEndzoneCam, Game.AwayAbbrev);
                    return toolTip;
                case StreamType.EndzoneCam2:
                    toolTip = String.Format(Properties.Resources.lblEndzoneCam, Game.HomeAbbrev);
                    return toolTip;
                default:
                    return string.Format(Properties.Resources.lblOnNetwork, Network);
            }
        }
    }
}
