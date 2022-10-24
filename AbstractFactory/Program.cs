using AbstractFactory.Interfaces;
using AbstractFactory.Platforms;

class Program
{
    private static IPlatform platform;

    public static void Main()
    {
        platform = new IOS13();
        IAction action = platform.Action;
        ISuperAction superAction = platform.SuperAction;
        IOptions options = platform.Options;

        action.GetAction();
        superAction.GetSuperAction();
        options.GetOptions();
    }
}