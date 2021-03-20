using MovieTicket.Respository.Models.Venues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Respository.Repositories.Venues
{
    public class VenueRepository : IVenueRepository
    {
        private List<VenueModel> venues;
        public VenueRepository()
        {
            venues = new List<VenueModel>();
            venues.Add(new VenueModel() { Id= Guid.NewGuid(), Name ="Venue 1" });
            venues.Add(new VenueModel() { Id= Guid.NewGuid(), Name ="Venue 2" });
            venues.Add(new VenueModel() { Id= Guid.NewGuid(), Name ="Venue 3" });
        }
        public Guid CreateVenue(VenueModel venue)
        {
            venue.Id = Guid.NewGuid();
            venues.Add(venue);
            return venue.Id;
        }

        public void Delete(Guid id)
        {
            venues.RemoveAll(x => x.Id.Equals(id));
        }

        public IEnumerable<VenueModel> GetAllVenue()
        {
            return this.venues;
        }

        public VenueModel GetVenueById(Guid id)
        {
            return this.venues.FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}
