using Newtonsoft.Json;
using StatBrawl.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Configuration;

namespace StatBrawl.Services
{
    public class BrawlApiService
    {
        private readonly string _token = ConfigurationManager.AppSettings["BrawlApiToken"];

        public async Task<Player> GetPlayerAsync(string playerTag)
        {
            playerTag = playerTag.Replace("#", "%23");

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                string url = $"https://api.brawlstars.com/v1/players/{playerTag}";
                string json = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<Player>(json);
            }
        }
    }
}
