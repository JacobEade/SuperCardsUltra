using System.Collections.Generic;

namespace SuperCardsLib
{
    // Class for a Chip which shows money
    abstract public class Chip : Viewable
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

        // Function: GetImageNames - returns the Images
        public List<string> GetImageNames()//do we really need this or just use the getter for image???
        {
            return new List<string> { Image };
        }
    }
}
