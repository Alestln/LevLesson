namespace LevLesson
{
    public class Alice : AbstractNPC
    {
        public override void Move()
        {
            Console.WriteLine("NPC двигается по маршруту.");
        }

        public override void Stop()
        {
            Console.WriteLine("NPC остановился.");
        }
    }

    public class Bob : AbstractNPC, ITrade
    {
        public void Buy()
        {
            throw new NotImplementedException();
        }

        public void Sell()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            Console.WriteLine("NPC двигается по маршруту.");
        }

        public override void Stop()
        {
            Console.WriteLine("NPC остановился.");
        }
    }

    public abstract class AbstractNPC : IMovable
    {
        public int Speed { get; set; }

        public abstract void Move();
        public abstract void Stop();
    }
}
