using Singleton;

class Program
{
    private static string baseAdress = "https://localhost:7248/api/products";
    private static int id = 2;
    public static void Main()
    {
        var httpSingleton = HttpSingleton.GetInstance(baseAdress);
        var httpResponse = httpSingleton.Get(id);
        var result = httpResponse.Result;
        Console.WriteLine(result);
    }
}