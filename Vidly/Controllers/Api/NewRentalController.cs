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
            Customer customer = _context.Customers.SingleOrDefault(c => c.Id == newRentalDto.CustomerId);

            if (customer == null)
            {
                return BadRequest("Invalid customer ID");
            }

            IQueryable<Movie> movies = _context
                .Movies
                .Where(m => newRentalDto
                    .MoviesId
                    .Contains(m.Id));

            foreach (Movie movie in movies)
            {
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