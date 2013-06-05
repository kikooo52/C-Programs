using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            bool valid = true;
            if (hand.Cards.Count != 5)
            {
                valid = false;
            }

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face && hand.Cards[i].Suit == hand.Cards[j].Suit)
                    {
                        valid = false;
                    }   
                }
            }
            return valid;
        }

        public bool IsFlush(IHand hand)
        {
            bool isFlush = false;
            if (IsValidHand(hand) && IsSameSuit(hand))
            {
                isFlush = true;
            }
            return isFlush;
        }

        private bool IsSameSuit(IHand hand)
        {
            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[0].Suit != hand.Cards[i].Suit)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsOnePair(IHand hand)
        {
            bool IsOnePair = false;
            if (IsValidHand(hand) && OnePear(hand))
            {
                IsOnePair = true;
            }
            return IsOnePair;
        }

        private bool OnePear(IHand hand)
        {
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            bool IsOnePair = false;
            if (IsValidHand(hand) && FourOfAKind(hand))
            {
                IsOnePair = true;
            }
            return IsOnePair;
        }

        private static bool FourOfAKind(IHand hand)
        {
            int count = 1;
            int fourOfAKind = 4;

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        count++;
                        if (count == fourOfAKind)
                        {
                            return true;
                        }
                    }
                }
                count = 1;
            }
            return false;
        }


        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }   

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
