using MovieTicket.Respository.Models.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Respository.Repositories.Movies
{
    public interface IMovieRepository
    {
        IEnumerable<MovieModel> GetAllMovies();
        Guid CreateMovie(MovieModel movie);
        void Delete(Guid id);
        MovieModel GetMovieById(Guid id);
    }
}
