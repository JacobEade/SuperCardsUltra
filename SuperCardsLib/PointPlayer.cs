namespace SuperCardsLib
{
    // Class: PointPlayer - player that uses points (not money)
    public class PointPlayer : Player
    {
        // Constructor: PointPlayer - username, wins, losses, points
        public PointPlayer(string username,int wins, int losses, int points)
            : base(username, wins, losses)
        {
            Points = points;
        }

        // Constructor: Points - the points of the player
        public int Points {
            get;
            private set;
        }
    }
}
