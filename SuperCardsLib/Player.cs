using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCardsLib
{
    public class Player
    {
        List<Card> hand;
        public Player(string username)
        {
            Username = username;
            hand = new List<Card>();
        }

        public string Username { get; private set; }
    }
}
