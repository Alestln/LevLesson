namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание массива без заполнения данными
            // int[] arr = new int[5];

            // Создание массива с заполнением данными при объявлении
            // int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            //                          0, 1, 2, 3, 4  - индексы элементов массива

            // Обращение к элементам массива по индексу
            // Console.WriteLine(arr[2]);

            // В переменной arr хранится ссылка на область памяти, где лежит массив

            /*int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Random.Shared.Next();
            }*/

            // Найти сумму элементов массива случайных чисел от 1 до 10
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Random.Shared.Next(1, 11);
            }

            Console.Write("Элементы массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }

            Console.WriteLine($"\nСумма: {sum}");
        }
    }
}
