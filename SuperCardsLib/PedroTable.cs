using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCardsLib
{
    public class PedroTable : Table
    {
        private List<Card> _cardsOnTable;
        private PedroTeam team1;
        private PedroTeam team2;
        public const int POINTSTOWIN = 91;

        public int PointsOnTable {
            get;
            private set;
        }

        public PedroTable(List<Player> players) : base(players)
        {
            _cardsOnTable = new List<Card>();
            PointsOnTable = 0;
        }
        public bool Win()
        {
            return team1.Points >= 91 || team2.Points >= 91;
        }
        public PedroTeam GetWinningTeam()
        {
            if(team1.Points >=91 && team2.Points >= 91)
            {
                if (team1.HasBid)
                {
                    return team1;
                }
                return team2;
            }
            else if (team1.Points >= 91)
            {
                return team1;
            }
            return team2;
        }
    }
}
