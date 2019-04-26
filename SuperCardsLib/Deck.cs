using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCardsLib
{
    // Class: Deck - controls the deck of cards
    public class Deck
    {   
        // Constant: NUMBER_OF_SHUFFLES - represents the number of shuffles
        public const int NUMBER_OF_SHUFFLES = 3;

        // Private Member Variable: _deck - Object for the deck of cards
        private List<Card> _deck;
        /// <summary>Instance variable <c>drawer</c> 
        ///     represents ... </summary>
        private Random dealer;
        /// <summary>method <c>CreateDeck</c> Builds the deck</summary>
        public Deck()//needs updated to use the enum for face and moved to new class
        {
            _deck = new List<Card>();
            dealer = new Random();
            CardSuit suit;
            CardFace face;
            for (int i = 0; i < 4; i++)
            {
                suit = SelectSuit(i);
                for (int k = 0; k < 13; k++)
                {
                    face = SelectFace(k);
                    _deck.Add(new Card(face, suit));
                }
            }
            Shuffle();
        }

        // Function: Shuffle - shuffles the deck of cards object
        private void Shuffle()
        {
            Card tmp;
            int swapIndex;
            for (int i = 0; i<NUMBER_OF_SHUFFLES; i++)
            {
                for (int k = 0; k < _deck.Count; k++)
                {
                    tmp = _deck[k];
                    swapIndex = dealer.Next(_deck.Count - 1);
                    _deck[k] = _deck[swapIndex];
                    _deck[swapIndex] = tmp;
                }
            }
        }

        // Function: SelectSuit - gets suit from an index value
        private static CardSuit SelectSuit(int i)
        {
            CardSuit suit;
            switch (i)
            {
                case 0:
                    suit = CardSuit.Clubs;
                    break;
                case 1:
                    suit = CardSuit.Diamonds;
                    break;
                case 2:
                    suit = CardSuit.Hearts;
                    break;
                case 3:
                    suit = CardSuit.Spades;
                    break;
                default:
                    throw new ArgumentOutOfRangeException
                        ("there are only 4 suits");
            }

            return suit;
        }

        // Function: SelectFace - get face from index
        private static CardFace SelectFace(int k)
        {
            CardFace face;
            switch (k)
            {
                case 0:
                    face = CardFace.Ace;
                    break;
                case 1:
                    face = CardFace.Two;
                    break;
                case 2:
                    face = CardFace.Three;
                    break;
                case 3:
                    face = CardFace.Four;
                    break;
                case 4:
                    face = CardFace.Five;
                    break;
                case 5:
                    face = CardFace.Six;
                    break;
                case 6:
                    face = CardFace.Seven;
                    break;
                case 7:
                    face = CardFace.Eight;
                    break;
                case 8:
                    face = CardFace.Nine;
                    break;
                case 9:
                    face = CardFace.Ten;
                    break;
                case 10:
                    face = CardFace.Jack;
                    break;
                case 11:
                    face = CardFace.Queen;
                    break;
                case 12:
                    face = CardFace.King;
                    break;
                default:
                    throw new ArgumentOutOfRangeException
                        ("there are only 13 faces");
            }

            return face;
        }

        /// Function: Deal - deals a card
        public Card Deal()
        {
            if (_deck == null)
            {
                throw new ArgumentNullException
                    ("deck was never created");
            }
            else if (_deck.Count == 0)
            {
                throw new ArgumentOutOfRangeException
                    ("deck has no more cards");
            }
            Card card = _deck[0];
            _deck.RemoveAt(0);
            return card;
        }
        // Function: Deal - deals a number of cards
        public List<Card> Deal(int numberOfCards)
        {
            if (numberOfCards < 0)
            {
                return new List<Card>();
            }
            List<Card> cards = new List<Card>();
            for (int i = 0; i < numberOfCards; i++)
            {
                // reuse the deal function
                cards.Add(Deal());
            }
            return cards;
        }
    }
}
