namespace LevLesson
{
    internal class Program
    {
        public delegate void AttackAction(int damage);

        static void Main(string[] args)
        {
            /*AttackAction currentAttack = FireSlash;
            currentAttack.Invoke(50);

            currentAttack = IceSpike;
            currentAttack.Invoke(30);*/

            AttackAction? combo = FireSlash;
            combo += IceSpike;

            int bonusDamage = 20;

            // combo += delegate (int damage) { Console.WriteLine($"Lightning Strike attack with {damage} damage!"); };
            combo += (int damage) => Console.WriteLine($"Lightning Strike attack with {damage + bonusDamage} damage!"); // Lambda expression

            combo.Invoke(100);

            combo -= FireSlash;

            combo?.Invoke(100);

            // Action, Func, Predicate - почитать

            // Action
            /*Log((string name) => Console.WriteLine(name), "Hello, World!");
            Log((string name) => Console.WriteLine($"\t\t\t\t{name}\nEnd"), "Hello, World!");*/

            // Predicate
            /*Predicate<int> isEven = (int number) => number % 2 == 0;
            bool result = isEven.Invoke(11);
            // Log(isEven, 11);
            Log((number) => number % 2 == 0, 11);*/

            // Func
            Func<int, int, int> add = (int a, int b) => a + b;
            int result = add.Invoke(5, 10);
            Console.WriteLine(result);
        }

        static void Log(Action<string> print, string message)
        {
            // Часть логики, которая может быть общей для всех сообщений
            print.Invoke(message);
            // Часть логики, которая может быть общей для всех сообщений
        }

        static void Log(Predicate<int> check, int number)
        {
            if (check.Invoke(number))
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }

        static void FireSlash(int damage)
        {
            Console.WriteLine($"Fire Slash attack with {damage} damage!");
        }

        static void IceSpike(int damage)
        {
            Console.WriteLine($"Ice Spike attack with {damage} damage!");
        }
    }
}
