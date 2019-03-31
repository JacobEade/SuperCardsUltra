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
