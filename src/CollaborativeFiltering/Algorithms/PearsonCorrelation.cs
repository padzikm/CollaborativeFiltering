﻿using System;
using System.Collections.Generic;

namespace CollaborativeFiltering
{
    public class PearsonCorrelation : MemoryBasedAlgorithm
    {
        public PearsonCorrelation(IEnumerable<IRating> ratings) : base(ratings)
        {}

        internal override decimal Weight(IRater baseRater, IRater neighbour)
        {
            var helper = GetRatingService();

            var baseUsersMean = RatersMeanVote(baseRater);
            var neighbourMean = RatersMeanVote(neighbour);
            var numerator = 0M;
            var denominatorSumBase = 0M;
            var denominatorSumNeigh = 0M;

            foreach (var pair in helper.GetCommonRatings(baseRater, neighbour))
            {
                var ratingBase = (decimal) pair.FirstRating.Value;
                var ratingNeigh = (decimal) pair.SecondRating.Value;

                var diffBase = ratingBase - baseUsersMean;
                var diffNeigh = ratingNeigh - neighbourMean;

                numerator += diffBase*diffNeigh;
                denominatorSumBase += diffBase*diffBase;
                denominatorSumNeigh += diffNeigh*diffNeigh;
            };

            var tmp = (double)(denominatorSumBase*denominatorSumNeigh);
            var denominator = (decimal)Math.Sqrt(tmp);

            if (denominator == 0)
                return 0;

            var result = numerator / denominator;

            return result;
        }

        protected virtual IRatingService GetRatingService()
        {
            return new RatingService();
        }

        public override string ToString()
        {
            return "Pearson Correlation";
        }
    }
}
