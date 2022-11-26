using System.Collections;

namespace Composite.Interfaces
{
    public interface IFileComponent : IEnumerable
    {
        void Display();

        void AcceptArchiving(IArchiveVisitor visitor);
    }
}
