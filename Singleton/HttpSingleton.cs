using System.Linq;
using System.Net;

namespace Singleton
{
    public class HttpSingleton
    {
        private static HttpSingleton instance;
        private HttpClient _httpClient;
        private string _baseAdress = "https://localhost:7248/api/products";

        private static Dictionary<int, HttpSingleton> HttpClientThreadMap = new();

        private HttpSingleton()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(_baseAdress)
            };
        }

        public static HttpSingleton Instance
        {
            get
            {
                var currentThreadId = Environment.CurrentManagedThreadId;
                if (!HttpClientThreadMap.ContainsKey(currentThreadId))
                {
                    instance = new HttpSingleton();
                    HttpClientThreadMap.Add(currentThreadId, instance);
                }
                else
                {
                    instance = HttpClientThreadMap[currentThreadId];
                }
                return instance;
            }
        }

        public async Task<HttpResponseMessage> Get(int id)
        {
            if (instance != null)
            {
                try
                {
                    var result = await instance._httpClient.GetAsync(_baseAdress + $"/{id}");
                    return result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return new HttpResponseMessage(HttpStatusCode.NoContent);
                }
            }

            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}
