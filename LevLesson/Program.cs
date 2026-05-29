using System.Text.RegularExpressions;

namespace LevLesson
{
    internal class Program
    {
        static (int Rows, int Cols) GetFieldSize()
        {
            string errorMessage = "Ошибка! Введите число.\n";

            while (true)
            {
                Console.Write("Введите количество строк: ");
                if (!int.TryParse(Console.ReadLine(), out int rows))
                {
                    Console.WriteLine(errorMessage);
                    continue;
                }

                Console.Write("Введите количество столбцов: ");
                if (!int.TryParse(Console.ReadLine(), out int cols))
                {
                    Console.WriteLine(errorMessage);
                    continue;
                }

                if ((rows * cols) % 2 != 0)
                {
                    Console.WriteLine("Количество карт должно быть четным.\n");
                    continue;
                }

                return (rows, cols);
            }
        }

        static (int Value, bool Revealed)[,] InitializeCards(int rows, int columns)
        {
            (int Value, bool Revealed)[,] cards = new (int, bool)[rows, columns];

            int[] pairs = GeneratePairs(rows * columns);

            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    cards[i, j].Value = pairs[index];
                    index++;
                }
            }

            return cards;
        }

        static int[] GeneratePairs(int count)
        {
            int[] pairs = new int[count];

            for (int i = 0; i < count / 2; i++)
            {
                int element = i + 1;
                pairs[i * 2] = element;
                pairs[i * 2 + 1] = element;
            }

            Random.Shared.Shuffle(pairs);

            return pairs;
        }

        static (int Row, int Col) GetPosition((int Value, bool Revealed)[,] cards)
        {
            while (true)
            {
                Console.Write("Введите номер строки и столбца через пробел: ");

                string input = Console.ReadLine();
                
                MatchCollection matches = Regex.Matches(input, @"\d+");

                if (matches.Count != 2)
                {
                    Console.WriteLine("Ошибка! Введите два числа.\n");
                    continue;
                }

                int row = int.Parse(matches[0].Value);
                int col = int.Parse(matches[1].Value);

                if (row < 0 || row > cards.GetLength(0) || col < 0 || col > cards.GetLength(1))
                {
                    Console.WriteLine("Ошибка! Введенные числа выходят за пределы игрового поля.\n");
                    continue;
                }

                if (cards[row - 1, col - 1].Revealed)
                {
                    Console.WriteLine("Эта карта уже открыта.");
                    continue;
                }

                return (row - 1, col - 1);
            }
        }

        static void DisplayBoard((int Value, bool Revealed)[,] cards)
        {
            for (int i = 0; i < cards.GetLength(0); i++)
            {
                for (int j = 0; j < cards.GetLength(1); j++)
                {
                    if (cards[i, j].Revealed)
                    {
                        Console.Write($"{cards[i, j].Value}\t");
                    }
                    else
                    {
                        Console.Write("?\t");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static bool IsWin((int Value, bool Revealed)[,] cards, int founded)
        {
            return founded * 2 == cards.Length;
        }

        static void Main(string[] args)
        {
            (int Rows, int Cols) size = /*GetFieldSize();*/(2, 3);

            (int Value, bool Revealed)[,] cards = InitializeCards(size.Rows, size.Cols);

            int founded = 0;

            do
            {
                DisplayBoard(cards);

                (int Row, int Col) firstPosition = GetPosition(cards);
                cards[firstPosition.Row, firstPosition.Col].Revealed = true;

                Console.Clear();
                DisplayBoard(cards);

                (int Row, int Col) secondPosition = GetPosition(cards);
                cards[secondPosition.Row, secondPosition.Col].Revealed = true;

                Console.Clear();
                DisplayBoard(cards);

                if (cards[firstPosition.Row, firstPosition.Col].Value != cards[secondPosition.Row, secondPosition.Col].Value)
                {
                    cards[firstPosition.Row, firstPosition.Col].Revealed = false;
                    cards[secondPosition.Row, secondPosition.Col].Revealed = false;
                }
                else
                {
                    founded++;
                }

                if (!IsWin(cards, founded))
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            while (!IsWin(cards, founded));

            Console.WriteLine("Поздравляем! Вы выиграли!");
        }
    }
}
