using LevLesson.Interfaces;

namespace LevLesson
{
    public class WoodenBox : GameObject, IDamageable, IInteractable
    {
        public int Health { get; private set; } = 10;

        public WoodenBox(string name) : base(name)
        {
        }

        public void Interact()
        {
            Console.WriteLine($"[ЯЩИК] {Name} заперт. Кажется, его можно просто разбить...");
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health <= 0)
            {
                Console.WriteLine($"[ЯЩИК] {Name} разлетается в щепки! Выпало 5 монет.");
            }
            else
            {
                Console.WriteLine($"[ЯЩИК] {Name} трещит, но держится.");
            }
        }
    }
}
