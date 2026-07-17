namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Нужно реализовать коллекцию данных Stack

            // Push: добавляет элемент в стек в верхушку стека
            // Pop: извлекает и возвращает первый элемент из стека
            // Peek: просто возвращает первый элемент из стека без его удаления

            MyStack stack = new MyStack(1);

            stack.Push(15);

            stack.Clear();

            stack.Push(15);
        }
    }
}
