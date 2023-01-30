﻿using HtmlAgilityPack;

namespace SportsResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var url = "https://www.basketball-reference.com/boxscores/";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var gameTables = doc.DocumentNode.SelectNodes("//div[@class='game_summary expanded nohover']");
            List<Game> games = new List<Game>();
            foreach ( var gameTable in gameTables )
            {
                var game = new Game()
                {
                    WinningTeam = gameTable.SelectSingleNode(".//tr[@class='winner']").SelectSingleNode(".//a").InnerText,
                    WinningScore = int.Parse(gameTable.SelectSingleNode(".//tr[@class='winner']").SelectSingleNode(".//td[@class='right']").InnerText),
                    LosingTeam = gameTable.SelectSingleNode(".//tr[@class='loser']").SelectSingleNode(".//a").InnerText,
                    LosingScore = int.Parse(gameTable.SelectSingleNode(".//tr[@class='loser']").SelectSingleNode(".//td[@class='right']").InnerText),
                };
                games.Add(game);
                Console.WriteLine($"Game {gameTables.IndexOf(gameTable)}: {game.WinningTeam} [{game.WinningScore}] - {game.LosingTeam} [{game.LosingScore}]");
            }
        }
    }
}