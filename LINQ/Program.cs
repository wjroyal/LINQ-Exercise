namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() { "Red Dead Redemption 2, Grand Theft Auto V, Crash Bandicoot" };

            videoGames.Add("SOCOM US Navy Seals");

            videoGames.Add("Madden NFL");

            var orderedGames = videoGames.OrderBy(name => name.Length);

            foreach(var game in orderedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
