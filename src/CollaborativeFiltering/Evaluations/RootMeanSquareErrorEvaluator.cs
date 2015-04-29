using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFiltering.Evaluations
{
    public class RootMeanSquareErrorEvaluator : BaseEvaluator
    {
        public RootMeanSquareErrorEvaluator() : base("Root mean square error evaluation")
        {

        }

        public override IEnumerable<Tuple<IRecommendation, double>> Evaluate(IEnumerable<IRecommendation> recommendations, IEnumerable<IRating> testRatings)
        {
            var rand = new Random();
            var res = new List<Tuple<IRecommendation, double>>();

            foreach (var r in recommendations)
                res.Add(new Tuple<IRecommendation, double>(r, Math.Round(rand.NextDouble(), 3)));

            return res;
        }
    }
}
