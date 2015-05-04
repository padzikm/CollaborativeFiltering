using CollaborativeFilteringUI.Core;
using CollaborativeFilteringUI.Core.Utils;
using CollaborativeFilteringUI.Utils;
using Microsoft.Win32;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CollaborativeFilteringUI.Views.LoadResults
{
    public class LoadResultsViewModel : BaseViewModel, ILoadResultsViewModel
    {
        public LoadResultsViewModel(ILoadResultsView view, IContainer container)
            : base(view, container)
        {
            LoadResultsCommand = new DelegateAsyncCommand<object>(OnLoad, OnResponsivnesLost, OnResponsivnesGained);
        }

        public string MethodName { get; set; }

        public ObservableCollection<Pair<string, double>> Results { get; set; }

        public bool ResultsLoaded { get; set; }

        public ICommand LoadResultsCommand { get; set; }

        private void OnLoad(object obj)
        {
            var filePath = FindFile("Wczytaj wyniki");

            if (filePath == String.Empty)
            {
                MessageBox.Show("Problem z wczytywaniem", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var resultsPersister = new ResultsPersister();

            try
            {
                List<Pair<string, double>> results;
                string methodName;
                resultsPersister.LoadResults(filePath, out results, out methodName);

                Results = new ObservableCollection<Pair<string, double>>(results);
                MethodName = methodName;
                ResultsLoaded = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Problem z wczytywaniem", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private string FindFile(string windowTitle)
        {
            var dialog = new OpenFileDialog();
            dialog.DefaultExt = ".txt";
            dialog.CheckFileExists = false;
            dialog.Filter = "Text files (*.txt)|*.txt";
            dialog.Title = windowTitle;
            var result = dialog.ShowDialog();

            if (result != true)
                return string.Empty;

            return dialog.FileName;
        }
    }
}
