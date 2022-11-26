using Composite.Components;
using Composite.Interfaces;

namespace Composite.Visitors
{
    public class RarArchieveVisitor : IArchieveVisitor
    {
        public void Archieve(FileComponent fileComponent)
        {
            Console.WriteLine("Rar..");
            Console.WriteLine(fileComponent.Name);
        }

        public void Archieve(Folder folder)
        {
            Console.WriteLine("Rar..");
            Console.WriteLine(folder.Name);
        }
    }
}
