using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNETService
{
    internal class KnetInitializer
    {
        private static KnetInitializer _objKNET = null;
        private static void InitKNETClient(Configuration KNETConfig)
        {
            _objKNET = new KnetInitializer()
            {
                Language = KNETConfig.Language,
                AliasName = KNETConfig.AliasName,
                ResponseURL = KNETConfig.ResponseURL,
                ErrorURL = KNETConfig.ErrorURL,
                ResourcePath = KNETConfig.ResourcePath,
                KnetCurrency = KNETConfig.KnetCurrency
            };
        }

        public string Language { get; set; }
        public string AliasName { get; set; }
        public string ResponseURL { get; set; }
        public string ErrorURL { get; set; }
        public string ResourcePath { get; set; }
        public string KnetCurrency { get; set; }

        public static KnetInitializer GetInstance(Configuration KNETConfig)
        {
            if (_objKNET == null)
                InitKNETClient(KNETConfig);
            return _objKNET;
        }
        public static void Destroy()
        {
            _objKNET = null;
        }
    }
}
