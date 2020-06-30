using AlkhalidUtility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AlKhalidConnector
{
    internal class HttpClientRQHandler
    {
        private static string BaseURL { get; set;}
        static HttpClientRQHandler()
        {
            BaseURL = ConfigSettings.SapAPIUrl;
        }
        internal static T SendRQ<T, U>(U objPostParams, string endPoint)
        {
            T rsponseData = default(T);
            HttpClientHandler cHandler = new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip,
                AllowAutoRedirect = false,
                UseDefaultCredentials = false,
                UseCookies = false
            };
            HttpClient _httlClnt = new HttpClient(cHandler);

            string postParams = SerializeToJSON<U>(objPostParams);

            HttpRequestMessage httpRequestMsg = new HttpRequestMessage(HttpMethod.Post, BaseURL + endPoint);
            httpRequestMsg.Content = new StringContent(postParams, Encoding.UTF8, "application/json");
            httpRequestMsg.Headers.Add("Accept", "application/json");

            using (HttpResponseMessage response = _httlClnt.SendAsync(httpRequestMsg, HttpCompletionOption.ResponseHeadersRead).Result)
            {
                using (HttpContent content = response.Content)
                {
                    string responseLog = content.ReadAsStringAsync().Result;
                    rsponseData = DeSerializeJSON<T>(responseLog);
                }
            }
            return rsponseData;
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
