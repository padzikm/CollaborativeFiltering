﻿using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CollaborativeFiltering.Algorithms
{
    public class MemoryBasedAlgorithmCache : MemoryBasedAlgorithm
    {
        private readonly MemoryBasedAlgorithm _algorithm;
        private readonly ConcurrentDictionary<string, decimal> _userWeightsCache;
        private readonly ConcurrentDictionary<long, decimal> _userMeanVotesCache;
        private readonly ConcurrentDictionary<long, bool> _notCachedUsers; 

        public MemoryBasedAlgorithmCache(MemoryBasedAlgorithm algorithm) : base(algorithm.Ratings)
        {
            _algorithm = algorithm;
            _userWeightsCache = new ConcurrentDictionary<string, decimal>();
            _userMeanVotesCache = new ConcurrentDictionary<long, decimal>();
            _notCachedUsers = new ConcurrentDictionary<long, bool>();
        }

        internal override decimal Weight(IRater baseRater, IRater neighbour)
        {
            var isBaseUserCached = !_notCachedUsers.TryUpdate(baseRater.Id, false, true);
            var isNeighbourCached = !_notCachedUsers.TryUpdate(neighbour.Id, false, true);
            var areCached = isBaseUserCached && isNeighbourCached;
            
            var key = string.Format("{0}_{1}", baseRater.Id, neighbour.Id);
            var reverseKey = string.Format("{0}_{1}", neighbour.Id, baseRater.Id);
            var cachedWeight = 0M;

            if (areCached && _userWeightsCache.TryGetValue(key, out cachedWeight))
                return cachedWeight;
            if (areCached && _userWeightsCache.TryGetValue(reverseKey, out cachedWeight))
                return cachedWeight;

            cachedWeight = _algorithm.Weight(baseRater, neighbour);
            
            _userWeightsCache[key] = cachedWeight;

            return cachedWeight;
        }

        public override void AddRating(IRating rating)
        {
            _notCachedUsers[rating.Rater.Id] = true;
            _algorithm.AddRating(rating);
            base.AddRating(rating);
        }

        public override string ToString()
        {
            return _algorithm.ToString();
        }

        protected internal override decimal RatersMeanVote(IRater rater)
        {
            var isCached = !_notCachedUsers.TryUpdate(rater.Id, false, true);
            var value = 0M;

            if (isCached && _userMeanVotesCache.TryGetValue(rater.Id, out value))
                return value;

            value = base.RatersMeanVote(rater);

            _userMeanVotesCache[rater.Id] = value;

            return value;
        }
    }
}
