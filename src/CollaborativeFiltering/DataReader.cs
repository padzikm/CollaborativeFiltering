using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CollaborativeFiltering
{
    public class DataReader
    {
        public List<Movie> ReadMovies(string path)
        {
            var movies = new List<Movie>();

            using (var stream = File.OpenText(path))
            {
                if (stream.EndOfStream)
                    return movies;

                var line = stream.ReadLine();

                while (!stream.EndOfStream && !string.IsNullOrEmpty(line))
                {
                    var tab = line.Split(',');

                    var id = int.Parse(tab[0]);
                    var year = 0;
                    if (!int.TryParse(tab[1], out year))
                        year = 2000;
                    var title = tab[2];

                    var movie = new Movie(id, title, year);
                    movies.Add(movie);

                    line = stream.ReadLine();
                }
            }

            return movies;
        }

        public void ReadDataFromFiles(string movisPath, string ratingsPath, out List<Movie> movies, out List<User> users, out List<Rating> ratings)
        {
            movies = ReadMovies(movisPath);
            users = new List<User>();
            ratings = new List<Rating>();

            using (var stream = File.OpenText(ratingsPath))
            {
                if (stream.EndOfStream)
                    return;

                var line = stream.ReadLine();

                while (!stream.EndOfStream && !string.IsNullOrEmpty(line))
                {
                    var tab = line.Split(',');

                    var movieId = int.Parse(tab[0]);
                    var userId = int.Parse(tab[1]);
                    var value = double.Parse(tab[2], CultureInfo.InvariantCulture);

                    User user;
                    if(users.Any(u => u.Id == userId))
                        user = users.First(u => u.Id == userId);
                    else
                    {
                        user = new User(userId);
                        users.Add(user);
                    }

                    var movie = movies.First(p => p.Id == movieId);

                    var rating = Rating.CreateRating(user, movie, value);

                    ratings.Add(rating);

                    line = stream.ReadLine();
                }
            }

        }
    }
}
