namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] array = CreateArray(5);

            Print(array);*/

            /*int number = GenerateNumber(17, 7);
            Console.WriteLine(number);*/
            
            int.TryParse(Console.ReadLine(), out int number);
            
            Method(3, 5, out int resultSum, out int resultDiff);

            Console.WriteLine($"Sum: {resultSum}, Diff: {resultDiff}");
        }

        // В сигнатуру любого метода входит:
        /*
         * Название метода
         * Колиество параметров метода
         * Порядок параметров метода
         */
        
        static void Print()
        {
            Console.WriteLine("Hello World!");
        }

        static void Print(string text)
        {
            Console.WriteLine(text);
        }

        static void Print(int[] array)
        {
            Console.WriteLine($"Array: {string.Join(", ", array)}");
        }

        static int[] CreateArray(int length)
        {
            int[] array = new int[length];
            
            return array;
        }

        static int GenerateNumber(int length, int number = 42)
        {
            return number * 2 / 4 + Random.Shared.Next(-100, 100) - length;
        }

        static bool Method(int a, int b, out int sum, out int diff)
        {
            sum = a + b;
            diff = a - b;

            return sum == diff;
        }
    }
}
