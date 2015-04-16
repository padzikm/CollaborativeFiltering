using CollaborativeFiltering;
using CollaborativeFilteringUI.Core;
using Microsoft.Win32;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CollaborativeFilteringUI.Views.LoadData
{
    public class LoadDataViewModel : BaseViewModel, ILoadDataViewModel
    {
        public LoadDataViewModel(ILoadDataView view, IContainer container)
            : base(view, container)
        {
            FindMoviesFile = new DelegateCommand<object>(OnFindMoviesFile);
            FindRatingsFile = new DelegateCommand<object>(OnFindRatingsFile);
            LoadFiles = new DelegateAsyncCommand<object>(OnLoadFiles, OnResponsivnesLost, OnResponsivnesGained);
        }

        public string MoviesFilePath { get; set; }
        public string RatingsFilePath { get; set; }

        public ICommand FindMoviesFile { get; set; }

        public ICommand FindRatingsFile { get; set; }

        public ICommand LoadFiles { get; set; }

        public IDataRepository DataRepository { get; set; }

        private void OnFindMoviesFile(object obj)
        {
            MoviesFilePath = FindFile("Wczytaj filmy z pliku");
        }

        private void OnFindRatingsFile(object obj)
        {
            RatingsFilePath = FindFile("Wczytaj oceny z pliku");
        }

        private string FindFile(string windowTitle)
        {
            var dialog = new OpenFileDialog();
            dialog.DefaultExt = ".txt";
            dialog.Filter = "Text files (*.txt)|*.txt";
            dialog.Title = windowTitle;
            var result = dialog.ShowDialog();

            if (result != true)
                return string.Empty;

            return dialog.FileName;
        }

        private void OnLoadFiles(object obj)
        {
            IEnumerable<User> users;
            IEnumerable<Movie> movies;
            IEnumerable<Rating> ratings;
            var dataReader = new DataReader();

            try
            {
                dataReader.ReadDataFromFiles(MoviesFilePath, RatingsFilePath, out movies, out users, out ratings);
                DataRepository.Users.AddRange(users);
                DataRepository.Movies.AddRange(movies);
                DataRepository.Ratings.AddRange(ratings);
            }
            catch(Exception)
            {
                MessageBox.Show("Błąd w trakcie wczytywania danych", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
