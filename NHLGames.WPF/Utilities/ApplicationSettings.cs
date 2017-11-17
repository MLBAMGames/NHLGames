using System;
using System.Configuration;

namespace NHLGames.WPF.Utilities
{
    public class ApplicationSettings
    {
        public static T Read<T>(SettingsEnum key, object defaultReturnValue = null)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                dynamic result = configFile.AppSettings.Settings[key.ToString()].Value;
                if (string.IsNullOrEmpty(result))
                {
                    return (T)defaultReturnValue;
                }

                if (result is T variable)
                {
                    return variable;
                }


                if (bool.TryParse(result, out bool boolResult))
                {
                    return (T) Convert.ChangeType(boolResult, typeof(T));
                }

                try
                {
                    return Serialization.DeserializeObject<T>(result);
                }
                catch (Exception)
                {
                    Console.WriteLine(Properties.Resources.errorDeserialize, key.ToString(), typeof(T));
                    return (T) defaultReturnValue;
                }

            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine(Properties.Resources.errorReadingSettings, key);
                return (T) defaultReturnValue;
            }
        }


        public static void SetValue(SettingsEnum key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key.ToString()] == null)
                {
                    settings.Add(key.ToString(), value);
                }
                else
                {
                    settings[key.ToString()].Value = value;
                }

                if (value != null && value.Length > 200)
                {
                    value = Properties.Resources.msgValueTooLarge;
                }
                if (key != SettingsEnum.DefaultWatchArgs)
                {
                    Console.WriteLine(Properties.Resources.msgSettingUpdated, key.ToString(), value);
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine(Properties.Resources.errorWritingSettings);
            }
        }

    }
}
