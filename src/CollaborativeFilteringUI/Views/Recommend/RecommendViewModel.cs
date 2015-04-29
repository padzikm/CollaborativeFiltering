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
            Users = new ObservableCollection<User>();
            RecommendedMovies = new ObservableCollection<IRating>();

            Task.Run(() => 
            {
                var dataRepository = Container.GetInstance<IDataRepository>();
                Users = new ObservableCollection<User>(dataRepository.Users);
                SelectedUser = Users.FirstOrDefault();

                var recProvider = Container.GetInstance<IRecommendationsProvider>();
                Recommendations = new ObservableCollection<IRecommendation>(recProvider.GetRecommendations(dataRepository.TrainingRatings));
                SelectedMethod = Recommendations.FirstOrDefault();
            });

            Recommendations = new ObservableCollection<IRecommendation>();
            RecommendMovie = new DelegateAsyncCommand<object>(OnRecommendMovie, OnResponsivnesLost, OnResponsivnesGained);
        }

        public ObservableCollection<User> Users { get; set; }

        public User SelectedUser { get; set; }

        public ObservableCollection<IRecommendation> Recommendations { get; set; }

        public IRecommendation SelectedMethod { get; set; }

        public ICommand RecommendMovie { get; set; }

        public ObservableCollection<IRating> RecommendedMovies { get; set; }

        private void OnRecommendMovie(object obj)
        {
            var dataRepository = Container.GetInstance<IDataRepository>();
            var userMovies = dataRepository.TrainingRatings.Where(r => r.User == SelectedUser).Select(r => r.Movie);

            var unratedMovies = new ConcurrentBag<Movie>();
            Parallel.ForEach(dataRepository.Movies, movie =>
            {
                if (!userMovies.Contains(movie))
                    unratedMovies.Add(movie);
            });

            var results = new ConcurrentBag<IRating>();

            Parallel.ForEach(unratedMovies, m =>
            {
                try
                {
                    var rating = SelectedMethod.RecommendSubject(SelectedUser, m);
                    if(rating != null)
                        results.Add(rating);
                }
                catch (Exception)
                {

                }
            });

            RecommendedMovies = new ObservableCollection<IRating>(results.OrderBy(r => r.Value).Reverse().Take(10));
        }

    }
}
