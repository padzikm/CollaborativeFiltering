using System;

namespace CollaborativeFiltering
{
    public class Movie
    {
        public int Id { get; private set; }

        public string Title { get; private set; }

        public int Year { get; private set; }

        public Movie(int id, string title, int year)
        {
            if(id <= 0)
                throw new ArgumentException("Id must be greater than zero");
            if(string.IsNullOrEmpty(title))
                throw new ArgumentException("Title cannot be null or empty");
            if (year <= 0)
                throw new ArgumentException("Year must be greater than zero");

            Id = id;
            Title = title;
            Year = year;
        }

        public override string ToString()
        {
            return Title + " (" + Year.ToString() + ")";
        }
    }
}
