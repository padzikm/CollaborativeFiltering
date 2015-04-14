namespace CollaborativeFiltering
{
    interface IRatingHelper
    {
        Pair GetNextCommonRatings(User firstUser, User secondUser);
    }

    public class Pair
    {
        public Rating FirstRating { get; set; }

        public Rating SecondRating { get; set; }
    }
}
