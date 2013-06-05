using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace PokerTests
{
    [TestClass]
    public class PokerHasdandsCheckerTests
    {
        private Exception _resultException;

        [TestMethod]
        public void TestToStringAceSpades()
        {
            Hand hand = null;
            try
            {
                hand = new Hand(new List<ICard>
                {
                    new Card(CardFace.Two, CardSuit.Clubs),
                    new Card(CardFace.Three, CardSuit.Diamonds),
                    new Card(CardFace.Four, CardSuit.Hearts),
                    new Card(CardFace.Ace, CardSuit.Spades),
                    new Card(CardFace.King, CardSuit.Clubs),              
                });
            }
            catch (Exception ex)
            {
                _resultException = ex;
            }

            Assert.IsNotNull(hand);
            Assert.IsInstanceOfType(_resultException,typeof(ArgumentOutOfRangeException));
        }
    }
}
