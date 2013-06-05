using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace PokerTests
{
    [TestClass]
    public class PokerHandCheckerTests
    {
        [TestMethod]
        public void TestIsValidHand()
        {
            Hand hand = new Hand(new List<ICard>{
              new Card(CardFace.Two, CardSuit.Diamonds),
              new Card(CardFace.Three, CardSuit.Diamonds),
              new Card(CardFace.Four, CardSuit.Diamonds),
              new Card(CardFace.Ace, CardSuit.Diamonds),
              new Card(CardFace.King, CardSuit.Diamonds),

          });
       
            PokerHandsChecker checker = new PokerHandsChecker();
            var excpected = true;
            var actual = checker.IsValidHand(hand);
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void TestIsFlush()
        {
            Hand hand = new Hand(new List<ICard>{
              new Card(CardFace.Two, CardSuit.Diamonds),
              new Card(CardFace.Three, CardSuit.Diamonds),
              new Card(CardFace.Four, CardSuit.Diamonds),
              new Card(CardFace.Ace, CardSuit.Diamonds),
              new Card(CardFace.King, CardSuit.Diamonds),

          });

            PokerHandsChecker checker = new PokerHandsChecker();
            var excpected = true;
            var actual = checker.IsFlush(hand);
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void TestIsOnePair()
        {
            Hand hand = new Hand(new List<ICard>{
              new Card(CardFace.Two, CardSuit.Hearts),
              new Card(CardFace.Two, CardSuit.Diamonds),
              new Card(CardFace.Four, CardSuit.Diamonds),
              new Card(CardFace.Ace, CardSuit.Diamonds),
              new Card(CardFace.King, CardSuit.Diamonds),

          });

            PokerHandsChecker checker = new PokerHandsChecker();
            var excpected = true;
            var actual = checker.IsOnePair(hand);
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void TestIsThreeOfAKind()
        {
            Hand hand = new Hand(new List<ICard>{
              new Card(CardFace.Two, CardSuit.Hearts),
              new Card(CardFace.Two, CardSuit.Diamonds),
              new Card(CardFace.Two, CardSuit.Clubs),
              new Card(CardFace.Two, CardSuit.Spades),
              new Card(CardFace.King, CardSuit.Diamonds),

          });

            PokerHandsChecker checker = new PokerHandsChecker();
            var excpected = true;
            var actual = checker.IsFourOfAKind(hand);
            Assert.AreEqual(excpected, actual);
        }
    }
}
