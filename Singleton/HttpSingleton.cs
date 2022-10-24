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

        public Task<HttpResponseMessage> Get(string baseAdress)
        {
            var httpInstance = GetInstance(baseAdress);
            var result = httpInstance._httpClient.GetAsync(baseAdress);
            return result;
        }
    }
}
