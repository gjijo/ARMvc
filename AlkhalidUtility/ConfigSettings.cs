using System;
using System.Configuration;

namespace AlkhalidUtility
{
    public class ConfigSettings
    {
        private static System.Collections.Specialized.NameValueCollection AppSettings
        {
            get
            {
                return ConfigurationManager.AppSettings;
            }
        }

        #region MainSiteConfigs
        public static string RootPath
        {
            get
            {
                return AppSettings["RootPath"] == null ? string.Empty : AppSettings["RootPath"];
            }
        }
        public static string LogsPath
        {
            get
            {
                return AppSettings["LogsPath"] == null ? string.Empty : AppSettings["LogsPath"];
            }
        }
        public static string SapAPIUrl
        {
            get
            {
                return AppSettings["SapAPIUrl"] == null ? string.Empty : AppSettings["SapAPIUrl"];
            }
        }
        #endregion MainSiteConfigs

        #region KnetConfigs
        public static string KnetLanguage
        {
            get
            {
                return AppSettings["KnetLanguage"] == null ? string.Empty : AppSettings["KnetLanguage"];
            }

        }
        public static string KnetAliasName
        {
            get
            {
                return AppSettings["KnetAliasName"] == null ? string.Empty : AppSettings["KnetAliasName"];
            }

        }
        public static string KnetResponseURL
        {
            get
            {
                return AppSettings["KnetResponseURL"] == null ? string.Empty : AppSettings["KnetResponseURL"];
            }

        }
        public static string KnetErrorURL
        {
            get
            {
                return AppSettings["KnetErrorURL"] == null ? string.Empty : AppSettings["KnetErrorURL"];
            }

        }
        public static string KnetResourcePath
        {
            get
            {
                return AppSettings["KnetResourcePath"] == null ? string.Empty : AppSettings["KnetResourcePath"];
            }

        }
        public static string KnetCurrency
        {
            get
            {
                return AppSettings["KnetCurrency"] == null ? string.Empty : AppSettings["KnetCurrency"];
            }

        }
        public static double KnetServiceCharge
        {
            get
            {
                double _KnetServiceCharge = 0;
                double.TryParse(AppSettings["KnetServiceCharge"], out _KnetServiceCharge);
                return _KnetServiceCharge;
            }

        }
        #endregion KnetConfigs
    }
}
