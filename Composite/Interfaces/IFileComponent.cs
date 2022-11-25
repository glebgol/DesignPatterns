namespace Composite.Interfaces
{
    public interface IFileComponent
    {
        void Display();

        void AcceptArchieving(IArchieveVisitor visitor);
    }
}
