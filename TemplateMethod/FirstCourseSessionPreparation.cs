namespace TemplateMethod
{
    public class FirstCourseSessionPreparation : SessionPreparationBase
    {
        protected override void CollectPracticeInfo()
        {
            Console.WriteLine("Open practice notes.");
        }

        protected override void CollectTheoryInfo()
        {
            base.CollectTheoryInfo();
            Console.WriteLine("Open lecture notes.");
        }

        protected override void ProcessTheory()
        {
            Console.WriteLine("Repeat theory!");
        }
    }
}
