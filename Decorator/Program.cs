using Decorator;
using Decorator.FileReaders;
using Decorator.Interfaces;

class Program
{
    public static IFileReader reader;
    public static void Main()
    {
        reader = new TxtFileReader(new FileDataSource("input.txt"));
        reader.Write("output.txt");
        reader.Encrypt("output.txt");
    }
}