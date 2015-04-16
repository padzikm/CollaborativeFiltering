using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CollaborativeFiltering
{
    public class EvaluationTester
    {
        public static double MeanAbsoluteError(IRecommendation system, IEnumerable<Rating> ratings)
        {
            var sum = 0D;
            var count = 0;

            foreach (var rating in ratings)
            {
                var value = system.RecommendMovieForUser(rating.User, rating.Movie);
                var diff = value - rating.Value;
                sum += Math.Abs(diff);
                ++count;
            };

            var error = sum/count;

            return error;
        }

        public static double RootMeanSquareError(IRecommendation system, IEnumerable<Rating> ratings)
        {
            var sum = 0D;
            var count = 0;

            foreach (var rating in ratings)
            {
                var value = system.RecommendMovieForUser(rating.User, rating.Movie);
                var diff = value - rating.Value;
                sum += diff*diff;
                ++count;
            };

            var partial = sum / count;
            var error = Math.Sqrt(partial);

            return error;
        }
    }
}
