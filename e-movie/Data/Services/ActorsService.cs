using e_movie.Data.Base;
using e_movie.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_movie.Data.Services
{
    public class ActorsService : EntityBaseRepository <Actor>,IActorsService
    {

        public ActorsService(AppDbContext context) : base(context) { }
       
       
    }
}
