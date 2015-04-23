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
            FindTrainingRatingsFile = new DelegateCommand<object>(OnFindTrainingRatingsFile);
            FindTestRatingsFile = new DelegateCommand<object>(OnFindTestRatingsFile);
            LoadFiles = new DelegateAsyncCommand<object>(OnLoadFiles, OnResponsivnesLost, OnResponsivnesGained);
            SetPercent = 1.0;
        }

        public string MoviesFilePath { get; set; }

        public string TrainingRatingsFilePath { get; set; }

        public string TestRatingsFilePath { get; set; }

        public double SetPercent { get; set; }

        public ICommand FindMoviesFile { get; set; }

        public ICommand FindTrainingRatingsFile { get; set; }

        public ICommand FindTestRatingsFile { get; set; }

        public ICommand LoadFiles { get; set; }

        public IDataRepository DataRepository { get; set; }

        private void OnFindMoviesFile(object obj)
        {
            MoviesFilePath = FindFile("Wczytaj filmy z pliku");
        }

        private void OnFindTrainingRatingsFile(object obj)
        {
            TrainingRatingsFilePath = FindFile("Wczytaj oceny treningowe z pliku");
        }

        private void OnFindTestRatingsFile(object obj)
        {
            TestRatingsFilePath = FindFile("Wczytaj oceny testowe z pliku");
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
            try
            {
                DataRepository.AddDataFromFiles(MoviesFilePath, TrainingRatingsFilePath, TestRatingsFilePath, SetPercent);
                RaiseOnWindowUpdated(this, EventArgs.Empty);
            }
            catch(Exception)
            {
                MessageBox.Show("Błąd w trakcie wczytywania danych", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
