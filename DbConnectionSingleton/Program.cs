using DbConnSingleton;

class Program
{
    private static void ThreadAction()
    {
        var dbConnection = DbConnectionSingleton.Instance;
        var threadId = dbConnection.TreadId;
        Console.WriteLine(threadId);
    }

    public static void Main()
    {
        var thread1 = new Thread(ThreadAction);
        var thread2 = new Thread(ThreadAction);
        thread1.Start();
        thread2.Start();
    }
}