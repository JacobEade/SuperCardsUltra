using System;
using System.Collections.Generic;

namespace SuperCardsLib
{
    /// <summary>Class <c>Table</c> 
    ///     models a table for the game being played</summary>
    ///
    public class Table : Viewable
    {
        /// <summary>Instance variable <c>_players</c> 
        ///     represents the point's x-coordinate.</summary>
        private List<Player> _players;

        /// <summary>Instance variable <c>_deck</c> 
        ///     represents the cards actively in the deck</summary>
        private List<Card> _deck;

        /// <summary>Instance variable <c>drawer</c> 
        ///     represents ... </summary>
        private Random drawer;

        /// <summary>This constructor initializes 
        ///     the new Table to the list of players passed in
        /// <param name="players">The list of players at the table</param>
        public Table(List<Player> players)
        {
            _players = players;
            CreateDeck();
            drawer = new Random();
        }

        /// <summary>method <c>CreateDeck</c> Builds the deck</summary>
        private void CreateDeck()
        {
            _deck = new List<Card>();
            CardSuit suit;
            for (int i = 0; i < 4; i++)
            {
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
                    default:
                        suit = CardSuit.Spades;
                        break;
                }
                for (int k = 1; k <= 13; k++)
                {
                    _deck.Add(new Card(k, suit));
                }
            }
        }
        /// <summary>method <c>Draw</c> deals a card</summary>
        protected Card Draw()
        {
            int cardIndex = drawer.Next(_deck.Count + 1);
            Card card =
                _deck[drawer.Next(cardIndex)];
            _deck.RemoveAt(cardIndex);
            return card;
        }

        /// <summary>method <c>GetImageNames</c> gets the image names
        ///     from the deck</summary>
        public List<string> GetImageNames()
        {
            List<string> images = new List<string>();
            foreach (Card card in _deck)
            {
                images.AddRange(card.GetImageNames());
            }
            return images;
        }
    }
}
