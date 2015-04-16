using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CollaborativeFiltering
{
    public class User
    {
        private readonly ConcurrentDictionary<int, Rating> _ratings; 

        public int Id { get; private set; }

        public string FullName { get; private set; }

        public IEnumerable<Rating> Ratings { get { return _ratings.Values; } }

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
            _ratings = new ConcurrentDictionary<int, Rating>();
        }

        public void AddRating(Rating rating)
        {
            if(_ratings.ContainsKey(rating.Movie.Id))
                throw new InvalidOperationException("User alread voted for this movie");

            _ratings[rating.Movie.Id] = rating;
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
