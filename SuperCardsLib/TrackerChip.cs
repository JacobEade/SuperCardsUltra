namespace SuperCardsLib
{
    class TrackerChip : Chip
    {
        public TrackerChip(string image, string label) : base(image)
        {
            Label = label;
        }

        public string Label { get; private set; }
    }
}
