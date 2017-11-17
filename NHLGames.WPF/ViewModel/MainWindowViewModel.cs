using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Practices.ServiceLocation;
using NHLGames.WPF.Utilities;

namespace NHLGames.WPF.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _version;
        private bool _isActive;
        private ICommand _helpCommand;
        private ICommand _copyToClipboardCommand;
        private ICommand _clearCommand;
        private int _selectedIndex;

        public GamesViewModel GamesViewModel { get; set; }

        public SettingsViewModel SettingsViewModel { get; set; }
        
        public string Version
        {
            get => _version;
            set { Set(() => Version, ref _version, value); }
        }

        public int GamesFound => GamesViewModel.Games.Count;

        public bool IsActive
        {
            get => _isActive;
            set { Set(() => IsActive, ref _isActive, value); }
        }

        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                if (SelectedIndex == 1) //the settings page
                {
                    SettingsViewModel.SaveSetting();
                }
                Set(() => SelectedIndex, ref _selectedIndex, value); 
            }
        }

        public ICommand HelpCommand => _helpCommand ?? (_helpCommand = new RelayCommand(OnHelpCommand));

        public ICommand CopyToClipboardCommand => _copyToClipboardCommand ?? (_copyToClipboardCommand = new RelayCommand(OnCopyToClipboardCommand));

        public ICommand ClearCommand => _clearCommand ?? (_clearCommand = new RelayCommand(OnClearCommand));
        
        public MainWindowViewModel()
        {
            Version = ApplicationSettings.Read<string>(SettingsEnum.Version, "");
            SettingsViewModel = ServiceLocator.Current.GetInstance<SettingsViewModel>();
            GamesViewModel = ServiceLocator.Current.GetInstance<GamesViewModel>();
            GamesViewModel.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
            {
                if (args.PropertyName == nameof(GamesViewModel.Games))
                {
                    RaisePropertyChanged(nameof(GamesFound));
                }
            };
        }

        private void OnHelpCommand()
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/NHLGames/NHLGames#nhlgames");
            Process.Start(sInfo);
        }

        private void OnClearCommand()
        {
            throw new NotImplementedException();
        }

        private void OnCopyToClipboardCommand()
        {
            throw new NotImplementedException();
        }
    }
}
