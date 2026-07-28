namespace LevLesson
{
    public class Cat : Animal
    {
        public string Color { get; init; }

        public Cat(string name, int age, string color) : base(name, age)
        {
            Color = color;
        }

        public void Meow()
        {
            Console.WriteLine($"{Name} говорит: Мяу!");
        }
    }
}
