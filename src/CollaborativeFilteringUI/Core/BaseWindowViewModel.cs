using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        }

        public IView View { get; set; }

        public IContainer Container { get; set; }

        public IWindow Window { get; set; }

        protected void ShowView<T>() where T : IViewModel
        {
            View = Container.GetInstance<T>().View;
        }
    }
}
