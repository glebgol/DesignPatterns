using Composite.Interfaces;

namespace Composite.Components
{
    public class Folder : IFileComponent
    {
        protected List<IFileComponent> components = new();
        public string Name { get; set; }

        public Folder(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine(Name);
            foreach (var component in components)
            {
                component.Display();
            }
        }

        public void AddComponent(IFileComponent fileComponent)
        {
            components.Add(fileComponent);
        }

        public void RemoveComponent(IFileComponent fileComponent)
        {
            components.Remove(fileComponent);
        }

        public void AcceptArchiving(IArchiveVisitor visitor)
        {
            visitor.Archive(this);
        }
    }
}
