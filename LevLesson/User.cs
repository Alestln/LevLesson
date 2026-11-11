namespace LevLesson
{
    internal class User
    {
        public int Id { get; init; }

        public string Nickname { get; init; }

        public int CoinCount { get; init; }

        public int AccountLevel { get; init; }

        public User(int id, string nickname, int coinCount, int accountLevel)
        {
            Id = id;
            Nickname = nickname;
            CoinCount = coinCount;
            AccountLevel = accountLevel;
        }
    }
}
