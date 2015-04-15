using CollaborativeFiltering;
using CollaborativeFilteringUI.Core;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CollaborativeFilteringUI.Views.GetRecommendationValue
{
    public class GetRecommendationValueViewModel : BaseViewModel, IGetRecommendationValueViewModel
    {
        public GetRecommendationValueViewModel(IGetRecommendationValueView view, IContainer container)
            : base(view, container)
        {
            var dataRepository = Container.GetInstance<IDataRepository>();
            Users = new ObservableCollection<User>(dataRepository.Users);
            Movies = new ObservableCollection<Movie>(dataRepository.Movies);

            SelectedUser = Users.FirstOrDefault();
            SelectedMovie = Movies.FirstOrDefault();

            var recProvider = Container.GetInstance<IRecommendationsProvider>();
            Recommendations = new ObservableCollection<IRecommendation>(recProvider.GetRecommendations(dataRepository.Ratings));

            SelectedMethod = Recommendations.FirstOrDefault();

            GetRecommendationValue = new DelegateCommand<object>(OnGetRecommendationValue); //TODO: Przerobić na async
        }

        public ObservableCollection<User> Users { get; set; }

        public User SelectedUser { get; set; }

        public ObservableCollection<Movie> Movies { get; set; }

        public Movie SelectedMovie { get; set; }

        public ObservableCollection<IRecommendation> Recommendations { get; set; }

        public IRecommendation SelectedMethod { get; set; }

        public double RecommendationValue { get; set; }

        public ICommand GetRecommendationValue { get; set; }

        private void OnGetRecommendationValue(object obj)
        {
            try
            {
                RecommendationValue = SelectedMethod.RecommendationValue(SelectedUser, SelectedMovie);
            }
            catch(Exception e)
            {
                MessageBox.Show("Problem z wyznaczeniem wartości rekomendacji", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
