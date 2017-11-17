using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Windows.Input;
using Caliburn.Micro;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MahApps.Metro.Controls.Dialogs;
using Metro.Dialogs;
using NHLGames.WPF.Objects;
using NHLGames.WPF.Services;
using NHLGames.WPF.Utilities;
using ApplicationSettings = NHLGames.WPF.Utilities.ApplicationSettings;
using PathFinder = NHLGames.WPF.Utilities.PathFinder;
using PlayerTypeEnum = NHLGames.WPF.Utilities.PlayerTypeEnum;
using SettingsEnum = NHLGames.WPF.Utilities.SettingsEnum;

namespace NHLGames.WPF.ViewModel
{
    public class SettingsViewModel : ViewModelBase
    {
        private string _quality;
        private bool _is60Fps;
        private string _cdn;
        private bool _isVod;
        private string _gameTitle;
        private string _playerPath;
        private PlayerTypeEnum _playerType;
        private string _streamlinkPath;
        private bool _usestreamlinkArgs;
        private bool _usePlayerArgs;
        private bool _useOutputArgs;
        private string _streamlinkArgs;
        private string _playerArgs;
        private string _playerOutputPath;
        private string[] _hostNames;
        private string[] _languages;
        private string _hostName;
        private string _language;
        private bool _showScores;
        private bool _showLiveScores;
        private bool _showSeriesRecord;
        private ICommand _helpCommand;
        private ICommand _testHostCommand;
        private ICommand _viewHostCommand;
        private ICommand _addEntryCommand;
        private ICommand _removeEntriesCommand;
        private string _vlcPath;
        private string _mpcPath;
        private string _mpvPath;
        private ICommand _openOutputPathCommand;
        private ICommand _openVlcPathCommand;
        private ICommand _openMpcPathCommand;
        private ICommand _openMpvPathCommand;
        private ICommand _openSlPathCommand;
        private const string DomainName = "mf.svc.nhl.com";

        public GameWatchArguments GameWatchArguments { get; }

        public string Quality
        {
            get => _quality;
            set
            {
                Set(() => Quality, ref _quality, value);
                if (Quality != "720p")
                {
                    Is60Fps = false;
                }
            }
        }

        public bool Is60Fps
        {
            get => _is60Fps;
            set
            {
                Set(() => Is60Fps, ref _is60Fps, value);
                if (value)
                {
                    Quality = "720p";
                }
            }
        }

        public string Cdn
        {
            get => _cdn;
            set { Set(() => Cdn, ref _cdn, value); }
        }

        public bool IsVod
        {
            get => _isVod;
            set { Set(() => IsVod, ref _isVod, value); }
        }

        public string GameTitle
        {
            get => _gameTitle;
            set { Set(() => GameTitle, ref _gameTitle, value); }
        }

        public string PlayerPath
        {
            get => _playerPath;
            set { Set(() => PlayerPath, ref _playerPath, value); }
        }

        public PlayerTypeEnum PlayerType
        {
            get => _playerType;
            set
            {
                Set(() => PlayerType, ref _playerType, value);

                switch (PlayerType)
                {
                    case PlayerTypeEnum.Vlc:
                        PlayerPath = VlcPath;
                        break;
                    case PlayerTypeEnum.Mpc:
                        PlayerPath = MpcPath;
                        break;
                    case PlayerTypeEnum.Mpv:
                        PlayerPath = MpvPath;
                        break;
                }
            }
        }

        public string StreamlinkPath
        {
            get => _streamlinkPath;
            set { Set(() => StreamlinkPath, ref _streamlinkPath, value); }
        }

        public bool UsestreamlinkArgs
        {
            get => _usestreamlinkArgs;
            set { Set(() => UsestreamlinkArgs, ref _usestreamlinkArgs, value); }
        }

        public string StreamlinkArgs
        {
            get => _streamlinkArgs;
            set { Set(() => StreamlinkArgs, ref _streamlinkArgs, value); }
        }

        public bool UsePlayerArgs
        {
            get => _usePlayerArgs;
            set { Set(() => UsePlayerArgs, ref _usePlayerArgs, value); }
        }

        public string PlayerArgs
        {
            get => _playerArgs;
            set { Set(() => PlayerArgs, ref _playerArgs, value); }
        }

        public bool UseOutputArgs
        {
            get => _useOutputArgs;
            set { Set(() => UseOutputArgs, ref _useOutputArgs, value); }
        }

        public string PlayerOutputPath
        {
            get => _playerOutputPath;
            set { Set(() => PlayerOutputPath, ref _playerOutputPath, value); }
        }

        public string[] HostNames
        {
            get => _hostNames;
            set { Set(() => HostNames, ref _hostNames, value); }
        }

