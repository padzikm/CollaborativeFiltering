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

        internal override decimal Weight(User baseUser, User neighbour)
        {
            var weight = (double)_algorithm.Weight(baseUser, neighbour);

            if (weight >= 0)
                return (decimal)Math.Pow(weight, Ro);
 
            return (decimal)-Math.Pow(-weight, Ro);
        }

        public override string ToString()
        {
            return _algorithm.ToString() + " with Case Amplification";
        }
    }
}
