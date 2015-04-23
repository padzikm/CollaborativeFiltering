using CollaborativeFiltering;
using CollaborativeFilteringUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollaborativeFilteringUI.Views.LoadData
{
    public interface ILoadDataViewModel : IViewModel
    {
        string MoviesFilePath { get; set; }

        string TrainingRatingsFilePath { get; set; }

        string TestRatingsFilePath { get; set; }

        double SetPercent { get; set; }

        ICommand FindMoviesFile { get; set; }

        ICommand FindTrainingRatingsFile { get; set; }

        ICommand FindTestRatingsFile { get; set; }

        ICommand LoadFiles { get; set; }

        IDataRepository DataRepository { get; set; }
    }
}
