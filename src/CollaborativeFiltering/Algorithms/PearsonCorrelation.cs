using System;
using System.Collections.Generic;

namespace CollaborativeFiltering
{
    public class PearsonCorrelation : MemoryBasedAlgorithm
    {
        public PearsonCorrelation(IEnumerable<Rating> ratings) : base(ratings)
        {}

        internal override double Weight(User baseUser, User neighbour)
        {
            var helper = GetRatingHelper();

            var baseUsersMean = UsersMeanVote(baseUser);
            var neighbourMean = UsersMeanVote(neighbour);
            var numerator = 0D;
            var denominatorSumBase = 0D;
            var denominatorSumNeigh = 0D;

            var pair = helper.GetNextCommonRatings(baseUser, neighbour);

            while (pair != null)
            {
                var ratingBase = pair.FirstRating;
                var ratingNeigh = pair.SecondRating;

                var diffBase = ratingBase.Value - baseUsersMean;
                var diffNeigh = ratingNeigh.Value - neighbourMean;

                numerator += diffBase*diffNeigh;
                denominatorSumBase += diffBase*diffBase;
                denominatorSumNeigh += diffNeigh*diffNeigh;

                pair = helper.GetNextCommonRatings(baseUser, neighbour);
            }

            var denominator = Math.Sqrt(denominatorSumBase*denominatorSumNeigh);

            return numerator/denominator;
        }

        protected virtual RatingHelper GetRatingHelper()
        {
            return new RatingHelper();
        }
    }
}
