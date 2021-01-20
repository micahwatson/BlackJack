﻿using BlackJack.Models.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Models
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
        public int RoundCardTotal { get; set; }
        public int Score { get; set; }
    }
}
