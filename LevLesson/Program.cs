namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int choice = GetMenuChoice();
            Console.WriteLine($"Your choice is {choice}");*/

            int number = 42;
            char symbol = '*';
            bool result = true;
            string name = "Alex";
            Method(ref number);

            Console.WriteLine(number);
        }

        static void Method(ref int number)
        {
            number += 3;
        }

        /*static int GetMenuChoice()
        {
            while (true)
            {
                Console.Write("Enter the number (1-4): ");
                
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 4)
                {
                    return choice;
                }

                Console.WriteLine("Invalid choice");
            }
        }*/

        // Метод занимается только изменением баланса и не более.
        /*static void ChangeBalance(double amount, out string resultOperation)
        {
            // userBalance += amount;
            resultOperation = "Balance";
        }*/
    }
}
