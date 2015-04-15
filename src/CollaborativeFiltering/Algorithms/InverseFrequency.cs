using System;
using System.Collections.Generic;
using System.Linq;

namespace CollaborativeFiltering
{
    public class InverseFrequency : MemoryBasedAlgorithm
    {
        private readonly Dictionary<int, decimal> _frequencies;
        private double? _userCount;

        public InverseFrequency(IEnumerable<Rating> ratings) : base(ratings)
        {
            _frequencies = new Dictionary<int, decimal>();
        }

        internal override decimal Weight(User baseUser, User neighbour)
        {
            var helper = new RatingHelper();

            var frequencySum = 0M;
            var commonRatingsSum = 0M;
            var baseRatingsSum = 0M;
            var neighRatingsSum = 0M;
            var baseRatingsSquareSum = 0M;
            var neighRatingsSquareSum = 0M;

            foreach(var pair in helper.GetCommonRatings(baseUser, neighbour))
            {
                var baseRating = (decimal)pair.FirstRating.Value;
                var neighRating = (decimal)pair.SecondRating.Value;
                var frequency = GetFrequency(pair.FirstRating.Movie);

                frequencySum += frequency;
                commonRatingsSum += frequency*baseRating*neighRating;
                baseRatingsSum += frequency*baseRating;
                neighRatingsSum += frequency*neighRating;

                baseRatingsSquareSum += frequency*(baseRating*baseRating);
                neighRatingsSquareSum += frequency*(neighRating*neighRating);
            }

            var numerator = frequencySum*commonRatingsSum - baseRatingsSum*neighRatingsSum;
            var firstFactor = frequencySum*(baseRatingsSquareSum - baseRatingsSum*baseRatingsSum);
            var secondFactor = frequencySum*(neighRatingsSquareSum - neighRatingsSum*neighRatingsSum);
            var factors = (double)(firstFactor*secondFactor);
            var denominator = (decimal)Math.Sqrt(factors);

            var result = numerator / denominator;

            return result;
        }

        private decimal GetFrequency(Movie movie)
        {
            if (_userCount == null)
                _userCount = _ratings.GroupBy(p => p.User.Id).Count();

            var value = 0M;

            if (!_frequencies.TryGetValue(movie.Id, out value))
            {
                var movieRateCout = (double)_ratings.Count(p => p.Movie.Id == movie.Id);
                var tmp = _userCount.Value/movieRateCout;
                value = (decimal)Math.Log(tmp);
                _frequencies.Add(movie.Id, value);
            }

            return value;
        }

        public override string ToString()
        {
            return "Inverse Frequency";
        }
    }
}
