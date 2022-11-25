namespace Composite
{
    public interface IArchieveVisitor
    {
        void Archieve(FileComponent fileComponent);

        void Archieve(Folder folder);
    }
}
