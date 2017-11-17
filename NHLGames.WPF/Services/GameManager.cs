using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows;
using NHLGames.WPF.Objects;
using NHLGames.WPF.Utilities;
using NHLGames.WPF.ViewModel;

namespace NHLGames.WPF.Services
{
    public class GameManager
    {
        public static DateTime GamesListDate { get; set; }
        public static ObservableCollectionEx<GameViewModel> GamesList { get; }

        static GameManager()
        {
            GamesList = new ObservableCollectionEx<GameViewModel>();
        }

        public static void ClearGames()
        {
            GamesList.Clear();
            GamesListDate = DateTime.MinValue;
        }

        public static void GetGames(DateTime dateTime, RootObject rootObject, bool refreshing)
        {
            GamesListDate = dateTime;
            try
            {
                foreach (var date in rootObject.Dates)
                {
                    foreach (var game in date.Games)
                    {
                        if (refreshing)
                        {
                            GameViewModel gameViewModel = GamesList.FirstOrDefault(g => g.GameId == game.GamePk.ToString());
                            if (gameViewModel == null)
                            {
                                Application.Current.Dispatcher.Invoke(delegate { GamesList.Add(new GameViewModel(game)); });
                            }
                            else
                            {
                                Application.Current.Dispatcher.Invoke(delegate { gameViewModel.Update(game); });
                            }
                        }
                        else
                        {
                            Application.Current.Dispatcher.Invoke(delegate { GamesList.Add(new GameViewModel(game)); });
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(Properties.Resources.errorGeneral, e);
            }
        }
    }
}
