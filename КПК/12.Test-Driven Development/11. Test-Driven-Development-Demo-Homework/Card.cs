using System;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string faceString = GetCardFaceAsSting();

            char suitChar = GetCardSuitAsString();

            string cardSting = faceString + suitChar;

            return cardSting;
        }

        private string GetCardFaceAsSting()
        {
            string faceSting;
            if ((int)this.Face <= 10)
            {
                faceSting = ((int)this.Face).ToString();
            }
            else
            {
                char faceLetter = Face.ToString()[0];
                faceSting = faceLetter.ToString();
            }
            return faceSting;
        }

        private char GetCardSuitAsString()
        {
            char suitChar;
            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    suitChar = '♣'; break;
                case CardSuit.Diamonds:
                    suitChar = '♦'; break;
                case CardSuit.Hearts:
                    suitChar = '♥'; break;
                case CardSuit.Spades:
                    suitChar = '♠'; break;

                default:
                    throw new InvalidOperationException("Invalid suit " + this.Suit);
            }
            return suitChar;
        }
    }
}
