using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;

namespace NHLGames.WPF.Utilities
{

    public class HostsFile
    {

        public static string HostsFilePath { get; }

        public static bool TestEntry(string domain, string ip)
        {
            string resolvedIp = "";
            try
            {
                resolvedIp = Dns.GetHostAddresses(domain).ToString();
            }
            catch (Exception ex)
            {
            }
            return ip == resolvedIp;
        }

        private static string RemoveOldEntries(string host, string contents)
        {
            string newContents = string.Empty;

            Console.WriteLine(Properties.Resources.msgCleanHostsFile);

            dynamic hostsFile = contents.Replace("\\r", String.Empty).Split('\n');

            for (int lineCount = 0; lineCount <= hostsFile.Length - 1; lineCount++)
            {
                if (hostsFile(lineCount).Contains(host) == false)
                {
                    newContents += hostsFile(lineCount).Replace("\\n", String.Empty);
                    if (lineCount < hostsFile.Length - 1)
                    {
                        newContents += Environment.NewLine;
                    }
                }
            }

            newContents = newContents.TrimEnd();

            return newContents;
        }


        public static void CleanHosts(string host)
        {
            if (FileAccess.HasAccess(HostsFilePath, false, true))
            {
                bool fileIsReadonly = FileAccess.IsFileReadonly(HostsFilePath);

                if (fileIsReadonly)
                {
                    FileAccess.RemoveReadOnly(HostsFilePath);
                }

                Console.WriteLine(Properties.Resources.msgBackingHostsFile, HostsFilePath);
                File.Copy(HostsFilePath, HostsFilePath + ".bak", true);

                string input = null;
                using (StreamReader sr = new StreamReader(HostsFilePath))
                {
                    input = sr.ReadToEnd();
                }

                string output = RemoveOldEntries(host, input);

                using (StreamWriter sw = new StreamWriter(HostsFilePath))
                {
                    sw.Write(output);
                    sw.Close();
                }

                if (fileIsReadonly)
                {
                    FileAccess.AddReadonly(HostsFilePath);
                }

                MessageOpenHostsFile();
            }

        }

        private static void MessageOpenHostsFile()
        {
            //if (InvokeElement.MsgBoxBlue(Properties.Resources.msgViewHostsText, Properties.Resources.msgViewHosts, MessageBoxButtons.YesNo) == DialogResult.Yes && FileAccess.HasAccess(HostsFilePath, false, true))
            {
                Process.Start("NOTEPAD", HostsFilePath);
            }
        }


        public static void AddEntry(string ip, string host)
        {
            if (EnsureAdmin())
            {
                bool fileIsReadonly = FileAccess.IsFileReadonly(HostsFilePath);

                if (fileIsReadonly)
                {
                    FileAccess.RemoveReadOnly(HostsFilePath);
                }

                Console.WriteLine(Properties.Resources.msgBackingHostsFile, HostsFilePath);
                File.Copy(HostsFilePath, HostsFilePath + ".bak", true);

                string input = null;
                using (StreamReader sr = new StreamReader(HostsFilePath))
                {
                    input = sr.ReadToEnd();
                }

                string output = RemoveOldEntries(host, input);

                output = output + Environment.NewLine + ip + '\t' + host;

                using (StreamWriter sw = new StreamWriter(HostsFilePath))
                {
                    sw.Write(output);
                    sw.Close();
                }

                if (fileIsReadonly)
                {
                    FileAccess.AddReadonly(HostsFilePath);
                }

                MessageOpenHostsFile();
            }

        }

        public static bool EnsureAdmin()
        {

            if (FileAccess.HasAccess(HostsFilePath, false, true))
            {
                if (IsAdministrator())
                {

                    //if (InvokeElement.MsgBoxBlue(NHLGamesMetro.RmText.GetString("msgRunAsAdminText"), NHLGamesMetro.RmText.GetString("msgRunAsAdmin"), MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Restart program And run as admin
                        dynamic exeName = Process.GetCurrentProcess().MainModule.FileName;
                        ProcessStartInfo startInfo = new ProcessStartInfo(exeName)
                        {
                            Verb = "runas",
                            UseShellExecute = true
                        };
                        try
                        {
                            Process.Start(startInfo);
                            Application.Exit();
                        }
                        catch (Exception)
                        {
                            // ignored
                        }
                    }
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return !principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
