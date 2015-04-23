using System;
using System.Collections.Generic;
using System.Linq;

namespace CollaborativeFiltering
{
    public class EvaluationTester
    {
        public static double MeanAbsoluteError(IRecommendation system, IEnumerable<IRating> ratings)
        {
            var sum = 0D;
            var count = 0;

            foreach (var rating in ratings)
            {
                var value = system.RecommendSubject(rating.Rater, rating.Subject);
                
                if(value == null)
                    continue;

                var diff = value.Value - rating.Value;
                sum += Math.Abs(diff);
                ++count;
            };

            if (count == 0)
                return -1;

            var error = sum/count;

            return error;
        }

        public static double AvarageRaterMeanAbsoluteError(IRecommendation system, IEnumerable<IRating> ratings)
        {
            var grouppedByRater = ratings.GroupBy(p => p.Rater.Id);
            var count = 0D;
            var sum = 0D;

            foreach (var rater in grouppedByRater)
            {
                var error = MeanAbsoluteError(system, rater.AsEnumerable());

                if (error != -1)
                {
                    sum += error;
                    ++count;
                }
            }

            if (count == 0)
                return -1;

            var avarage = sum/count;

            return avarage;
        }

        public static double RootMeanSquareError(IRecommendation system, IEnumerable<IRating> ratings)
        {
            var sum = 0D;
            var count = 0;

            foreach (var rating in ratings)
            {
                var value = system.RecommendSubject(rating.Rater, rating.Subject);
                
                if (value == null)
                    continue;

                var diff = value.Value - rating.Value;
                sum += diff*diff;
                ++count;
            };

            if (count == 0)
                return -1;

            var partial = sum / count;
            var error = Math.Sqrt(partial);

            return error;
        }
    }
}
