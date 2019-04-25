using System.Collections.Generic;

namespace SuperCardsLib
{
    // Class for a Chip which shows money
    abstract public class Chip
    {
        // Constructor for the Chip class
        public Chip(string image)
        {
            Image = image;
        }
        
        // Constructor for and Image.
        public string Image {
            get;
            private set;
        }
    }
}
