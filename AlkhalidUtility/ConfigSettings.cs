using System;
using System.Configuration;

namespace AlkhalidUtility
{
    public class ConfigSettings
    {
        public static System.Collections.Specialized.NameValueCollection AppSettings
        {
            get
            {
                return ConfigurationManager.AppSettings;
            }
        }
        public static string LogsPath
        {
            get
            {
                return AppSettings["LogsPath"] == null ? string.Empty : AppSettings["LogsPath"];
            }

        }
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
    }
}
