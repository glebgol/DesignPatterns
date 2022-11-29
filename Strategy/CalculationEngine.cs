namespace Strategy
{
    public class CalculationEngine
    {
        private IStrategy strategy;

        public CalculationEngine(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SortAndPrint(List<int> list)
        {
            var sortedList = strategy.Sort(list);
            foreach (var item in sortedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
