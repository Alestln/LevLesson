namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var wave = new EnemyWave();

            wave.AddVanguard(new Enemy("Goblin scout", 30));
            wave.AddReinforcement(new Enemy("Orc boss", 300));
            wave.AddVanguard(new Enemy("Goblin warrior", 70));
            wave.AddVanguard(new Enemy("Goblin scout", 30));
            wave.AddReinforcement(new Enemy("Necromancer", 150));

            foreach (var enemy in wave)
            {
                Console.WriteLine($"Тип врага: {enemy.Type} HP: {enemy.Health}");
            }*/

            foreach (var item in Method())
            {
                Console.WriteLine(item);
            }

            Method(); // [7, 42]
            Method(); // [7, 42]
        }

        static IEnumerable<int> Method()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return i;
            }
        }
    }
}
