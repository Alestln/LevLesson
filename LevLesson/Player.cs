namespace LevLesson
{
    internal class Player : IEquatable<Player>
    {
        public int Id { get; private set; }
        public string Nickname { get; private set; }

        public Player(int id, string nickname)
        {
            Id = id;
            Nickname = nickname;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Player);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public bool Equals(Player? other)
        {
            if (other is null)
            {
                return false;
            }

            return Id == other.Id;
        }
    }
}
