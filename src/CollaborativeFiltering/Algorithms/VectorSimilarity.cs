using System;
using System.Collections.Generic;
using System.Linq;

namespace CollaborativeFiltering
{
    public class VectorSimilarity : MemoryBasedAlgorithm
    {
        public VectorSimilarity(IEnumerable<Rating> ratings) : base(ratings)
        {}

        internal override double Weight(User baseUser, User neighbour)
        {
            var helper = new RatingHelper();

            var baseSum = baseUser.Ratings.Sum(p => p.Value*p.Value);
            var neighSum = neighbour.Ratings.Sum(p => p.Value*p.Value);
            var denominator = Math.Sqrt(baseSum)*Math.Sqrt(neighSum);
            var sum = 0D;

            var pair = helper.GetNextCommonRatings(baseUser, neighbour);

            while (pair != null)
            {
                var ratingBase = pair.FirstRating;
                var ratingNeigh = pair.SecondRating;

                sum += ratingBase.Value*ratingNeigh.Value;

                pair = helper.GetNextCommonRatings(baseUser, neighbour);
            }

            return sum/denominator;
        }
    }
}
