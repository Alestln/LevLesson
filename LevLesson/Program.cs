namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generics

            MyList<string> myList = new MyList<string>();

            myList.Add("Hello");
            myList.Add("World");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            /*double number1 = 5;
            double number2 = 10;*/

            ChildClass child1 = new ChildClass();
            ChildClass child2 = new ChildClass();

            Swap(ref child1, ref child2);

            // Домашнее задание: Создать Связный список с дженериками
        }

        public static void Swap<T>(ref T a, ref T b) where T : BaseClass, IAttacker
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
