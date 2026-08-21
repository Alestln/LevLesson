namespace LevLesson
{
    public class Car : IMovable
    {
        public int Speed { get; set; }

        public void Move()
        {
            Console.WriteLine("Машина едет на колесах.");
        }

        public void Stop()
        {
            Console.WriteLine("Машина тормозит колодками.");
        }
    }
}
