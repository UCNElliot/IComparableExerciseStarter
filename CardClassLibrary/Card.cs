using System;

namespace CardClassLibrary
{
    public enum Suit {Empty, Hearts, Spades, Clubs, Diamonds }
    public class Card : IComparable<Card>
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

        public int CompareTo(Card other)
        {
            if (other == null || this.Value == other.Value)
            {
                return 0;
            }
            else if (this.Value > other.Value)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
