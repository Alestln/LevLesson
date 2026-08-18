using LevLesson.Test;

namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Alice");
            Player player2 = new Player("Alice");

            bool isEqual = player1.Equals(player2);
            Console.WriteLine($"Are the players equal? {isEqual}");

            string text = player1.ToString();
            Console.WriteLine(text);

            Console.WriteLine(player1.GetHashCode());

            // Домашнее задание:
            // 1. Почитать про абстракцию.
            // 2. Почитать про интерфейсы. Чем отличаются интерфейсы от наследования. Привести примеры.
        }
    }

    public struct PlayerInput
    {
        public bool IsJump { get; set; }
    }
}
