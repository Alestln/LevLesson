namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String
            // В C# символы хранятся в кодировке UTF-16
            // Следовательно один смивол занимает 2 байта в памяти

            /*string text = "Hello";
            char[] c = ['H', 'e', 'l', 'l', 'o'];

            string obj = "5";
            string obj2 = "5";*/

            // Сравнение по значению, несмотря на то, что string - ссылочный тип.
            // String реализует IComparable
            // Console.WriteLine(obj == obj2);
            
            string name = "John"; // Создается 1-я строка
            name = name.ToUpper(); // Создается 2-я строка и ссылка на 2-ю строку присваивается в переменную name
            
            // В C# строки иммутабельны (неизменяемы)

            /*string s1 = string.Empty;
            string s2 = null;*/

            // Длина строки
            /*Console.WriteLine(name.Length);

            Console.WriteLine(name[0]);
            Console.WriteLine(name[name.Length - 1]);*/

            /*string s = "       Hello world!      ";
            Console.WriteLine(s.Trim());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.Trim().ToLower());*/

            string text = "C# is awesome!";
            bool contains = text.Contains("awes");
            bool starts = text.StartsWith("C#");
            bool ends = text.EndsWith("!");

            int index = text.IndexOf("is");
        }
    }
}
