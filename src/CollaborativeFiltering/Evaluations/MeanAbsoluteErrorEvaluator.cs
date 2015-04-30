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

        public override IEnumerable<Tuple<IRecommendation, double>> Evaluate(IEnumerable<IRecommendation> recommendations, IEnumerable<IRating> testRatings)
        {
            var results = new List<Tuple<IRecommendation, double>>();

            foreach (var r in recommendations)
            {
                var error = MeanAbsoluteError(r, testRatings);
                results.Add(new Tuple<IRecommendation, double>(r, error));
            }

            return results;
        }

        public double MeanAbsoluteError(IRecommendation recommendation, IEnumerable<IRating> ratings)
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
