namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*CoffeeMachine machine = new CoffeeMachine();

            machine.MakeCoffee();*/

            // Домашнее задание:
            // Написать самостоятельно пару примеров с интерфейсами и с наследованием. Сравнить их между собой.

            IMovable movable = new Enemy();

            movable.Move();

            IMovable[] movables = new IMovable[]
            {
                new Car(),
                new Character(),
                new Car(),
                new Alice()
            };

            for (int i = 0; i < movables.Length; i++)
            {
                movables[i].Move();
            }
        }
    }

    /*public abstract class Transport
    {
        public double Velocity { get; private set; }

        protected Transport(double velocity)
        {
            Velocity = velocity;
        }

        public abstract void Move();
    }

    public class Car : Transport
    {
        public Car(double velocity) : base(velocity)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"The car is moving at {Velocity} km/h.");
        }
    }*/

    public class CoffeeMachine : ICoffeeMaker
    {
        public void MakeCoffee()
        {
            HeatWater();
            GrindBeans();
            PourWater();
        }

        private void HeatWater()
        {
            Console.WriteLine("Heating water...");
        }

        private void GrindBeans()
        {

        }

        private void PourWater()
        {
            Console.WriteLine("Pouring water...");
        }
    }
}
