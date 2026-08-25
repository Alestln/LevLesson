using LevLesson.Interfaces;

namespace LevLesson
{
    public class Player : GameObject, IDamageable, IAttacker
    {
        public int Damage { get; private set; } = 25;

        public int Health { get; private set; } = 100;

        public Player(string name) : base(name)
        {
        }

        public void Attack(IDamageable target)
        {
            Console.WriteLine($"[ИГРОК] {Name} бьет мечом!");
            target.TakeDamage(Damage);
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"[ИГРОК] {Name} получил {amount} урона. ХП: {Health}");
            if (Health < 0)
            {
                Console.WriteLine($"[ИГРОК] {Name} погиб!");
            }
        }
    }
}
