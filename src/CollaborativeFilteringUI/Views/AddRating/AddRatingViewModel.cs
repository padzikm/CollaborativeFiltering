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

namespace CollaborativeFilteringUI.Views.AddRating
{
    public class AddRatingViewModel : BaseViewModel, IAddRatingViewModel
    {
        public AddRatingViewModel(IAddRatingView view, IContainer container)
            : base(view, container)
        {
            var dataRepository = Container.GetInstance<IDataRepository>();
            Users = new ObservableCollection<User>(dataRepository.Users);
            Movies = new ObservableCollection<Movie>(dataRepository.Movies);

            SelectedUser = Users.FirstOrDefault();
            SelectedMovie = Movies.FirstOrDefault();

            Add = new DelegateCommand<object>(OnAdd);
        }

        public ObservableCollection<User> Users { get; set; }

        public User SelectedUser { get; set; }

        public ObservableCollection<Movie> Movies { get; set; }

        public Movie SelectedMovie { get; set; }

        public string RatingValue { get; set; }

        public ICommand Add { get; set; }

        private void OnAdd(object obj)
        {
            var dataRepository = Container.GetInstance<IDataRepository>();

            if (dataRepository.Ratings.Any(r => r.User == SelectedUser && r.Movie == SelectedMovie))
            { 
                MessageBox.Show("Taka ocena jest już w bazie", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                RatingValue = string.Empty;
                return;
            }

            double ratingValue;
            if (double.TryParse(RatingValue, out ratingValue))
                dataRepository.Ratings.Add(Rating.CreateRating(SelectedUser, SelectedMovie, ratingValue));

            RatingValue = string.Empty;
        }
    }
}
