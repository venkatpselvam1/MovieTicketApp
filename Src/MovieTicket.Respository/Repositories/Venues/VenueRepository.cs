using MovieTicket.Respository.Constants;
using MovieTicket.Respository.Models.Movies;
using MovieTicket.Respository.Models.Venues;
using MovieTicket.Respository.SQLDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MovieTicket.Respository.Constants.DataAccess;

namespace MovieTicket.Respository.Repositories.Venues
{
    public class VenueRepository : IVenueRepository
    {
        private ISqlDataAccess SqlDataAccess;
        public VenueRepository(ISqlDataAccess SqlDataAccess)
        {
            this.SqlDataAccess = SqlDataAccess;
        }
        public Guid CreateVenue(VenueModel venue)
        {
            venue.Id = Guid.NewGuid();
            var createdVenue = this.SqlDataAccess.Create<VenueModel>(DataAccess.Movie.CreateVenue, venue);
            return createdVenue.Id;
        }

        public void Delete(Guid id)
        {
            var param = new { Id = id };
            this.SqlDataAccess.Delete(DataAccess.Movie.DeleteVenueById, param);
        }

        public IEnumerable<VenueModel> GetAllVenue()
        {
            return this.SqlDataAccess.Query<VenueModel>(DataAccess.Movie.GetAllVenues);
        }

        public VenueModel GetVenueById(Guid id)
        {
            var param = new { Id = id };
            return this.SqlDataAccess.QueryFirst<VenueModel>(DataAccess.Movie.GetVenueById, param);
        }
    }
}
