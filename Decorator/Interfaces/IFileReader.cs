namespace Decorator.Interfaces
{
    public interface IFileReader
    {
        string Filename { get; }

        ReadingResult Read();
        void Write(string outputFilename);

        void Encrypt(string outputFilename);
        void Decrypt(string outputFilename);

        void Archieve(string outputFilename);
        void Dearchive(string outputFilename);

        void Calculate(string outputFilename);
    }
}
