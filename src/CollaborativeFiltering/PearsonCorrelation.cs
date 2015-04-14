using System;
using System.Collections.Generic;
using System.Linq;

namespace CollaborativeFiltering
{
    public class PearsonCorrelation : MemoryBasedAlgorithm
    {
        public PearsonCorrelation(IEnumerable<Rating> ratings) : base(ratings)
        {}

        protected override double Weight(User baseUser, User neighbour)
        {
            var baseUsersMean = UsersMeanVote(baseUser);
            var neighbourMean = UsersMeanVote(neighbour);
            var numerator = 0D;
            var denominatorSumBase = 0D;
            var denominatorSumNeigh = 0D;

            foreach (var baseUsersRating in baseUser.Ratings)
            {
                var neighbourRating = neighbour.Ratings.FirstOrDefault(p => p.Movie.Id == baseUsersRating.Movie.Id);

                if(neighbourRating == null)
                    continue;

                var diffBase = baseUsersRating.Value - baseUsersMean;
                var diffNeigh = neighbourRating.Value - neighbourMean;

                numerator += diffBase*diffNeigh;
                denominatorSumBase += diffBase*diffBase;
                denominatorSumNeigh += diffNeigh*diffNeigh;
            }

            var denominator = Math.Sqrt(denominatorSumBase*denominatorSumNeigh);

            return numerator/denominator;
        } 
    }
}
