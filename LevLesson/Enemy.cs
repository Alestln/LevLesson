namespace LevLesson
{
    internal class Enemy : IMovable
    {
        public int Speed { get; set; }

        public void Move()
        {
            Console.WriteLine("Противник двигается в сторону игрока.");
        }

        public void Stop()
        {
            Console.WriteLine("Противник остановился.");
        }
    }
}
