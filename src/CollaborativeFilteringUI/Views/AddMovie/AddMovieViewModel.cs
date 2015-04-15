using CollaborativeFiltering;
using CollaborativeFilteringUI.Core;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollaborativeFilteringUI.Views.AddMovie
{
    public class AddMovieViewModel : BaseViewModel, IAddMovieViewModel
    {
        public AddMovieViewModel(IAddMovieView view, IContainer container)
            : base(view, container)
        {
            Add = new DelegateCommand<object>(OnAdd);
        }

        public IDataRepository DataRepository { get; set; }

        public string Title { get; set; }

        public string Year { get; set; }

        public ICommand Add { get; set; }

        private void OnAdd(object obj)
        {
            var rand = new Random();
            int id = rand.Next();
            while (DataRepository.Movies.Any(m => m.Id == (id = rand.Next())));

            int year;
            if (int.TryParse(Year, out year))
                DataRepository.Movies.Add(new Movie(id, Title, year));

            Year = string.Empty;
            Title = string.Empty;
        }
    }
}
