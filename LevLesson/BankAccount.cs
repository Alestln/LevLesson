namespace LevLesson
{
    public class BankAccount
    {
        private int _balance;

        public int Balance => _balance;

        public void Deposit(int amount)
        {
            if (amount > 0 && amount <= 1000)
            {
                _balance += amount;

                return;
            }

            throw new ArgumentOutOfRangeException("Надо ввести сумму пополнения счета от 1 до 1000");
        }

        public bool Withdraw(int amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                return true;
            }

            return false;
        }
    }
}