        public string HostName
        {
            get => _hostName;
            set
            {
                Set(() => HostName, ref _hostName, value);
                ServerIp = Dns.GetHostEntry(HostName).AddressList.First().ToString();
            }
        }

        public string ServerIp { get; set; }

        public string[] Languages
        {
            get => _languages;
            set { Set(() => Languages, ref _languages, value); }
        }

        public string Language
        {
            get => _language;
            set { Set(() => Language, ref _language, value); }
        }

        public bool ShowScores
        {
            get => _showScores;
            set { Set(() => ShowScores, ref _showScores, value); }
        }

        public bool ShowLiveScores
        {
            get => _showLiveScores;
            set { Set(() => ShowLiveScores, ref _showLiveScores, value); }
        }

        public bool ShowSeriesRecord
        {
            get => _showSeriesRecord;
            set { Set(() => ShowSeriesRecord, ref _showSeriesRecord, value); }
        }

        public string VlcPath
        {
            get => _vlcPath;
            set { Set(() => VlcPath, ref _vlcPath, value); }
        }

        public string MpcPath
        {
            get => _mpcPath;
            set { Set(() => MpcPath, ref _mpcPath, value); }
        }

        public string MpvPath
        {
            get => _mpvPath;
            set { Set(() => MpvPath, ref _mpvPath, value); }
        }

        public ICommand HelpCommand => _helpCommand ?? (_helpCommand = new RelayCommand(OnHelpCommand));
        public ICommand TestHostCommand => _testHostCommand ?? (_testHostCommand = new RelayCommand(OnTestHostCommand));
        public ICommand ViewHostCommand => _viewHostCommand ?? (_viewHostCommand = new RelayCommand(OnViewHostCommand));
        public ICommand AddEntryCommand => _addEntryCommand ?? (_addEntryCommand = new RelayCommand(OnAddEntryCommand));
        public ICommand RemoveEntriesCommand => _removeEntriesCommand ?? (_removeEntriesCommand = new RelayCommand(OnRemoveEntriesCommand));
        public ICommand OpenOutputPathCommand => _openOutputPathCommand ?? (_openOutputPathCommand = new RelayCommand(OnOpenOutputPathCommand));
        public ICommand OpenVlcPathCommand => _openVlcPathCommand ?? (_openVlcPathCommand = new RelayCommand(OnOpenVlcPathCommand));
        public ICommand OpenMpcPathCommand => _openMpcPathCommand ?? (_openMpcPathCommand = new RelayCommand(OnOpenMpcPathCommand));
        public ICommand OpenMpvPathCommand => _openMpvPathCommand ?? (_openMpvPathCommand = new RelayCommand(OnOpenMpvPathCommand));
        public ICommand OpenSlPathCommand => _openSlPathCommand ?? (_openSlPathCommand = new RelayCommand(OnOpenSlPathCommand));
        
        public SettingsViewModel()
        {
            GameWatchArguments = ApplicationSettings.Read<GameWatchArguments>(SettingsEnum.DefaultWatchArgs);
            var serverList = ApplicationSettings.Read<string>(SettingsEnum.ServerList);

            if (!string.IsNullOrWhiteSpace(serverList))
            {
                HostNames = serverList.Split(';');
            }

            var languageList = ApplicationSettings.Read<string>(SettingsEnum.LanguageList);

            if (!string.IsNullOrWhiteSpace(languageList))
            {
                Languages = languageList.Split(';');
            }

            HostName = ApplicationSettings.Read<string>(SettingsEnum.SelectedServer);
            Language = ApplicationSettings.Read<string>(SettingsEnum.SelectedLanguage);

            ShowScores = ApplicationSettings.Read<bool>(SettingsEnum.ShowScores);
            ShowLiveScores = ApplicationSettings.Read<bool>(SettingsEnum.ShowLiveScores);
            ShowSeriesRecord = ApplicationSettings.Read<bool>(SettingsEnum.ShowSeriesRecord);

            VlcPath = ApplicationSettings.Read<string>(SettingsEnum.VlcPath);
            MpcPath = ApplicationSettings.Read<string>(SettingsEnum.MpcPath);
            MpvPath = ApplicationSettings.Read<string>(SettingsEnum.MpvPath);
            StreamlinkPath = ApplicationSettings.Read<string>(SettingsEnum.StreamlinkPath);

            if (string.IsNullOrWhiteSpace(VlcPath))
            {
                VlcPath = PathFinder.GetPathOfVlc();
            }

            if (string.IsNullOrWhiteSpace(MpcPath))
            {
                MpcPath = PathFinder.GetPathOfMpc();
            }

            if (string.IsNullOrWhiteSpace(MpvPath))
            {
                MpvPath = PathFinder.GetPathOfMpv();
            }

            var thisProperties = this.GetType().GetProperties();
            foreach (var propertyInfo in GameWatchArguments.GetType().GetProperties())
            {
                var samePropertyInfo = thisProperties.FirstOrDefault(tp => tp.Name == propertyInfo.Name);
                if (samePropertyInfo != null)
                {
                    samePropertyInfo.SetValue(this, propertyInfo.GetValue(GameWatchArguments));
                }
            }
            
            if (string.IsNullOrWhiteSpace(StreamlinkPath))
            {
                StreamlinkPath = PathFinder.GetPathOfStreamlink();
            }
        }

