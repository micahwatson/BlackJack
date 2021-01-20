using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Models.Deck
{
    public class Shuffle
    {

        public List<Card> ShuffleDeck(List<Card> deck)
        {
            var random = new Random();
            deck = deck.OrderBy(card => random.Next()).ToList();

            return deck;
        }
    }
}
