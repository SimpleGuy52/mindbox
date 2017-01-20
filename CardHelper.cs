using System.Collections.Generic;
using System.Linq;

namespace Cards
{
    public static class CardHelper
    {
        // Difficulty O(N), N - num of elements
        public static List<Card> Sort(List<Card> cards)
        {
            var result = new List<Card>();
            if (cards == null || !cards.Any())
                return result;

            var arrayFrom = cards.Select(a => a.PointFrom).ToArray();
            var arrayTo = cards.Select(a => a.PointTo).ToArray();
            var startPoint = arrayFrom.Except(arrayTo).FirstOrDefault();
            if (startPoint == null)
                return result;
            var current = cards.First(c => c.PointFrom == startPoint);
            result.Add(current);

            while (true)
            {
                current = cards.FirstOrDefault(c => c.PointFrom == current.PointTo);
                if (current == null)
                    break;
                result.Add(current);
            }
            return result;
        }
    }
}
