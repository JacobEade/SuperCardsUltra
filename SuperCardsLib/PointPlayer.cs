namespace SuperCardsLib
{
    public class PointPlayer : Player
    {
        public PointPlayer(string username,int wins, int losses, int points)
            : base(username, wins, losses)
        {
            Points = points;
        }

        public int Points {
            get;
            private set;
        }
    }
}
