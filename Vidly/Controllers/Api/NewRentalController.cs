using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRentalDto)
        {
            if (newRentalDto.MoviesId.Any())
            {
                return BadRequest("No movie Ids have been given");
            }

            Customer customer = _context.Customers.SingleOrDefault(c => c.Id == newRentalDto.CustomerId);

            if (customer == null)
            {
                return BadRequest("Invalid customer ID");
            }


            List<Movie> movies = _context
                .Movies
                .Where(m => newRentalDto
                    .MoviesId
                    .Contains(m.Id)).ToList();

            if (movies.Count != newRentalDto.MoviesId.Count)
            {
                return BadRequest("One or more movieIds are invalid");
            }

            foreach (Movie movie in movies)
            {
                if (movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie is not available");
                }

                movie.NumberAvailable--;

                Rental rental = new Rental()
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now,
                };
                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}