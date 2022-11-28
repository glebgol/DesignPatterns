namespace TemplateMethod
{
    public class ThirdCourseSessionPreparation : SessionPreparationBase
    {
        protected override void CollectPracticeInfo()
        {
            Console.WriteLine("Ask classmates for practice");
        }

        protected override void CollectTheoryInfo()
        {
            Console.WriteLine("Theory?");
        }

        protected override void ProcessTheory()
        {
            Console.WriteLine("Do some practice, please...");
        }
    }
}
