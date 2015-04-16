using System.Collections.Generic;
using System.Linq;

namespace CollaborativeFiltering
{
    public class RatingService : IRatingService
    {
        protected User FirstUser;
        protected User SecondUser;
        protected IEnumerable<Rating> RatingsFirstSort;
        protected IEnumerable<Rating> RatingsSecondSort;
        protected int IndexFirst;
        protected int IndexSecond;
        protected int CountFirst;
        protected int CountSecond;

        protected virtual void Initialize(User firstUser, User secondUser) //O(nlogn)
        {
            FirstUser = firstUser;
            SecondUser = secondUser;
            RatingsFirstSort = firstUser.Ratings.OrderBy(p => p.Movie.Id);
            RatingsSecondSort = secondUser.Ratings.OrderBy(p => p.Movie.Id);
            IndexFirst = 0;
            IndexSecond = 0;
            CountFirst = RatingsFirstSort.Count();
            CountSecond = RatingsSecondSort.Count();
        }

        public virtual IEnumerable<Pair> GetCommonRatings(User firstUser, User secondUser) //O(n)
        {
            if (FirstUser != firstUser || SecondUser != secondUser)
                Initialize(firstUser, secondUser);

            while (IndexFirst < CountFirst && IndexSecond < CountSecond)
            {
                var firstRating = RatingsFirstSort.ElementAt(IndexFirst);
                var secondRating = RatingsSecondSort.ElementAt(IndexSecond);

                var pair = ProcessRatings(firstRating, secondRating);

                if(pair != null)
                    yield return pair;
            }
        }

        protected virtual Pair ProcessRatings(Rating firstRating, Rating secondRating)
        {
            var pair = null as Pair;

            if (firstRating.Movie.Id == secondRating.Movie.Id)
            {
                pair = new Pair() { FirstRating = firstRating, SecondRating = secondRating };

                ++IndexFirst;
                ++IndexSecond;
            }
            else if (firstRating.Movie.Id < secondRating.Movie.Id)
                ++IndexFirst;
            else
                ++IndexSecond;

            return pair;
        }
    }
}
