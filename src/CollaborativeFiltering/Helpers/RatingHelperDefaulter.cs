using System.Collections.Generic;
using System.Linq;

namespace CollaborativeFiltering
{
    public class RatingHelperDefaulter : RatingHelper
    {
        private readonly double _defaultValue;

        public RatingHelperDefaulter(double defaultValue)
        {
            _defaultValue = defaultValue;
        }

        public override Pair GetNextCommonRatings(User firstUser, User secondUser)
        {
            var pair = base.GetNextCommonRatings(firstUser, secondUser);

            if (pair != null)
                return pair;

            pair = GetRatingTail(ref IndexFirst, CountFirst, RatingsFirstSort, firstUser, true);

            if (pair != null)
                return pair;

            pair = GetRatingTail(ref IndexSecond, CountSecond, RatingsSecondSort, secondUser, false);

            return pair;
        }

        protected override Pair ProcessRatings(Rating firstRating, Rating secondRating)
        {
            var pair = new Pair() { FirstRating = firstRating, SecondRating = secondRating };

            if (firstRating.Movie.Id == secondRating.Movie.Id)
            {
                ++IndexFirst;
                ++IndexSecond;
            }
            else if (firstRating.Movie.Id < secondRating.Movie.Id)
            {
                var rating = new Rating(firstRating.User, firstRating.Movie, _defaultValue);
                pair.FirstRating = rating;
                ++IndexFirst;
            }
            else
            {
                var rating = new Rating(secondRating.User, secondRating.Movie, _defaultValue);
                pair.SecondRating = rating;
                ++IndexSecond;
            }

            return pair;
        }

        private Pair GetRatingTail(ref int index, int count, IEnumerable<Rating> ratings, User user, bool isSecondFake)
        {
            if (index >= count)
                return null;

            var rating = ratings.ElementAt(index);
            var ratingFake = new Rating(user, rating.Movie, _defaultValue);
            var pair = isSecondFake ? new Pair() { FirstRating = rating, SecondRating = ratingFake } : new Pair() { FirstRating = ratingFake, SecondRating = rating }; ;
            ++index;

            return pair;
        }
    }
}
