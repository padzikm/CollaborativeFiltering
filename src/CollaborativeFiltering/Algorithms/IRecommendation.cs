namespace CollaborativeFiltering
{
    public interface IRecommendation
    {
        double RecommendationValue(User user, Movie movie);
    }
}
