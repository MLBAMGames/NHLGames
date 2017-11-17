using System;
using System.IO;
using System.Xml.Serialization;
using NHLGames.WPF.Utilities;
using NHLGames.WPF.ViewModel;

namespace NHLGames.WPF.Objects
{
    [Serializable]
    public class GameWatchArguments
    {
        public string Quality { get; set; }
        public bool Is60Fps { get; set; }
        public string Cdn { get; set; }
        [XmlIgnore]
        public GameStreamViewModel Stream { get; set; }
        public bool IsVod { get; set; }
        public string GameTitle { get; set; }
        public string PlayerPath { get; set; }
        public PlayerTypeEnum PlayerType { get; set; }
        public string StreamlinkPath { get; set; }
        public bool UsestreamlinkArgs { get; set; }
        public string StreamlinkArgs { get; set; }
        public bool UsePlayerArgs { get; set; }
        public string PlayerArgs { get; set; }
        public bool UseOutputArgs { get; set; }
        public string PlayerOutputPath { get; set; }

        public override string ToString()
        {
            return OutputArgs(false);
        }

        public string ToString(bool safeOutput)
        {
            return OutputArgs(safeOutput);
        }

        private string OutputArgs(bool safeOutput)
        {
            string returnValue = "";
            const string dblQuot = "\"";
            const string dblQuot2 = "\"\"";
            const string space = " ";
            string literalPlayerArgs = string.Empty;

            if (UsePlayerArgs)
            {
                literalPlayerArgs = PlayerArgs;
            }

            //DEBUG
            //Returnvalue &= "-v -l debug -h "

            string titleArg = literalPlayerArgs;

            if (PlayerType == PlayerTypeEnum.Vlc)
            {
                titleArg = string.Format("--meta-title{0}{1}{2}{1}{0}", space, dblQuot2, GameTitle);
            }
            else if (PlayerType == PlayerTypeEnum.Mpv)
            {
                titleArg = string.Format("--title{0}{1}{2}{1}{0}--user-agent=User-Agent={1}Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, Like Gecko) Chrome/48.0.2564.82 Safari/537.36 Edge/14.14316{1}{0}", space, dblQuot2, GameTitle);
            }

            if (string.IsNullOrEmpty(PlayerPath) == false)
            {
                returnValue += string.Format("--player{0}{1}{2}{0}{3}{4}{0}{1}{0}", space, dblQuot, PlayerPath, titleArg, literalPlayerArgs);
            }
            else
            {
                Console.WriteLine(Properties.Resources.errorPlayerPathEmpty);
            }

            if (PlayerType == PlayerTypeEnum.Mpv)
            {
                returnValue += $"--player-passthrough=hls{space}";
            }

            if (safeOutput == false)
            {
                returnValue += string.Format("--http-cookie={0}mediaAuth={1}{2}{0}{2}", dblQuot, Common.GetRandomString(240), space);
            }

            returnValue += string.Format("--http-header={0}User-Agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, Like Gecko) Chrome/48.0.2564.82 Safari/537.36 Edge/14.14316{0}{1}", dblQuot, space);

            if (safeOutput == false)
            {
                returnValue += $"{dblQuot}hlsvariant://";

                if (IsVod)
                {
                    returnValue += Stream.Vodurl;
                }
                else
                {
                    returnValue += Stream.GameUrl;
                }

                returnValue = returnValue.Replace("CDN", Cdn) + space;
            }
            else
            {
                returnValue += $"{dblQuot}hlsvariant://--URL CENSORED--{space}";
            }

            if (Is60Fps)
            {
                returnValue += $"name_key=bitrate{dblQuot}{space}";
            }
            else
            {
                returnValue += dblQuot + space;
            }

            if (Is60Fps)
            {
                returnValue += $"best{space}";
            }
            else
            {
                returnValue += Quality + space;
            }

            returnValue += $"--http-no-ssl-verify{space}";

            if (UseOutputArgs)
            {
                string outputPath = PlayerOutputPath.Replace("(DATE)", DateHelper.GetPacificTime(Stream.Game.GameDate).ToString("yyyy-MM-dd")).Replace("(HOME)", Stream.Game.HomeAbbrev).Replace("(AWAY)", Stream.Game.AwayAbbrev).Replace("(TYPE)", Stream.Type.ToString()).Replace("(QUAL)", Is60Fps ? "720p60" : Quality);
                int suffix = 1;
                dynamic originalName = Path.GetFileNameWithoutExtension(outputPath);
                dynamic originalExt = Path.GetExtension(outputPath);
                while (File.Exists(outputPath))
                {
                    outputPath = Path.ChangeExtension(Path.Combine(Path.GetDirectoryName(outputPath), originalName + "_" + suffix), originalExt);
                    suffix += 1;
                }

                returnValue += "-f -o" + space + dblQuot + outputPath + dblQuot + space;
            }

            if (UsestreamlinkArgs)
            {
                returnValue += StreamlinkArgs;
            }

            return returnValue;
        }

        public void SetDefaultValues()
        {
            this.PlayerType = PlayerTypeEnum.Mpv;
            this.Is60Fps = true;
            this.Quality = "720p";
            this.Cdn = "Akamai";
        }
    }
}
