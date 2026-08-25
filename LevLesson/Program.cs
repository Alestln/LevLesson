namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Player
            // Orc
            // Merchant
            // WoodenBox

            Player hero = new Player("Alex");
            Merchant npc = new Merchant("Bob");
            WoodenBox box = new WoodenBox("Old chest");

            npc.Interact();
            box.Interact();

            hero.Attack(box);
        }
    }
}
