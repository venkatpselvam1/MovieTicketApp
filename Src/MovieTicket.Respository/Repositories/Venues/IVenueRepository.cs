using MovieTicket.Respository.Models.Venues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Respository.Repositories.Venues
{
    public interface IVenueRepository
    {
        IEnumerable<VenueModel> GetAllVenue();
        Guid CreateVenue(VenueModel venue);
        void Delete(Guid id);
        VenueModel GetVenueById(Guid id);
    }
}
