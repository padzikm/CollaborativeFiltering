using CollaborativeFiltering;
using CollaborativeFilteringUI.Core;
using StructureMap;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollaborativeFilteringUI.Views.Recommend
{
    public class RecommendViewModel : BaseViewModel, IRecommendViewModel
    {
        public RecommendViewModel(IRecommendView view, IContainer container)
            : base(view, container)
        {
            var dataRepository = Container.GetInstance<IDataRepository>();
            Users = new ObservableCollection<User>(dataRepository.Users);
            RecommendedMovies = new ObservableCollection<Tuple<Movie,double>>();
            movies = new List<Movie>(dataRepository.Movies);

            SelectedUser = Users.FirstOrDefault();

            var recProvider = Container.GetInstance<IRecommendationsProvider>();
            Recommendations = new ObservableCollection<IRecommendation>(recProvider.GetRecommendations(dataRepository.Ratings));

            SelectedMethod = Recommendations.FirstOrDefault();

            RecommendMovie = new DelegateAsyncCommand<object>(OnRecommendMovie, OnResponsivnesLost, OnResponsivnesGained);
        }

        private List<Movie> movies;

        public ObservableCollection<User> Users { get; set; }

        public User SelectedUser { get; set; }

        public ObservableCollection<IRecommendation> Recommendations { get; set; }

        public IRecommendation SelectedMethod { get; set; }

        public ICommand RecommendMovie { get; set; }

        public ObservableCollection<Tuple<Movie,double>> RecommendedMovies { get; set; }

        private void OnRecommendMovie(object obj)
        {
            Movie recommendedMovie = null;

            ConcurrentBag<Tuple<Movie, double>> results = new ConcurrentBag<Tuple<Movie, double>>();

            Parallel.ForEach(movies, m =>
                {
                    try
                    {
                        var rating = SelectedMethod.RecommendSubject(SelectedUser, m);
                        var recValue = rating != null ? rating.Value : -1;
                        results.Add(new Tuple<Movie, double>(m, recValue));
                    }
                    catch (Exception)
                    {

                    }
                });

            var max = results.Max(t => t.Item2);
            RecommendedMovies = new ObservableCollection<Tuple<Movie,double>>(results.OrderBy(t => t.Item2).Reverse().Take(10));
        }

    }
}
