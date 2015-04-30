using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFiltering.Evaluations
{
    public class MeanAbsoluteErrorEvaluator : BaseEvaluator
    {
        public MeanAbsoluteErrorEvaluator() : base("Mean absolute error evaluation")
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
                sum += Math.Abs(diff);
                ++count;
            };

            if (count == 0)
                return -1;

            var error = sum / count;

            return error;
        }
    }
}
