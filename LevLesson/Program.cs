using System.Text.RegularExpressions;

namespace LevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string badText = "Привет     мир!   Как   дела?   ";

            string goodText = Regex.Replace(badText, @"\s{2,}", " ");
        }
    }
}
