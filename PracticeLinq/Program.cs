using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Order the list of games by length of the game name
            var videoGames = new List<string> { "Dark Souls", "Sifu", "The Witcher 3", "Fifa 21" };
            videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
        
    }
}
