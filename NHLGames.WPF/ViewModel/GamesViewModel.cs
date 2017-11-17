using System;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using NHLGames.WPF.Services;
using NHLGames.WPF.Utilities;

namespace NHLGames.WPF.ViewModel
{
    public class GamesViewModel : ViewModelBase
    {
        private bool _isActive;
        private DateTime _selectedDate;
        private ICommand _nextDateCommand;
        private ICommand _previousDateCommand;
        private ICommand _refreshGamesCommand;

        public bool IsActive
        {
            get => _isActive;
            set { Set(() => IsActive, ref _isActive, value); }
        }

        public DateTime SelectedDate
        {
            get => _selectedDate;
            set { Set(() => SelectedDate, ref _selectedDate, value); }
        }

        public ICommand NextDateCommand => _nextDateCommand ?? (_nextDateCommand = new RelayCommand(OnNextDateCommand));

        public ICommand PreviousDateCommand => _previousDateCommand ?? (_previousDateCommand = new RelayCommand(OnPreviousDateCommand));

        public ICommand RefreshGamesCommand => _refreshGamesCommand ?? (_refreshGamesCommand = new RelayCommand(OnRefreshGamesCommand));

        public ObservableCollectionEx<GameViewModel> Games => GameManager.GamesList;

        public GamesViewModel()
        {
            SelectedDate = DateTime.Now;
            OnRefreshGamesCommand();
        }

        private async void OnRefreshGamesCommand()
        {
            IsActive = true;

            await Task.Run(() => GameFetcher.LoadGames(SelectedDate, true));

            RaisePropertyChanged(nameof(Games));

            IsActive = false;
        }

        private void OnPreviousDateCommand()
        {
            SelectedDate = SelectedDate.AddDays(-1.0);
            OnRefreshGamesCommand();
        }

        private void OnNextDateCommand()
        {
            SelectedDate = SelectedDate.AddDays(1.0);
            OnRefreshGamesCommand();
        }
    }
}
