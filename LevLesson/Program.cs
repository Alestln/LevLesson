namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Inventory inventory = new Inventory();

            for (int i = 0; i < inventory.Length; i++)
            {
                var item = inventory[i];
            }*/


            // IEquatable<T>

            /*List<Player> players = new List<Player>
            {
                new Player(1, "Player1"),
                new Player(2, "Player2"),
                new Player(3, "Player3")
            };

            players.Contains(new Player(1, "Player1"));*/

            // IComparable<T>

            /*List<Monster> monsters = new List<Monster>
            {
                new Monster("Goblin", 3),
                new Monster("Orc", 1),
                new Monster("Dragon", 2)
            };

            monsters.Sort();*/

            // IComparer<T>
            List<Monster> monsters = new List<Monster>
            {
                new Monster("Goblin", 3),
                new Monster("Dragon", 1),
                null,
                new Monster("Orc", 2),
                null
            };

            monsters.Sort(new MonsterNameComparer());

            // Почитать про IEnumerable<T> и IEnumerator<T>
            // Почитать как указать направление сортировки в IComparer<T> (по возрастанию и по убыванию)
        }
    }
}
