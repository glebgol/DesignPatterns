namespace Strategy
{
    public class DescendingSortStrategy : IStrategy
    {
        public ICollection<int> Sort(List<int> list)
        {
            return list.OrderByDescending(i => i).ToList();
        }
    }
}
