using System.Collections.Generic;

namespace SuperCardsLib
{
    
    public enum CardSuit { Spades, Clubs, Hearts, Diamonds};
    public enum CardFace { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King}
    public class Card:Viewable
    {
        public Card(CardFace face, CardSuit suit)
        {
            Face = face;
            Suit = suit;
            Image = Face.ToString() + Suit + ".jpg";
        }
        public CardFace Face {
            get;
            private set;
        }
        public string Image {
            get;
            private set;
        }
        public CardSuit Suit {
            get;
            private set;
        }

        public List<string> GetImageNames()//do we really need this or just use the getter for image???
        {
            return new List<string> { Image };
        }
    }
}
