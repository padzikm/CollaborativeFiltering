using System.Collections.Generic;

namespace CollaborativeFiltering
{
    public interface IRatingService
    {
        IEnumerable<Pair> GetCommonRatings(User firstUser, User secondUser);
    }

    public class Pair
    {
        public Rating FirstRating { get; set; }

        public Rating SecondRating { get; set; }
    }
}
