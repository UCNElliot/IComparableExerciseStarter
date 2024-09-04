using System;

namespace CardClassLibrary
{
    public enum Suit {Empty, Hearts, Spades, Clubs, Diamonds }
    public class Card
    {
        public Suit Suit { get; set; }
        public int Value { get; set; }

        public Card(int value, Suit suit)
        {
            Value = value;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
