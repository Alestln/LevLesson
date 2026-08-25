namespace LevLesson.Interfaces
{
    public interface IAttacker
    {
        int Damage { get; }
        void Attack(IDamageable target);
    }
}
