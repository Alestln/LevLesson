namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print();
            Print("Hi, Peter!");

            int a = -7;
            Console.WriteLine(Sum(ref a, 5));
            Console.WriteLine(a);
        }
        
        /*
         static тип_возвращаемого_значения Название_метода(аргументы_метода)
         {
            тело_метода
         }
         */
        
        // Сигнатура метода - это уникальный идентификатора метода, который состоит из имени и списка параметров (типов, количества и порядка)
        
        static void Print(string text = "Hello!")
        {
            Console.WriteLine(text);
        }
        
        // Написать метод, который находит сумму чисел
        // 1 + 2
        // 1 - left
        // 2 - right
        static int Sum(ref int left, int right)
        {
            left = 5;
            return left + right;
        }

        static int Sum(int[] arr)
        {
            int sum = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            
            return sum;
        }
    }
}
