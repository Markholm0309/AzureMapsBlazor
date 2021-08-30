using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using AzureMaps.Contracts;
using AzureMaps.Data.Entities;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace AzureMaps.Services
{
    public class EventRepository : IEventRepository
    {
        private readonly IHttpClientFactory _httpClient;

        public EventRepository(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Root> Get(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var client = _httpClient.CreateClient();

            var response = await client.SendAsync(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK) return null;
            
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonConvert.DeserializeObject<Root>(content);
        }
    }
}