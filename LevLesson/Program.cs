namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание:
            // Почитать про Очередь (Queue). Реализовать свой класс MyQueue, который будет работать по принципу FIFO (First In First Out).
            // Реализовать методы Enqueue, Dequeue, Peek, Count, Capacity. Внутри использовать массив для хранения элементов.

            // 1 Не используя Список

            /*string[] names =
            {
                "Alex",
                "Sasha",
                "Konny",
                "Alice"
            };

            string newName = "Lev";

            string[] temp = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                temp[i] = names[i];
            }

            temp[temp.Length - 1] = newName;

            names = temp;*/

            // 2 Используя Список
            List<string> names = new List<string>()
            {
                "Alex",
                "Sasha",
                "Konny",
                "Alice"
            };

            names.Add("Lev");

            string[] copy = new string[5];
            names.CopyTo(copy);

            names.EnsureCapacity(5);
        }
    }
}
