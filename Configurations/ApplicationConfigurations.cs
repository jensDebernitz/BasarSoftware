using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Configurations
{
    public class ApplicationConfigurations
    {
        public string ServerIpAddresse = string.Empty;
        public string ServerPort = "51948";
        public string AdminClientPort = "51949";
        public string SellerClientPort = "51950";
        public string BasarName = "Kinder- und Kleiderbasar Oberfell";
        public string NextBasarDate = "11.10.1983";

        public ApplicationConfigurations()
        {
            GetConfigurationValue("ServerIpAddresse", ref ServerIpAddresse);
            GetConfigurationValue("ServerPort", ref ServerPort);
            GetConfigurationValue("AdminClientPort", ref AdminClientPort);
            GetConfigurationValue("SellerClientPort", ref SellerClientPort);
            GetConfigurationValue("BasarName", ref BasarName);
            GetConfigurationValue("NextBasarDate", ref NextBasarDate);
        }

        public void SaveConfigurations(string executablePath)
        {
            //Application.ExecutablePath
            Configuration NewConfig = ConfigurationManager.OpenExeConfiguration(executablePath);
            SetConfigurationValue(NewConfig, "ServerIpAddresse", ServerIpAddresse);
            SetConfigurationValue(NewConfig, "ServerPort", ServerPort);
            SetConfigurationValue(NewConfig, "AdminClientPort", AdminClientPort);
            SetConfigurationValue(NewConfig, "SellerClientPort", SellerClientPort);
            SetConfigurationValue(NewConfig, "NextBasarDate", NextBasarDate);
            SetConfigurationValue(NewConfig, "NextBasarDate", NextBasarDate);

            NewConfig.Save(ConfigurationSaveMode.Full);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void GetConfigurationValue(string sKey, ref string value)
        {
            string sValue = string.Empty;

            if (ConfigurationManager.AppSettings[sKey] != null)
            {
                sValue = ConfigurationManager.AppSettings[sKey];
            }

            if (sValue != String.Empty)
            {
                value = sValue;
            }
        }

        private void GetConfigurationValue(string sKey, ref int value)
        {
            int nValue = -1;
            if (ConfigurationManager.AppSettings[sKey] != null)
            {
                try
                {
                    nValue = Convert.ToInt32(ConfigurationManager.AppSettings[sKey]);
                }
                catch (Exception)
                {
                }
            }

            if(nValue != 0)
            {
                value = nValue;
            }
            
        }

        private void SetConfigurationValue(Configuration Config, string sKey, string sValue)
        {
            KeyValueConfigurationElement Element = Config.AppSettings.Settings[sKey];
            if (Element == null)
            {
                Config.AppSettings.Settings.Add(sKey, sValue);
            }
            else
            {
                Element.Value = sValue;
            }

            Config.Save(ConfigurationSaveMode.Full);
        }

        private void SetConfigurationValue(Configuration Config, string sKey, int nValue)
        {
            KeyValueConfigurationElement Element = Config.AppSettings.Settings[sKey];
            if (Element == null)
            {
                Config.AppSettings.Settings.Add(sKey, nValue.ToString());
            }
            else
            {
                Element.Value = nValue.ToString();
            }

            Config.Save(ConfigurationSaveMode.Full);
        }
    }
}
