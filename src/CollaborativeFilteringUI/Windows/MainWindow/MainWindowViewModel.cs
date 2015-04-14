using CollaborativeFilteringUI.Core;
using CollaborativeFilteringUI.Views.GetRecommendationValue;
using CollaborativeFilteringUI.Views.LoadData;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CollaborativeFilteringUI
{
    public class MainWindowViewModel : BaseWindowViewModel, IMainWindowViewModel
    {
        public MainWindowViewModel(IMainWindow mainWindow, IContainer container)
            : base(mainWindow, container)
        {
            LoadData = new DelegateCommand<object>(OnLoadData);
            GetRecommendationValue = new DelegateCommand<object>(OnGetRecommandationValue);
            Exit = new DelegateCommand<object>(OnExit);
        }

        public ICommand LoadData { get; set; }

        public ICommand GetRecommendationValue { get; set; }

        public ICommand Exit { get; set; }

        private void OnExit(object obj)
        {
            Application.Current.Shutdown();
        }

        private void OnLoadData(object obj)
        {
            ShowView<ILoadDataViewModel>();
        }

        private void OnGetRecommandationValue(object obj)
        {
            ShowView<IGetRecommendationValueViewModel>();
        }
    }
}
