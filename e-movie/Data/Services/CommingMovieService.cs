using e_movie.Data.Base;
using e_movie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_movie.Data.Services
{
    public class CommingMovieService : EntityBaseRepository<CommingMovie>, ICommingMovieService
    {
        public CommingMovieService(AppDbContext context) : base(context)
        {

        }
    }
}
