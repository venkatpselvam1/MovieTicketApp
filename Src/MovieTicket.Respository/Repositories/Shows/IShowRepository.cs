using MovieTicket.Respository.Models.Shows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Respository.Repositories.Shows
{
    public interface IShowRepository
    {
        IEnumerable<ShowModel> GetAllShows();
        Guid CreateShow(ShowModel Show);
        void Delete(Guid id);
        ShowModel GetShowById(Guid id);
    }
}
