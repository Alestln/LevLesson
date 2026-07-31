namespace LevLesson
{
    public abstract class Animal
    {
        protected string Name { get; init; }

        public Animal(string name)
        {
            Name = name;
            Console.WriteLine("Создано животное");
        }

        protected abstract void Eat();
    }
}
