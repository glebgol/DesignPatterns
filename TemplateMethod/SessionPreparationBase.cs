namespace TemplateMethod
{
    public abstract class SessionPreparationBase
    {
        protected virtual void CollectTheoryInfo()
        {
            Console.WriteLine("Collect theory info");
        }

        protected abstract void CollectPracticeInfo();

        protected void ProcessPractice()
        {
            Console.WriteLine("Process practice....");
        }

        protected abstract void ProcessTheory();

        public void PrepareSession()
        {
            CollectTheoryInfo();
            CollectPracticeInfo();
            ProcessTheory();
            ProcessPractice();
        }
    }
}
