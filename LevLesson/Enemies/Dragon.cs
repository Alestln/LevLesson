namespace LevLesson.Enemies
{
    public class Dragon : Enemy
    {
        private bool _isRage = false;

        public Dragon(string name, int health, int? maxHealth = null) : base(name, health, maxHealth)
        {
        }

        public override void Attack(Enemy target)
        {
            if (true) // condition 1
            {
                AttackDamage = 55;
            }

            if (_isRage) // condition 2
            {
                AttackDamage = 75;
            }
            else
            {
                AttackDamage = BaseAttackDamage;
            }

            Console.WriteLine("Dragon attacks!");
            base.Attack(target);
        }
    }
}
