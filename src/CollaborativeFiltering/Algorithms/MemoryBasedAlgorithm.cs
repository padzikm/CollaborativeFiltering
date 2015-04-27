using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollaborativeFiltering
{
    public abstract class MemoryBasedAlgorithm : IRecommendation
    {
        protected readonly List<IRating> _ratings;

        protected MemoryBasedAlgorithm(IEnumerable<IRating> ratings)
        {
            _ratings = ratings.ToList();
        }

        public virtual IRating RecommendSubject(IRater rater, ISubject subject)
        {
            var alreadyRated = _ratings.Find(p => p.Rater.Id == rater.Id && p.Subject.Id == subject.Id);

            if (alreadyRated != null)
                return alreadyRated;

            var ratings = _ratings.Where(p => p.Subject.Id == subject.Id && p.Rater.Id != rater.Id).ToList();

            if (!ratings.Any())
                return null;

            var meanVote = RatersMeanVote(rater);
            var options = new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount };
            var sumBag = new ConcurrentBag<decimal>();
            var weightSumBag = new ConcurrentBag<decimal>();

            Parallel.ForEach(ratings, options, rating =>
            {
                var weight = Weight(rater, rating.Rater);
                var mean = RatersMeanVote(rating.Rater);
                var value = (decimal) rating.Value;
                var diff = value - mean;
                var val = weight*diff;

                weightSumBag.Add(weight);
                sumBag.Add(val);
            });

            var sum = sumBag.Sum();
            var weightSum = weightSumBag.Sum();

            if (weightSum == 0)
                return null;

            var kappa = 1/weightSum;
            var result = meanVote + kappa*sum;
            var res = (double) result;
            var rate = new SimpleRating(rater, subject, res);

            return rate;
        }

        public virtual IEnumerable<IRating> RecommendSubjects(IRater rater, IEnumerable<ISubject> subjects, int take = -1, int skip = 0)
        {
            var dict = new Dictionary<ISubject, IRating>();

            foreach (var subject in subjects)
                if(!dict.ContainsKey(subject))
                    dict[subject] = RecommendSubject(rater, subject);

            var sortedList = dict.Values.OrderByDescending(p => p.Value).AsEnumerable();

            if (skip > 0)
                sortedList = sortedList.Skip(skip);
            if (take > 0)
                sortedList = sortedList.Take(take);

            return sortedList;
        }

        public virtual void AddRating(IRating rating)
        {
            _ratings.Add(rating);
        }

        internal abstract decimal Weight(IRater baseRater, IRater neighbour);

        protected virtual decimal RatersMeanVote(IRater rater)
        {
            var sum = 0M;
            var count = 0;

            foreach (var rating in rater.Ratings)
            {
                sum += (decimal)rating.Value;
                ++count;
            }

            return sum/count;
        }
    }
}
