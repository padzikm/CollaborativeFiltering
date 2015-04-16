﻿using System.Collections.Generic;

namespace CollaborativeFiltering.Algorithms
{
    public class MemoryBasedAlgorithmWeightCache : MemoryBasedAlgorithm
    {
        private readonly MemoryBasedAlgorithm _algorithm;
        private readonly Dictionary<string, decimal> _cache; 

        public MemoryBasedAlgorithmWeightCache(IEnumerable<Rating> ratings, MemoryBasedAlgorithm algorithm) : base(ratings)
        {
            _algorithm = algorithm;
            _cache = new Dictionary<string, decimal>();
        }

        internal override decimal Weight(User baseUser, User neighbour)
        {
            var key = string.Format("{0}_{1}", baseUser.Id, neighbour.Id);
            var reverseKey = string.Format("{0}_{1}", neighbour.Id, baseUser.Id);
            var cachedWeight = 0M;

            if (_cache.TryGetValue(key, out cachedWeight))
                return cachedWeight;
            if (_cache.TryGetValue(reverseKey, out cachedWeight))
                return cachedWeight;

            cachedWeight = _algorithm.Weight(baseUser, neighbour);
            
            _cache.Add(key, cachedWeight);

            return cachedWeight;
        }
    }
}
