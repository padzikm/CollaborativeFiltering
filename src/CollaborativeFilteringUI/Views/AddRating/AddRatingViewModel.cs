using CollaborativeFilteringUI.Core;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFilteringUI.Views.AddRating
{
    public class AddRatingViewModel : BaseViewModel, IAddRatingViewModel
    {
        public AddRatingViewModel(IAddRatingView view, IContainer container)
            : base(view, container)
        {

        }
    }
}
