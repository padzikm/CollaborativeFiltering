using CollaborativeFiltering;
using CollaborativeFilteringUI.Core;
using CollaborativeFilteringUI.Views.AddMovie;
using CollaborativeFilteringUI.Views.AddRating;
using CollaborativeFilteringUI.Views.AddUser;
using CollaborativeFilteringUI.Views.Evaluate;
using CollaborativeFilteringUI.Views.GetRecommendationValue;
using CollaborativeFilteringUI.Views.LoadData;
using CollaborativeFilteringUI.Views.Recommend;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CollaborativeFilteringUI
{
    public class MainWindowViewModel : BaseWindowViewModel, IMainWindowViewModel
    {
        public MainWindowViewModel(IMainWindow mainWindow, IContainer container)
            : base(mainWindow, container)
        {
            LoadData = new DelegateCommand<object>(OnLoadData);
            GetRecommendationValue = new DelegateCommand<object>(OnGetRecommandationValue);
            Exit = new DelegateCommand<object>(OnExit);
            AddUser = new DelegateCommand<object>(OnAddUser);
            AddMovie = new DelegateCommand<object>(OnAddMovie);
            AddRating = new DelegateCommand<object>(OnAddRating);
            Recommend = new DelegateCommand<object>(OnRecommend);
            ClearData = new DelegateAsyncCommand<object>(OnClearData);
            Evaluate = new DelegateCommand<object>(OnEvaluate);
            RefreshDataInfo();
        }

        public ICommand LoadData { get; set; }

        public ICommand GetRecommendationValue { get; set; }

        public ICommand Exit { get; set; }

        public ICommand AddUser { get; set; }

        public ICommand AddMovie { get; set; }

        public ICommand AddRating { get; set; }

        public ICommand Recommend { get; set; }

        public ICommand ClearData { get; set; }

        public ICommand Evaluate { get; set; }

        public int UsersCount { get; set; }

        public int MoviesCount { get; set; }

        public int TestRatingsCount { get; set; }

        public int TrainingRatingsCount { get; set; }

        private void OnExit(object obj)
        {
            Application.Current.MainWindow.Close();
        }

        private void OnLoadData(object obj)
        {
            ShowView<ILoadDataViewModel>();
        }

        private void OnGetRecommandationValue(object obj)
        {
            ShowView<IGetRecommendationValueViewModel>();
        }

        private void OnAddUser(object obj)
        {
            ShowView<IAddUserViewModel>();
        }

        private void OnAddMovie(object obj)
        {
            ShowView<IAddMovieViewModel>();
        }

        private void OnAddRating(object obj)
        {
            ShowView<IAddRatingViewModel>();
        }

        private void OnRecommend(object obj)
        {
            ShowView<IRecommendViewModel>();
        }

        private void OnEvaluate(object obj)
        {
            ShowView<IEvaluateViewModel>();
        }

        private void OnClearData(object obj)
        {
            var dataRepository = Container.GetInstance<IDataRepository>();
            dataRepository.Users.Clear();
            dataRepository.Movies.Clear();
            dataRepository.TrainingRatings.Clear();
            dataRepository.TestRatings.Clear();
            UsersCount = dataRepository.Users.Count;
            MoviesCount = dataRepository.Movies.Count;
            TrainingRatingsCount = dataRepository.TrainingRatings.Count;
            TestRatingsCount = dataRepository.TestRatings.Count;
        }

        override protected void ViewModelOnWindowUpdated(object sender, EventArgs e)
        {
            RefreshDataInfo();
        }

        private void RefreshDataInfo()
        {
            var dataRepository = Container.GetInstance<IDataRepository>();
            UsersCount = dataRepository.Users.Count;
            MoviesCount = dataRepository.Movies.Count;
            TrainingRatingsCount = dataRepository.TrainingRatings.Count;
            TestRatingsCount = dataRepository.TestRatings.Count;
        }

        
    }
}
