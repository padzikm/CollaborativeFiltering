using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFiltering.Evaluations
{
    public abstract class BaseEvaluator : IEvaluator
    {
        public BaseEvaluator(string methodName)
        {
            MethodName = methodName;
        }

        public IEnumerable<Tuple<IRecommendation, double>> Evaluate(IEnumerable<IRecommendation> recommendations, IEnumerable<IRating> testRatings, IEnumerable<IRater> raters, IEnumerable<ISubject> subjects)
        {
            var results = new List<Tuple<IRecommendation, double>>();

            foreach (var r in recommendations)
            {
                var error = CalculateError(r, testRatings, raters, subjects);
                results.Add(new Tuple<IRecommendation, double>(r, error));
            }

            return results;
        }
        public abstract double CalculateError(IRecommendation recommendation, IEnumerable<IRating> ratings, IEnumerable<IRater> raters, IEnumerable<ISubject> subjects);

        public string MethodName { get; set; }

        public override string ToString()
        {
            return MethodName;
        }
    }
}
