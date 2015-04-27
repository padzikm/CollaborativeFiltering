using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace CollaborativeFiltering
{
    public class InverseFrequency : MemoryBasedAlgorithm
    {
        private readonly ConcurrentDictionary<long, decimal> _frequencies;
        private double? _userCount;

        public InverseFrequency(IEnumerable<IRating> ratings) : base(ratings)
        {
            _frequencies = new ConcurrentDictionary<long, decimal>();
        }

        internal override decimal Weight(IRater baseRater, IRater neighbour)
        {
            var helper = new RatingService();

            var frequencySum = 0M;
            var commonRatingsSum = 0M;
            var baseRatingsSum = 0M;
            var neighRatingsSum = 0M;
            var baseRatingsSquareSum = 0M;
            var neighRatingsSquareSum = 0M;

            foreach(var pair in helper.GetCommonRatings(baseRater, neighbour))
            {
                var baseRating = (decimal)pair.FirstRating.Value;
                var neighRating = (decimal)pair.SecondRating.Value;
                var frequency = GetFrequency(pair.FirstRating.Subject);

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

            if (denominator == 0)
                return 0;

            var result = numerator / denominator;

            return result;
        }

        private decimal GetFrequency(ISubject subject)
        {
            if (_userCount == null)
                _userCount = _ratings.GroupBy(p => p.Rater.Id).Count();

            var value = 0M;

            if (!_frequencies.TryGetValue(subject.Id, out value))
            {
                var movieRateCout = (double)_ratings.Count(p => p.Subject.Id == subject.Id);
                var tmp = _userCount.Value/movieRateCout;
                value = (decimal)Math.Log(tmp);
                _frequencies.TryAdd(subject.Id, value);
            }

            return value;
        }

        public override string ToString()
        {
            return "Inverse Frequency";
        }
    }
}
