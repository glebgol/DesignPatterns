using Decorator.Interfaces;

namespace Decorator.FileReaders
{
    public abstract class Reader : IFileReader
    {
        public ReadingResult Read(string filename)
        {
            Console.WriteLine($"reading {filename}");
            return new ReadingResult();
        }

        public void Write(string filename, string outputFilename)
        {
            Console.WriteLine($"writing {filename} to {outputFilename}");
        }

        public void Archieve(string filename)
        {
            Console.WriteLine($"Archieve {filename}");
        }

        public void Dearchive(string filename)
        {
            Console.WriteLine($"Dearchieve {filename}");
        }

        public void Encrypt(string filename)
        {
            Console.WriteLine($"Encrypt {filename}");
        }

        public void Decrypt(string filename)
        {
            Console.WriteLine($"Decrypt {filename}");
        }

        public void Calculate(string filename, string outputFilename)
        {
            Console.WriteLine($"Calculate {filename}, write to {outputFilename}");
        }
    }
}
