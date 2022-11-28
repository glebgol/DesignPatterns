namespace TemplateMethod
{
    public class SecondCourseSessionPreparation : SessionPreparationBase
    {
        protected override void CollectPracticeInfo()
        {
            Console.WriteLine("Ask students for practice info");
        }

        protected override void CollectTheoryInfo()
        {
            base.CollectTheoryInfo();
            Console.WriteLine("Open lectures on google disk");
        }

        protected override void ProcessTheory()
        {
            Console.WriteLine("Process theory!!");
        }


    }
}
