using System;

namespace CollaborativeFiltering
{
    public class Rating : IRating
    {
        public static readonly double MinValue = 1;

        public static readonly double MaxValue = 5;

        public static readonly double DefaultValue = 3;

        public IRater Rater { get { return User; } }

        public User User { get; private set; }

        public ISubject Subject { get { return Movie; } }

        public Movie Movie { get; private set; }

        public double Value { get; private set; }

        internal Rating(User user, Movie movie, double value)
        {
            if (user == null)
                throw new ArgumentNullException("user");
            if(movie == null)
                throw new ArgumentNullException("movie");
            if(value < MinValue)
                throw new ArgumentException("Value must be greater than or equal" + MinValue);
            if (value > MaxValue)
                throw new ArgumentException("Value must be less than or equal" + MaxValue);

            User = user;
            Movie = movie;
            Value = value;
        }

        public static Rating CreateRating(User user, Movie movie, double value)
        {
            var rating = new Rating(user, movie, value);
            
            user.AddRating(rating);

            return rating;
        }
    }
}
