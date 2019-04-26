using System;

namespace SuperCardsLib
{
    // Class: PointPlayer - player that uses points (not money)
    public class PointPlayer : Player
    {
        // Constructor: PointPlayer - username, wins, losses, points
        public PointPlayer(string username, int points, PedroTeam team)
            : base(username)
        {
            Points = points;
            Team = team;
        }
        public PointPlayer(Player player, int points, PedroTeam team) : base(player.Username)
        {
            Points = points;
            Team = team;
        }

        // Constructor: Points - the points of the player
        public int Points {
            get;
            private set;
        }
        public int Bid
        {
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
            Bid = bid;
        }

        public void DiscardOffSuit(CardSuit suit)
        {
            foreach(Card card in Hand)
            {
                if (card.Face == CardFace.Five)
                {
                    if (suit == CardSuit.Spades || suit == CardSuit.Clubs && card.Suit != CardSuit.Spades || card.Suit != CardSuit.Clubs)
                    {
                        Hand.Remove(card);
                    }
                    else if (suit == CardSuit.Hearts || suit == CardSuit.Diamonds && card.Suit != CardSuit.Diamonds || card.Suit != CardSuit.Hearts)
                    {
                        Hand.Remove(card);
                    }
                }
                else if(card.Suit != suit)
                {
                    Hand.Remove(card);
                }
            }
        }
    }
}
