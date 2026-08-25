namespace LevLesson
{
    public abstract class GameObject
    {
        public string Name { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public GameObject(string name)
        {
            Name = name;
        }
    }
}
