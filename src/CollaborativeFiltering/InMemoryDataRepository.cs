using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFiltering
{
    public class InMemoryDataRepository : IDataRepository
    {
        public InMemoryDataRepository()
        {
            Users = new List<User>();
            Movies = new List<Movie>();
            Ratings = new List<Rating>();
        }

        public List<User> Users { get; set; }

        public List<Movie> Movies { get; set; }

        public List<Rating> Ratings { get; set; }
    }
}
