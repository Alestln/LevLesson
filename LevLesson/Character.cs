namespace LevLesson
{
    public class Character : IMovable
    {
        public int Speed { get; set; }

        public void Move()
        {
            Console.WriteLine("Персонаж бежит ногами по земле.");
        }

        public void Stop()
        {
            Console.WriteLine("Персонаж остановился.");
        }
    }
}
