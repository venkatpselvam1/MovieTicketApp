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
            //Movie realted SPs
            public static string GetAllMovies = "movie.GetAllMovies";
            public static string GetMovieById = "movie.GetMovieById";
            public static string DeleteMovieById = "movie.DeleteMovieById";
            public static string CreateMovie = "movie.CreateMovie";
            //Venue realted SPs
            public static string CreateVenue = "movie.CreateVenue";
            public static string DeleteVenueById = "movie.DeleteVenueById";
            public static string GetAllVenues = "movie.GetAllVenues";
            public static string GetVenueById = "movie.GetVenueById";
            //show realted SPs
            public static string CreatShow = "movie.CreatShow";
            public static string DeleteShowById = "movie.DeleteShowById";
            public static string GetAllShows = "movie.GetAllShows";
            public static string GetShowById = "movie.GetShowById";

        }
    }
}
