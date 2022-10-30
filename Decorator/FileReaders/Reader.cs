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
            Filename = _reader.Filename;
        }

        public virtual void Archieve(string outputFilename)
        {
            reader.Archieve(outputFilename);
        }

        public virtual void Calculate(string outputFilename)
        {
            reader.Calculate(outputFilename);
        }

        public virtual void Dearchive(string outputFilename)
        {
            reader.Dearchive(outputFilename);
        }

        public virtual void Decrypt(string outputFilename)
        {
            reader.Decrypt(outputFilename);
        }

        public virtual void Encrypt(string outputFilename)
        {
            reader.Encrypt(outputFilename);
        }

        public virtual ReadingResult Read()
        {
            return reader.Read();
        }

        public virtual void Write(string outputFilename)
        {
            reader.Write(outputFilename);
        }
    }
}
