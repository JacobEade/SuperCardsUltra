using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCardsLib
{
    public class PedroTeam
    {
        private List<Card> CardsWon;

        public PedroTeam()
        {
            Points = 0;
            CardsWon = new List<Card>();
            HasBid = false;
            Bid = 0;
            PointsCollectedThisHand = 0;
        }

        public bool HasBid {
            get;
            set;
        }
        public int Bid
        {
            get;
            set;
        }
        public int Points {
            get;
            private set;
        }
        public int PointsCollectedThisHand {
            get;
            private set;
        }

        public void TakePot(List<Card> cardsOntable, int pointsOnTable)
        {
            CardsWon.AddRange(cardsOntable);
            PointsCollectedThisHand += pointsOnTable;
        }
        public void AddPoints()
        {
            if(HasBid && Bid> PointsCollectedThisHand)
            {
                Points -= Bid;
            }
            else
            {
                Points += PointsCollectedThisHand;
            }
            CardsWon = new List<Card>();
            PointsCollectedThisHand = 0;
        }
        
    }
}
