namespace LevLesson
{
    internal class PointClass
    {
        public int X { get; set; }

        public int Y { get; set; }
    }

    internal record PointRecord(int X, int Y);

    internal class Program
    {
        static void Main(string[] args)
        {
            // DTO - Data Transfer Object

            PointClass c1 = new PointClass { X = 1, Y = 2 };
            PointClass c2 = new PointClass { X = 1, Y = 2 };
            Console.WriteLine(c1 == c2);

            PointRecord r1 = new PointRecord(1, 2);
            PointRecord r2 = new PointRecord(1, 2);
            Console.WriteLine(r1 == r2);

        }
    }
}
