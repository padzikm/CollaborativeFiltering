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
using System.Windows;
using System.Windows.Input;

namespace CollaborativeFilteringUI.Views.AddRating
{
    public class AddRatingViewModel : BaseViewModel, IAddRatingViewModel
    {
        public AddRatingViewModel(IAddRatingView view, IContainer container)
            : base(view, container)
        {
            Users = new ObservableCollection<User>();
            Movies = new ObservableCollection<Movie>();
            Add = new DelegateAsyncCommand<object>(OnAdd, OnResponsivnesLost, OnResponsivnesGained);
            SelectedUserChangedCommand = new DelegateAsyncCommand<object>(OnSelectedUserChanged, OnResponsivnesLost, OnResponsivnesGained);
            RatingValue = 3.0;

            Task.Run(() =>
            {
                var dataRepository = Container.GetInstance<IDataRepository>();
                Users = new ObservableCollection<User>(dataRepository.Users);
                SelectedUser = Users.FirstOrDefault();
                SelectedMovie = Movies.FirstOrDefault();
            });
        }

        public ObservableCollection<User> Users { get; set; }

        public User SelectedUser { get; set; }

        public ObservableCollection<Movie> Movies { get; set; }

        public Movie SelectedMovie { get; set; }

        public double RatingValue { get; set; }

        public ICommand Add { get; set; }

        public ICommand SelectedUserChangedCommand { get; set; }

        private void OnAdd(object obj)
        {
            var dataRepository = Container.GetInstance<IDataRepository>();

            if (dataRepository.TrainingRatings.Any(r => r.User == SelectedUser && r.Movie == SelectedMovie))
            {
                MessageBox.Show("Taka ocena jest już w bazie", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                RatingValue = 3.0;
                return;
            }

            dataRepository.TrainingRatings.Add(Rating.CreateRating(SelectedUser, SelectedMovie, RatingValue));
            RatingValue = 3.0;

            RaiseOnWindowUpdated(this, EventArgs.Empty);
        }

        private void OnSelectedUserChanged(object obj)
        {
            Movies = null;
            OnResponsivnesLost(this, EventArgs.Empty);
            var dataRepository = Container.GetInstance<IDataRepository>();
            var userMovies = dataRepository.TrainingRatings.Where(r => r.User == SelectedUser).Select(r => r.Movie);
            var ratedMovies = new ObservableCollection<Movie>(userMovies);

            var unratedMovies = new ConcurrentBag<Movie>();
            Parallel.ForEach(dataRepository.Movies, movie =>
            {
                if (!userMovies.Contains(movie))
                    unratedMovies.Add(movie);
            });

            Movies = new ObservableCollection<Movie>(unratedMovies);
            OnResponsivnesGained(this, EventArgs.Empty);
        }
    }
}
