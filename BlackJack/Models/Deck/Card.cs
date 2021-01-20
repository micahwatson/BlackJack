using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Models.Deck
{
    public class Card
    {
        public string Name { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }
        public int AltValue { get; set; }
        public bool FaceDown { get; set; }
    }
}
