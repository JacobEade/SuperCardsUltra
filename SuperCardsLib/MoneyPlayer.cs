using System.Collections.Generic;

namespace SuperCardsLib
{
    public class MoneyPlayer : Player
    {
        string username;
        int wins;
        int losses;
        Money money;
        List<Card> hand; // Do I need this? - Harrison

        public MoneyPlayer(string username,int wins, int losses, Money money)
        {
            this.username = username;
            this.wins = wins;
            this.losses = losses;
            this.money = money;
            hand = new List<Card>();
        }
    }
}
