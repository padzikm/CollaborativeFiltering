using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFiltering
{
    public interface IDataRepository
    {
        List<User> Users { get; set; }

        List<Movie> Movies { get; set; }

        List<Rating> Ratings { get; set; }
    }
}
