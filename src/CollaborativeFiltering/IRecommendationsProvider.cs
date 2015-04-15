using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFiltering
{
    public interface IRecommendationsProvider
    {
        List<IRecommendation> GetRecommendations(IEnumerable<Rating> ratings);
    }
}
