namespace LevLesson.Enemies
{
    public class Werewolf : Enemy
    {
        private const int RageAttackDamage = 60;
        private const int RageAttackCount = 2;
        private bool _isRage = false;

        public Werewolf(string name, int health, int? maxHealth = null) : base(name, health, maxHealth)
        {

        }

        public override void Attack(Enemy target)
        {
            int count = _isRage ? RageAttackCount : 1;

            for (int i = 0; i < count; i++)
            {
                base.Attack(target);
            }
        }

        public override int TakeDamage(int damage)
        {
            if (Health < MaxHealth / 2)
            {
                _isRage = true;
                AttackDamage = RageAttackDamage;
            }

            return base.TakeDamage(damage);
        }
    }
}
