using System.Collections.Generic;

namespace SuperCardsLib
{
    abstract public class Chip : Viewable
    {
        public Chip(string image)
        {
            Image = image;
        }

        public string Image {
            get;
            private set;
        }

        public List<string> GetImageNames()//do we really need this or just use the getter for image???
        {
            return new List<string> {Image };
        }
    }
}
