using MovieTicket.Respository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Respository.Models.Movies
{
    public class MovieModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public MovieLanguage Language { get; set; }
        public MovieRating Rating { get; set; }
    }
}
