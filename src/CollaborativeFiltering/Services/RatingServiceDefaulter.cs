using System.Collections.Generic;
using System.Linq;

namespace CollaborativeFiltering
{
    public class RatingHelperDefaulter : RatingService
    {
        private readonly double _defaultValue;

        public RatingHelperDefaulter(double defaultValue)
        {
            _defaultValue = defaultValue;
        }

        public override IEnumerable<Pair> GetCommonRatings(IRater firstRater, IRater secondRater)
        {
            var list = base.GetCommonRatings(firstRater, secondRater);

            foreach (var pair in list)
                yield return pair;

            var tail = GetRatingTail(ref IndexFirst, CountFirst, RatingsFirstSort, firstRater, true);

            foreach (var pair in tail)
                yield return pair;

            tail = GetRatingTail(ref IndexSecond, CountSecond, RatingsSecondSort, secondRater, false);

            foreach (var pair in tail)
                yield return pair;
        }

        protected override Pair ProcessRatings(IRating firstRating, IRating secondRating)
        {
            var pair = new Pair() { FirstRating = firstRating, SecondRating = secondRating };

            if (firstRating.Subject.Id == secondRating.Subject.Id)
            {
                ++IndexFirst;
                ++IndexSecond;
            }
            else if (firstRating.Subject.Id < secondRating.Subject.Id)
            {
                var rating = new SimpleRating(firstRating.Rater, firstRating.Subject, _defaultValue);
                pair.FirstRating = rating;
                ++IndexFirst;
            }
            else
            {
                var rating = new SimpleRating(secondRating.Rater, secondRating.Subject, _defaultValue);
                pair.SecondRating = rating;
                ++IndexSecond;
            }

            return pair;
        }

        private IEnumerable<Pair> GetRatingTail(ref int index, int count, IEnumerable<IRating> ratings, IRater rater, bool isSecondFake)
        {
            var list = new LinkedList<Pair>();

            while (index < count)
            {
                var rating = ratings.ElementAt(index);
                var ratingFake = new SimpleRating(rater, rating.Subject, _defaultValue);
                var pair = isSecondFake
                    ? new Pair() {FirstRating = rating, SecondRating = ratingFake}
                    : new Pair() {FirstRating = ratingFake, SecondRating = rating};
                
                ++index;

                list.AddLast(pair);
            }

            return list;
        }
    }
}
