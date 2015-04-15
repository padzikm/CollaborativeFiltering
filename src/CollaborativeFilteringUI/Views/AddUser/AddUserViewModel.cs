using CollaborativeFilteringUI.Core;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFilteringUI.Views.AddUser
{
    public class AddUserViewModel : BaseViewModel, IAddUserViewModel
    {
        public AddUserViewModel(IAddUserView view, IContainer container)
            : base(view, container)
        {

        }
    }
}
