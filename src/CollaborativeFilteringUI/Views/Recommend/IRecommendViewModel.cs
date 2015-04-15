using CollaborativeFiltering;
using CollaborativeFilteringUI.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollaborativeFilteringUI.Views.Recommend
{
    public interface IRecommendViewModel : IViewModel
    {
        ObservableCollection<User> Users { get; set; }

        User SelectedUser { get; set; }

        ObservableCollection<IRecommendation> Recommendations { get; set; }

        IRecommendation SelectedMethod { get; set; }

        ICommand RecommendMovie { get; set; }

        string RecommendedMovie { get; set; }
    }
}
