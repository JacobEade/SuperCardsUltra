using SuperCardsLib;
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
        private List<PointPlayer> _players;
        public const int POINTSTOWIN = 91;

        public int PointsOnTable {
            get;
            private set;
        }

        public PedroTable(List<Player> players) : base(players)
        {
            _cardsOnTable = new List<Card>();
            PointsOnTable = 0;
            team1 = new PedroTeam();
            team2 = new PedroTeam();
            _players = new List<PointPlayer>();
            for (int i = 0; i < 4; i++)
            {
                switch (i % 2)
                {
                    case 0:
                        _players.Add(new PointPlayer(players[i], 0, team1));
                        break;
                    case 1:
                        _players.Add(new PointPlayer(players[i], 0, team2));
                        break;
                }
            }
        }
        public void DealInitialHand()
        {
            foreach(PointPlayer player in _players)
            {
                player.Draw(GetDeck().Deal(9));
            }
        }
        public bool Win()
        {
            return team1.Points>=91 || team2.Points>=91;
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
