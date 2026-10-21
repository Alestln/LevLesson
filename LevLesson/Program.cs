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
