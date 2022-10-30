namespace Decorator.Interfaces
{
    public interface IStream
    {
        string[] Lines { get; }
        byte[] Bytes { get; }
    }
}
