using System;
using System.Collections.Generic;

namespace SuperCardsLib
{
    public class GameModel : Viewable
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
        public Table Table {
            get;
            private set;
        }
        public List<string> GetImageNames()// change to a method instead of an interface
        {
            return Table.GetImageNames();
        }
    }
}
