namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Массивы
            // Создание массива
            // int[] arr = new int[10];
            
            // Инициализация массива в коде
            // int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Обращение к элементу массива по индексу
            // arr[0]
            
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Random.Shared.Next(1, 10);
            }

            // Почитать про методы Array
            // Array.Resize(ref arr, 30);
        }
    }
}
