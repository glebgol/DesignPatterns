﻿using Decorator.Interfaces;

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

        public void Archieve(string outputFilename)
        {
            reader.Archieve(outputFilename);
        }

        public void Calculate(string outputFilename)
        {
            reader.Calculate(outputFilename);
        }

        public void Dearchive(string outputFilename)
        {
            reader.Dearchive(outputFilename);
        }

        public void Decrypt(string outputFilename)
        {
            reader.Decrypt(outputFilename);
        }

        public void Encrypt(string outputFilename)
        {
            reader.Encrypt(outputFilename);
        }

        public ReadingResult Read()
        {
            return reader.Read();
        }

        public void Write(string outputFilename)
        {
            reader.Write(outputFilename);
        }
    }
}
