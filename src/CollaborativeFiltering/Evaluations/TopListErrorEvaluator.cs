using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFiltering.Evaluations
{
    public class TopListErrorEvaluator : BaseEvaluator
    {
        private IEvaluator basicMethod;

        public TopListErrorEvaluator(IEvaluator _basicMethod)
            : base(_basicMethod.MethodName + " on top list")
        {
            basicMethod = _basicMethod;
        }

        public override double CalculateError(IRecommendation recommendation, IEnumerable<IRating> ratings, IEnumerable<IRater> raters, IEnumerable<ISubject> subjects)
        {
            var error = 0.0;

            foreach(var rater in raters)
            {
                var recommendedSubjectsRatings = recommendation.RecommendSubjects(rater, subjects, 10, 0);
                error += basicMethod.CalculateError(recommendation, recommendedSubjectsRatings, raters, subjects);
            }

            return error / raters.Count();
        }
    }
}
