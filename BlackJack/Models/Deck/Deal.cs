using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Models.Deck
{
    public class Deal
    {
        public void NewDeal(Game game)
        {
            foreach(var player in game.Players)
            {
                player.Hand.Add(game.GameDeck[0]);
                game.GameDeck.RemoveAt(0);                
                player.Hand.Add(game.GameDeck[0]);
                game.GameDeck.RemoveAt(0);

                player.RoundCardTotal = player.Hand.Sum(card => card.Value);
                player.Hand[0].FaceDown = true;
            }
        }
    }
}
