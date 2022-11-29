namespace Strategy;

class Program
{
    public static void Main()
    {
        var listToSort = new List<int> { 10, 2, -3 };

        IStrategy strategy = new AscendingSortStrategy();
        var calculationEngine = new CalculationEngine(strategy);

        calculationEngine.SortAndPrint(listToSort);

        strategy = new DescendingSortStrategy();
        calculationEngine.SetStrategy(strategy);

        calculationEngine.SortAndPrint(listToSort);
    }
}