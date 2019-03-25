using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCardsLib
{
    class MoneyChip : Chip
    {
        public MoneyChip(string image, int value) : base(image)
        {
            Value = value;
        }

        public int Value { get; private set; }
    }
}
