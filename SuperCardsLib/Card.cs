using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCardsLib
{
    public class Card:Viewable
    {
        public Card(int value, string image)
        {
            Value = value;
            Image = image;
        }

        public int Value { get; private set; }
        public string Image { get; private set; }

        public List<string> GetImageName()
        {
            return new List<string> { Image };
        }
    }
}
