﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CollaborativeFiltering
{
    public abstract class MemoryBasedAlgorithm : IRecommendation
    {
        protected readonly List<Rating> _ratings;

        public MemoryBasedAlgorithm(IEnumerable<Rating> ratings)
        {
            _ratings = ratings.ToList();
        }

        public virtual double RecommendationValue(User user, Movie movie)
        {
            var meanVote = UsersMeanVote(user);
            var ratings = GetRatingsForExceptUser(movie, user);
            var sum = 0D;
            var weightSum = 0D;

            foreach (var rating in ratings)
            {
                var weight = Weight(user, rating.User);
                var mean = UsersMeanVote(rating.User);
                var diff = rating.Value - mean;
                var val = weight*diff;

                weightSum += Math.Abs(weight);
                sum += val;
            }

            var kappa = 1/weightSum;
            var result = meanVote + kappa*sum;

            return result;
        }

        protected virtual List<Rating> GetRatingsForExceptUser(Movie movie, User user)
        {
            return _ratings.Where(p => p.Movie.Id == movie.Id && p.User.Id != user.Id).ToList();
        }

        protected virtual double UsersMeanVote(User user)
        {
            var sum = 0D;
            var count = 0;

            foreach (var rating in user.Ratings)
            {
                sum += rating.Value;
                ++count;
            }

            return sum / count;
        }

        protected abstract double Weight(User baseUser, User neighbour);
    }
}