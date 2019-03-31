using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCardsLib
{
    public class Table
    {
        private List<Player> _players;
        private List<Card> _deck;
        private Random drawer;
        public Table(List<Player> players)
        {
            _players = players;
            CreateDeck();
            drawer = new Random();
        }
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
        internal Card Draw()
        {
            int cardIndex = drawer.Next(_deck.Count + 1);
            Card card =
                _deck[drawer.Next(cardIndex)];
            _deck.RemoveAt(cardIndex);
            return card;
        }
        
    }
}
