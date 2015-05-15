using System;
using System.Collections.Generic;

namespace CollaborativeFiltering.Evaluations
{
    public class RootMeanSquareErrorEvaluator : BaseEvaluator
    {
        public RootMeanSquareErrorEvaluator() : base("Root mean square error evaluation")
        {

        }

        public override double CalculateError(IRecommendation recommendation, IEnumerable<IRating> ratings, IEnumerable<IRater> raters, IEnumerable<ISubject> subjects)
        {
            var sum = 0D;
            var count = 0;

            foreach (var rating in ratings)
            {
                var value = recommendation.RecommendSubject(rating.Rater, rating.Subject);

                if (value == null)
                    continue;

                var diff = value.Value - rating.Value;
                sum += diff * diff;
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
