using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Respository.SQLDataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        readonly DatabaseOptions databaseOptions;
        public SqlDataAccess(IDatabaseOptions databaseOptions)
        {
            this.databaseOptions = databaseOptions as DatabaseOptions;
        }

        public T QueryFirst<T>(string sqlQuery, object param = null)
        {
            using (var connection = new SqlConnection(this.databaseOptions.ConnectionString))
            {
                return connection.QueryFirst<T>(sqlQuery, param, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<T> Query<T>(string sqlQuery, object param = null)
        {
            using (var connection = new SqlConnection(this.databaseOptions.ConnectionString))
            {
                return connection.Query<T>(sqlQuery, param, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(string sqlQuery, object param = null)
        {
            using (var connection = new SqlConnection(this.databaseOptions.ConnectionString))
            {
                connection.Execute(sqlQuery, param, commandType: CommandType.StoredProcedure);
            }
        }

        public T Create<T>(string sqlQuery, object param = null)
        {
            using (var connection = new SqlConnection(this.databaseOptions.ConnectionString))
            {
                return connection.QueryFirst<T>(sqlQuery, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
