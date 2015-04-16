using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CollaborativeFiltering
{
    public class DataReader
    {
        public IEnumerable<Movie> ReadMovies(string path)
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

        public void ReadDataFromFiles(string moviesPath, string ratingsPath, out IEnumerable<Movie> movies, out IEnumerable<User> users, out IEnumerable<Rating> ratings)
        {
            movies = ReadMovies(moviesPath);
            var ratingsBag = new ConcurrentBag<Rating>();
            var text = null as string;
            var moviesDict = movies.ToDictionary(p => p.Id);
            var usersDict = new ConcurrentDictionary<int, User>();

            using (var stream = File.OpenText(ratingsPath))
                text = stream.ReadToEnd();

            var lines = text.Split('\n');
            var options = new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount };
            
            Parallel.ForEach(lines, options, line =>
            {
                var tab = line.Split(',');

                if (tab.Length != 3)
                    return;

                var movieId = int.Parse(tab[0]);
                var userId = int.Parse(tab[1]);
                var value = double.Parse(tab[2], CultureInfo.InvariantCulture);

                var user = null as User;

                if (!usersDict.TryGetValue(userId, out user))
                {
                    user = new User(userId);
                    usersDict[userId] = user;
                }

                var movie = moviesDict[movieId];

                var rating = Rating.CreateRating(user, movie, value);

                ratingsBag.Add(rating);
            });

            users = usersDict.Select(p => p.Value);
            ratings = ratingsBag.ToList();
        }
    }
}
