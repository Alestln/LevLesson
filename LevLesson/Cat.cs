namespace LevLesson
{
    public class Cat : Animal
    {
        const int DefaultLivesCount = 9;

        public int LivesCount { get; init; }

        public Cat(string name) : base(name)
        {
            LivesCount = DefaultLivesCount;
            Console.WriteLine($"Создан кот по имени {Name}");
        }

        protected override void Eat()
        {
            
        }
    }
}
