using Decorator.Interfaces;

namespace Decorator
{
    public class FileDataSource : IFileReader
    {
        public string Filename { get; }

        public FileDataSource(string filename)
        {
            Filename = filename;
        }

        public void Archieve(string outputFilename)
        {
            Console.WriteLine($"Archieve {outputFilename}");
        }

        public void Calculate(string outputFilename)
        {
            Console.WriteLine($"Calculate {outputFilename}");
        }

        public void Dearchive(string outputFilename)
        {
            Console.WriteLine($"Dearchive {outputFilename}");
        }

        public void Decrypt(string outputFilename)
        {
            Console.WriteLine($"Decrypt {outputFilename}");
        }

        public void Encrypt(string outputFilename)
        {
            Console.WriteLine($"Encrypt {outputFilename}");
        }

        public ReadingResult Read()
        {
            Console.WriteLine($"Read {Filename}");
            return new ReadingResult();
        }

        public void Write(string outputFilename)
        {
            Console.WriteLine($"Write {outputFilename}");
        }
    }
}
