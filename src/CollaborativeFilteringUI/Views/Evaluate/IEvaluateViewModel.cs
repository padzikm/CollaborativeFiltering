using CollaborativeFiltering;
using CollaborativeFiltering.Evaluations;
using CollaborativeFilteringUI.Core;
using CollaborativeFilteringUI.Core.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollaborativeFilteringUI.Views.Evaluate
{
    public interface IEvaluateViewModel : IViewModel
    {
        ObservableCollection<IEvaluator> Evaluators { get; set; }

        IEvaluator SelectedEvaluator { get; set; }

        ObservableCollection<Pair<IRecommendation, bool>> RecommendationsToCompare { get; set; }

        ICommand EvaluateCommand { get; set; }

        ICommand SaveCommand { get; set; }

        bool ShowResults { get; set; }

        ObservableCollection<Pair<string, double>> EvaluationResults { get; set; }
    }
}
