using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;

namespace AzureMaps.Services
{
    public class BaseRepository<T> where T : class
    {
        private readonly IHttpClientFactory _httpClient;

        public BaseRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory;
        }
        
        public async Task<IList<T>> Get(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var client = _httpClient.CreateClient();

            HttpResponseMessage response = await client.SendAsync(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK) return null;
            
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IList<T>>(content);
        }
    }
}