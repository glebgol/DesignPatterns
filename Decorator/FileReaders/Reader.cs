using Decorator.Interfaces;

namespace Decorator.FileReaders
{
    public abstract class Reader : IFileReader
    {
        protected IFileReader reader;

        public string Filename { get; }

        public Reader(IFileReader _reader)
        {
            reader = _reader;
        }

        public virtual void Archieve(string filename, string outputFilename)
        {
            reader.Archieve(filename, outputFilename);
        }

        public virtual void Calculate(string filename, string outputFilename)
        {
            reader.Calculate(filename, outputFilename);
        }

        public virtual void Dearchive(string filename, string outputFilename)
        {
            reader.Dearchive(filename, outputFilename);
        }

        public virtual void Decrypt(string filename, string outputFilename)
        {
            reader.Decrypt(filename, outputFilename);
        }

        public virtual void Encrypt(string filename, string outputFilename)
        {
            reader.Encrypt(filename, outputFilename);
        }

        public virtual ReadingResult Read(string filename)
        {
            return reader.Read(filename);
        }

        public virtual void Write(string filename, string outputFilename)
        {
            reader.Write(filename, outputFilename);
        }
    }
}
