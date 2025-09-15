namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Литералы
            /*
             * Целочисленные литералы
             * 5, 42, 123, -10, 0 - представляется типом int
             * 
             * Дробные литералы
             * 5.5, 3.14, -0.001, 0.0 - представляется типом double
             * 5.5f, 3.14f, -0.001f, 0.0f, 5f, 10f, -12f - представляется типом float
             * 5.5m, 3.14m, -0.001m, 0.0m, 5m, 10m, -12m - представляется типом decimal
             * 
             * Символьные литералы
             * 'a', 'Z', '0', '#', '\n', '\t', '\'' - представляется типом char
             * 
             * Строковые литералы
             * "Строка", "Hello, World!", "123", "Line1\nLine2", "Tab\tCharacter" - представляется типом string
             * 
             * Булевы литералы
             * true, false - представляется типом bool
             */

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            // Способ 1: Использование Convert
            // int age = Convert.ToInt32(Console.ReadLine());
            /*double ageDouble = Convert.ToDouble(Console.ReadLine());
            float ageFloat = Convert.ToSingle(Console.ReadLine());*/

            // Способ 2: Использование Parse
            int age = int.Parse(Console.ReadLine());
            /*double ageDouble = double.Parse(Console.ReadLine());
            float ageFloat = float.Parse(Console.ReadLine());
            char firstChar = char.Parse(Console.ReadLine());
            bool isAdult = bool.Parse(Console.ReadLine());*/

            Console.WriteLine($"Ваше имя: {name}");
            Console.WriteLine($"Ваш возраст: {age}");

            // Домашнее задание
            /*
             * 1. Переделать дз с анкетой пользователя учитывая замечания с урока.
             * 2. Почитать про все типы данных на C#.
             * 3. Почитать про приведение типов. Явное и неявное приведение типов. Безопасное и небезопасное приведение типов.
             */
        }
    }
}
