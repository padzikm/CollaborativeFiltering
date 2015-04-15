using System;
using System.Collections.Generic;

namespace CollaborativeFiltering
{
    public class PearsonCorrelation : MemoryBasedAlgorithm
    {
        public PearsonCorrelation(IEnumerable<Rating> ratings) : base(ratings)
        {}

        internal override decimal Weight(User baseUser, User neighbour)
        {
            var helper = GetRatingService();

            var baseUsersMean = UsersMeanVote(baseUser);
            var neighbourMean = UsersMeanVote(neighbour);
            var numerator = 0M;
            var denominatorSumBase = 0M;
            var denominatorSumNeigh = 0M;

            foreach (var pair in helper.GetCommonRatings(baseUser, neighbour))
            {
                var ratingBase = (decimal)pair.FirstRating.Value;
                var ratingNeigh = (decimal)pair.SecondRating.Value;

                var diffBase = ratingBase - baseUsersMean;
                var diffNeigh = ratingNeigh - neighbourMean;

                numerator += diffBase*diffNeigh;
                denominatorSumBase += diffBase*diffBase;
                denominatorSumNeigh += diffNeigh*diffNeigh;
            }

            var tmp = (double)(denominatorSumBase*denominatorSumNeigh);
            var denominator = (decimal)Math.Sqrt(tmp);

            var result = numerator / denominator;

            return result;
        }

        protected virtual IRatingService GetRatingService()
        {
            return new RatingService();
        }

        public override string ToString()
        {
            return "Person Correlation";
        }
    }
}
