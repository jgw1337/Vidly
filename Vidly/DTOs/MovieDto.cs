using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class MovieDto
    {
        // Movie Info
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the name of the movie")]
        public String Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public byte GenreTypeId { get; set; }

        [Required]
        [Range(1, 20)]
        public int NumberInStock { get; set; }


        // Auditing Info
        public DateTime? DateAdded { get; set; }
    }
}