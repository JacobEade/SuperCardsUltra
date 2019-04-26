using System;
using System.Collections.Generic;

namespace SuperCardsLib
{
    /// <summary>Class <c>Table</c> 
    ///     models a table for the game being played</summary>
    ///
    public class Table
    {
        /// <summary>Instance variable <c>_players</c> 
        ///     represents the point's x-coordinate.</summary>
        private List<Player> _players;

        /// <summary>Instance variable <c>_deck</c> 
        ///     represents the cards actively in the deck</summary>
        private Deck _deck;
        /// <summary>This constructor initializes 
        ///     the new Table to the list of players passed in
        /// <param name="players">The list of players at the table</param>
        public Table(List<Player> players)
        {
            _players = players;
            _deck = new Deck();
        }
        public Deck GetDeck()
        {
            return _deck;
        }
    }
}
