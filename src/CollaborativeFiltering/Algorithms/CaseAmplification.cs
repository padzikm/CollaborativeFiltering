using System;
using System.Collections.Generic;

namespace CollaborativeFiltering
{
    public class CaseAmplification : MemoryBasedAlgorithm
    {
        private const double Ro = 2.5;
        private readonly MemoryBasedAlgorithm _algorithm;

        public CaseAmplification(IEnumerable<Rating> ratings, MemoryBasedAlgorithm algorithm) : base(ratings)
        {
            _algorithm = algorithm;
        }

        internal override double Weight(User baseUser, User neighbour)
        {
            var weight = _algorithm.Weight(baseUser, neighbour);

            if (weight >= 0)
                return Math.Pow(weight, Ro);
 
            return -Math.Pow(-weight, Ro);
        }

        public override string ToString()
        {
            return _algorithm.ToString() + " with Case Amplification";
        }
    }
}
