using System.ComponentModel.Composition;
using System.Windows.Controls;
using NHLGames.AdDetection.Common;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace NHLGames.AdDetection.Modules.OBS
{

    [Export(typeof (IAdModule))]
    public class OBSAdModule : IAdModule
    {
        public string Title => "OBS";
        public string Description => "Changes OBS Scene using Key \"1\" for Scene 1 and Key \"2\" for Scene 2";

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindow(IntPtr hWnd);

        

        public System.Windows.Controls.UserControl SettingsControl => null;
        private IntPtr? obsPtr;
        private int obsPID;
        private List<string> processNames;

        public void Initialize()
        {
            processNames = new List<string>();
            processNames.Add("obs32");
            processNames.Add("obs64");
            connect();            
        }

        public void AdStarted()
        {
            if (IsWindow((IntPtr)obsPtr))
            {
                Utilities.WriteLineWithTime($"OBS: Changing to Scene 2");
                SetForegroundWindow((IntPtr)obsPtr);
                SendKeys.SendWait("2");
            }
            else
            {
                connect();
            }
        }

        public void AdEnded()
        {

            if (IsWindow((IntPtr)obsPtr))
            {
                Utilities.WriteLineWithTime($"OBS: Changing to Scene 1");
                SetForegroundWindow((IntPtr)obsPtr);
                SendKeys.SendWait("1");
            }
            else
            {
                connect();

            }
        }

        public void Stop() { }
        
        private IntPtr? getProcesses(List<string> processNames)
        {
            Process[] pList;
            for (int i = 0; i < processNames.Count; i++)
            {
                pList = Process.GetProcessesByName(processNames[i]);
                if (pList.Length != 0)
                {
                    obsPID = pList[0].Id;
                    return pList[0].MainWindowHandle;
                }
            }
            return null;
        }

        private void connect()
        {
            obsPtr = null;
            while (obsPtr == null)
            {
                Utilities.WriteLineWithTime($"OBS was not found... trying again in 10 seconds.");
                Thread.Sleep(TimeSpan.FromSeconds(10));
                obsPtr = getProcesses(processNames);
            }
            Utilities.WriteLineWithTime($"Connected to OBS.");
        }
    }
}