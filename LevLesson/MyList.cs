namespace LevLesson
{
    public class MyList
    {
        private int[] _items;

        private int _count = 0;

        public const int DefaultCapacity = 4;

        public MyList()
        {
            _items = new int[DefaultCapacity];
        }

        public MyList(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentException("Вместимость не может быть меньше нуля.");
            }

            _items = new int[capacity];
        }

        public int Count => _count;

        public int Capacity
        {
            get => _items.Length;
            set
            {
                if (value < _count)
                {
                    throw new ArgumentException($"Вместимость не может быть меньше количества элементов списка. Код ошибки: {(int)ErrorCodes.CapacityLessThanCount}");
                }

                if (value != _items.Length)
                {
                    int[] newItems = new int[value];
                    if (_count > 0)
                    {
                        Array.Copy(_items, newItems, _count);
                    }
                    _items = newItems;
                }
            }
        }

        public int this[int index]
        {
            get
            {
                if (!IsValidIndex(index))
                {
                    throw new ArgumentOutOfRangeException("Индекс находится вне диапазона.");
                }
                return _items[index];
            }
            set
            {
                if (!IsValidIndex(index))
                {
                    throw new ArgumentOutOfRangeException("Индекс находится вне диапазона.");
                }
                _items[index] = value;
            }
        }

        public void Add(int item)
        {
            if (_count == _items.Length)
            {
                Grow();
            }
            _items[_count] = item;
            _count++;
        }

        private void Grow()
        {
            int newCapacity = _items.Length == 0 ? DefaultCapacity : _items.Length * 2;
            Capacity = newCapacity;
        }

        private bool IsValidIndex(int index)
        {
            return index >= 0 && index < _count;
        }
    }
}
