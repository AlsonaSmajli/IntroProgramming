using e_movie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_movie.Data.ViewModels
{
    public class NewMovieDropdownsVM
    {

        public NewMovieDropdownsVM()
        {
            Producers = new List<Producer>();
            Cinemas = new List<Cinema>();
            Actors = new List<Actor>();
        }

        public List<Producer> Producers { get; set; }
        public List<Cinema> Cinemas { get; set; }
        public List<Actor> Actors { get; set; }

    }
}
