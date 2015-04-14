using StructureMap;

namespace CollaborativeFilteringUI.Core
{
    public class BaseViewModel : BaseNotification, IViewModel
    {
        public BaseViewModel(IView view, IContainer container)
        {
            View = view;
            view.DataContext = this;
            Container = container;
        }

        public IView View { get; set; }

        public IContainer Container { get; set; }
    }
}
