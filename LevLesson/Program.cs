namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Alex", 25, 1.79);

            Console.WriteLine(person.Age);
            Console.WriteLine(person.FirstLetterOfName);

            try
            {
                person.Age = 30;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine(person.Age);
        }
    }
}
