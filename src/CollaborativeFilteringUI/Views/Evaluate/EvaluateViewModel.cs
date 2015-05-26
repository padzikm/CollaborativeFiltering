using CollaborativeFiltering;
using CollaborativeFiltering.Evaluations;
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

namespace CollaborativeFilteringUI.Views.Evaluate
{
    public class EvaluateViewModel : BaseViewModel, IEvaluateViewModel
    {
        public EvaluateViewModel(IEvaluateView view, IContainer container)
            : base(view, container)
        {
            EvaluateCommand = new DelegateAsyncCommand<object>(OnEvaluate, OnResponsivnesLost, OnResponsivnesGained);
            SaveCommand = new DelegateAsyncCommand<object>(OnSave, OnResponsivnesLost, OnResponsivnesGained);
            ShowResults = false;
            EvaluationResults = new ObservableCollection<Pair<string, double>>();

            Task.Run(() =>
                {
                    IsResponsive = false;
                    var evaluatorsProvider = Container.GetInstance<IEvaluatorsProvider>();
                    Evaluators = new ObservableCollection<IEvaluator>(evaluatorsProvider.GetEvaluators());
                    SelectedEvaluator = Evaluators.FirstOrDefault();

                    var dataRepository = Container.GetInstance<IDataRepository>();
                    var recommendationsProvider = Container.GetInstance<IRecommendationsProvider>();
                    var recommendations = recommendationsProvider.GetRecommendations(dataRepository.TrainingRatings);

                    RecommendationsToCompare = new ObservableCollection<Pair<IRecommendation, bool>>(recommendations.Select(r => new Pair<IRecommendation, bool>(r, false)));
                    
                    IsResponsive = true;
                });

        }

        public ObservableCollection<IEvaluator> Evaluators { get; set; }

        public IEvaluator SelectedEvaluator { get; set; }

        public ObservableCollection<Pair<IRecommendation, bool>> RecommendationsToCompare { get; set; }

        public ICommand EvaluateCommand { get; set; }

        public bool ShowResults { get; set; }

        public ICommand SaveCommand { get; set; }

        public ObservableCollection<Pair<string, double>> EvaluationResults { get; set; }

        private void OnEvaluate(object obj)
        {
            var dataRepository = Container.GetInstance<IDataRepository>();
            var rawResults = SelectedEvaluator.Evaluate(RecommendationsToCompare.Where(p => p.Item2 == true).Select(p => p.Item1), dataRepository.TestRatings, dataRepository.Users, dataRepository.Movies).OrderBy(t => t.Item2);

            App.Current.Dispatcher.Invoke(() =>
            {
                EvaluationResults.Clear();
                var maxError = rawResults.Max(r => r.Item2);
                var toAdd = new List<Pair<string, double>>(rawResults.Select(t => new Pair<string, double>(t.Item1.ToString(), t.Item2 / maxError)));
                foreach (var result in toAdd)
                    EvaluationResults.Add(result);
                ShowResults = true;
            });

        }

        private void OnSave(object obj)
        {
            var filePath = FindFile("Zapisz wyniki");

            if(filePath == String.Empty)
            {
                MessageBox.Show("Problem z zapisem", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var resultsPersister = new ResultsPersister();

            try
            {
                resultsPersister.SaveResults(EvaluationResults.ToList(), SelectedEvaluator.ToString(), filePath);
            }
            catch(Exception)
            {
                MessageBox.Show("Problem z zapisem", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
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
