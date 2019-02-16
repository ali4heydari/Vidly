using System;
using System.Collections.Generic;
using System.Web.Http;
using Vidly.Dtos;

namespace Vidly.Controllers.Api
{
    public class NewRentalController : ApiController
    {
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRentalDto)
        {
            throw new NotImplementedException();
        }
    }

}