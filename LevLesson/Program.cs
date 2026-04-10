namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Реализация метода Clamp
            // Console.WriteLine(Math.Clamp(5, 1, 10));

            string text = "Hello, World!";
            bool contains = text.Contains("o, W");
            bool starts = text.StartsWith("Hllo");

            char lastSymbol = text[text.Length - 1];

            string phone = "123-456-7890";
            string cleanPhone = phone.Replace("$", "777");

            string date = "2024-06-01";
            string year = date.Substring(0, 4);

            string csv = ",John,Doe,30,";
            csv = csv.Trim(','); // Удаляем запятые в начале и конце строки
            string[] parts = csv.Split(',');

            string result = string.Join(" | ", parts);

            string str1 = "hello";
            string str2 = "HELLO";

            // Плохой способ сравнения строк
            /*if (str1.ToLower() == str2.ToLower())
            {

            }*/

            // Хороший способ сравнения строк
            if (string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Строки равны");
            }

            string input = "null";

            bool b1 = string.IsNullOrEmpty(input); // Проверяет, является ли строка null или пустой

            bool b2 = string.IsNullOrWhiteSpace(input); // Проверяет, является ли строка null, пустой или состоит только из пробелов
        }
    }
}
