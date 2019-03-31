using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCardsLib
{
    enum CardSuit { Spades, Clubs, Hearts, Diamonds};
    public class Card:Viewable
    {
        public Card(int value, string image, CardSuit suit)
        {
            Value = value;
            Image = image;
        }

        public int Value { get; private set; }
        public string Image { get; private set; }

        public List<string> GetImageNames()
        {
            return new List<string> { Image };
        }
    }
}
