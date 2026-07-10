namespace LevLesson
{
    internal class Test
    {
        private int[] _array;
        private int _capacity = 4;
        private readonly User _admin = new User { Name = "Admin" };

        internal IReadOnlyList<int> Array => _array;
        internal User Admin => _admin;

        public Test()
        {
            _array = new int[_capacity];
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = 1;
            }
        }
    }
}
