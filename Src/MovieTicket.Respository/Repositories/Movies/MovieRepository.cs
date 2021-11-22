using MovieTicket.Respository.Constants;
using MovieTicket.Respository.Models.Movies;
using MovieTicket.Respository.SQLDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Respository.Repositories.Movies
{
    public class MovieRepository : IMovieRepository
    {
        private ISqlDataAccess SqlDataAccess;
        public MovieRepository(ISqlDataAccess SqlDataAccess)
        {
            this.SqlDataAccess = SqlDataAccess;
        }

        public Guid CreateMovie(MovieModel movie)
        {
            movie.Id = Guid.NewGuid();
            var createdMovie = this.SqlDataAccess.Create<MovieModel>(DataAccess.Movie.CreateMovie, movie);
            return createdMovie.Id;
        }

        public void Delete(Guid id)
        {
            var param = new { Id = id };
            this.SqlDataAccess.Delete(DataAccess.Movie.DeleteMovieById, param);
        }

        public IEnumerable<MovieModel> GetAllMovies()
        {
            return this.SqlDataAccess.Query<MovieModel>(DataAccess.Movie.GetAllMovies);
        }

        public MovieModel GetMovieById(Guid id)
        {
            var param = new { Id = id };
            return this.SqlDataAccess.QueryFirst<MovieModel>(DataAccess.Movie.GetMovieById, param);
        }
    }
}
