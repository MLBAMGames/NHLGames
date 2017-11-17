using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NHLGames.WPF.Utilities
{
    public class PathFinder
    {
        private static string _ProgramFiles(string programPath)
        {
            string[] drives = Environment.GetLogicalDrives();
            List<string[]> dirPrgFiles = new List<string[]>();
            foreach (string d in drives)
            {
                try
                {
                    DriveInfo dType = new DriveInfo(d.Substring(0, 1).ToUpper());
                    if (dType.DriveType != DriveType.CDRom)
                    {
                        dirPrgFiles.Add(Directory.GetDirectories(d, "Program Files"));
                        if ((_is64bits()))
                            dirPrgFiles.Add(Directory.GetDirectories(d, "Program Files (x86)"));
                    }
                }
                catch
                {
                }
            }

            return (from dirFound in dirPrgFiles where dirFound.Length != 0 where File.Exists(dirFound[0] + programPath) select dirFound[0] + programPath).FirstOrDefault();
        }

        private static bool _is64bits()
        {
            return Environment.Is64BitOperatingSystem;
        }

        public static string GetPathOfVlc()
        {
            var path = (Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\vlc.exe", "", null) ??
                _ProgramFiles("\\VideoLAN\\VLC\\vlc.exe")) ?? string.Empty;

            return path.ToString();
        }

        public static string GetPathOfMpc()
        {
            var path = Registry.GetValue("HKEY_CURRENT_USER\\Software\\MPC-HC\\MPC-HC", "ExePath", null);
            if (path == null)
            {
                var x64 = _is64bits() ? "64" : "";
                path = _ProgramFiles($"\\MPC-HC\\mpc-hc{x64}.exe");
            }
            if (path == null)
                path = string.Empty;

            return path.ToString();
        }

        public static string GetPathOfMpv()
        {
            return Path.Combine(Application.StartupPath, "mpv\\mpv.exe");
        }

        public static string GetPathOfStreamlink()
        {
            return Path.Combine(Application.StartupPath, "streamlink-0.8.1\\streamlink.exe");
        }
    }
}
