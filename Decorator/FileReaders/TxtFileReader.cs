using Decorator.Interfaces;

namespace Decorator.FileReaders
{
    public class TxtFileReader : Reader
    {
        public TxtFileReader(IFileReader _reader) : base(_reader)
        {
        }

        public override void Write(string outputFilename)
        {
            base.Write(outputFilename);
        }

        public override ReadingResult Read()
        {
            return base.Read();
        }

        public override void Archieve(string outputFilename)
        {
            base.Archieve(outputFilename);
        }

        public override void Dearchive(string outputFilename)
        {
            base.Dearchive(outputFilename);
        }

        public override void Calculate(string outputFilename)
        {
            base.Calculate(outputFilename);
        }

        public override void Encrypt(string outputFilename)
        {
            base.Encrypt(outputFilename);
        }

        public override void Decrypt(string outputFilename)
        {
            base.Decrypt(outputFilename);
        }
    }
}
