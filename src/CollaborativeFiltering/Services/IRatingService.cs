using System.Collections.Generic;

namespace CollaborativeFiltering
{
    public interface IRatingService
    {
        IEnumerable<Pair> GetCommonRatings(IRater firstRater, IRater secondRater);
    }

    public class Pair
    {
        public IRating FirstRating { get; set; }

        public IRating SecondRating { get; set; }
    }
}
