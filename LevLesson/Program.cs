namespace LevLesson
{
    internal class Program
    {
        static (int Rows, int Cols) GetFieldSize()
        {
            return (2, 3);
        }

        static int[,] InitializeCards(int rows, int columns)
        {
            int[,] cards = new int[rows, columns];

            int[] pairs = GeneratePairs(rows * columns);

            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    cards[i, j] = pairs[index];
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

        static void Main(string[] args)
        {
            (int Rows, int Cols) size = GetFieldSize();

            int[,] cards = InitializeCards(size.Rows, size.Cols);
        }
    }
}
