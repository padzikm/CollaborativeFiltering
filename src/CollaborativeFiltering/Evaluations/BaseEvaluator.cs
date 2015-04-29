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

        public abstract IEnumerable<Tuple<IRecommendation, double>> Evaluate(IEnumerable<IRecommendation> recommendations, IEnumerable<IRating> testRatings);

        public string MethodName { get; set; }

        public override string ToString()
        {
            return MethodName;
        }
    }
}
