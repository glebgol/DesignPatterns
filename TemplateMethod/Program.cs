using TemplateMethod;

namespace Composite;

class Program
{
    public static void Main()
    {
        var firstCourseSession = new FirstCourseSessionPreparation();
        firstCourseSession.PrepareSession();

        Console.WriteLine();

        var secondCourseSession = new SecondCourseSessionPreparation();
        secondCourseSession.PrepareSession();

        Console.WriteLine();

        var thirdCourseSession = new ThirdCourseSessionPreparation();
        thirdCourseSession.PrepareSession();
    }
}