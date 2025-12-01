namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Циклы в C#
            // while
            // do...while
            // for

            // Пример использования цикла while
            /*while (условие)
            {
                тело цикла
            }*/

            /*int counter = 5;
            while (counter < 5)
            {
                Console.WriteLine($"Counter: {counter}");
                counter++;
            }*/

            // Пример бесконечного цикла while
            /*while (true)
            {
                Console.WriteLine("Hello");
            }*/

            // Пример использования цикла do...while
            /*do
            {
               тело цикла 
            }
            while (условие);*/

            // Гарантированное однократное выполнение тела цикла
            /*int counter = 5;
            do
            {
                Console.WriteLine($"Counter: {counter}");
                counter++;
            }
            while (counter < 5);*/

            /*int number;
            do
            {
                number = Random.Shared.Next(-5, 10);
            }
            while (number < 1 || number > 5);*/

            // Пример использования цикла for
            /*for (инициализация; условие; итерация)
            {
                тело цикла
            }*/

            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}
