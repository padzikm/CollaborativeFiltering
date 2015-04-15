using CollaborativeFiltering;
using CollaborativeFilteringUI.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollaborativeFilteringUI.Views.AddRating
{
    public interface IAddRatingViewModel : IViewModel
    {
        ObservableCollection<User> Users { get; set; }

        User SelectedUser { get; set; }

        ObservableCollection<Movie> Movies { get; set; }

        Movie SelectedMovie { get; set; }

        string RatingValue { get; set; }

        ICommand Add { get; set; }
    }
}
