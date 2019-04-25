using System.Collections.Generic;

namespace SuperCardsLib
{
    // enum to hold the Card Suit of Card. Which can be one of the four suits
    public enum CardSuit { Spades, Clubs, Hearts, Diamonds};
    // enum to hold the face or value of the Card
    public enum CardFace { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King}
    
    // class to hold the card
    public class Card
    {
        // Constructor for a Card
        public Card(CardFace face, CardSuit suit)
        {
            Face = face;
            Suit = suit;
            Image = Face.ToString() + Suit + ".jpg";
        }
        // Property for Faces
        public CardFace Face {
            get;
            private set;
        }
        // Property for Images
        public string Image {
            get;
            private set;
        }
        // Property for Suit of a card
        public CardSuit Suit {
            get;
            private set;
        }
    }
}
