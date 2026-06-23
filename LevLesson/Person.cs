using LevLesson.Enums;

namespace LevLesson
{
    internal class Person
    {
        private string _name;
        private string _email;
        private int _age;
        private Gender _gender;

        internal string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }

                _name = value;
            }
        }

        internal char FirstLetterOfName
        {
            get
            {
                return _name[0];
            }
        }

        internal Person(string name, string email, int age, Gender gender)
        {
            _name = name;
            _email = email;
            _age = age;
            _gender = gender;
        }
    }
}
