using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CollaborativeFiltering;
using CollaborativeFiltering.Algorithms;
using CollaborativeFiltering.Evaluations;

namespace ConsoleTester
{
    class Program
    {
        static string _moviesPath = "movie_titles.txt";
        static string _trainRatingsPath = "TrainingRatings.txt";
        static string _testRatingPath = "TestingRatings.txt";

        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                _moviesPath = args[0];
                _trainRatingsPath = args[1];
                _testRatingPath = args[2];
            }
            else if (args.Length > 0)
            {
                Console.WriteLine("Usage: moviesPath trainingRatingsPath testingRatingsPath");
                return;
            }

            foreach (var algorithm in GetAlgorithms())
                foreach (var evaluator in GetEvaluators())
                    if (!ComputeErrorRate(evaluator, algorithm))
                    {
                        Console.WriteLine("Error occured...exiting");
                        return;
                    }

            Console.WriteLine("Completed successfully");
        }

        static List<IRecommendation> GetAlgorithms()
        {
            var reader = new DataReader();
            var movies = Enumerable.Empty<Movie>();
            var users = Enumerable.Empty<User>();
            var ratings = Enumerable.Empty<Rating>();
            var list = new List<IRecommendation>();

            reader.ReadDataFromFiles(_moviesPath, _trainRatingsPath, out movies, out users, out ratings);
            list.Add(new AlgorithmCache(new MemoryBasedAlgorithmCache(new PearsonCorrelation(ratings))));

            reader.ReadDataFromFiles(_moviesPath, _trainRatingsPath, out movies, out users, out ratings);
            list.Add(new AlgorithmCache(new MemoryBasedAlgorithmCache(new VectorSimilarity(ratings))));

            reader.ReadDataFromFiles(_moviesPath, _trainRatingsPath, out movies, out users, out ratings);
            list.Add(new AlgorithmCache(new MemoryBasedAlgorithmCache(new InverseFrequency(ratings))));

            reader.ReadDataFromFiles(_moviesPath, _trainRatingsPath, out movies, out users, out ratings);
            list.Add(new AlgorithmCache(new MemoryBasedAlgorithmCache(new DefaultVoting(ratings, Rating.DefaultValue))));

            reader.ReadDataFromFiles(_moviesPath, _trainRatingsPath, out movies, out users, out ratings);
            list.Add(new AlgorithmCache(new MemoryBasedAlgorithmCache(new CaseAmplification(ratings, new PearsonCorrelation(ratings)))));

            reader.ReadDataFromFiles(_moviesPath, _trainRatingsPath, out movies, out users, out ratings);
            list.Add(new AlgorithmCache(new MemoryBasedAlgorithmCache(new CaseAmplification(ratings, new VectorSimilarity(ratings)))));

            reader.ReadDataFromFiles(_moviesPath, _trainRatingsPath, out movies, out users, out ratings);
            list.Add(new AlgorithmCache(new MemoryBasedAlgorithmCache(new CaseAmplification(ratings, new InverseFrequency(ratings)))));

            reader.ReadDataFromFiles(_moviesPath, _trainRatingsPath, out movies, out users, out ratings);
            list.Add(new AlgorithmCache(new MemoryBasedAlgorithmCache(new CaseAmplification(ratings, new DefaultVoting(ratings, Rating.DefaultValue)))));

            reader.ReadDataFromFiles(_moviesPath, _trainRatingsPath, out movies, out users, out ratings);
            list.Add(new AlgorithmCache(new BayesianAlgorithm(ratings)));

            return list;
        }

        static List<IEvaluator> GetEvaluators()
        {
            return new List<IEvaluator>()
            {
                new MeanAbsoluteErrorEvaluator(),
                new RootMeanSquareErrorEvaluator(),
                new AvarageRaterMeanAbsoluteErrorEvaluator(),
                new TopListErrorEvaluator(new MeanAbsoluteErrorEvaluator()),
                new TopListErrorEvaluator(new RootMeanSquareErrorEvaluator()),
                new TopListErrorEvaluator(new AvarageRaterMeanAbsoluteErrorEvaluator()),
            };
        } 

        static bool ComputeErrorRate(IEvaluator evaluator, IRecommendation recommendation)
        {
            var watch = new Stopwatch();

            try
            {
                var reader = new DataReader();

                var subjects = Enumerable.Empty<Movie>();
                var raters = Enumerable.Empty<User>();
                var ratings = Enumerable.Empty<Rating>();

                reader.ReadDataFromFiles(_moviesPath, _testRatingPath, out subjects, out raters, out ratings);

                Console.WriteLine("Started: " + recommendation.ToString());

                watch.Start();

                var error = evaluator.CalculateError(recommendation, ratings, raters, subjects);

                watch.Stop();

                var algName = recommendation.ToString();

                var errorName = evaluator.MethodName;

                var text = string.Format("Algorithm: {0}\t{1}: {2}\tElapsed: {3}", algName, errorName, error,
                    watch.Elapsed);

                Console.WriteLine(text);

                using (var stream = File.AppendText("scores.txt"))
                    stream.WriteLine(text);

                return true;
            }
            catch (Exception ex)
            {
                if(watch.IsRunning)
                    watch.Stop();

                var err = string.Format("{0} \n\n {1} \n\n {2}", watch.Elapsed, ex.Message, ex.StackTrace);

                using (var stream = File.AppendText("error.txt"))
                    stream.WriteLine(err);

                var innerEx = ex.InnerException;

                while (innerEx != null)
                {
                    err = string.Format("inner: \n\n {0} \n\n {1}", innerEx.Message, innerEx.StackTrace);

                    using (var stream = File.AppendText("error.txt"))
                        stream.WriteLine(err);

                    innerEx = innerEx.InnerException;
                }

                return false;
            }
        }
    }
}
