using MovieTicket.Respository.Models.Movies;
using MovieTicket.Respository.Models.Venues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Respository.Models.Shows
{
    public class ShowModel
    {
        public Guid Id { get; set; }
        public Guid VenuId { get; set; }
        public Guid MovieId { get; set; }
        public DateTime ShowDateTime { get; set; }
    }
}
