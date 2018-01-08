using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JobAdApp.Data
{
    public class DataManager
    {
        const string Url = "http://api.arbetsformedlingen.se/af/v0/platsannonser/matchning";
        HttpClient client;

        public DataManager()
        {
            client = new HttpClient();
        client.DefaultRequestHeaders.Add("Accept", "application/json");
        client.DefaultRequestHeaders.Add("Accept-Language", "sv");
        }


        public async Task<RootObject> GetAll()
        {
            // TODO: use GET to retrieve summary 
            string result = await client.GetStringAsync(Url + "?lanid=1&antalrader=100");
            RootObject r = JsonConvert.DeserializeObject<RootObject>(result);
            return r;
        }


        public async Task<RootObject> Search(string keyWord)
        {         
            string searchResult = await client.GetStringAsync(Url + "?lanid=1&antalrader=100&nyckelord=" +keyWord);
            RootObject r = JsonConvert.DeserializeObject<RootObject>(searchResult);
            return r;
        }
  
    }
}
