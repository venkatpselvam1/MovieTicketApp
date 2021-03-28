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
        readonly ILogger<VenuesController> _log;

        private IVenueRepository venueRepository;

        public VenuesController(IVenueRepository venueRepository, ILogger<VenuesController> log)
        {
            this.venueRepository = venueRepository;
            this._log = log;
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
            _log.LogDebug($"new venue is create with id {newId}.");
            return newId;
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            this.venueRepository.Delete(id);
            _log.LogDebug($"venue with id {id} is deleted.");
            return Ok();
        }
    }
}
