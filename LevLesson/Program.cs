namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // LINQ - методы расширения
            // x => x % 2 == 0 - Predicate (условие)
            // numbers.RemoveAll(x => x % 2 == 0); // Удаляем все четные числа

            // int health = 50; // 0...100

            // health += 60;

            /*if (health > 100)
            {
                health = 100;
            }
            else if(health < 0)
            {
                health = 0;
            }*/

            // Готовое решение для ограничения значения health в диапазоне от 0 до 100
            // health = Math.Clamp(health -= 10, 0, 100); // Ограничение значения health в диапазоне от 0 до 100

            object obj = 10;
            // Под капотом происходит упаковка (boxing) - преобразование значения value type в ссылочный тип (object)
            object obj2 = (object)10; // Упаковка (boxing), происходит Upcasting - преобразование производного типа в базовый тип (object)

            // Распаковка (unboxing) - преобразование ссылочного типа (object) обратно в value type. НЕБЕЗОПАСНОЕ ПРЕОБРАЗОВАНИЕ, МОЖЕТ ВЫЗВАТЬ ОШИБКУ ВРЕМЕНИ ВЫПОЛНЕНИЯ
            int value = (int)obj2; // Происходит Downcasting - преобразование базового типа в производный тип

            // Пример использования ToString(), который не переопределен в классе List<T>
            // Console.WriteLine(numbers.ToString()); // Выводится полное квалифицированное имя типа, а не содержимое списка

            /*int[] numbers1 = new int[4] { 1, 2, 3, 4 };
            int[] numbers2 = new int[4] { 1, 2, 3, 4 };

            Console.WriteLine(numbers1.Equals(numbers2));*/ // False, так как сравниваются ссылки на объекты, а не их содержимое

            /*MyList list1 = new MyList([1, 2, 3, 4]);
            MyList list2 = new MyList([1, 2, 3, 4]);

            Console.WriteLine(list1.Equals(list2));*/ // True, так как переопределен метод Equals() в классе MyList

            // GetType() - возвращает объект Type, который представляет тип данного объекта.
            // Используется для получения информации о типе объекта во время выполнения. Используйется в рефлексии.

            // Домашнее задание
            // Создать класс, который переопределяет метод Equals() и метод ToString().
            // Почитать про принцип ООП Абстракция.
        }
    }
}
