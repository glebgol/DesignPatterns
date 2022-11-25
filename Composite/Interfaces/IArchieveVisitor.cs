using Composite.Components;

namespace Composite.Interfaces
{
    public interface IArchieveVisitor
    {
        void Archieve(FileComponent fileComponent);

        void Archieve(Folder folder);
    }
}
