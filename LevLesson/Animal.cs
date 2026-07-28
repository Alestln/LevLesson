namespace LevLesson
{
    public class Animal
    {
        public string Name { get; init; }
        public int Age { get; init; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} кушает.Ням-ням!");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} спит. Zzz...");
        }
    }
}
