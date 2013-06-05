using System;
using System.Collections.Generic;

namespace Poker
{
    class PokerExample
    {
        static void Main()
        {
            ICard card = new Card(CardFace.Ace, CardSuit.Clubs);
            Console.WriteLine(card);

            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Spades),
            });
            Console.WriteLine(hand);

            IPokerHandsChecker checker = new PokerHandsChecker();
            Console.WriteLine(checker.IsValidHand(hand));
            Console.WriteLine(checker.IsFlush(hand));
            Console.WriteLine(checker.IsOnePair(hand));
            Console.WriteLine(checker.IsFourOfAKind(hand));
        }
    }
}
