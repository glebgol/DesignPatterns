namespace Composite
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
    }
}
