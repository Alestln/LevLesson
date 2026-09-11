using System.Collections;

namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Nagibator2000";

            int hash = name.GetHashCode();

            Hashtable ht = new Hashtable();

            Item item = new Item()
            {
                Id = 1,
                Name = "Меч"
            };

            Item item2 = new Item()
            {
                Id = 1,
                Name = "Меч"
            };

            // Домашнее задание
            // 1. Попробуйте написать программу, которая покажет коллизию хешей для разных объектов.
            // Например, создайте несколько объектов с одинаковыми значениями свойств и проверьте их хеши.
            // Для этого задания создайте класс Player с свойством никнейма и уровня, переопределите метод
            // GetHashCode() для этого класса, чтобы он возвращал одинаковый хеш для объектов с одинаковыми значениями свойств.
            // 2. Почитать про коллекцию HashTable и HashSet, понять их отличия и преимущества использования HashSet перед HashTable.
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Item item &&
                   Id == item.Id;
        }
    }
}
