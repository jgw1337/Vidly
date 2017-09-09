using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        // Movie Info
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the name of the movie")]
        public String Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreTypeId { get; set; }

        public GenreType GenreType { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public int NumberInStock { get; set; }


        // Auditing Info
        public DateTime? DateAdded { get; set; }
    }
}