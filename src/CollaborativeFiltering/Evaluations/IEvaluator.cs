using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFiltering.Evaluations
{
    public interface IEvaluator
    {
        IEnumerable<Tuple<IRecommendation, double>> Evaluate(IEnumerable<IRecommendation> recommendations, IEnumerable<IRating> testRatings);

        string MethodName { get; set; }
    }
}
