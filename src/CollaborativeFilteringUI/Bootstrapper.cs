using CollaborativeFiltering;
using CollaborativeFilteringUI.Views.GetRecommendationValue;
using CollaborativeFilteringUI.Views.LoadData;
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

            x.For<IDataRepository>().Singleton().Use<InMemoryDataRepository>();
            x.Policies.SetAllProperties(y => y.OfType<IDataRepository>());
        }
    }
}
