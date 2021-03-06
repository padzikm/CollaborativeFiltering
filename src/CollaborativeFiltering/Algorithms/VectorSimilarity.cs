﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CollaborativeFiltering
{
    public class VectorSimilarity : MemoryBasedAlgorithm
    {
        public VectorSimilarity(IEnumerable<IRating> ratings) : base(ratings)
        {}

        internal override decimal Weight(IRater baseRater, IRater neighbour)
        {
            var helper = new RatingService();

            var baseSum = baseRater.Ratings.Sum(p => p.Value*p.Value);
            var neighSum = neighbour.Ratings.Sum(p => p.Value*p.Value);
            var denominator = (decimal)(Math.Sqrt(baseSum)*Math.Sqrt(neighSum));
            var sum = 0M;

            foreach (var pair in helper.GetCommonRatings(baseRater, neighbour))
            {
                var ratingBase = (decimal)pair.FirstRating.Value;
                var ratingNeigh = (decimal)pair.SecondRating.Value;

                sum += ratingBase*ratingNeigh;
            }

            if (denominator == 0)
                return 0;

            var result = sum / denominator;

            return result;
        }

        public override string ToString()
        {
            return "Vector Similarity";
        }
    }
}
