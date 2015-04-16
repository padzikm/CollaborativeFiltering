using System.Collections.Generic;
using System.Linq;

namespace CollaborativeFiltering
{
    public class RatingService : IRatingService
    {
        protected IRater FirstRater;
        protected IRater SecondRater;
        protected IEnumerable<IRating> RatingsFirstSort;
        protected IEnumerable<IRating> RatingsSecondSort;
        protected int IndexFirst;
        protected int IndexSecond;
        protected int CountFirst;
        protected int CountSecond;

        protected virtual void Initialize(IRater firstRater, IRater secondRater) //O(nlogn)
        {
            FirstRater = firstRater;
            SecondRater = secondRater;
            RatingsFirstSort = firstRater.Ratings.OrderBy(p => p.Subject.Id);
            RatingsSecondSort = secondRater.Ratings.OrderBy(p => p.Subject.Id);
            IndexFirst = 0;
            IndexSecond = 0;
            CountFirst = RatingsFirstSort.Count();
            CountSecond = RatingsSecondSort.Count();
        }

        public virtual IEnumerable<Pair> GetCommonRatings(IRater firstRater, IRater secondRater) //O(n)
        {
            if (FirstRater != firstRater || SecondRater != secondRater)
                Initialize(firstRater, secondRater);

            while (IndexFirst < CountFirst && IndexSecond < CountSecond)
            {
                var firstRating = RatingsFirstSort.ElementAt(IndexFirst);
                var secondRating = RatingsSecondSort.ElementAt(IndexSecond);

                var pair = ProcessRatings(firstRating, secondRating);

                if(pair != null)
                    yield return pair;
            }
        }

        protected virtual Pair ProcessRatings(IRating firstRating, IRating secondRating)
        {
            var pair = null as Pair;

            if (firstRating.Subject.Id == secondRating.Subject.Id)
            {
                pair = new Pair() { FirstRating = firstRating, SecondRating = secondRating };

                ++IndexFirst;
                ++IndexSecond;
            }
            else if (firstRating.Subject.Id < secondRating.Subject.Id)
                ++IndexFirst;
            else
                ++IndexSecond;

            return pair;
        }
    }
}
