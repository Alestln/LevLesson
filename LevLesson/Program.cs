namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] matrix = CreateArray(5);

            Initialize(matrix, 42);*/
            
            // Нужно создать несколько реализаций генерации случайного числа
            int number = GenerateNumber();
            
            Console.WriteLine(number);
        }

        static int GenerateNumber()
        {
            int number = DateTime.Now.Millisecond * 2 - DateTime.Now.Second;
            
            return number;
        }
        
        static int[] CreateArray(int size)
        {
            int[] array = new int[size];
            
            return array;
        }
        
        /// <summary>
        /// Метод инициализации массива случайными числами
        /// </summary>
        /// <param name="matrix">Массив для инициализации</param>
        static void Initialize(int[] matrix)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Random.Shared.Next();
            }
        }

        /// <summary>
        /// Метод инициализации массива числом
        /// </summary>
        /// <param name="matrix">Массив для инициализации</param>
        /// <param name="number">Число, которым инициализируются элементы массива</param>
        static void Initialize(int[] matrix, int number)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                matrix[i] = number;
            }
        }
        
        // В статическом методе НЕЛЬЗЯ вызвать не статически метод
        static int /*возвращаемый тип метода*/ Method /*имя метода*/() /*входящие параметры метода*/
        {
            /*тело метода*/
            return 42;
        }
        
        /*
         * Сигнатура - это уникальный идентификатор метода, состоящий из его имени и списка типов параметров (включая их порядок).
         */
        
        /*
         * Метод вывода текста на консоль
         * число с переносом (\n) - Writeline(int number)
         * число без переноса (\n) - Write(int number)
         * строку - Write(string text)
         * символ - Write(char symbol)
         * объект - Write(object obj)
         * дробное число - Write(double number)
         * булевое значение - Write(bool value)
         */
        
        /*
         * Полиморфизм - принцип ООП
         */
    }
}
