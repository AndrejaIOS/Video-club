using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly2.Models;

namespace Vidly2.Dtos
{
    public class MovieDto
    {

        public int Id { get; set; }


        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        public DateTime DateReleased { get; set; }

        [Required]
        [Range(1, 20)] // ErrorMessage = "The field Number in stock must be between 1 and 20.")]
        public int NumberInStock { get; set; }

        [Required]
        public int GenreId { get; set; }
    }
}