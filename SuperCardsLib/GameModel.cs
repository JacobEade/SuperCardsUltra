using System;
using System.Collections.Generic;

namespace SuperCardsLib
{
    class GameModel : Viewable
    {
        public GameModel(Table table)
        {
            if (table == null)
            {
                throw new ArgumentNullException
                    ("table cannot be null");
            }
            Table = table;
        }
        public Table Table { get; private set; }
        public List<string> GetImageNames()
        {
            return Table.GetImageNames();
        }
    }
}
