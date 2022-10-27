using System.Net;

namespace Singleton
{
    public class HttpSingleton
    {
        private static HttpSingleton instance;
        private HttpClient _httpClient;
        private string _baseAdress;

        private HttpSingleton(string baseAdress)
        {
            _baseAdress = baseAdress;
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(baseAdress)
            };
        }

        public static HttpSingleton GetInstance(string baseAdress)
        {
            if (instance == null)
            {
                instance = new HttpSingleton(baseAdress);
            }
            return instance;
        }

        public Task<HttpResponseMessage> Get(int id)
        {
            if (instance != null)
            {
                var result = instance._httpClient.GetAsync(_baseAdress + $"/{id}");
                return result;
            }

            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.NoContent));
        }
    }
}
