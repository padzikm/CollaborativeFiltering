using CollaborativeFilteringUI.Core;
using CollaborativeFilteringUI.Views.AddMovie;
using CollaborativeFilteringUI.Views.AddRating;
using CollaborativeFilteringUI.Views.AddUser;
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
        }

        public ICommand LoadData { get; set; }

        public ICommand GetRecommendationValue { get; set; }

        public ICommand Exit { get; set; }

        public ICommand AddUser { get; set; }

        public ICommand AddMovie { get; set; }

        public ICommand AddRating { get; set; }

        public ICommand Recommend { get; set; }

        private void OnExit(object obj)
        {
            Application.Current.Shutdown();
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

        override protected void ViewModelOnWindowUpdated(object sender, EventArgs e)
        {
            MessageBox.Show("Abc");
        }
    }
}
