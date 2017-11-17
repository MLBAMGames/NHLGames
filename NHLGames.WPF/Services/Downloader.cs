using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using NHLGames.WPF.Objects;
using NHLGames.WPF.Properties;
using NHLGames.WPF.Utilities;

namespace NHLGames.WPF.Services
{
    public class Downloader
    {
        private const string AppUrl = "https://showtimes.ninja/";
        private const string ApiUrl = "http://statsapi.web.nhl.com/api/v1/schedule";
        private const string ScheduleApiurl = ApiUrl + "?startDate={0}&endDate={1}&expand=schedule.teams,schedule.linescore,schedule.game.seriesSummary,schedule.game.content.media.epg";
        private const string AppVersionUrl = AppUrl + "static/version.txt";

        private const string AppChangelogUrl = AppUrl + "static/changelog.txt";

        private const char Backslash = '\\';

        private static string _localFileDirectory = GetLocalFileDirectory();
        
        private static string GetLocalFileDirectory()
        {
            if (true)
            {
                const string dir = "NHLGames";
                const string file = "test.txt";

                string exeStartupPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Backslash;
                string tempPath = Path.GetTempPath();

                if (File.Exists(localAppDataPath + file))
                {
                    _localFileDirectory = localAppDataPath;
                }
                else if (File.Exists(tempPath))
                {
                    _localFileDirectory = tempPath;
                }
                else
                {
                    _localFileDirectory = exeStartupPath;
                }

                if (!Directory.Exists(_localFileDirectory + dir + Backslash))
                {
                    Directory.CreateDirectory(_localFileDirectory + dir + Backslash);
                }

                _localFileDirectory = _localFileDirectory + dir + Backslash;
            }

            return _localFileDirectory;

        }

        private static string DownloadContents(string server, string url)
        {
            WebClient client = new WebClient();
            string content = string.Empty;
            client.Encoding = Encoding.UTF8;
            try
            {
                content = client.DownloadString(url).Trim();
            }
            catch (Exception)
            {
                if (!(server == AppUrl))
                {
                    Console.WriteLine(Resources.msgServerSeemsDown, server);
                }
            }
            return content;
        }

        private static bool DownloadJsonFile(string server, string url, string fileName)
        {
            WebClient client = new WebClient();
            string filePath = Path.Combine(_localFileDirectory, fileName);
            client.Encoding = Encoding.UTF8;
            try
            {
                client.DownloadFile(url, filePath);
            }
            catch (Exception)
            {
                Console.WriteLine(Resources.msgServerNoRespondTryingAgain, server);
                return false;
            }
            return true;
        }

        private static string ReadFileContents(string fileName)
        {
            string returnValue = "";
            string filePath = Path.Combine(_localFileDirectory, fileName);
            try
            {
                using (var streamReader = new StreamReader(filePath))
                {
                    returnValue = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(Resources.errorGeneral, ex.Message);
            }

            return returnValue;
        }

        public static string DownloadApplicationVersion()
        {
            var appVers = DownloadContents(AppUrl, AppVersionUrl);
            if (appVers.Contains("<html>"))
            {
                appVers = string.Empty;
            }
            return appVers;
        }

        public static string DownloadChangelog()
        {
            string appChangelog = DownloadContents(AppUrl, AppChangelogUrl);
            if (appChangelog.Contains("<html>"))
            {
                appChangelog = string.Empty;
            }
            return appChangelog;
        }

        public static RootObject DownloadJsonSchedule(DateTime startDate, bool refreshing = false)
        {
            string dateTimeString = startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string fileName = dateTimeString + ".json";
            string url = string.Format(ScheduleApiurl, dateTimeString, dateTimeString);
            string data;
            string filePath = Path.Combine(_localFileDirectory, fileName);
            string gettingTerm = refreshing ? Resources.msgRefreshing : Resources.msgFetching;

            if (startDate.Date >= DateHelper.GetPacificTime())
            {
                Console.WriteLine(Resources.msgGettingSchedule, gettingTerm, startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                data = DownloadContents(ApiUrl, url);
            }
            else
            {
                if (LookOldJsonFiles(fileName) & !refreshing)
                {
                    Console.WriteLine(Resources.msgFetchingSavedSchedule, startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), filePath);
                    data = ReadFileContents(fileName);
                }
                else
                {
                    if (DownloadJsonFile(ApiUrl, url, fileName))
                    {
                        Console.WriteLine(Resources.msgDownloadingJsonFile, startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), filePath);
                        data = ReadFileContents(fileName);
                    }
                    else
                    {
                        Console.WriteLine(Resources.msgGettingSchedule, gettingTerm, startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                        data = DownloadContents(ApiUrl, url);
                    }
                }
            }

            if (data.Equals(string.Empty))
                return null;

            return RootObject.FromJson(data);

            //return Deserialize<RootObject>(data);
        }

        public static bool LookOldJsonFiles(string filename)
        {
            if (File.Exists(_localFileDirectory + filename))
            {
                return File.GetLastAccessTime(filename).AddDays(1) <= DateTime.Now;
            }
            return false;
        }

        public static string Serialize<T>(T obj)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            MemoryStream ms = new MemoryStream();
            serializer.WriteObject(ms, obj);
            string retVal = Encoding.UTF8.GetString(ms.ToArray());
            return retVal;
        }

        public static T Deserialize<T>(string json)
        {
            T obj = Activator.CreateInstance<T>();
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json));
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            obj = (T)serializer.ReadObject(ms);
            ms.Close();
            return obj;
        }

    }
}
