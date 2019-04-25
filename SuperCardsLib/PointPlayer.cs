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
        public PointPlayer(Player player, int points, PedroTeam team) : base(player.Username,player.Wins,player.Losses)
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
        public void PlaceBid(int bid)
        {
            if (bid> Team.Bid)
            {
                Team.Bid = bid;
            }
        }
    }
}
