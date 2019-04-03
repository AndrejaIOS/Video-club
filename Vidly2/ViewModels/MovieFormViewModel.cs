using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly2.Models;

namespace Vidly2.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public DateTime? DateReleased { get; set; }

        [Required]
        [Range(1, 20)] 
        public int? NumberInStock { get; set; }

        [Required]
        public int? GenreId { get; set; }

        public string Title
        {
            get { return Id != 0 ? "Edit Movie" : "New Movie"; }
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            DateReleased = movie.DateReleased;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
        public MovieFormViewModel()
        {
            Id = 0;
        }

    }
}