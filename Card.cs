using System;

namespace Cards
{
    public class Card
    {
        public Card(string pointFrom, string pointTo)
        {
            PointFrom = pointFrom;
            PointTo = pointTo;
        }

        public string PointFrom { get; set; }
        public string PointTo { get; set; }
    }
}
