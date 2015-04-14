using CollaborativeFilteringUI.Core;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFilteringUI.Views.GetRecommendationValue
{
    public class GetRecommendationValueViewModel : BaseViewModel, IGetRecommendationValueViewModel
    {
        public GetRecommendationValueViewModel(IGetRecommendationValueView view, IContainer container)
            : base(view, container)
        {

        }

    }
}
