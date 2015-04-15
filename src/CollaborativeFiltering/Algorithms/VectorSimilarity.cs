using System;
using System.Collections.Generic;
using System.Linq;

namespace CollaborativeFiltering
{
    public class VectorSimilarity : MemoryBasedAlgorithm
    {
        public VectorSimilarity(IEnumerable<Rating> ratings) : base(ratings)
        {}

        internal override decimal Weight(User baseUser, User neighbour)
        {
            var helper = new RatingService();

            var baseSum = baseUser.Ratings.Sum(p => p.Value*p.Value);
            var neighSum = neighbour.Ratings.Sum(p => p.Value*p.Value);
            var denominator = (decimal)(Math.Sqrt(baseSum)*Math.Sqrt(neighSum));
            var sum = 0M;

            foreach (var pair in helper.GetCommonRatings(baseUser, neighbour))
            {
                var ratingBase = (decimal)pair.FirstRating.Value;
                var ratingNeigh = (decimal)pair.SecondRating.Value;

                sum += ratingBase*ratingNeigh;
            }

            var result = sum / denominator;

            return result;
        }

        public override string ToString()
        {
            return "Vector Similarity";
        }
    }
}
