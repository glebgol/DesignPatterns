namespace Composite
{
    public interface IFileComponent
    {
        void Display();

        void AcceptArchieving(IArchieveVisitor visitor);
    }
}
