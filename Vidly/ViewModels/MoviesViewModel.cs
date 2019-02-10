using System.Collections;
using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MoviesViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
    }
}