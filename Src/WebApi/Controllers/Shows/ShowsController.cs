using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieTicket.Respository.Models.Shows;
using MovieTicket.Respository.Repositories.Movies;
using MovieTicket.Respository.Repositories.Shows;
using MovieTicket.Respository.Repositories.Venues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers.Shows
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowsController : ControllerBase
    {
        readonly ILogger<ShowsController> log;

        private IShowRepository ShowRepository;

        private IVenueRepository venueRepository;
        private IMovieRepository movieRepository;

        public ShowsController(IShowRepository ShowRepository,
            IVenueRepository venueRepository,
            IMovieRepository movieRepository,
            ILogger<ShowsController> log)
        {
            this.ShowRepository = ShowRepository;
            this.movieRepository = movieRepository;
            this.venueRepository = venueRepository;
            this.log = log;
        }

        [HttpGet]
        public IEnumerable<ShowModel> Get()
        {
            return this.ShowRepository.GetAllShows();
        }

        [HttpGet]
        [Route("/api/[controller]/{ShowId}")]
        public ActionResult<ShowModel> Get(Guid ShowId)
        {
            var Show = this.ShowRepository.GetShowById(ShowId);
            if (Show == null)
            {
                return NoContent();
            }

            return Show;
        }

        [HttpPost]
        public ActionResult<Guid> Post(ShowModel ShowModel)
        {
            var movie = this.movieRepository.GetMovieById(ShowModel.MovieId);
            if (movie == null)
            {
                log.LogError($"The movie is not avilable.");
                return BadRequest();
            }
            var venue = this.venueRepository.GetVenueById(ShowModel.VenuId);
            if (venue == null)
            {
                log.LogError($"The venue is not avilable.");
                return BadRequest();
            }
            var newId = this.ShowRepository.CreateShow(ShowModel);
            if (newId.Equals(Guid.Empty))
            {
                log.LogError($"The venue is not empty for the given time.");
                return BadRequest();
            }
            log.LogDebug($"new Show is create with id {newId}.");
            return newId;
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            this.ShowRepository.Delete(id);
            log.LogDebug($"Show with id {id} is deleted.");
            return Ok();
        }
    }
}
