using LevLesson.Interfaces;

namespace LevLesson
{
    public class Merchant : GameObject, IDamageable, IInteractable
    {
        public int Health { get; private set; } = 50;

        public Merchant(string name) : base(name)
        {
        }

        public void Interact()
        {
            Console.WriteLine($"[ТОРГОВЕЦ] {Name} говорит: 'Привет, путник! Хочешь купить зелье за 10 золотых?'");
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"[ТОРГОВЕЦ] {Name} кричит: 'Стража! Меня бьют!'");
        }
    }
}
