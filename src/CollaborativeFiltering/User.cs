using System;
using System.Collections.Generic;

namespace CollaborativeFiltering
{
    public class User
    {
        private readonly List<Rating> _ratings; 

        public int Id { get; private set; }

        public string FullName { get; private set; }

        public IEnumerable<Rating> Ratings { get { return _ratings; } }

        public User(int id) : this(id, id.ToString())
        {}

        public User(int id, string fullName)
        {
            if(id <= 0)
                throw new ArgumentException("Id must be greater than zero");
            if(string.IsNullOrEmpty(fullName))
                throw new ArgumentException("FullName cannot be null or empty");

            Id = id;
            FullName = fullName;
            _ratings = new List<Rating>();
        }

        public void AddRating(Rating rating)
        {
            if(_ratings.Find(p => p.Movie.Id == rating.Movie.Id) != null)
                throw new InvalidOperationException("User alread voted for this movie");

            _ratings.Add(rating);
        }
    }
}
