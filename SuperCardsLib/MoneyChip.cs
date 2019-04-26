namespace SuperCardsLib
{
    // Class: MoneyChip
    public class MoneyChip : Chip
    {   
        // Constructor: MoneyChip - build for image and value
        public MoneyChip(string image, int value) : base(image)
        {
            Value = value;
        }

        // Property: Value - 
        public int Value {
            get;
            private set;
        }
    }
}
