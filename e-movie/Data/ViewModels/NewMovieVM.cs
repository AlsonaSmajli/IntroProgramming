using e_movie.Data;
using e_movie.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace e_movie.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Movie name")]
        [Required(ErrorMessage ="Name is required!")]
        public string Name { get; set; }

        [Display(Name = "Movie description")]
        [Required(ErrorMessage = "Description is required!")]
        public string Desctription { get; set; }


        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required!")]
        public double Price { get; set; }

        [Display(Name = "Movie poster URl")]
        [Required(ErrorMessage = "Movie poster URL is required!")]
        public string ImageURL { get; set; }


        [Display(Name = "Movie Start date")]
        [Required(ErrorMessage = "Start date is required!")]
        public DateTime StartDate { get; set; }


        [Display(Name = "Movie End date")]
        [Required(ErrorMessage = "End date is required!")]
        public DateTime EndDate { get; set; }


        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Movie category is required!")]
        public MovieCategory MovieCategory { get; set; }

        //Realitonships
        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is required!")]
        public List<int> ActorIds { get; set; }



        //Cinema
        [Display(Name = "Select a cinema")]
        [Required(ErrorMessage = "Movie cinema is required!")]
        public int CinemaId { get; set; }


        //Producer
        [Display(Name = "Select a producuer")]
        [Required(ErrorMessage = "Movie producer is required!")]
        public int ProducerId { get; set; }

   

    }
}
