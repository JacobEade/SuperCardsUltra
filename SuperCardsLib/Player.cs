using System.Collections.Generic;
using System;

namespace SuperCardsLib
{
    public class Player
    {
        private List<Card> hand;
        public Player(string username,int wins, int losses)
        {
            Username = username;
            hand = new List<Card>();
            Wins = wins;
            Losses = losses;
        }
        /// <summary>
        /// Plays a card from the players hand to the table
        /// return null if players hand is empty
        /// throws an error if the index is out of range or hand is null
        /// </summary>
        /// <param name="cardIndex"></param>
        /// <returns>card and index CardIndex</returns>
        public Card PlayCard(int cardIndex)
        {
            if(hand == null)
            {
                throw new NullReferenceException("Hand was never made");
            }
            else if (hand.Count == 0)
            {
                return null;
            }
            else if(cardIndex < 0 || cardIndex <= hand.Count)
            {
                throw new ArgumentOutOfRangeException("invalid hand index");
            }
            else
            {
                Card card = hand[cardIndex];
                hand.RemoveAt(cardIndex);
                return card;
            }
        }
        public int Losses {
            get;
            private set;
        }


        public string Username {
            get;
            private set;
        }


        public int Wins {
            get;
            private set;
        }
    }
}
