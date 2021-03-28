using MovieTicket.Respository.Models.Shows;
using MovieTicket.Respository.Repositories.Movies;
using MovieTicket.Respository.Repositories.Venues;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTicket.Respository.Repositories.Shows
{
    public class ShowRepository : IShowRepository
    {
        private IVenueRepository venueRepository;
        private IMovieRepository movieRepository;
        private List<ShowModel> Shows;
        public ShowRepository(IVenueRepository venueRepository, IMovieRepository movieRepository)
        {
            this.venueRepository = venueRepository;
            this.movieRepository = movieRepository;
            var movies = this.movieRepository.GetAllMovies().ToList();
            var venues = this.venueRepository.GetAllVenue().ToList();
            Shows = new List<ShowModel>();
            Shows.Add(new ShowModel() { Id = Guid.NewGuid(), MovieId = movies[0].Id, VenuId = venues[0].Id, ShowDateTime = DateTime.Now.AddDays(1) });
            Shows.Add(new ShowModel() { Id = Guid.NewGuid(), MovieId = movies[0].Id, VenuId = venues[1].Id, ShowDateTime = DateTime.Now.AddDays(1) });
            Shows.Add(new ShowModel() { Id = Guid.NewGuid(), MovieId = movies[1].Id, VenuId = venues[1].Id, ShowDateTime = DateTime.Now.AddDays(1) });
            Shows.Add(new ShowModel() { Id = Guid.NewGuid(), MovieId = movies[1].Id, VenuId = venues[0].Id, ShowDateTime = DateTime.Now.AddDays(1) });
        }

        public Guid CreateShow(ShowModel show)
        {
            show.Id = Guid.NewGuid();
            if (!this.Validate(show))
            {
                return Guid.Empty;
            }
            this.Shows.Add(show);
            return show.Id;
        }

        public void Delete(Guid id)
        {
            this.Shows.RemoveAll(x => x.Id.Equals(id));
        }

        public IEnumerable<ShowModel> GetAllShows()
        {
            return this.Shows;
        }

        public ShowModel GetShowById(Guid id)
        {
            return  this.Shows.FirstOrDefault(x => x.Id.Equals(id));
        }

        private bool Validate(ShowModel showModel)
        {
            // for the given time, make sure no other shows available at the venue for the given time.
            return this.Shows.All(x => !(x.VenuId.Equals(showModel.VenuId) && x.ShowDateTime.Equals(showModel.ShowDateTime)));
        }
    }
}
