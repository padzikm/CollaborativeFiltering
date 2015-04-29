using CollaborativeFilteringUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFilteringUI
{
    public interface IMainWindowViewModel : IWindowViewModel
    {
        int UsersCount { get; set; }

        int MoviesCount { get; set; }

        int TestRatingsCount { get; set; }

        int TrainingRatingsCount { get; set; }
    }
}
