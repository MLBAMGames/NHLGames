﻿using System;
using System.Collections.Generic;
using System.Linq;
using CSCore.CoreAudioAPI;

namespace NHLGames.AdDetection.AdDetectors
{
    public class VolumeAdDetectionEngine : AdDetectionEngineBase
    {
        private readonly Dictionary<int, DateTime> _lastSoundTime = new Dictionary<int, DateTime>();
        protected override int PollPeriodMilliseconds => 100;

        private int _requiredSilenceMilliseconds => 500;

        protected override bool IsAdCurrentlyPlaying()
        {
            var closedProcesses = _lastSoundTime.Keys.Where(x => !MediaPlayerProcesses.Contains(x)).ToList();
            var newProcesses = MediaPlayerProcesses.Where(x => !_lastSoundTime.Keys.Contains(x)).ToList();
            foreach (var closedProcess in closedProcesses)
            {
                _lastSoundTime.Remove(closedProcess);
            }


            foreach (var newProcess in newProcesses)
            {
                AddOrUpdateLastSoundOccured(newProcess);
            }


            foreach (var process in MediaPlayerProcesses)
            {
                if (Math.Abs(GetCurrentVolume(process)) > 0.00001)
                {
                    AddOrUpdateLastSoundOccured(process);
                }
            }


            if (_lastSoundTime.Values.All(x => DateTime.Now - x > TimeSpan.FromMilliseconds(_requiredSilenceMilliseconds)))
            {
                return true;
            }


            return false;
        }


        private void AddOrUpdateLastSoundOccured(int processId)
        {
            if (_lastSoundTime.ContainsKey(processId))
            {
                _lastSoundTime[processId] = DateTime.Now;
            }
            else
            {
                _lastSoundTime.Add(processId, DateTime.MinValue);
            }
        }


        public float GetCurrentVolume(int processId)
        {
            //todo: Must be able to optimize this? Only looking for 1 process, probably don't need to iterate through all of them.
            using (var sessionManager = GetDefaultAudioSessionManager2(DataFlow.Render))
            using (var sessionEnumerator = sessionManager.GetSessionEnumerator())
            {
                foreach (var session in sessionEnumerator)
                {
                    using (var session2 = session.QueryInterface<AudioSessionControl2>())
                    {
                        if (session2.ProcessID == processId)
                        {
                            using (var audioMeterInformation = session.QueryInterface<AudioMeterInformation>())
                            {
                                return audioMeterInformation.GetPeakValue();
                            }
                        }
                    }
                }
            }

            return 0;
        }

        private static AudioSessionManager2 GetDefaultAudioSessionManager2(DataFlow dataFlow)
        {
            //todo: Let people choose their own device if they aren't using the default sound device for VLC/MPC.
            using (var enumerator = new MMDeviceEnumerator())
            {
                using (var device = enumerator.GetDefaultAudioEndpoint(dataFlow, Role.Multimedia))
                {
                    var sessionManager = AudioSessionManager2.FromMMDevice(device);
                    return sessionManager;
                }
            }
        }
    }
}