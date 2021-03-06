﻿using CollaborativeFiltering;
using CollaborativeFilteringUI.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollaborativeFilteringUI.Views.GetRecommendationValue
{
    public interface IGetRecommendationValueViewModel : IViewModel
    {
        ObservableCollection<User> Users { get; set; }

        User SelectedUser { get; set; }

        ObservableCollection<Movie> RatedMovies { get; set; }

        ObservableCollection<Movie> UnratedMovies { get; set; }

        Movie SelectedMovie { get; set; }

        ObservableCollection<IRecommendation> Recommendations { get; set; }

        IRecommendation SelectedMethod { get; set; }

        IRating RecommendationValue { get; set; }

        ICommand GetRecommendationValue { get; set; }

        ICommand SelectedUserChangedCommand { get; set; }
    }
}
