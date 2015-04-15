using CollaborativeFiltering;
using CollaborativeFilteringUI.Core;
using StructureMap;
using System;
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
            movies = new List<Movie>(dataRepository.Movies);

            SelectedUser = Users.FirstOrDefault();

            var recProvider = Container.GetInstance<IRecommendationsProvider>();
            Recommendations = new ObservableCollection<IRecommendation>(recProvider.GetRecommendations(dataRepository.Ratings));

            SelectedMethod = Recommendations.FirstOrDefault();

            RecommendMovie = new DelegateCommand<object>(OnRecommendMovie);
        }

        private List<Movie> movies;

        public ObservableCollection<User> Users { get; set; }

        public User SelectedUser { get; set; }

        public ObservableCollection<IRecommendation> Recommendations { get; set; }

        public IRecommendation SelectedMethod { get; set; }

        public ICommand RecommendMovie { get; set; }

        public Movie RecommendedMovie { get; set; }

        private void OnRecommendMovie(object obj)
        {
            double maxRecommendation = double.MinValue;
            Movie recommendedMovie = null;

            foreach(var m in movies)
            {
                try
                {
                    var recValue = SelectedMethod.RecommendationValue(SelectedUser, m);
                    if (recValue > maxRecommendation)
                    {
                        maxRecommendation = recValue;
                        recommendedMovie = m;
                    }
                }
                catch(Exception)
                {

                }
            }

            RecommendedMovie = recommendedMovie;
        }

    }
}
