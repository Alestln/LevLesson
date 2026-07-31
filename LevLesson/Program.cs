namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*MyQueue queue = new MyQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine(queue.IsEmpty);*/

            // Небезопасное приведение типов
            // short number = GetNumber();

            // Up Cast
            Animal animal = new Cat("Garfild");

            // Down Cast (используем в самых крайних случаях)
            Cat cat = (Cat)animal; // Нет никакой гарантии, что в animal объект класса Cat
        }

        static int GetNumber()
        {
            return 42;
        }
    }
}
