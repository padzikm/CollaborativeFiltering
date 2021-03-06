﻿using CollaborativeFiltering;
using CollaborativeFilteringUI.Core;
using StructureMap;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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
            Users = new ObservableCollection<User>();
            RatedMovies = new ObservableCollection<Movie>();
            UnratedMovies = new ObservableCollection<Movie>();
            Recommendations = new ObservableCollection<IRecommendation>();
            GetRecommendationValue = new DelegateAsyncCommand<object>(OnGetRecommendationValue, OnResponsivnesLost, OnResponsivnesGained);
            SelectedUserChangedCommand = new DelegateAsyncCommand<object>(OnSelectedUserChanged, OnResponsivnesLost, OnResponsivnesGained);

            Task.Run(() =>
            {
                var dataRepository = Container.GetInstance<IDataRepository>();
                Users = new ObservableCollection<User>(dataRepository.Users);

                RatedMovies = new ObservableCollection<Movie>();
                UnratedMovies = new ObservableCollection<Movie>();

                SelectedUser = Users.FirstOrDefault();
                SelectedMovie = RatedMovies.FirstOrDefault();

                var recProvider = Container.GetInstance<IRecommendationsProvider>();
                Recommendations = new ObservableCollection<IRecommendation>(recProvider.GetRecommendations(dataRepository.TrainingRatings));

                SelectedMethod = Recommendations.FirstOrDefault();
            });
        }

        public ObservableCollection<User> Users { get; set; }

        public User SelectedUser { get; set; }

        private void OnSelectedUserChanged(object obj)
        {
            RatedMovies = null;
            UnratedMovies = null;

            OnResponsivnesLost(this, EventArgs.Empty);
            var dataRepository = Container.GetInstance<IDataRepository>();
            var userMovies = dataRepository.TrainingRatings.Where(r => r.User == SelectedUser).Select(r => r.Movie);
            RatedMovies = new ObservableCollection<Movie>(userMovies);

            var unratedMovies = new ConcurrentBag<Movie>();
            Parallel.ForEach(dataRepository.Movies, movie =>
            {
                if (!userMovies.Contains(movie))
                    unratedMovies.Add(movie);
            });

            UnratedMovies = new ObservableCollection<Movie>(unratedMovies);
            OnResponsivnesGained(this, EventArgs.Empty);
        }

        public ObservableCollection<Movie> RatedMovies { get; set; }

        public ObservableCollection<Movie> UnratedMovies { get; set; }

        public Movie SelectedMovie { get; set; }

        public ObservableCollection<IRecommendation> Recommendations { get; set; }

        public IRecommendation SelectedMethod { get; set; }

        public IRating RecommendationValue { get; set; }

        public ICommand GetRecommendationValue { get; set; }

        public ICommand SelectedUserChangedCommand { get; set; }

        private void OnGetRecommendationValue(object obj)
        {
            try
            {
                RecommendationValue = SelectedMethod.RecommendSubject(SelectedUser, SelectedMovie);
            }
            catch (Exception e)
            {
                MessageBox.Show("Problem z wyznaczeniem wartości rekomendacji", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
