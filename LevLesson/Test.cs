namespace LevLesson
{
    internal class Test
    {
        static internal int StaticValue = InitStaticField();

        internal int instanceField = 67;

        internal int Property { get; private init; }

        private int CalculateValue()
        {
            return Random.Shared.Next();
        }

        static Test()
        {
            Console.WriteLine("Вызов статического конструктора.");

            // instanceField = 43; // Ошибка компиляции: нельзя обращаться к нестатическим полям в статическом конструкторе
        }

        internal Test()
        {
            Console.WriteLine("Вызов обычного конструктора.");
            instanceField = InitInstanceField();
            Property = CalculateValue();
        }

        private int InitInstanceField()
        {
            Console.WriteLine("Инициализация обычного поля класса");
            return 42;
        }

        internal static int InitStaticField()
        {
            // instanceField = 43; // Ошибка компиляции: нельзя обращаться к нестатическим полям в статическом методе
            Console.WriteLine("Инициализация статического поля класса");
            return 100;
        }
    }
}
