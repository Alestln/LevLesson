namespace LevLesson;

internal class Program
{
    static void Main(string[] args)
    {
        ShowWelcome();
        Deposit(100, out string depositMessage);
        PrintOperation(depositMessage);
    }

    static void ShowWelcome()
    {
        Console.WriteLine("Welcome to our MEGA Bank.");
        // Action list
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. Withdraw with fee");
        Console.WriteLine("5. Format money");
        Console.WriteLine("6. Get operation message");
        
        Console.WriteLine();
    }

    static double GetBalance()
    {
        return 100;
    }

    static bool Deposit(double amount, out string message)
    {
        if (amount > 0)
        {
            // Increase balance
            message = "Deposit successful";
            return true;
        }

        message = "Invalid amount";
        return false;
    }

    static bool Withdraw(double amount, out string message)
    {
        double balance = GetBalance();

        if (balance >= amount)
        {
            // Decrease balance
            message = "Withdraw successful";
            return true;
        }
        
        message = "Insufficient funds";
        return false;
    }

    static bool Withdraw(double amount, double fee, out string message)
    {
        double balance = GetBalance();

        if (balance >= amount + fee)
        {
            // Decrease balance
            message = "Withdraw successful";
            return true;
        }
        
        message = "Insufficient funds";
        return false;
    }

    static string FormatMoney(double amount, string currency = "UAH")
    {
        return $"{amount} {currency}";
    }

    static void PrintOperation(string text)
    {
        Console.WriteLine(text);
    }
}