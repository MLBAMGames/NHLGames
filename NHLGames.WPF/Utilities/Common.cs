using System;
using System.Net;
using System.Text;

namespace NHLGames.WPF.Utilities
{
    public class Common
    {
        public static object GetRandomString(int intLength)
        {
            const string s = "abcdefghijklmnopqrstuvwxyz0123456789";
            Random r = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= intLength; i++)
            {
                int idx = r.Next(0, 35);
                sb.Append(s.Substring(idx, 1));
            }

            return sb.ToString();
        }

        public static bool CheckUrl(string address, HttpWebRequest httpWebRequest = null)
        {
            try
            {
                HttpWebRequest myHttpWebRequest = default(HttpWebRequest);
                if (httpWebRequest == null)
                {
                    myHttpWebRequest = (HttpWebRequest)WebRequest.Create(address);
                    myHttpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, Like Gecko) Chrome/48.0.2564.82 Safari/537.36 Edge/14.14316";
                }
                else
                {
                    myHttpWebRequest = httpWebRequest;
                }
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                myHttpWebResponse.Close();

                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        public static void GetLanguage()
        {
            //dynamic lang = ApplicationSettings.Read<string>(SettingsEnum.SelectedLanguage, string.Empty);
            //if (string.IsNullOrEmpty(lang) || lang == NHLGamesMetro.RmText.GetString("lblEnglish"))
            //{
            //    NHLGamesMetro.RmText = English.ResourceManager;
            //}
            //else if (lang == NHLGamesMetro.RmText.GetString("lblFrench"))
            //{
            //    NHLGamesMetro.RmText = French.ResourceManager;
            //}
        }
    }
}
