using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollaborativeFiltering;
using System.Collections.Generic;

namespace CollaborativeFilteringTests
{
    [TestClass]
    public class DataTests
    {
        [TestMethod]
        public void Given_PathToMoviesFileAndDataReader_When_FileReaded_Then_ProperCollectionCreated()
        {
            //given
            var path = "../../../../data/movie_titles.txt";
            var dataReader = new DataReader();

            //when
            var movies = dataReader.ReadMovies(path);

            //then
            Assert.IsNotNull(movies);
        }

        [TestMethod]
        public void Given_PathsToMoviesRatingsAndDataReader_When_FilesReaded_Then_ProperCollectionsCreated()
        {
            //given
            var moviesPath = "../../../../data/movie_titles.txt";
            var ratingsPath = "../../../../data/TestingRatingsShort.txt";
            List<User> users;
            List<Movie> movies;
            List<Rating> ratings;
            var dataReader = new DataReader();

            //when
            dataReader.ReadDataFromFiles(moviesPath, ratingsPath, out movies, out users, out ratings);

            //then
            Assert.IsNotNull(users);
            Assert.IsNotNull(movies);
            Assert.IsNotNull(ratings);
        }
    }
}
