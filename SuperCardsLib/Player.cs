using System.Collections.Generic;

namespace SuperCardsLib
{
    public class Player
    {
        List<Card> hand;
        public Player(string username,int wins, int losses)
        {
            Username = username;
            hand = new List<Card>();
            Wins = wins;
            Losses = losses;
        }

        public int Losses { get; private set; }
        public string Username { get; private set; }
        public int Wins { get; private set; }
    }
}
