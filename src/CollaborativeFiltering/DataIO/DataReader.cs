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

            ratings = ratingsBag.ToList();
            movies = ratings.GroupBy(p => p.Movie.Id).OrderByDescending(p => p.Count()).Select(p => p.First().Movie).ToList();
            users = usersDict.Select(p => p.Value);
        }

        public void ReadDataFromFiles(string moviesFile, string trainingRatingsFile, string testRatingsFile, double percentToRead, out IEnumerable<Movie> movies, out IEnumerable<User> users, out IEnumerable<Rating> trainingRatings, out IEnumerable<Rating> testRatings)
        {
            movies = ReadMovies(moviesFile);
            var moviesById = movies.ToDictionary(m => m.Id);
            var usersById = new ConcurrentDictionary<int, User>();

            IEnumerable<Rating> allTrainingRatings;
            IEnumerable<Rating> allTestRatings;

            ReadRatings(trainingRatingsFile, percentToRead, moviesById, usersById, out allTrainingRatings);
            ReadRatings(testRatingsFile, percentToRead, moviesById, usersById, out allTestRatings);

            var allUsers = usersById.Select(u => u.Value);
            movies = allTestRatings.GroupBy(p => p.Movie.Id).OrderByDescending(p => p.Count()).Select(p => p.First().Movie).ToList();

            var usersToReturn = allUsers.OrderByDescending(u => u.Ratings.Count()).Take((int)((double)allUsers.Count() * percentToRead)).ToList();

            testRatings = allTestRatings;
            trainingRatings = allTrainingRatings;
            users = usersToReturn;
        }

        private void ReadRatings(string ratingsFile, double percentToRead, Dictionary<long,Movie> movies, ConcurrentDictionary<int, User> usersById, out IEnumerable<Rating> ratings)
        {
            String file;
            using (var stream = File.OpenText(ratingsFile))
                file = stream.ReadToEnd();

            var lines = file.Split('\n');

            var linesToRead = (int)((double)lines.Count() * percentToRead);
            var readedLines = lines.Take(linesToRead);

            var ratingsBag = new ConcurrentBag<Rating>();

            Parallel.ForEach(readedLines, line => 
            {
                var tab = line.Split(',');
                if (tab.Length != 3)
                    return;

                var movieId = int.Parse(tab[0]);
                var userId = int.Parse(tab[1]);
                var value = double.Parse(tab[2], CultureInfo.InvariantCulture);

                User user;
                if (!usersById.TryGetValue(userId, out user))
                {
                    user = new User(userId);
                    usersById[userId] = user;
                }

                var movie = movies[movieId];
                var rating = Rating.CreateRating(user, movie, value);
                ratingsBag.Add(rating);
            });

            ratings = ratingsBag.ToList();
        }
    }
}
