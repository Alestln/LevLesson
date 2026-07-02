namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Camry", Color.Blue);

            Console.WriteLine(car.Info());

            car.Ride(40);

            Thread.Sleep(2000);

            car.Stop();

            Console.WriteLine($"Car stopped.");
        }
    }
}
