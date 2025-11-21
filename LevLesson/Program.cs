namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter a number: ");
            string text = Console.ReadLine();*/

            // 1
            // int number1 = Convert.ToInt32(text);

            // 2
            // int number = int.Parse(text);

            // 3
            /*if (!int.TryParse(text, out int number))
            {
                Console.WriteLine($"Incorrect format number.");
                return;
            }*/

            // Console.WriteLine($"User entered a number: {number}");

            // Обработка исключений

            int a = 5, b = 0;
            int result = 0;

            try
            {
                // Расчет скорости
                result = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Some error: {ex.Message}");
            }
            finally
            {
                // Работает всегда
            }

            // Расчет температуры
            try
            {
                result = 4 / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Some error: {ex.Message}");
            }

            Console.Write(result);

            // Как выбросить исключение

            throw new Exception("Some exception message");

            Console.WriteLine("End of program");
        }
    }
}