namespace SuperCardsLib
{
    // Class: PointPlayer - player that uses points (not money)
    public class PointPlayer : Player
    {
        // Constructor: PointPlayer - username, wins, losses, points
        public PointPlayer(string username,int wins, int losses, int points, PedroTeam team)
            : base(username, wins, losses)
        {
            Points = points;
            Team = team;
        }

        // Constructor: Points - the points of the player
        public int Points {
            get;
            private set;
        }
        public PedroTeam Team {
            get;
            private set;
        }
        public void MakeBid(int bid)
        {
            if (bid> Team.Bid)
            {
                Team.Bid = bid;
            }
        }
    }
}
