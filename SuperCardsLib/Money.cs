using System.Collections.Generic;

namespace SuperCardsLib
{
    // Class: Money - Saves the money amount
    public class Money
    {
        // Ivar: amount - number of moneys
        int amount;

        // Constructor: Money for a ZERO amount
        public Money()
        {
            this.amount = 0;
        }
        // Constructor: Money for a specific amount
        public Money(int amount)
        {
            this.amount = amount;
        }
    }
}
