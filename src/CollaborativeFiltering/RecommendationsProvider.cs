using System.Collections.Generic;
using CollaborativeFiltering.Algorithms;

namespace CollaborativeFiltering
{
    public class RecommendationsProvider : IRecommendationsProvider
    {
        public List<IRecommendation> GetRecommendations(IEnumerable<Rating> ratings)
        {
            var recommendations = new List<IRecommendation>();

            recommendations.Add(new AlgorithmCache(new MemoryBasedAlgorithmCache(new PearsonCorrelation(ratings))));
            recommendations.Add(new AlgorithmCache(new MemoryBasedAlgorithmCache(new DefaultVoting(ratings, Rating.DefaultValue))));
            recommendations.Add(new AlgorithmCache(new MemoryBasedAlgorithmCache(new InverseFrequency(ratings))));
            recommendations.Add(new AlgorithmCache(new MemoryBasedAlgorithmCache(new VectorSimilarity(ratings))));
            recommendations.Add(new AlgorithmCache(new MemoryBasedAlgorithmCache(new CaseAmplification(ratings, new DefaultVoting(ratings, Rating.DefaultValue)))));
            recommendations.Add(new AlgorithmCache(new MemoryBasedAlgorithmCache(new CaseAmplification(ratings, new InverseFrequency(ratings)))));
            recommendations.Add(new AlgorithmCache(new MemoryBasedAlgorithmCache(new CaseAmplification(ratings, new PearsonCorrelation(ratings)))));
            recommendations.Add(new AlgorithmCache(new MemoryBasedAlgorithmCache(new CaseAmplification(ratings, new VectorSimilarity(ratings)))));
            recommendations.Add(new BayesianAlgorithm(ratings));

            return recommendations;
        }
    }
}
