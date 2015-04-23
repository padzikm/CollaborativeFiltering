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

        public IRating RecommendSubject(IRater rater, ISubject subject)
        {
            var key = CreateCacheKey(rater, subject);
            var cachedValue = 0D;

            if (_cache.TryGetValue(key, out cachedValue))
                return new SimpleRating(rater, subject, cachedValue);

            var rating = _algorithm.RecommendSubject(rater, subject);

            if(rating != null)
                _cache[key] = rating.Value;

            return rating;
        }

        public IEnumerable<IRating> RecommendSubjects(IRater rater, IEnumerable<ISubject> subjects, int take = -1, int skip = 0)
        {
            var cachedResults = new ConcurrentBag<IRating>();
            var notCachedSubjects = new ConcurrentBag<ISubject>();
            var options = new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount };

            Parallel.ForEach(subjects, options, subject =>
            {
                var key = CreateCacheKey(rater, subject);
                var value = 0D;
                if (_cache.TryGetValue(key, out value))
                {
                    var ranking = new SimpleRating(rater, subject, value);
                    cachedResults.Add(ranking);
                }
                else
                    notCachedSubjects.Add(subject);
            });

            var partial = _algorithm.RecommendSubjects(rater, notCachedSubjects);

            var results = partial.ToList();
            results.AddRange(cachedResults);

            var sorted = results.OrderByDescending(p => p.Value).AsEnumerable();

            if (skip > 0)
                sorted = sorted.Skip(skip);
            if (take > 0)
                sorted = sorted.Take(take);

            return sorted;
        }

        public void AddRating(IRating rating)
        {
            var key = CreateCacheKey(rating.Rater, rating.Subject);
            var value = 0D;

            _cache.TryRemove(key, out value);

            _algorithm.AddRating(rating);
        }

        public override string ToString()
        {
            return _algorithm.ToString();
        }

        private string CreateCacheKey(IRater rater, ISubject subject)
        {
            return string.Format("{0}_{1}", rater.Id, subject.Id);
        }
    }
}
