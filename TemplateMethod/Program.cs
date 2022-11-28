using TemplateMethod;

namespace Composite;

class Program
{
    public static void Main()
    {
        var sessionPreparator = new FirstCourseSessionPreparation();
        sessionPreparator.PrepareSession();
    }
}