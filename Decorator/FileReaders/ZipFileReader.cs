using Decorator.Interfaces;

namespace Decorator.FileReaders
{
    public class ZipFileReader : Reader
    {
        public ZipFileReader(IFileReader _reader) : base(_reader)
        {
        }

        public override void Archieve(string filename, string outputFilename)
        {
            base.Archieve(filename, outputFilename);
        }

        public override void Calculate(string filename, string outputFilename)
        {
            reader.Dearchive(filename, "temp1.txt");
            base.Calculate("temp1.txt", "temp2.txt");
            reader.Archieve("temp2.txt", outputFilename);
        }

        public override void Dearchive(string filename, string outputFilename)
        {
            base.Dearchive(filename, outputFilename);
        }

        public override void Decrypt(string filename, string outputFilename)
        {
            base.Decrypt(filename, outputFilename);
        }

        public override void Encrypt(string filename, string outputFilename)
        {
            base.Encrypt(filename, outputFilename);
        }

        public override ReadingResult Read(string filename)
        {
            return base.Read(filename);
        }

        public override void Write(string filename, string outputFilename)
        {
            base.Write(filename, outputFilename);
        }
    }
}
