using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTests
{
    [TestClass]
    public class TestsCard
    {
        [TestMethod]
        public void TestToStringAceSpades()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Spades);
            string expected = "A♠";
            string result = card.ToString();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestToStringTenHearts()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Hearts);
            string expected = "10♥";
            string result = card.ToString();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestToStringTwoClubs()
        {
            Card card = new Card(CardFace.Two, CardSuit.Clubs);
            string expected = "2♣";
            string result = card.ToString();
            Assert.AreEqual(expected, result);
        }

        public void TestToStringKingDiamonds()
        {
            Card card = new Card(CardFace.King, CardSuit.Diamonds);
            string expected = "K♣";
            string result = card.ToString();
            Assert.AreEqual(expected, result);
        }
    }
}
