namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
        }
    }

    public class Test
    {
        private int _count;

        public int Count => _count;

        public Test()
        {
            Method();   
        }

        public void Method()
        {
            Console.WriteLine("Hello");
        }
    }
}
