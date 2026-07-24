namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ООП
            // Инкапсуляция

            BankAccount account = new BankAccount();
            account.Deposit(500);
            Console.WriteLine(account.Balance);

            account.Withdraw(200);
            Console.WriteLine(account.Balance);

            // Домашнее задание
            // 1) Доделать реализацию класса MyQueue.
            // 2) Почитать про наследование.
        }
    }
}
