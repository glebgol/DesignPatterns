namespace Composite
{
    public class ZipArchieveVisitor : IArchieveVisitor
    {
        public void Archieve(FileComponent fileComponent)
        {
            Console.WriteLine("Zip..");
            Console.WriteLine(fileComponent.Name);
        }

        public void Archieve(Folder folder)
        {
            Console.WriteLine("Zip..");
            Console.WriteLine(folder.Name);
        }
    }
}
