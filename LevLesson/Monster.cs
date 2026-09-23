namespace LevLesson
{
    internal class Monster : IComparable<Monster>
    {
        public string Name { get; private set; }

        public int Level { get; private set; }

        public Monster(string name, int level)
        {
            Name = name;
            Level = level;
        }

        // -1 - this < other (должен стоять левее)
        // 0 - this == other (не менять порядок)
        // 1 - this > other (должен стоять правее)

        public int CompareTo(Monster? other)
        {
            if (other is null)
            {
                return 1;
            }

            return Level.CompareTo(other.Level);
        }
    }
}
