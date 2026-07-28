namespace LevLesson
{
    public class Dog : Animal
    {
        public string Breed { get; init; }

        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} говорит: Гав-гав!");
        }
    }
}
