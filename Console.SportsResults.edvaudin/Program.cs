using HtmlAgilityPack;

namespace SportsResults;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var url = "https://www.basketball-reference.com/boxscores/";
        var web = new HtmlWeb();
        var doc = web.Load(url);
        var gameTables = doc.DocumentNode.SelectNodes("//div[@class='game_summary expanded nohover']");

        List<Game> games = GameFactory.CreateGamesFromHtmlNodeCollection(gameTables);
    }
}