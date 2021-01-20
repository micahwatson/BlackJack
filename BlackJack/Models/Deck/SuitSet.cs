using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Models.Deck
{
    public class SuitSet
    {
        public string suit { get; set; }
        public List<Card> set { get; set; }

        public SuitSet (string newSuit)
        {
            suit = newSuit;
            set = CreateCardArray(newSuit);
        }

        private List<Card> CreateCardArray(string suit)
        {
            List<Card> cardSet = new List<Card>
            {
                new Card
                {
                    Name = "Ace",
                    Suit = suit,
                    Value = 11,
                    AltValue = 1
                },
                new Card
                {
                    Name = "2",
                    Suit = suit,
                    Value = 2
                },
                new Card
                {
                    Name = "3",
                    Suit = suit,
                    Value = 3
                },
                new Card
                {
                    Name = "4",
                    Suit = suit,
                    Value = 4
                },
                new Card
                {
                    Name = "5",
                    Suit = suit,
                    Value = 5
                },
                new Card
                {
                    Name = "6",
                    Suit = suit,
                    Value = 6
                },
                new Card
                {
                    Name = "7",
                    Suit = suit,
                    Value = 7
                },
                new Card
                {
                    Name = "8",
                    Suit = suit,
                    Value = 8
                },
                new Card
                {
                    Name = "9",
                    Suit = suit,
                    Value = 9
                },
                new Card
                {
                    Name = "10",
                    Suit = suit,
                    Value = 10
                },
                new Card
                {
                    Name = "Jack",
                    Suit = suit,
                    Value = 10
                },
                new Card
                {
                    Name = "Queen",
                    Suit = suit,
                    Value = 10
                },
                new Card
                {
                    Name = "King",
                    Suit = suit,
                    Value = 10
                }
            };

            return cardSet;
        }
    }
}
