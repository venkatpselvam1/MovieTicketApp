using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Respository.SQLDataAccess
{
    public class DatabaseOptions: IDatabaseOptions
    {
        public DatabaseOptions(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        public string ConnectionString { get; }
    }
    public interface IDatabaseOptions
    {

    }
}
