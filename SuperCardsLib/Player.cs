﻿using System.Collections.Generic;
using System;

namespace SuperCardsLib
{
    // Class: Player - the player doing the card games
    public class Player
    {
        private List<Card> hand;
        public Player(string username)
        {
            Username = username;
            hand = new List<Card>();
            //Wins = wins;not implemented
            //Losses = losses;not implemented
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
        public void Draw(Card card)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("hand was never made to draw to");
            }
            hand.Add(card);
        }
        public void Draw(List<Card> cards)
        {
            foreach(Card card in cards)
            {
                Draw(card);
            }
        }
        // Property: Username - the player name
        public string Username
        {
            get;
            private set;
        }

        public List<Card> Hand
        {
            get
            {
                return hand;
            }

            set
            {
                hand = value;
            }
        }



        //// Property: Losses - the player Losses
        //public int Losses {
        //    get;
        //    private set;
        //}
        // Property: Wins - the player Wins
        //public int Wins {
        //    get;
        //    private set;not implemented
        //}
    }
}
