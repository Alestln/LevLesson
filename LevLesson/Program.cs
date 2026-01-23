namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Тема занятия: Двумерные массива
            int[] arr = new int[5] { 5, 4, 7, 6, 8 }; // Одномерный массив
            
            // Создать двумерный массив
            // int[,] matrix = new int[5, 4];
            
            // Инициализация двумерного массива в коде
            /*int[,] matrix = new int[2, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };*/

            int[,] matrix = new int[5, 4];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Random.Shared.Next(1, 1000);
                }
            }

            Console.WriteLine("Double array:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
