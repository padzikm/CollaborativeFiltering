using System;
using System.Collections.Generic;

namespace CollaborativeFiltering
{
    public class DefaultVoting : PearsonCorrelation
    {
        private readonly double _defaultValue;

        public DefaultVoting(IEnumerable<Rating> ratings, double defaultValue) : base(ratings)
        {
            if(defaultValue < Rating.MinValue)
                throw new ArgumentException("Value cannot be less than " + Rating.MinValue);
            if (defaultValue > Rating.MaxValue)
                throw new ArgumentException("Value cannot be more than " + Rating.MaxValue);

            _defaultValue = defaultValue;
        }

        protected override RatingHelper GetRatingHelper()
        {
            return new RatingHelperDefaulter(_defaultValue);
        }
    }
}
