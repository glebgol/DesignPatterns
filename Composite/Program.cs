using Composite;

class Program
{
    public static void Main()
    {
        var fileSystem = new Folder("Folder");
        fileSystem.AddComponent(new FileComponent("input1.txt"));
        fileSystem.AddComponent(new FileComponent("input2.txt"));
        fileSystem.AddComponent(new FileComponent("input3.txt"));

        var folder = new Folder("Wrapped Folder");
        folder.AddComponent(new FileComponent("output1.txt"));
        folder.AddComponent(new FileComponent("output2.txt"));
        folder.AddComponent(new FileComponent("output3.txt"));

        fileSystem.AddComponent(folder);

        fileSystem.Display();
    }
}