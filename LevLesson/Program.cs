namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> list1 = new MyLinkedList<int>();
            list1.AddLast(1);
            list1.AddLast(3);

            MyLinkedList<int> list2 = new MyLinkedList<int>();
            list2.AddLast(2);
            list2.AddLast(4);

            Console.WriteLine(list1 == list2);

            // Домашнее задание
            // Дописать MyLinkedList<T>. Переопределить операторы сравнения == и !=.
            // Переопределить индексатор, чтобы можно было получать и устанавливать элементы по индексу. И пройтись по списку с помощью for.
            // Переопределить оператор + для объединения двух списков и оператор - для удаления элементов одного списка из другого.
        }
    }
}
