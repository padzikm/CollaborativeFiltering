using System;
using System.Collections.Generic;

namespace CollaborativeFiltering
{
    public class DefaultVoting : PearsonCorrelation
    {
        private readonly double _defaultValue;

        public DefaultVoting(IEnumerable<IRating> ratings, double defaultValue) : base(ratings)
        {
            _defaultValue = defaultValue;
        }

        protected override IRatingService GetRatingService()
        {
            return new RatingHelperDefaulter(_defaultValue);
        }

        public override string ToString()
        {
            return "Default voting";
        }
    }
}
