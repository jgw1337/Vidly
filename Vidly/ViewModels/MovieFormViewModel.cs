using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        public byte GenreTypeId { get; set; }

        [Required]
        public int? NumberInStock { get; set; }

        public IEnumerable<GenreType> GenreTypes { get; set; }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            GenreTypeId = movie.GenreTypeId;
        }

        public string TitleAction
        {
            get
            {
                return (Id == 0) ? "Add New Movie" : "Edit Movie";
            }
        }
    }
}