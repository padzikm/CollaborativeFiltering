using System;
using System.Collections.Generic;
using System.Linq;

namespace CollaborativeFiltering
{
    public abstract class MemoryBasedAlgorithm : IRecommendation
    {
        protected readonly List<Rating> _ratings;

        protected MemoryBasedAlgorithm(IEnumerable<Rating> ratings)
        {
            _ratings = ratings.ToList();
        }

        public virtual double RecommendationValue(User user, Movie movie)
        {
            var meanVote = UsersMeanVote(user);
            var ratings = _ratings.Where(p => p.Movie.Id == movie.Id && p.User.Id != user.Id).ToList();
            var sum = 0M;
            var weightSum = 0M;

            foreach (var rating in ratings)
            {
                var weight = Weight(user, rating.User);
                var mean = UsersMeanVote(rating.User);
                var value = (decimal) rating.Value;
                var diff = value - mean;
                var val = weight*diff;

                weightSum += Math.Abs(weight);
                sum += val;
            }

            var kappa = 1/weightSum;
            var result = meanVote + kappa*sum;

            return (double)result;
        }

        internal abstract decimal Weight(User baseUser, User neighbour);

        protected virtual decimal UsersMeanVote(User user)
        {
            var sum = 0M;
            var count = 0;

            foreach (var rating in user.Ratings)
            {
                sum += (decimal)rating.Value;
                ++count;
            }

            return sum / count;
        }
    }
}
