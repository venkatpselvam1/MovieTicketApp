using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Respository.SQLDataAccess
{
    public interface ISqlDataAccess
    {
        T QueryFirst<T>(string sqlQuery, object param = null);
        IEnumerable<T> Query<T>(string sqlQuery, object param = null);
        void Delete(string sqlQuery, object param = null);
        T Create<T>(string sqlQuery, object param = null);
    }
}
