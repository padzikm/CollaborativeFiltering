using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollaborativeFiltering
{
    public abstract class MemoryBasedAlgorithm : IRecommendation
    {
        protected readonly List<Rating> _ratings;

        protected MemoryBasedAlgorithm(IEnumerable<Rating> ratings)
        {
            _ratings = ratings.ToList();
        }

        public virtual double RecommendMovieForUser(User user, Movie movie)
        {
            var ratings = _ratings.Where(p => p.Movie.Id == movie.Id && p.User.Id != user.Id).ToList();

            if (!ratings.Any())
                return -1;

            var meanVote = UsersMeanVote(user);
            var sum = 0M;
            var weightSum = 0M;

            Parallel.ForEach(ratings, rating =>
            {
                var weight = Weight(user, rating.User);
                var mean = UsersMeanVote(rating.User);
                var value = (decimal) rating.Value;
                var diff = value - mean;
                var val = weight*diff;

                weightSum += Math.Abs(weight);
                sum += val;
            });

            if (weightSum == 0)
                return -1;

            var kappa = 1/weightSum;
            var result = meanVote + kappa*sum;

            return (double)result;
        }

        public virtual IEnumerable<Rating> RecommendMoviesForUser(User user, IEnumerable<Movie> movies, int take = -1, int skip = 0)
        {
            var dict = new ConcurrentDictionary<Movie, double>();

            Parallel.ForEach(movies, movie =>
            {
                dict[movie] = RecommendMovieForUser(user, movie);
            });

            var sortedList = dict.OrderByDescending(p => p.Value).Select(p => new Rating(user, p.Key, p.Value));

            if (skip > 0)
                sortedList = sortedList.Skip(skip);
            if (take > 0)
                sortedList = sortedList.Take(take);

            return sortedList;
        }

        public virtual void AddRating(Rating rating)
        {
            _ratings.Add(rating);
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

            return sum/count;
        }
    }
}
