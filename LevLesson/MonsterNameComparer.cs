namespace LevLesson
{
    internal class MonsterNameComparer : IComparer<Monster>
    {
        public int Compare(Monster? x, Monster? y)
        {
            if (x is null && y is null)
            {
                return 0;
            }

            if (x is null)
            {
                return 1;
            }

            if (y is null)
            {
                return -1;
            }

            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
        }
    }
}
