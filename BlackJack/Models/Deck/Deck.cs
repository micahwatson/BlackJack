using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Models.Deck
{
    public class Deck
    {        
        public List<Card> NewDeck()
        {
            List<Card> newDeck = new List<Card>();
            foreach (var suit in Enum.GetNames(typeof(Suits)))
            {
                var newCardSet = new SuitSet(suit);
                newDeck.AddRange(newCardSet.set);
            }
            return newDeck;
        }
    }
}
