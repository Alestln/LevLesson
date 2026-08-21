namespace LevLesson
{
    public interface IMovable
    {
        public int Speed { get; set; }

        public void Move();

        public void Stop();
    }
}
