using Composite.Interfaces;
using System.Collections;

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

        public void AcceptArchiving(IArchiveVisitor visitor)
        {
            visitor.Archive(this);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
