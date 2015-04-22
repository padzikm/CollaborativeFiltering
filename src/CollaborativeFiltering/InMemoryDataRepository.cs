using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFiltering
{
    public class InMemoryDataRepository : IDataRepository
    {
        public InMemoryDataRepository()
        {
            Users = new List<User>();
            Movies = new List<Movie>();
            TrainingRatings = new List<Rating>();
            TestRatings = new List<Rating>();
        }

        public List<User> Users { get; set; }

        public List<Movie> Movies { get; set; }

        public List<Rating> TrainingRatings { get; set; }

        public List<Rating> TestRatings { get; set; }


        public void AddDataFromFiles(string moviesFile, string trainingFile, string testFile, double setPercent)
        {
            IEnumerable<User> users;
            IEnumerable<Movie> movies;
            IEnumerable<Rating> trainingRatings;
            IEnumerable<Rating> testRatings;
            var dataReader = new DataReader();

            dataReader.ReadDataFromFiles(MoviesFilePath, TrainingRatingsFilePath, TestRatingsFilePath, SetPercent, out movies, out users, out trainingRatings, out testRatings);
            Users.AddRange(users);
            Movies.AddRange(movies);
            TrainingRatings.AddRange(trainingRatings);
            TestRatings.AddRange(testRatings);
        }
    }
}
