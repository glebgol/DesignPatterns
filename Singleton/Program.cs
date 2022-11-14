using Singleton;

class Program
{
    private static int id = 2;
    public static void Main()
    {
        var httpSingleton = HttpSingleton.Instance;
        var httpResponse = httpSingleton.Get(id);
        var result = httpResponse.Result;
        Console.WriteLine(result);
    }
}