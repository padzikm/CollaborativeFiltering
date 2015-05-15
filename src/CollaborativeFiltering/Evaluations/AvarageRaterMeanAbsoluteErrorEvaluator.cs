using System.Collections.Generic;
using System.Linq;

namespace CollaborativeFiltering.Evaluations
{
    class AvarageRaterMeanAbsoluteErrorEvaluator : BaseEvaluator
    {
        public AvarageRaterMeanAbsoluteErrorEvaluator() : base("Avarage mean absolute error evaluation")
        {
        }

        public override double CalculateError(IRecommendation recommendation, IEnumerable<IRating> ratings, IEnumerable<IRater> raters, IEnumerable<ISubject> subjects)
        {
            var grouppedByRater = ratings.GroupBy(p => p.Rater.Id);
            var count = 0D;
            var sum = 0D;
            var evaluator = new MeanAbsoluteErrorEvaluator();

            foreach (var rater in grouppedByRater)
            {
                var error = evaluator.CalculateError(recommendation, rater.AsEnumerable(), new List<IRater>(){ raters.First(p => p.Id == rater.Key)}, subjects);

                if (error != -1)
                {
                    sum += error;
                    ++count;
                }
            }
            if (count == 0)
                return -1;
            var avarage = sum / count;
            return avarage;
        }
    }
}
