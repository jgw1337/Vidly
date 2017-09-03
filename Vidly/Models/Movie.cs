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

        [Required]
        public String Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public byte GenreTypeId { get; set; }
        public GenreType GenreType { get; set; }


        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }
    }
}