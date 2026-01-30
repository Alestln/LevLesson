namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start program");
            
            // Методы
            Method();
            Method("Text from parameter");

            // Перегрузка метода
            int[,] matrix = CreateDoubleArray(2, 3);
            
            // Сигнатура метода
            // В сигнатуру метода входит название метода, количество аргументов метода, порядок аргументов и типы аргументов
            
            Console.WriteLine("End program");
        }

        static int[,] CreateDoubleArray(int size)
        {
            int[,] array = new int[size, size];

            return array;
        }
        
        static int[,] CreateDoubleArray(int rows, int columns)
        {
            return new int[rows, columns];
        }
        
        static void Method()
        {
            Console.WriteLine("Method works!");

            // Под капотом вызовется этот return
            return;
        }
        
        static void Method(string text)
        {
            Console.WriteLine(text);
        }
    }
}
