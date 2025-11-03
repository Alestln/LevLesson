namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Операторы сравнения
            // Каждый оператор возвращает значение типа bool (true или false)
            // > - больше
            // < - меньше
            // >= - больше или равно
            // <= - меньше или равно
            // == - равно
            // != - не равно

            // Логические операторы
            // Каждый оператор возвращает значение типа bool (true или false)
            // && - логическое И
            // || - логическое ИЛИ
            // ! - логическое НЕ

            // Условная конструкция if
            /*if (условие)
            {
                тело условия
            }*/

            /*Console.Write("Введите порядковый номер пальца руки: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("Большой палец");
            }
            else if (number == 2)
            {
                Console.WriteLine("Указательный палец");
            }
            else if (number == 3)
            {
                Console.WriteLine("Средний палец");
            }
            else if (number == 4)
            {
                Console.WriteLine("Безымянный палец");
            }
            else if (number == 5)
            {
                Console.WriteLine("Мизинец");
            }
            else
            {
                Console.WriteLine("Пальца с таким номером не существует!");
            }*/

            /*Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("Год високосний");
            }
            else
            {
                Console.WriteLine("Год не високосний");
            }*/

            // int a = 5, b = -10;

            /*if (a > 0)
            {
                if (b > 0)
                {
                    Console.WriteLine("text");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }*/

            /*if (a > 0 && b > 0)
            {
                Console.WriteLine("text");
            }
            else
            {
                Console.WriteLine("error");
            }*/

            /*if (a > 0)
            {
                Console.WriteLine("text");
            }
            else if (b > 0)
            {
                Console.WriteLine("text");
            }
            else
            {
                Console.WriteLine("error");
            }*/

            /*if (a > 0 || b > 0)
            {
                Console.WriteLine("text");
            }
            else
            {
                Console.WriteLine("error");
            }*/

            // Генерация случайного числа
            int rand = Random.Shared.Next(1, 4);
        }
    }
}
