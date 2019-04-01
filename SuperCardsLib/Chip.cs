using System.Collections.Generic;

namespace SuperCardsLib
{
    public class Chip : Viewable
    {
        public Chip(string image)
        {
            Image = image;
        }

        public string Image {
            get;
            private set;
        }

        public List<string> GetImageNames()
        {
            return new List<string> {Image };
        }
    }
}
