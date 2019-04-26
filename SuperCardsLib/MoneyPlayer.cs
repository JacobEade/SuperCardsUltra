namespace SuperCardsLib
{
    // Class: MoneyPlayer - 
    public class MoneyPlayer : Player
    {

        // Construor : MoneyPlayer - for a username, wins, losses, and money
        public MoneyPlayer(string username, int wins, int losses, MoneyChip money)
            : base(username, wins,losses)
        {
            Money = money;
        }

        // Property: Money - 
        public MoneyChip Money {
            get;
            private set;
        }
    }
}
