using CollaborativeFilteringUI.Core;
using CollaborativeFilteringUI.Core.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollaborativeFilteringUI.Views.LoadResults
{
    public interface ILoadResultsViewModel : IViewModel
    {
        string MethodName { get; set; }

        ObservableCollection<Pair<string, double>> Results { get; set; }

        bool ResultsLoaded { get; set; }

        ICommand LoadResultsCommand { get; set; }
    }
}
