using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        readonly ILogger<VenuesController> log;

        private IVenueRepository venueRepository;

        public VenuesController(IVenueRepository venueRepository, ILogger<VenuesController> log)
        {
            this.venueRepository = venueRepository;
            this.log = log;
        }

        [HttpGet]
        public IEnumerable<VenueModel> Get()
        {
            return this.venueRepository.GetAllVenue();
        }

        [HttpGet]
        [Route("/api/[controller]/{venueId}")]
        public ActionResult<VenueModel> Get(Guid venueId)
        {
            var movie = this.venueRepository.GetVenueById(venueId);
            if (movie == null)
            {
                return NoContent();
            }

            return movie;
        }

        [HttpPost]
        public Guid Post(VenueModel venueModel)
        {
            var newId = this.venueRepository.CreateVenue(venueModel);
            log.LogDebug($"new venue is create with id {newId}.");
            return newId;
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            this.venueRepository.Delete(id);
            log.LogDebug($"venue with id {id} is deleted.");
            return Ok();
        }
    }
}
