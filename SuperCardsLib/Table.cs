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
        public Table(List<Player> players)
        {
            _players = players;
        }
        private void CreatDeck()
        {
            _deck = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                
            }
        }
        
    }
}
