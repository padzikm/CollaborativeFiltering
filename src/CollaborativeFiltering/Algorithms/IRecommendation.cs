using System.Collections.Generic;
using System.Linq;

namespace CollaborativeFiltering
{
    public interface IRecommendation
    {
        double RecommendMovieForUser(User user, Movie movie);

        IEnumerable<Rating> RecommendMoviesForUser(User user, IEnumerable<Movie> movies, int take = -1, int skip = 0);

        void AddRating(Rating rating);
    }
}
