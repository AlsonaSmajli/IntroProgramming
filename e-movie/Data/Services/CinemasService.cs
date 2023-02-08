using e_movie.Data.Base;
using e_movie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_movie.Data.Services
{
    public class CinemasService :  EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context): base(context)
        {

        }
    }
}
