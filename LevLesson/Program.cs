namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // / - оператор деления

            // Пользователь должен вводить ТОЛЬКО целые числа
            /*int x = 7;
            int y = 2;*/

            // Целочисленное деление
            // double result = x / y; // 3

            // Приведение типов
            // double result = (double)x / y; // 3.5
            // double result = x / 2.0; // 3.5
            // Console.WriteLine($"Result: {result}");

            // int / int = int
            // double / int = double
            // int / double = double
            // double / double = double

            // Результат деления всегда будет того типа, который имеет наибольший диапазон значений
            // int + long = long

            /*int x = -70000;
            short y = (short)x;*/ // Небезопасное приведение типов (explicit casting)

            /*short x = 30000;
            int y = x;*/ // Безопасное приведение типов (implicit casting)

            /*short x = 30000;
            int y = (int)x;*/ // Явное приведение типов

            /*short x = 30000;
            int y = x;*/ // Неявное приведение типов

            // Console.WriteLine($"X: {x}\nY: {y}");

            int a = 5;
            // double result = Math.Pow(a, 2);
            int result = a * a; // Операция умножения будет быстрее, чем вызов метода
        }
    }
}
