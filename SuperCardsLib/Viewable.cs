using System.Collections.Generic;

namespace SuperCardsLib
{
    // Interface: Viewable - Thing that is viewed
    public interface Viewable
    {
        // Ivar: GetImageNames - the image names for the cards
        List<string> GetImageNames();
    }
}
