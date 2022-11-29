namespace Strategy
{
    public class CalculationEngine
    {
        private IStrategy strategy;

        public CalculationEngine(IStrategy strategy)
        {
            this.strategy = strategy;
        }
    }
}
