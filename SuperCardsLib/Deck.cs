using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCardsLib
{
    public class Deck : Viewable
    {
        private List<Card> _deck;
        /// <summary>Instance variable <c>drawer</c> 
        ///     represents ... </summary>
        private Random dealer;
        /// <summary>method <c>CreateDeck</c> Builds the deck</summary>
        public Deck()//needs updated to use the enum for face and moved to new class
        {
            _deck = new List<Card>();
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
        }

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

        /// <summary>method <c>Draw</c> deals a card</summary>
        protected Card Deal()
        {
            int cardIndex = dealer.Next(_deck.Count + 1);
            Card card =
                _deck[cardIndex];
            _deck.RemoveAt(cardIndex);
            return card;
        }
        public List<string> GetImageNames()
        {
            throw new NotImplementedException();
        }
    }
}
