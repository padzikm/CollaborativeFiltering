using CollaborativeFiltering;
using CollaborativeFilteringUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollaborativeFilteringUI.Views.AddUser
{
    public interface IAddUserViewModel : IViewModel
    {
        IDataRepository DataRepository { get; set; }

        string UserName { get; set; }

        ICommand Add { get; set; }
    }
}
