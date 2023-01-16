using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Respository.Constants
{
    public class DataAccess
    {
        public class Movie
        {
            public static string GetAllMovies = "movie.GetAllMovies";
            public static string GetMovieById = "movie.GetMovieById";
            public static string DeleteMovieById = "movie.DeleteMovieById";
            public static string CreateMovie = "movie.CreateMovie";
            public static string CreateVenue = "movie.CreateVenue";
            public static string DeleteVenueById = "movie.DeleteVenueById";
            public static string GetAllVenues = "movie.GetAllVenues";
            public static string GetVenueById = "movie.GetVenueById";


        }
    }
}
