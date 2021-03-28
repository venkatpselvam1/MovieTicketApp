using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieTicket.Respository.Models.Movies;
using MovieTicket.Respository.Repositories.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers.Movies
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        readonly ILogger<MoviesController> log;

        private IMovieRepository movieRepository;

        public MoviesController(IMovieRepository movieRepository, ILogger<MoviesController> log)
        {
            this.movieRepository = movieRepository;
            this.log = log;
        }

        [HttpGet]
        public IEnumerable<MovieModel> Get()
        {
            return this.movieRepository.GetAllMovies();
        }

        [HttpGet]
        [Route("/api/[controller]/{movieId}")]
        public ActionResult<MovieModel> Get(Guid movieId)
        {
            var movie = this.movieRepository.GetMovieById(movieId);
            if (movie == null)
            {
                return NoContent();
            }

            return movie;
        }

        [HttpPost]
        public Guid Post(MovieModel movieModel)
        {
            var newId = this.movieRepository.CreateMovie(movieModel);
            log.LogDebug($"new movie is create with id {newId}.");
            return newId;
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            this.movieRepository.Delete(id);
            log.LogDebug($"movie with id {id} is deleted.");
            return Ok();
        }
    }
}
