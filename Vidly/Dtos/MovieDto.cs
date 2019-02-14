using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required] public string Name { get; set; }

        [Required] public byte GenreId { get; set; }

        public Genre Genre { get; set; }

        [Required] [Range(1, 20)] public int NumberInStock { get; set; }

        [Required] public DateTime ReleaseDate { get; set; }

        [Required] public DateTime DateAdded { get; set; }
    }
}