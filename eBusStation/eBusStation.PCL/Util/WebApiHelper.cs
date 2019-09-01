using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace eBusStation.PCL.Util
{
    public class WebApiHelper
    {
        private readonly static HttpClient _client;
        private readonly static string _apiURL;

        static WebApiHelper()
        {
            _client = new HttpClient();
            _apiURL = MyConfig.apiURL;
        }
        public static HttpResponseMessage GetResult(string requestURI, IDictionary<string, string> queryParameters = null)
        {
            UriBuilder uri = new UriBuilder(_apiURL + requestURI);
            if (queryParameters != null)
            {
                string query = "";
                foreach (KeyValuePair<string, string> item in queryParameters)
                {
                    query += item.Key + "=" + item.Value;
                    query += "&";
                }
                query = query.Remove(query.Length - 1);
                uri.Query = query;
            }
            HttpResponseMessage response = _client.GetAsync(uri.Uri).Result;
            return response;
        }
        public static HttpResponseMessage PostResult(string requestURI, object obj)
        {
            UriBuilder uri = new UriBuilder(_apiURL + requestURI);
            StringContent content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

            HttpResponseMessage response = _client.PostAsync(uri.Uri, content).Result;
            return response;
        }

    }
}
