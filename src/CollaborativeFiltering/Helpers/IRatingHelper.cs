using System.Collections.Generic;

namespace CollaborativeFiltering
{
    interface IRatingHelper
    {
        IEnumerable<Pair> GetCommonRatings(User firstUser, User secondUser);
    }

    public class Pair
    {
        public Rating FirstRating { get; set; }

        public Rating SecondRating { get; set; }
    }
}
