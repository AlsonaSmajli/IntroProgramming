﻿using e_movie.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_movie.Models
{
    public class Producer: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile picture is required!")]
        
        public string ProfilePictureURL { get; set; }

        [Display(Name = "FullName")]
        [Required(ErrorMessage = "FullName is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "FullName must be between 3 and 50 chars")]
        public string FullName { get; set; }
        

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required!")]
        public string Bio { get; set; }

        //Realitonships
        public List<Movie> Movies { get; set; }
    }
}
