namespace Decorator.Interfaces
{
    public interface IFileReader
    {
        IStream Read(string filename);
        void Write(string filename, string outputFilename);

        void Encrypt(string filename);
        void Decrypt(string filename);

        void Archieve(string filename);
        void Dearchive(string filename);

        void Calculate(string filename, string outputFilename);
    }
}
