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
            var text = null as string;
            var moviesDict = movies.ToDictionary(p => p.Id);
            var usersDict = new Dictionary<int, User>();

            using (var stream = File.OpenText(ratingsPath))
                text = stream.ReadToEnd();

            var lines = text.Split('\n');

            foreach (var line in lines)
            {
                var tab = line.Split(',');

                if(tab == null || tab.Length != 3)
                    continue;

                var movieId = int.Parse(tab[0]);
                var userId = int.Parse(tab[1]);
                var value = double.Parse(tab[2], CultureInfo.InvariantCulture);

                var user = null as User;

                if (!usersDict.TryGetValue(userId, out user))
                {
                    user = new User(userId);
                    usersDict.Add(userId, user);
                    users.Add(user);
                }

                var movie = moviesDict[movieId];

                var rating = Rating.CreateRating(user, movie, value);

                ratings.Add(rating);
            }
        }
    }
}
