using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {

        static void Main(string[] args)
        {
            var startingDeck = from s in Card.Suits()
                               from r in Card.Ranks()
                               select new { Suit = s, Rank = r };

            // Display each card that we've generated and placed in startingDeck in the console
            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }
        }


    }
}
