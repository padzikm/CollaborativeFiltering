using StructureMap;
using System;

namespace CollaborativeFilteringUI.Core
{
    public class BaseViewModel : BaseNotification, IViewModel
    {
        public BaseViewModel(IView view, IContainer container)
        {
            View = view;
            view.DataContext = this;
            Container = container;
            IsResponsive = true;
        }

        public IView View { get; set; }

        public IContainer Container { get; set; }

        public bool IsResponsive { get; set; }

        protected void OnResponsivnesLost(object sender, EventArgs e)
        {
            IsResponsive = false;
        }

        protected void OnResponsivnesGained(object sender, EventArgs e)
        {
            IsResponsive = true;
        }
    }
}
