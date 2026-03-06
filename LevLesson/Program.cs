namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            char symbol = '$';
            string text = "Hello world";
            text = "Hello";
            string copyText = text;

            int b = 10;
            int result = Sum(a, b, out int res);
            Console.WriteLine(result);
            
            (int Sum, int UniversalNumber) sumResult = Sum(a, b);
            Console.WriteLine($"Sum: {sumResult.Sum}; Universal Number: {sumResult.UniversalNumber}");
        }

        static int Sum(int a, int b, out int result)
        {
            result = a + b;
            return a + b;
        }
        
        static (int, int) Sum(int a, int b)
        {
            return (a + b, 42);
        }
    }
}
