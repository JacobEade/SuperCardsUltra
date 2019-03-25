using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCardsLib
{
    class Chip : Viewable
    {
        public Chip(string image)
        {
            Image = image;
        }

        public string Image { get; private set; }

        public List<string> GetImageName()
        {
            throw new NotImplementedException();
        }
    }
}
