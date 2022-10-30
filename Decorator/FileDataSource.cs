using Decorator.Interfaces;

namespace Decorator
{
    public class FileDataSource : IFileReader
    {
        public void Archieve(string filename, string outputFilename)
        {
            Console.WriteLine($"Archieve {outputFilename}");
        }

        public void Calculate(string filename, string outputFilename)
        {
            Console.WriteLine($"Calculate {outputFilename}");
        }

        public void Dearchive(string filename, string outputFilename)
        {
            Console.WriteLine($"Dearchive {outputFilename}");
        }

        public void Decrypt(string filename, string outputFilename)
        {
            Console.WriteLine($"Decrypt {outputFilename}");
        }

        public void Encrypt(string filename, string outputFilename)
        {
            Console.WriteLine($"Encrypt {outputFilename}");
        }

        public ReadingResult Read(string filename)
        {
            Console.WriteLine($"Read {filename}");
            return new ReadingResult();
        }

        public void Write(string filename, string outputFilename)
        {
            Console.WriteLine($"Write {outputFilename}");
        }
    }
}