        public void SaveSetting()
        {
            var properties = GameWatchArguments.GetType().GetProperties();
            foreach (var propertyInfo in GetType().GetProperties())
            {
                var samePropertyInfo = properties.FirstOrDefault(tp => tp.Name == propertyInfo.Name);
                if (samePropertyInfo != null)
                {
                    samePropertyInfo.SetValue(GameWatchArguments, propertyInfo.GetValue(this));
                }
            }

            ApplicationSettings.SetValue(SettingsEnum.DefaultWatchArgs, Serialization.SerializeObject(GameWatchArguments));
            ApplicationSettings.SetValue(SettingsEnum.SelectedServer, HostName);
            ApplicationSettings.SetValue(SettingsEnum.SelectedLanguage, Language);

            ApplicationSettings.SetValue(SettingsEnum.ShowScores, ShowScores.ToString());
            ApplicationSettings.SetValue(SettingsEnum.ShowLiveScores, ShowLiveScores.ToString());
            ApplicationSettings.SetValue(SettingsEnum.ShowSeriesRecord, ShowSeriesRecord.ToString());

            ApplicationSettings.SetValue(SettingsEnum.VlcPath, VlcPath);
            ApplicationSettings.SetValue(SettingsEnum.MpcPath, MpcPath);
            ApplicationSettings.SetValue(SettingsEnum.MpvPath, MpvPath);
            ApplicationSettings.SetValue(SettingsEnum.StreamlinkPath, StreamlinkPath);
        }

        private async void OnHelpCommand()
        {
            var result = await MessageManager.ShowMessageAsync(this, Properties.Resources.msgDiySteps, string.Format(Properties.Resources.msgDiyStepsText, Environment.NewLine, ServerIp, DomainName),
                 MessageDialogStyle.AffirmativeAndNegative, new MetroDialogSettings { AffirmativeButtonText = "Yes", NegativeButtonText = "No" });

            if (result == MessageDialogResult.Affirmative)
            {
                Clipboard.SetText(ServerIp + Environment.NewLine + DomainName);
            }
        }

        private async void OnTestHostCommand()
        {
            if (HostsFile.TestEntry(DomainName, ServerIp))
            {
                await MessageManager.ShowMessageAsync(this, Properties.Resources.msgSuccess, Properties.Resources.msgHostsSuccess);
            }
            else
            {
                await MessageManager.ShowMessageAsync(this, Properties.Resources.msgFailure, Properties.Resources.msgHostsFailure);
            }
        }

        private void OnViewHostCommand()
        {
            string hostsFilePath = Environment.SystemDirectory + "\\drivers\\etc\\hosts";
            Process.Start("NOTEPAD", hostsFilePath);
        }

        private void OnAddEntryCommand()
        {
            HostsFile.AddEntry(ServerIp, DomainName);
        }

        private void OnRemoveEntriesCommand()
        {
            HostsFile.CleanHosts(DomainName);
        }
        
        private void OnOpenOutputPathCommand()
        {
            WindowsDialogs svc = new WindowsDialogs(new WindowManager());
            PlayerOutputPath = svc.ShowSelectFolderDialog("Select output folder");
        }
        
        private void OnOpenVlcPathCommand()
        {
            VlcPath = GetSelectedFile("Select the Vlc executable");
        }
        
        private void OnOpenMpcPathCommand()
        {
            MpcPath = GetSelectedFile("Select the Mpc executable");
        }
        
        private void OnOpenMpvPathCommand()
        {
            MpvPath = GetSelectedFile("Select the Mpv executable");
        }
        
        private void OnOpenSlPathCommand()
        {
            StreamlinkPath = GetSelectedFile("Select the Streamlink executable");
        }

        private string GetSelectedFile(string title)
        {
            WindowsDialogs svc = new WindowsDialogs(new WindowManager());
            return svc.ShowOpenFileDialog(title, "Executable files (*.exe)|*.exe");
        }
    }
}
