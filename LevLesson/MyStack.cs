namespace LevLesson
{
    public class MyStack
    {
        private int[] _items;
        private int _count;

        public const int DefaultCapacity = 4;

        public int Count => _count;
        public int Capacity => _items.Length;
        public bool IsEmpty => _count == 0;

        public MyStack(int initialCapacity = DefaultCapacity)
        {
            if (initialCapacity < 0)
            {
                throw new ArgumentException();
            }

            _items = new int[initialCapacity];
            _count = 0;
        }

        public void Push(int item)
        {
            if (_count == _items.Length)
            {
                Resize(_items.Length * 2); // TODO: Придумать формулу увеличения объема, так как _items.Length может равняться нулю.
            }

            _items[_count] = item;
            _count++;
        }

        public int Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Стек пуст! Нельзя достать элемент.");
            }

            return _items[_count - 1];
        }

        public int Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Стек пуст! Нельзя достать элемент.");
            }

            _count--;
            int item = _items[_count];

            _items[_count] = default;

            if (_count <= _items.Length / 2)
            {
                Resize(_items.Length / 2);
            }

            return item;
        }

        public void Clear()
        {
            Array.Clear(_items);
            _count = 0;
            Resize(_items.Length / 2);
        }

        private void Resize(int newCapacity)
        {
            int[] temp = new int[newCapacity];

            Array.Copy(_items, temp, _count);

            _items = temp;
        }
    }
}
