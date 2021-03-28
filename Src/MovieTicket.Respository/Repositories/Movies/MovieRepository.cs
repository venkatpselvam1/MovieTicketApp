using MovieTicket.Respository.Models.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Respository.Repositories.Movies
{
    public class MovieRepository : IMovieRepository
    {
        private List<MovieModel> movies;
        public MovieRepository()
        {
            movies = new List<MovieModel>();
            movies.Add(new MovieModel() { Id = Guid.NewGuid(), Name = "Movie 1", Description = "action", Language = Enums.MovieLanguage.Tamil });
            movies.Add(new MovieModel() { Id = Guid.NewGuid(), Name = "Movie 2", Description = "comedy", Language = Enums.MovieLanguage.English });
            movies.Add(new MovieModel() { Id = Guid.NewGuid(), Name = "Movie 3", Description = "love", Language = Enums.MovieLanguage.Kannada });
        }

        public Guid CreateMovie(MovieModel movie)
        {
            movie.Id = Guid.NewGuid();
            this.movies.Add(movie);
            return movie.Id;
        }

        public void Delete(Guid id)
        {
            this.movies.RemoveAll(x => x.Id.Equals(id));
        }

        public IEnumerable<MovieModel> GetAllMovies()
        {
            return this.movies;
        }

        public MovieModel GetMovieById(Guid id)
        {
            return this.movies.FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}
