using DotaMatchupFinder.Core.Wrappers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DotaMatchupFinder.Core.Parsers
{
    public class JsonParser
    {

        public List<T> Parse<T>(string txtToParse)
        {
            try
            {
                var wrapper = JsonConvert.DeserializeObject<BasicModelWrapper<T>>(txtToParse);
                return wrapper.rows;
            }
            catch
            {
                return default;
            }
        }

        public async Task<List<T>> ParseQuery<T>(string query)
        {
            var paramArr = HttpUtility.UrlEncode(query);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.opendota.com/api/explorer");
                var res = await client.GetAsync("?sql=" + paramArr);
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();

                    return Parse<T>(json);
                }
            }
            return new List<T>();
        }
    }
}
