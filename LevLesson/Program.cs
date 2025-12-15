namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            
            int number;

            Console.Write("Enter four digit number: ");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Incorrect input data.");
                    continue;
                }

                if (number < 1000 || number > 9999)
                {
                    Console.WriteLine("Please enter a four digit number.");
                    continue;
                }

                break;
            }
            
            /*
             * a = (fourDigitNum / 1000) % 10;
               b = (fourDigitNum / 100) % 10;
               c = (fourDigitNum / 10) % 10;
               d = (fourDigitNum / 1) % 10;
             */
            
            // 1234 / 10
            // 123 / 10
            // 12 / 10
            // 1 / 10 = 0

            int count = 0;

            for (int i = number; i != 0; i /= 10)
            {
                if (i % 10 % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Number {number} have {count} even digits.");

            Console.WriteLine("End of program.");
        }
    }
}
