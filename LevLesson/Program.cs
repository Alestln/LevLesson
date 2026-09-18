namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            Console.WriteLine(names.Contains("Charlie"));*/

            // Не удобно использовать, так как не типизированный
            /*Hashtable hashtable = new Hashtable();

            hashtable.Add(1, "One");
            hashtable.Add("jashddf", 1);*/

            // HashSet<string> uniqueNames = new HashSet<string> { "Alice", "Bob", "Charlie" };
            // uniqueNames.Add("Alice"); // Попытка добавить дубликат не вызовет ошибку, но не изменит множество
            // Console.WriteLine(uniqueNames.Contains("Charlie"));

            Dictionary<string, int> items = new Dictionary<string, int>();
            items.Add("apple", 0);
            bool added = items.TryAdd("banana", 20);
            // items["apple"]++;

            items.Remove("1");

            for (int i = 0; i < items.Keys.Count; i++)
            {
                Console.WriteLine(items[items.Keys.ElementAt(i)]);
            }
        }
    }
}
