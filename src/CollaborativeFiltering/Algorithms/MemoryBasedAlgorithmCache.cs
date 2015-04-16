using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CollaborativeFiltering.Algorithms
{
    public class MemoryBasedAlgorithmCache : MemoryBasedAlgorithm
    {
        private readonly MemoryBasedAlgorithm _algorithm;
        private readonly ConcurrentDictionary<string, decimal> _userWeightsCache;
        private readonly ConcurrentDictionary<int, decimal> _userMeanVotesCache;
        private readonly ConcurrentDictionary<int, bool> _notCachedUsers; 

        public MemoryBasedAlgorithmCache(IEnumerable<Rating> ratings, MemoryBasedAlgorithm algorithm) : base(ratings)
        {
            _algorithm = algorithm;
            _userWeightsCache = new ConcurrentDictionary<string, decimal>();
            _userMeanVotesCache = new ConcurrentDictionary<int, decimal>();
            _notCachedUsers = new ConcurrentDictionary<int, bool>();
        }

        internal override decimal Weight(User baseUser, User neighbour)
        {
            var isBaseUserCached = !_notCachedUsers.TryUpdate(baseUser.Id, false, true);
            var isNeighbourCached = !_notCachedUsers.TryUpdate(neighbour.Id, false, true);
            var areCached = isBaseUserCached && isNeighbourCached;

            var key = string.Format("{0}_{1}", baseUser.Id, neighbour.Id);
            var reverseKey = string.Format("{0}_{1}", neighbour.Id, baseUser.Id);
            var cachedWeight = 0M;

            if (areCached && _userWeightsCache.TryGetValue(key, out cachedWeight))
                return cachedWeight;
            if (areCached && _userWeightsCache.TryGetValue(reverseKey, out cachedWeight))
                return cachedWeight;

            cachedWeight = _algorithm.Weight(baseUser, neighbour);
            
            _userWeightsCache[key] = cachedWeight;

            return cachedWeight;
        }

        public override void AddRating(Rating rating)
        {
            _notCachedUsers[rating.User.Id] = true;

            base.AddRating(rating);
        }

        protected override decimal UsersMeanVote(User user)
        {
            var isCached = !_notCachedUsers.TryUpdate(user.Id, false, true);
            var value = 0M;

            if (isCached && _userMeanVotesCache.TryGetValue(user.Id, out value))
                return value;

            value = base.UsersMeanVote(user);

            _userMeanVotesCache[user.Id] = value;

            return value;
        }
    }
}
