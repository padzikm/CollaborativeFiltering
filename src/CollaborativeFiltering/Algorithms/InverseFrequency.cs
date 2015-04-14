using System;
using System.Collections.Generic;
using System.Linq;

namespace CollaborativeFiltering
{
    public class InverseFrequency : MemoryBasedAlgorithm
    {
        private readonly Dictionary<int, double> _frequencies;
        private double? _userCount;

        public InverseFrequency(IEnumerable<Rating> ratings) : base(ratings)
        {
            _frequencies = new Dictionary<int, double>();
        }

        internal override double Weight(User baseUser, User neighbour)
        {
            var helper = new RatingHelper();

            var frequencySum = 0D;
            var commonRatingsSum = 0D;
            var baseRatingsSum = 0D;
            var neighRatingsSum = 0D;
            var baseRatingsSquareSum = 0D;
            var neighRatingsSquareSum = 0D;

            var pair = helper.GetNextCommonRatings(baseUser, neighbour);

            while (pair != null)
            {
                var baseRating = pair.FirstRating;
                var neighRating = pair.SecondRating;
                var frequency = GetFrequency(baseRating.Movie);

                frequencySum += frequency;
                commonRatingsSum += frequency*baseRating.Value*neighRating.Value;
                baseRatingsSum += frequency*baseRating.Value;
                neighRatingsSum += frequency*neighRating.Value;

                baseRatingsSquareSum += frequency*(baseRating.Value*baseRating.Value);
                neighRatingsSquareSum += frequency*(neighRating.Value*neighRating.Value);

                pair = helper.GetNextCommonRatings(baseUser, neighbour);
            }

            var numerator = frequencySum*commonRatingsSum - baseRatingsSum*neighRatingsSum;
            var firstFactor = frequencySum*(baseRatingsSquareSum - baseRatingsSum*baseRatingsSum);
            var secondFactor = frequencySum*(neighRatingsSquareSum - neighRatingsSum*neighRatingsSum);
            var denominator = Math.Sqrt(firstFactor*secondFactor);

            return numerator/denominator;
        }

        private double GetFrequency(Movie movie)
        {
            if (_userCount == null)
                _userCount = _ratings.GroupBy(p => p.User.Id).Count();

            var value = 0D;

            if (!_frequencies.TryGetValue(movie.Id, out value))
            {
                var movieRateCout = (double)_ratings.Count(p => p.Movie.Id == movie.Id);
                var tmp = _userCount.Value/movieRateCout;
                value = Math.Log(tmp);
                _frequencies.Add(movie.Id, value);
            }

            return value;
        }
    }
}
