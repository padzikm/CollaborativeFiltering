using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CollaborativeFilteringUI.Core
{
    public class BaseWindowViewModel : BaseNotification, IWindowViewModel
    {
        public BaseWindowViewModel(IWindow window, IContainer container)
        {
            Window = window;
            Window.DataContext = this;
            Container = container;
            IsResponsive = true;
            IsViewChanged = false;
        }

        public IView View { get; set; }

        public IViewModel ViewModel { get; set; }

        public IContainer Container { get; set; }

        public IWindow Window { get; set; }

        public bool IsResponsive { get; set; }

        public bool IsViewChanged { get; set; }

        protected void ShowView<T>() where T : IViewModel
        {
            ViewModel = Container.GetInstance<T>();
            ViewModel.OnWindowUpdated += ViewModelOnWindowUpdated;
            ViewModel.OnWindowResponsivnesLost += ViewModelOnWindowResponsivnesLost;
            ViewModel.OnWindowResponsivnesGained += ViewModelOnWindowResponsivnesGained;
            View = ViewModel.View;
        }

        void ViewModelOnWindowResponsivnesGained(object sender, EventArgs e)
        {
            IsResponsive = true;
        }

        private void ViewModelOnWindowResponsivnesLost(object sender, EventArgs e)
        {
            IsResponsive = false;
        }

        protected virtual void ViewModelOnWindowUpdated(object sender, EventArgs e)
        {
        }
    }
}
