namespace LevLesson.Test
{
    internal class Player
    {
        private string _name;
        private Movement _movement;

        public Player(string name)
        {
            _movement = new Movement();
            _name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Player otherPlayer)
            {
                return _name == otherPlayer._name;
            }

            return false;
        }

        public override string ToString()
        {
            return $"Player Name: {_name}";
        }

        /*public override int GetHashCode()
        {
            return _name.GetHashCode();
        }*/

        private class Movement
        {
            public void Move()
            {
                Console.WriteLine("Player is moving.");
            }
        }
    }
}
