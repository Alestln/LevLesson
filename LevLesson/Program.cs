namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("John", 3, "RED");
            cat.Eat();
            cat.Sleep();
            cat.Meow();
            cat.Eat();

            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Age);
            Console.WriteLine(cat.Color);

            Console.WriteLine();

            Dog dog = new Dog("Bobik", 7, "Labrador");
            dog.Eat();
            dog.Sleep();
            dog.Bark();
            dog.Eat();

            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Age);
            Console.WriteLine(dog.Breed);

            // Домашнее задание
            // 1. Доделать класс MyQueue
            // 2. Почитать про то, на что влияют модификаторы доступа в родительских классах
            // 3. Почитать про переопределение методов.
            // 4. Почитать про слово abstract.
            // 5. Если будет время, почитать про принцип ООП - Абстракция.
        }
    }
}
