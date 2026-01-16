using System.Text;

namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            //создание и заполнение массива
            int[] array = new int[5];
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Random.Shared.Next(51);
            }

            Console.WriteLine($"Неотсортированный массив: {string.Join(", ", array)}");

            #region Selection sort

            // Selection sort
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }

            Console.WriteLine($"Отсортированный массив: {string.Join(", ", array)}");

            #endregion
            
            #region Counting sort

            /*if (array.Length <= 1)
            {
                Console.WriteLine($"Отсортированный массив: {string.Join(", ", array)}");
                return;
            }
            
            int maxValue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            
            int[] count = new int[maxValue + 1];

            for (int i = 0; i < array.Length; i++)
            {
                count[array[i]]++;
            }
            
            // O(n^2)
            int index = 0;
            for (int i = 0; i < count.Length; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    array[index] = i;
                    index++;
                }
            }

            Console.WriteLine($"Отсортированный массив: {string.Join(", ", array)}");*/

            #endregion

        }
    }
}
