using CollaborativeFiltering.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFiltering
{
    public class RecommendationsProvider : IRecommendationsProvider
    {
        public List<IRecommendation> GetRecommendations(IEnumerable<Rating> ratings)
        {
            var recommendations = new List<IRecommendation>();

            recommendations.Add(new AlgorithmCache(new PearsonCorrelation(ratings)));
            recommendations.Add(new AlgorithmCache(new DefaultVoting(ratings, 3)));
            recommendations.Add(new AlgorithmCache(new InverseFrequency(ratings)));
            recommendations.Add(new AlgorithmCache(new VectorSimilarity(ratings)));
            recommendations.Add(new AlgorithmCache(new CaseAmplification(ratings, new DefaultVoting(ratings, 1))));
            recommendations.Add(new AlgorithmCache(new CaseAmplification(ratings, new InverseFrequency(ratings))));
            recommendations.Add(new AlgorithmCache(new CaseAmplification(ratings, new PearsonCorrelation(ratings))));
            recommendations.Add(new AlgorithmCache(new CaseAmplification(ratings, new VectorSimilarity(ratings))));

            return recommendations;
        }
    }
}
