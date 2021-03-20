using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieTicket.Respository.Models.Venues;
using MovieTicket.Respository.Repositories.Venues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers.Venues
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenuesController : ControllerBase
    {
        private IVenueRepository venueRepository;

        public VenuesController(IVenueRepository venueRepository)
        {
            this.venueRepository = venueRepository;
        }

        [HttpGet]
        public IEnumerable<VenueModel> Get()
        {
            return this.venueRepository.GetAllVenue();
        }

        [HttpPost]
        public Guid Post(VenueModel venueModel)
        {
            var newId = this.venueRepository.CreateVenue(venueModel);
            return newId;
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            this.venueRepository.Delete(id);
            return Ok();
        }
    }
}
