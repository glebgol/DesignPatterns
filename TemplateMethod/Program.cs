using TemplateMethod;

namespace Composite;

class Program
{
    public static void Main()
    {
        Console.WriteLine("First course session preparation:");

        var firstCourseSession = new FirstCourseSessionPreparation();
        firstCourseSession.PrepareSession();

        Console.WriteLine("\nSecond course session preparation:");

        var secondCourseSession = new SecondCourseSessionPreparation();
        secondCourseSession.PrepareSession();

        Console.WriteLine("\nThird course session preparation:");

        var thirdCourseSession = new ThirdCourseSessionPreparation();
        thirdCourseSession.PrepareSession();
    }
}