using CardClassLibrary;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject
{
    public class TestSorting
    {

        List<Card> cards;

        [SetUp]
        public void Setup()
        {
            cards = new List<Card>();
            cards.Add(new Card(4, Suit.Clubs));
            cards.Add(new Card(5, Suit.Hearts));
            cards.Add(new Card(2, Suit.Spades));
            cards.Add(new Card(11, Suit.Clubs));
            cards.Add(new Card(13, Suit.Hearts));
            cards.Add(new Card(3, Suit.Spades));
            cards.Add(new Card(9, Suit.Diamonds));
        }

        [Test]
        public void TestPureValueSorting()
        {
            //Arrange
            //already done via Setup() method

            //Act
            cards.Sort();

            //Assert
            bool areSorted = AreOrderedByValue(cards);
            Assert.That(areSorted, "The cards weren't sorted by value");

        }

        [Test]
        public void TestHeartilySorting()
        {
            //Arrange
            //already done via Setup() method

            //Act
            //... insert your code here :)

            //Assert
            bool areSorted = AreOrderedByHeartilyValue(cards);
            Assert.That(areSorted, "The cards weren't sorted by value");

        }

        #region Helpermethods
        private static bool AreOrderedByValue(List<Card> cards)
        {
            int previousValue = -1;
            foreach (var card in cards)
            {
                if (card.Value < previousValue) { return false; }
                previousValue = card.Value;
            }
            return true;
        }

        private bool AreOrderedByHeartilyValue(List<Card> cards)
        {
            int previousValue = -1;
            foreach (var card in cards)
            {
                int currentCardsValue = card.Value;
                if (card.Suit == Suit.Hearts) { currentCardsValue += 13; }
                if (previousValue >= currentCardsValue) { return false; }
                previousValue = currentCardsValue;
            }
            return true;
        } 
        #endregion

    }
}