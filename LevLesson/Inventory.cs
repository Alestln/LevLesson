namespace LevLesson
{
    internal class Inventory
    {
        private Dictionary<int, Item> items = new Dictionary<int, Item>();

        public int Length => items.Count;

        public Inventory()
        {
            items.Add(1, new Item(1, "Sword"));
            items.Add(2, new Item(2, "Shield"));
        }

        internal KeyValuePair<int, Item> this[int index]
        {
            get
            {
                if (index >= 0 && index < items.Count)
                {
                    return new KeyValuePair<int, Item>(items.Keys.ElementAt(index), items[items.Keys.ElementAt(index)]);
                }
                else
                {
                    throw new IndexOutOfRangeException($"Item with index {index} does not exist.");
                }
            }
        }
    }
}
