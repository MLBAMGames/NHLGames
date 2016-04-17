using System;
using System.ComponentModel.Composition;
using System.Threading;
using System.Windows.Controls;
using NHLGames.AdDetection.Common;
using SpotifyAPI.Local;

namespace NHLGames.AdDetection.Modules.Spotify
{
    [Export(typeof (IAdModule))]
    public class SpotifyAdModule : IAdModule
    {
        private readonly TimeSpan m_connectSleep = TimeSpan.FromSeconds(5);

        private readonly SpotifyLocalAPI m_spotify;

        private bool m_initialized;

        public SpotifyAdModule()
        {
            m_spotify = new SpotifyLocalAPI();
            m_spotify.OnPlayStateChange += OnPlayerStateChanged;
            m_spotify.ListenForEvents = true;
        }

        public string Title => "Spotify";

        public string Description
            =>
                @"Plays and pauses Spotify when an Ad break is detected. Spotify desktop app must be running with a song/playlist paused."
            ;

        public void AdEnded()
        {
            if (!m_initialized)
            {
                return;
            }

            m_spotify.Pause();
        }

        public void Stop()
        {
        }

        public UserControl SettingsControl => null;

        public void AdStarted()
        {
            if (!m_initialized)
            {
                return;
            }

            m_spotify.Play();
        }

        public void Initialize()
        {
            ConnectLoop();

            try
            {
                var status = m_spotify.GetStatus();

                var now = DateTime.UtcNow;
                var serverTime = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(status.ServerTime);
                var difference = now - serverTime;
                Console.WriteLine(
                    $"Spotify: Connected! Online: {status.Online}. Play Enabled: {status.PlayEnabled}");
                Console.WriteLine(
                    $"Spotify: Playing - {status.Playing}. Running: {status.Running}. Track Not Null : {status.Track != null}");
                Console.WriteLine($"Client Version: '{status.ClientVersion}'.");
                Console.WriteLine($"ServerTime: '{serverTime}' ");
                Console.WriteLine(
                    $"LocalTime:  '{DateTime.UtcNow}' -- Difference: {difference.TotalMilliseconds}ms");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: Exception logging the Connect status: {e.Message}.");
            }


            m_initialized = true;
        }

        private void OnPlayerStateChanged(object sender, PlayStateEventArgs e)
        {
            Console.WriteLine($"Spotify: Playing state changed to '{e.Playing}'");
        }

        private void ConnectLoop()
        {
            Console.WriteLine("Spotify: Attempting to connect...");

            while (true)
            {
                try
                {
                    if (ConnectInternal())
                    {
                        return;
                    }

                    Console.WriteLine("Spotify: Failed to connect. Attempting to reconnect in 10 seconds.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(
                        $"Error: Unexpected exception connecting to Spotify: {e.Message}. Attempting to reconnect in {m_connectSleep}.");
                }

                Thread.Sleep(m_connectSleep);
            }
        }

        private bool ConnectInternal()
        {
            if (!SpotifyLocalAPI.IsSpotifyRunning())
            {
                Console.WriteLine("Spotify: Process not running. Trying to start it...");
                try
                {
                    SpotifyLocalAPI.RunSpotify();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: Starting Spotify: {e.Message}");
                    return false;
                }
            }

            if (!SpotifyLocalAPI.IsSpotifyWebHelperRunning())
            {
                Console.WriteLine("Spotify: Web Helper isn't running. Trying to start it...");
                try
                {
                    SpotifyLocalAPI.RunSpotifyWebHelper();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: Starting Spotify Web Helper: {e.Message}");
                    return false;
                }
            }

            return m_spotify.Connect();
        }
    }
}