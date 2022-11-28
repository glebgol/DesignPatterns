namespace TemplateMethod
{
    public abstract class SessionPreparationBase
    {
        protected virtual void CollectTheoryInfo()
        {
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
