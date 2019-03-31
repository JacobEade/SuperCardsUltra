using System.Collections.Generic;

namespace SuperCardsLib
{
    public enum CardSuit { Spades, Clubs, Hearts, Diamonds};
    public class Card:Viewable
    {
        public Card(int value, CardSuit suit)
        {
            Value = value;
            Suit = suit;
            Image = Value + Suit + ".jpg";
        }
        public int Value { get; private set; }
        public string Image { get; private set; }
        public CardSuit Suit { get; private set; }

        public List<string> GetImageNames()
        {
            return new List<string> { Image };
        }
    }
}
