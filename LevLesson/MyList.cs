namespace LevLesson
{
    public class MyList
    {
        private int[] _items;

        public MyList(int[] values)
        {
            _items = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                _items[i] = values[i];
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj is MyList otherList)
            {
                if (_items.Length != otherList._items.Length)
                {
                    return false;
                }

                for (int i = 0; i < _items.Length; i++)
                {
                    if (_items[i] != otherList._items[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }
    }
}
