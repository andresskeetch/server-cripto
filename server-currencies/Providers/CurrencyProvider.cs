using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using server_currencies.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace server_currencies.Providers
{
    public class CurrencyProvider
    {
        static readonly HttpClient client = new HttpClient();
        public async Task<List<Currency>> getList()
        {
            HttpResponseMessage response = await client.GetAsync("https://api.coinlore.net/api/tickers/");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();


            JObject data = JObject.Parse(responseBody);
            return JsonConvert.DeserializeObject<List<Currency>>(data["data"].ToString());

        }

        public async Task<Currency> getDetail(string id)
        {
            HttpResponseMessage response = await client.GetAsync("https://api.coinlore.net/api/ticker/?id="+id);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();


            return JsonConvert.DeserializeObject<List<Currency>>(responseBody).FirstOrDefault();

        }


    }
}