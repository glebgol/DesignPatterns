﻿using Composite.Interfaces;

namespace Composite.Components
{
    public class FileComponent : IFileComponent
    {
        public string Name { get; set; }

        public FileComponent(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"File name {Name}");
        }

        public void AcceptArchieving(IArchieveVisitor visitor)
        {
            visitor.Archieve(this);
        }
    }
}
