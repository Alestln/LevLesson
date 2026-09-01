namespace LevLesson
{
    internal class MyList<T>
    {
        private T[] _items;
        private int _count;

        public MyList()
        {
            _items = new T[4];
            _count = 0;
        }

        public void Add(T item)
        {
            if (_count == _items.Length)
            {
                Resize();
            }
            _items[_count] = item;
            _count++;
        }

        private void Resize()
        {
            int newSize = _items.Length * 2;
            T[] newItems = new T[newSize];
            for (int i = 0; i < _items.Length; i++)
            {
                newItems[i] = _items[i];
            }
            _items = newItems;
        }

        public int Count
        {
            get { return _count; }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException();
                }
                return _items[index];
            }
        }

    }
}
