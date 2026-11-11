namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User(1, "Alice", 100, 5),
                new User(2, "Bob", 200, 10),
                new User(3, "Charlie", 150, 7),
                new User(4, "David", 300, 15),
                new User(5, "Eve", 250, 12)
            };

            List<User> filteredByAccountLevel = FilterByAccountLevel(users, 10);
            List<User> filteredByCoinCount = FilterByCoinCount(users, 200);
            List<User> filteredByNickname = FilterByNickname(users, "a");

            List<User> filteredUsers = Filter(users, u => u.AccountLevel > 10);
            List<User> filteredUsersByCoinCount = Filter(users, u => u.CoinCount > 200);
            List<User> filteredUsersByNickname = Filter(users, u => u.Nickname.ToLower().Contains("a".ToLower()));

            var player = new Player();

            // скрипт для UI
            player.OnHealthChanged += ui.UpdateHealth;

            // скрипт для логики
            player.OnHealthChanged = null;
            player.OnHealthChanged.Invoke(50);
        }

        static List<User> Filter(List<User> users, Func<User, bool> predicate)
        {
            List<User> filteredUsers = new List<User>();

            foreach (var user in users)
            {
                if (predicate(user))
                {
                    filteredUsers.Add(user);
                }
            }

            return filteredUsers;
        }

        static List<User> FilterByAccountLevel(List<User> users, int accountLevel)
        {
            List<User> filteredUsers = new List<User>();

            foreach (var user in users)
            {
                if (user.AccountLevel > accountLevel)
                {
                    filteredUsers.Add(user);
                }
            }

            return filteredUsers;
        }

        static List<User> FilterByCoinCount(List<User> users, int coinCount)
        {
            List<User> filteredUsers = new List<User>();

            foreach (var user in users)
            {
                if (user.CoinCount > coinCount)
                {
                    filteredUsers.Add(user);
                }
            }

            return filteredUsers;
        }

        static List<User> FilterByNickname(List<User> users, string searchString)
        {
            List<User> filteredUsers = new List<User>();

            foreach (var user in users)
            {
                if (user.Nickname.ToLower().Contains(searchString.ToLower()))
                {
                    filteredUsers.Add(user);
                }
            }

            return filteredUsers;
        }
    }
}
