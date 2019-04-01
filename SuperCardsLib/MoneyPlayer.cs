namespace SuperCardsLib
{
    public class MoneyPlayer : Player
    {

        public MoneyPlayer(string username, int wins, int losses, MoneyChip money)
            : base(username, wins,losses)
        {
            Money = money;
        }

        public MoneyChip Money {
            get;
            private set;
        }
    }
}
