using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CollaborativeFiltering
{
    public class User : IRater
    {
        private readonly ConcurrentDictionary<long, Rating> _ratings; 

        public long Id { get; private set; }

        public string FullName { get; private set; }

        public IEnumerable<IRating> Ratings { get { return _ratings.Values; } }

        public User(long id) : this(id, id.ToString())
        {}

        public User(long id, string fullName)
        {
            if(id <= 0)
                throw new ArgumentException("Id must be greater than zero");
            if(string.IsNullOrEmpty(fullName))
                throw new ArgumentException("FullName cannot be null or empty");

            Id = id;
            FullName = fullName;
            _ratings = new ConcurrentDictionary<long, Rating>();
        }

        public void AddRating(Rating rating)
        {
            if(_ratings.ContainsKey(rating.Subject.Id))
                throw new InvalidOperationException("User alread voted for this movie");

            _ratings[rating.Subject.Id] = rating;
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
