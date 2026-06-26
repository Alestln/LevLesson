namespace LevLesson
{
    internal class Person
    {
        private string _name;
        private int _age;
        private double _height;

        internal int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 1 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 1 and 120.");
                }

                _age = value;
            }
        }

        internal char FirstLetterOfName
        {
            get
            {
                return _name[0];
            }
        }

        public Person(string name, int age, double height)
        {
            _name = name;
            _age = age;
            _height = height;
        }
    }
}
