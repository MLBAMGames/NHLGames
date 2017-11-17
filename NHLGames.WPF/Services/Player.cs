using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NHLGames.WPF.Objects;

namespace NHLGames.WPF.Services
{
    public class Player
    {
        public static void Watch(GameWatchArguments args)
        {
            //NHLGamesMetro form = NHLGamesMetro.FormInstance;

            if (args.PlayerPath.Equals(string.Empty) || args.StreamlinkPath.Equals(string.Empty))
            {
                if (args.StreamlinkPath.Equals(string.Empty))
                {
                    Console.WriteLine(Properties.Resources.errorStreamlinkExe);
                }
                else if (args.PlayerPath.Equals(string.Empty))
                {
                    Console.WriteLine(Properties.Resources.errorMpvExe);
                }
                else
                {
                    Console.WriteLine(Properties.Resources.errorPlayerPathEmpty);
                }

                return;
            }

            //current strings StreamLink shows into console, keep it updated to make sure the progress bar moves.
            List<string> lstKeywords = new List<string> {
                "Found matching plugin stream",
                "Available streams",
                "Opening stream",
                "Starting player"
            };
            //int progressStep = (NHLGamesMetro.ProgressMaxValue) / (lstKeywords.Count + 1);

            Task taskLaunchingStream = new Task(() =>
            {
            //    NHLGamesMetro.ProgressValue = 0;
            //    NHLGamesMetro.StreamStarted = true;
            //    NHLGamesMetro.ProgressVisible = true;
                Console.WriteLine(Properties.Resources.msgStartingApp, args.StreamlinkPath, args.ToString(true));

                dynamic procStreaming = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = args.StreamlinkPath,
                        Arguments = args.ToString(),
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                procStreaming.EnableRaisingEvents = true;

                Task taskPlayerWatcher = new Task(() =>
                {
                    Process[] processes = Process.GetProcesses();
                    int i = 0;
                    while (!processes.Any(p => p.ProcessName.ToLower().Contains(args.PlayerType.ToString().ToLower()) || /*NHLGamesMetro.StreamStarted == false ||*/ i == 10))
                    {
                        processes = Process.GetProcesses();
                        Thread.Sleep(1000);
                        i += 1;
                    }
                    //NHLGamesMetro.ProgressValue = NHLGamesMetro.ProgressMaxValue - 1;
                    //Thread.Sleep(1000);
                    //NHLGamesMetro.ProgressVisible = false;
                    //Thread.Sleep(1000);
                    //NHLGamesMetro.StreamStarted = false;
                });

                try
                {
                    procStreaming.Start();
                    while ((procStreaming.StandardOutput.EndOfStream == false))
                    {
                        dynamic line = procStreaming.StandardOutput.ReadLine();
                        if (line.Contains(lstKeywords[0]) | line.Contains("Unable to open URL:"))
                        {
                            line = line.Substring(0, line.IndexOf("http://", StringComparison.Ordinal)) + "--URL CENSORED--." + line.Substring(line.IndexOf("m3u8", StringComparison.Ordinal));
                        }
                        if (lstKeywords.Any(x => line.Contains(x)))
                        {
                           // NHLGamesMetro.ProgressValue += progressStep;
                        }
                        if (line.Contains(lstKeywords[3]))
                        {
                            taskPlayerWatcher.Start();
                        }
                        Console.WriteLine(line);
                        Thread.Sleep(100);
                        //to let some time for the progress bar to move
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(Properties.Resources.errorGeneral, ex.Message);
                    //NHLGamesMetro.ProgressVisible = false;
                    //Thread.Sleep(1000);
                    //NHLGamesMetro.StreamStarted = false;
                }
            });

            taskLaunchingStream.Start();

        }

        public static void RenewArgs(bool forceSet = false)
        {
            //NHLGamesMetro form = NHLGamesMetro.FormInstance;

            //if (NHLGamesMetro.FormLoaded || forceSet)
            //{
            //    GameWatchArguments watchArgs = new GameWatchArguments();
            //    watchArgs.Is60Fps = form.chk60.Checked;

            //    if (form.rbQual6.Checked)
            //    {
            //        watchArgs.Quality = "720p";
            //    }
            //    else if (form.rbQual5.Checked)
            //    {
            //        watchArgs.Quality = "540p";
            //        form.chk60.Checked = false;
            //    }
            //    else if (form.rbQual4.Checked)
            //    {
            //        watchArgs.Quality = "504p";
            //        form.chk60.Checked = false;
            //    }
            //    else if (form.rbQual3.Checked)
            //    {
            //        watchArgs.Quality = "360p";
            //        form.chk60.Checked = false;
            //    }
            //    else if (form.rbQual2.Checked)
            //    {
            //        watchArgs.Quality = "288p";
            //        form.chk60.Checked = false;
            //    }
            //    else if (form.rbQual1.Checked)
            //    {
            //        watchArgs.Quality = "224p";
            //        form.chk60.Checked = false;
            //    }

            //    if (form.rbMpv.Checked)
            //    {
            //        watchArgs.PlayerType = PlayerTypeEnum.Mpv;
            //        watchArgs.PlayerPath = form.txtMpvPath.Text;
            //    }
            //    else if (form.rbMPC.Checked)
            //    {
            //        watchArgs.PlayerType = PlayerTypeEnum.Mpc;
            //        watchArgs.PlayerPath = form.txtMPCPath.Text;
            //    }
            //    else if (form.rbVLC.Checked)
            //    {
            //        watchArgs.PlayerType = PlayerTypeEnum.Vlc;
            //        watchArgs.PlayerPath = form.txtVLCPath.Text;

            //    }

            //    watchArgs.StreamlinkPath = form.txtStreamlinkPath.Text;

            //    if (form.rbAkamai.Checked)
            //    {
            //        watchArgs.Cdn = "akc";
            //    }
            //    else if (form.rbLevel3.Checked)
            //    {
            //        watchArgs.Cdn = "l3c";
            //    }

            //    watchArgs.UsePlayerArgs = form.tgPlayer.Checked;
            //    watchArgs.PlayerArgs = form.txtPlayerArgs.Text;

            //    watchArgs.UsestreamlinkArgs = form.tgStreamer.Checked;
            //    watchArgs.StreamlinkArgs = form.txtStreamerArgs.Text;

            //    watchArgs.UseOutputArgs = form.tgOutput.Checked;
            //    watchArgs.PlayerOutputPath = form.txtOutputArgs.Text;
            //    ApplicationSettings.SetValue(SettingsEnum.DefaultWatchArgs, Serialization.SerializeObject<GameWatchArguments>(watchArgs));
            //}
        }
    }
}
