using e_movie.Data.Base;
using e_movie.Data.ViewModels;
using e_movie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_movie.Data.Services
{
    public interface IMoviesService: IEntityBaseRepository <Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);

    }
}
