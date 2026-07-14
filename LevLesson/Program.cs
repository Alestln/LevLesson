namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList(2);
            myList.Add(42);
            myList.Add(45);

            Console.Write("Элементы списка: ");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write($"{myList[i]} ");
            }
            Console.WriteLine();

            // Валидация 1
            /*int newCapacity;
            do
            {
                Console.Write("Введите новый объем списка: ");
                newCapacity = int.Parse(Console.ReadLine());
            }
            while (newCapacity < myList.Count);

            myList.Capacity = newCapacity;*/

            // Валидация 2
            while (true)
            {
                Console.Write("Введите новый объем списка: ");
                int newCapacity = int.Parse(Console.ReadLine());

                try
                {
                    myList.Capacity = newCapacity;
                    break; // Выход из цикла, если установка прошла успешно
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(myList.Capacity);

            // Домашнее задание:
            // Почитать про Очередь (Queue). Реализовать свой класс MyQueue, который будет работать по принципу FIFO (First In First Out).
            // Реализовать методы Enqueue, Dequeue, Peek, Count, Capacity. Внутри использовать массив для хранения элементов.
        }
    }
}
