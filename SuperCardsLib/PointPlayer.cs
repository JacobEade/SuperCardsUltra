using System.Collections.Generic;

namespace SuperCardsLib
{
    public class PointPlayer : Player
    {
        string username;
        int wins;
        int losses;
        int points;
        List<Card> hand; // Do I need this? - Harrison

        public PointPlayer(string username,int wins, int losses, int points)
        {
            this.username = username;
            this.wins = wins;
            this.losses = losses;
            this.points = points;
            hand = new List<Card>();
        }
    }
}
