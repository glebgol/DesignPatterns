namespace Composite
{
    public class Folder : IFileComponent
    {
        protected List<IFileComponent> components = new();
        public string Name { get; }

        public Folder(string name)
        {
            Name = name;
        }

        public void Display()
        {
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
    }
}
