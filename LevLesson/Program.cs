using LevLesson.Enemies;

namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enemy enemy = new Enemy("Enemy", 100); // This line will cause a compilation error because Enemy is an abstract class and cannot be instantiated directly.
            Orc orc = new Orc("Orc", 150, 100);
            Dragon dragon = new Dragon("Dragon", 200, 150);

            // Console.WriteLine($"Enemy damage: {enemy.AttackDamage}");
            Console.WriteLine($"Orc damage: {orc.AttackDamage}");
            Console.WriteLine($"Dragon damage: {dragon.AttackDamage}");
        }
    }
}
