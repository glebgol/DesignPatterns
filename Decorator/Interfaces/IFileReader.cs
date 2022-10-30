namespace Decorator.Interfaces
{
    public interface IFileReader
    {
        ReadingResult Read(string filename);
        void Write(string filename, string outputFilename);

        void Encrypt(string filename, string outputFilename);
        void Decrypt(string filename, string outputFilename);

        void Archieve(string filename, string outputFilename);
        void Dearchive(string filename, string outputFilename);

        void Calculate(string filename, string outputFilename);
    }
}
