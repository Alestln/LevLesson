namespace LevLesson
{
    public class MyQueue
    {
        private int[] _items;
        private int _head;
        private int _tail;

        const int DefaultCapacity = 2;

        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public MyQueue()
        {
            _items = new int[DefaultCapacity];
            _head = 0;
            _tail = 0;
            Count = 0;
        }

        public void Enqueue(int value)
        {
            if (Count == _items.Length)
            {
                Resize(_items.Length * 2 + 1);
            }

            _items[_tail] = value;
            _tail++;
            Count++;
        }

        public int Dequeue()
        {
            ThrowIfEmpty();

            int val = _items[_head];
            _items[_head] = default;
            _head++;
            Count--;

            if (Count <= _items.Length / 2)
            {
                Resize(Count + 1);
            }

            return val;
        }

        public int Peek()
        {
            ThrowIfEmpty();

            return _items[_head];
        }

        public void Clear()
        {
            _items = new int[DefaultCapacity];
            _head = 0;
            _tail = 0;
            Count = 0;
        }

        private void Resize(int newSize)
        {
            if (newSize < Count)
            {
                throw new ArgumentException();
            }

            int[] newArr = new int[newSize];

            Array.Copy(_items, newArr, Count);

            _items = newArr;
        }

        private void ThrowIfEmpty()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Очередь пустая");
            }
        }
    }
}
