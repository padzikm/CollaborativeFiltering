using System.Collections.Generic;

namespace CollaborativeFiltering.Algorithms
{
    public class AlgorithmCache : IRecommendation
    {
        private readonly IRecommendation _algorithm;
        private readonly Dictionary<string, double> _cache; 

        public AlgorithmCache(IRecommendation algorithm)
        {
            _algorithm = algorithm;
            _cache = new Dictionary<string, double>();
        }

        public double RecommendationValue(User user, Movie movie)
        {
            var key = string.Format("{0}_{1}", user.Id, movie.Id);
            var cachedValue = 0D;

            if (_cache.TryGetValue(key, out cachedValue))
                return cachedValue;

            cachedValue = _algorithm.RecommendationValue(user, movie);

            _cache.Add(key, cachedValue);

            return cachedValue;
        }

        public override string ToString()
        {
            return _algorithm.ToString();
        }
    }
}
