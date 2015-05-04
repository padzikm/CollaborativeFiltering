using CollaborativeFiltering;
using CollaborativeFiltering.Evaluations;
using CollaborativeFilteringUI.Views.AddMovie;
using CollaborativeFilteringUI.Views.AddRating;
using CollaborativeFilteringUI.Views.AddUser;
using CollaborativeFilteringUI.Views.Evaluate;
using CollaborativeFilteringUI.Views.GetRecommendationValue;
using CollaborativeFilteringUI.Views.LoadData;
using CollaborativeFilteringUI.Views.LoadResults;
using CollaborativeFilteringUI.Views.Recommend;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFilteringUI
{
    public static class Bootstrapper
    {
        public static void Initialize()
        {
            ObjectFactory.Initialize(OnInitialize);
        }

        private static void OnInitialize(IInitializationExpression x)
        {
            x.For<IMainWindow>().Singleton().Use<MainWindow>();
            x.For<IMainWindowViewModel>().Singleton().Use<MainWindowViewModel>();

            x.For<ILoadDataView>().Use<LoadDataView>();
            x.For<ILoadDataViewModel>().Use<LoadDataViewModel>();

            x.For<IGetRecommendationValueView>().Use<GetRecommendationValueView>();
            x.For<IGetRecommendationValueViewModel>().Use<GetRecommendationValueViewModel>();

            x.For<IAddUserView>().Use<AddUserView>();
            x.For<IAddUserViewModel>().Use<AddUserViewModel>();

            x.For<IAddMovieView>().Use<AddMovieView>();
            x.For<IAddMovieViewModel>().Use<AddMovieViewModel>();

            x.For<IAddRatingView>().Use<AddRatingView>();
            x.For<IAddRatingViewModel>().Use<AddRatingViewModel>();

            x.For<IRecommendView>().Use<RecommendView>();
            x.For<IRecommendViewModel>().Use<RecommendViewModel>();

            x.For<IEvaluateView>().Use<EvaluateView>();
            x.For<IEvaluateViewModel>().Use<EvaluateViewModel>();

            x.For<ILoadResultsView>().Use<LoadResultsView>();
            x.For<ILoadResultsViewModel>().Use<LoadResultsViewModel>();

            x.For<IDataRepository>().Singleton().Use<InMemoryDataRepository>();
            x.Policies.SetAllProperties(y => y.OfType<IDataRepository>());

            x.For<IRecommendationsProvider>().Use<RecommendationsProvider>();

            x.For<IEvaluatorsProvider>().Singleton().Use<EvaluatorsProvider>();
        }
    }
}
