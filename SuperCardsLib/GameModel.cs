﻿using System;
using System.Collections.Generic;

namespace SuperCardsLib
{
    // Class: GameModel - Base class for all games
    public class GameModel
    {
        // Constructor: GameModel build a GameModel from a table
        public GameModel(Table table)
        {
            if (table == null)
            {
                throw new ArgumentNullException
                    ("table cannot be null");
            }
            Table = table;
        }

        // Constructor: Table - 
        public Table Table {
            get;
            private set;
        }
    }
}
