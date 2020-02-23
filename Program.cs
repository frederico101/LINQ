using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var card = new Cards();
            var startingDeck = from s in card.Suits()
                               from r in card.Ranks()
                               select new { Suit = s, Rank = r };

            // Display each card that we've generated and placed in startingDeck in the console
            foreach (var cards in startingDeck)
            {
                Console.WriteLine(cards);
            }
        }


    }
}
