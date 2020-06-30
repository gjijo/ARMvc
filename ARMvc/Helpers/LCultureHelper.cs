using AlkhalidUtility;
using ARMvc.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ARMvc.Helpers
{
    public class LCultureHelper
    {
        public static IDictionary<string, IDictionary<string, string>> CultureValue {get;set;}
        static LCultureHelper()
        {
            LoadCultureData();
        }
        private static void LoadCultureData()
        {
            string cultJSON = File.ReadAllText(ConfigSettings.RootPath + @"CultureFile\CultureData.json");
            CultureValue = DeSerializeJSON<IDictionary<string, IDictionary<string, string>>>(cultJSON);
        }

        public static string GetCultureValue(string culture, string key)
        {

            return CultureValue[culture].ContainsKey(key) ? CultureValue[culture][key] : key;
        }

        public static IDictionary<string, IDictionary<string, string>> RetrieveFullData()
        {
            return CultureValue;
        }

        public static bool UpdateCultureFile(IDictionary<string, IDictionary<string, string>> CultData)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"~\CultureFile\CultureData.json", false))
                {
                    writer.Write(SerializeToJSON<IDictionary<string, IDictionary<string, string>>>(CultData));
                }
                LoadCultureData();
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        private static T DeSerializeJSON<T>(string data)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(data);
            }
            catch (Exception ex)
            {
            }
            return default(T);
        }
        private static string SerializeToJSON<T>(T data)
        {
            try
            {
                return JsonConvert.SerializeObject(data);
            }
            catch (Exception ex)
            {
            }
            return string.Empty;
        }
    }
}