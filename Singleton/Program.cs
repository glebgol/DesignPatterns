using Singleton;

class Program
{
    private static string baseAdress = "https://localhost:7248/api/products";
    public static void Main()
    {
        var httpSingleton = HttpSingleton.GetInstance(baseAdress);
        var httpResponse = httpSingleton.Get(baseAdress);
        var result = httpResponse.Result;
        Console.WriteLine(result);
    }
}