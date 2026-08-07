namespace LevLesson.Enemies
{
    public abstract class Enemy
    {
        protected const int BaseAttackDamage = 50;

        public string Name { get; private init; }
        public int AttackDamage { get; protected set; } = BaseAttackDamage;
        public int Health { get; private set; }
        public int MaxHealth { get; private init; }

        public Enemy(string name, int health, int? maxHealth = null)
        {
            Name = name;
            Health = health;

            if (maxHealth != null)
            {
                if (maxHealth < health)
                {
                    throw new Exception();
                }

                MaxHealth = (int)maxHealth;
            }
            else
            {
                MaxHealth = health;
            }
        }

        public virtual void Attack(Enemy target)
        {
            if (target == null)
            {
                throw new NullReferenceException("target is null");
            }

            Console.WriteLine("Base Attack");
        }

        public virtual int TakeDamage(int damage)
        {
            Console.WriteLine("Base Take Damage");
            return 0;
        }
    }
}
