using Ntier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier.DAL.Data
{
    public class CategoriesData
    {
        public static List<Categories> GetCategories()
        {
          return new List<Categories>();
            new Categories { CategoryName}
        }

    }
}


//////public static List<Movie> GetMovies()
//////{

//////    return new List<Movie>
//////            {

//////                new Movie {ID=1,Title="Movie 1",Description="Description 1"},
//////                new Movie {ID=2,Title="Movie 2",Description="Description 2"},
//////                new Movie {ID=3,Title="Movie 3",Description="Description 3"},

//////            };
//////}