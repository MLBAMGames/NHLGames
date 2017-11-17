using System;
using System.Windows;
using MetroFramework.Controls;

namespace NHLGames.WPF.Services
{
    public class GameFetcher
    {
        public static void StreamingProgress()
        {
            //NHLGamesMetro form = NHLGamesMetro.FormInstance;
            //form.spnStreaming.Visible = NHLGamesMetro.ProgressVisible;
            //form.flpGames.Enabled = false;
            //form.flpGames.Focus();
            //Progress(form.spnStreaming);
        }

        public static void LoadingProgress()
        {
            //NHLGamesMetro form = NHLGamesMetro.FormInstance;
            //form.spnLoading.Visible = NHLGamesMetro.ProgressVisible;
            //form.flpGames.Enabled = true;
            //Progress(form.spnLoading);
        }

        private static void Progress(MetroProgressSpinner spinner)
        {
            //NHLGamesMetro form = NHLGamesMetro.FormInstance;

            //if (NHLGamesMetro.ProgressValue < spinner.Maximum & NHLGamesMetro.ProgressValue >= 0)
            //{
            //    spinner.Value = NHLGamesMetro.ProgressValue;
            //}

            if (spinner.Visible)
            {
                //form.btnDate.Enabled = false;
                //form.btnTomorrow.Enabled = false;
                //form.btnYesterday.Enabled = false;
                //form.lblNoGames.Visible = false;
            }
            else
            {
                spinner.Value = 0;
                //form.btnDate.Enabled = true;
                //form.btnTomorrow.Enabled = true;
                //form.btnYesterday.Enabled = true;
                //if ((form.flpGames.Controls.Count == 0))
                //{
                //    form.lblNoGames.Visible = true;
                //}
                //else
                //{
                //    form.lblNoGames.Visible = false;
                //}
            }

        }

        public static void LoadGames(DateTime dateTime, bool refreshing)
        {
            try
            {
                //NHLGamesMetro.ProgressVisible = true;
                //NHLGamesMetro.ProgressValue = 0;
                //InvokeElement.SetFormStatusLabel(NHLGamesMetro.RmText.GetString("msgLoadingGames"));

               // if (!refreshing)
                //{
                    Application.Current.Dispatcher.Invoke(GameManager.ClearGames);
                   
                //}

               // InvokeElement.ClearGamePanel();

                var rootObject = Downloader.DownloadJsonSchedule(dateTime, refreshing);
                if (rootObject != null)
                {
                    GameManager.GetGames(dateTime, rootObject, refreshing);
                    //Common.WaitForGameThreads();
                    //NHLGamesMetro.ProgressValue = NHLGamesMetro.ProgressMaxValue - 1;
                    //Threading.Thread.Sleep(100);
                    //InvokeElement.NewGamesFound(GameManager.GamesDict);
                    //InvokeElement.SetFormStatusLabel(string.Format(NHLGamesMetro.RmText.GetString("msgGamesFound"), GameManager.GamesList.Count.ToString()));
                    // NHLGamesMetro.ProgressVisible = false;
                }
                else
                {
                    Console.WriteLine(Properties.Resources.errorFetchingGames);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

