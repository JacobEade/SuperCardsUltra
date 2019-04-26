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
        private int GetBid()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public void PlayRound()
        {
            DealInitialHand();
            int highestBidderIndex = PlaceBids();
            CardSuit roundSuit = ChooseSuit(highestBidderIndex);//temperary until ui
            DiscardAllOffSuits(roundSuit);
            RefillHands();
            PlayHand(highestBidderIndex);
            team1.AddPoints();
            team2.AddPoints();
            PedroTeam winningTeam = new PedroTeam();
            if (Win())
            {
                winningTeam = GetWinningTeam();
            }
            string teamMembers = "";
            foreach(PointPlayer player in _players)
            {
                if (player.Team == winningTeam)
                {
                    teamMembers = player.Username + " ";
                }
            }
            Console.WriteLine(teamMembers + "has won the game");//teporary until ui is done
        }

        private void PlayHand(int starterIndex)
        {

        }

        private void RefillHands()
        {
            foreach(PointPlayer player in _players)
            {
                int cardsNeeded = 6 - player.Hand.Count;
                player.Draw(GetDeck().Deal(cardsNeeded));
            }
        }

        private void DiscardAllOffSuits(CardSuit suit)
        {
            foreach (PointPlayer player in _players)
            {
                player.DiscardOffSuit(suit);
            }
        }

        private CardSuit ChooseSuit(int highestBidderIndex)
        {
            return CardSuit.Spades;//temporary until ui is done to select suit
        }

        private int PlaceBids()
        {
            int highestBidderIndex = -1;//-1 when no one has bid yet
            int highestBid = 5;// the smallest bid is 6, 5 is set here to make sure noone can bid under it
            for (int i = 0; i < 4; i++)
            {
                _players[i].PlaceBid(GetBid());//tempoary function call until ui is done
                if (_players[i].Bid > highestBid)
                {
                    highestBidderIndex = i;
                    highestBid = _players[i].Bid;
                }
            }
            if (highestBidderIndex == -1)//forces dealer to bid 6 if no one else bid 6 or above
            {
                _players[0].PlaceBid(6);
                highestBidderIndex = 0;
            }
            return highestBidderIndex;
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
