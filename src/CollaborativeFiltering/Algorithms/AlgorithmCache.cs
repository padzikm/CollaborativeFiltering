using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollaborativeFiltering.Algorithms
{
    public class AlgorithmCache : IRecommendation
    {
        private readonly IRecommendation _algorithm;
        private readonly ConcurrentDictionary<string, double> _cache; 

        public AlgorithmCache(IRecommendation algorithm)
        {
            _algorithm = algorithm;
            _cache = new ConcurrentDictionary<string, double>();
        }

        public double RecommendMovieForUser(User user, Movie movie)
        {
            var key = CreateCacheKey(user, movie);
            var cachedValue = 0D;

            if (_cache.TryGetValue(key, out cachedValue))
                return cachedValue;

            var rating = _algorithm.RecommendMovieForUser(user, movie);

            _cache[key] = rating;

            return rating;
        }

        public IEnumerable<Rating> RecommendMoviesForUser(User user, IEnumerable<Movie> movies, int take = -1, int skip = 0)
        {
            var cachedResults = new LinkedList<Rating>();
            var notCachedMovies = new LinkedList<Movie>();

            Parallel.ForEach(movies, movie =>
            {
                var key = CreateCacheKey(user, movie);
                var value = 0D;
                if (_cache.TryGetValue(key, out value))
                {
                    var ranking = new Rating(user, movie, value);
                    cachedResults.AddLast(ranking);
                }
                else
                    notCachedMovies.AddLast(movie);
            });

            var partial = _algorithm.RecommendMoviesForUser(user, notCachedMovies);

            foreach (var rating in partial)
                cachedResults.AddLast(rating);

            var sorted = cachedResults.OrderByDescending(p => p.Value).AsEnumerable();

            if (skip > 0)
                sorted = sorted.Skip(skip);
            if (take > 0)
                sorted = sorted.Take(take);

            return sorted;
        }

        public void AddRating(Rating rating)
        {
            var key = CreateCacheKey(rating.User, rating.Movie);
            var value = 0D;

            _cache.TryRemove(key, out value);

            _algorithm.AddRating(rating);
        }

        private string CreateCacheKey(User user, Movie movie)
        {
            return string.Format("{0}_{1}", user.Id, movie.Id);
        }
    }
}
