using LevLesson.Enums;

namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Alex", "email@gmail.com", 25, Gender.Male);

            person.Name = "Lev";

            Console.WriteLine("Person Info:");
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"First Letter of Name: {person.FirstLetterOfName}");

            // Домашнее задание: Создать класс "Car" с полями "Make", "Model", "Year" и "Color" (Color должен быть Enum).
            // Создать объект класса "Car" и вывести информацию о нем на консоль.

            // Второе домашнее задание:
            // Создать класс Patient.
        }
    }
}
