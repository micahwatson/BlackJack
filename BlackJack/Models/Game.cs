using BlackJack.Models.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Models
{
    public class Game
    {
        public Player Dealer { get; set; } = new Player { Name = "Dealer", Hand = new List<Card>() };
        public Player Player1 { get; set; } = new Player { Name = "Player1", Hand = new List<Card>() };
        public List<Card> GameDeck { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();

        public Game()
        {           
            GameDeck = new Shuffle().ShuffleDeck(new Deck.Deck().NewDeck());
            Players.Add(Dealer);
            Players.Add(Player1);
        }

    }
}
