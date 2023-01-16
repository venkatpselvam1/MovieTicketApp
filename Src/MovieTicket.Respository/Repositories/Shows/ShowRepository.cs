using MovieTicket.Respository.Constants;
using MovieTicket.Respository.Models.Shows;
using MovieTicket.Respository.Models.Venues;
using MovieTicket.Respository.Repositories.Movies;
using MovieTicket.Respository.Repositories.Venues;
using MovieTicket.Respository.SQLDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTicket.Respository.Repositories.Shows
{
    public class ShowRepository : IShowRepository
    {
        private ISqlDataAccess SqlDataAccess;

        public ShowRepository(ISqlDataAccess SqlDataAccess)
        {
            this.SqlDataAccess = SqlDataAccess;

        }

        public Guid CreateShow(ShowModel show)
        {
            if (!this.Validate(show))
            {
                return Guid.Empty;
            }
            show.Id = Guid.NewGuid();
            var createdVenue = this.SqlDataAccess.Create<ShowModel>(DataAccess.Movie.CreatShow, show);
            return createdVenue.Id;
        }

        public void Delete(Guid id)
        {
            var param = new { Id = id };
            this.SqlDataAccess.Delete(DataAccess.Movie.DeleteShowById, param);
        }

        public IEnumerable<ShowModel> GetAllShows()
        {
            return this.SqlDataAccess.Query<ShowModel>(DataAccess.Movie.GetAllShows);
        }

        public ShowModel GetShowById(Guid id)
        {
            var param = new { Id = id };
            return this.SqlDataAccess.QueryFirst<ShowModel>(DataAccess.Movie.GetShowById, param);
        }

        private bool Validate(ShowModel showModel)
        {
            // for the given time, make sure no other shows available at the venue for the given time.
            //return this.Shows.All(x => !(x.VenueId.Equals(showModel.VenueId) && x.ShowDateTime.Equals(showModel.ShowDateTime)));
            //TODO: Add validation here
            return true;
        }
    }
}
