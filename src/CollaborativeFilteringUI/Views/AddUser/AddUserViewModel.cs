using CollaborativeFiltering;
using CollaborativeFilteringUI.Core;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollaborativeFilteringUI.Views.AddUser
{
    public class AddUserViewModel : BaseViewModel, IAddUserViewModel
    {
        public AddUserViewModel(IAddUserView view, IContainer container)
            : base(view, container)
        {
            Add = new DelegateAsyncCommand<object>(OnAdd, OnResponsivnesLost, OnResponsivnesGained);
        }

        public IDataRepository DataRepository { get; set; }

        public string  UserName { get; set; }

        public ICommand Add { get; set; }

        private void OnAdd(object obj)
        {
            var rand = new Random();
            int id = rand.Next();
            while(DataRepository.Users.Any(u => u.Id == (id = rand.Next())));

            if(UserName !=  string.Empty)
                DataRepository.Users.Add(new User(id, UserName));
            UserName = string.Empty;

            RaiseOnWindowUpdated(this, EventArgs.Empty);
        }
    }
}
