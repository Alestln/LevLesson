namespace LevLesson
{
    internal class Player
    {
        public int Health = 100;
        public event Action<int> OnHealthChanged;

        public void TakeDamage(int damage)
        {
            Health -= damage;

            OnHealthChanged?.Invoke(Health);
        }
    }
}
