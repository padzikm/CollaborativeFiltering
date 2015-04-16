using System.Collections.Generic;

namespace CollaborativeFiltering
{
    public interface IRater
    {
        long Id { get; }

        IEnumerable<IRating> Ratings { get; } 
    }
}
