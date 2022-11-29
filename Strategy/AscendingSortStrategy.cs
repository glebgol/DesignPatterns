namespace Strategy
{
    public class AscendingSortStrategy : IStrategy
    {
        public ICollection<int> Sort(List<int> list)
        {
            return list.OrderBy(i => i).ToList();
        }
    }
}
