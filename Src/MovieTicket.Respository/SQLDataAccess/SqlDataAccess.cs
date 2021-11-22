using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Respository.SQLDataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        string connectionString;
        public SqlDataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public T QueryFirst<T>(string sqlQuery, object param = null)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                return connection.QueryFirst<T>(sqlQuery, param);
            }
        }

        public IEnumerable<T> Query<T>(string sqlQuery, object param = null)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                return connection.Query<T>(sqlQuery, param);
            }
        }

        public void Delete(string sqlQuery, object param = null)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Execute(sqlQuery, param);
            }
        }

        public T Create<T>(string sqlQuery, object param = null)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                return connection.QueryFirst<T>(sqlQuery, param);
            }
        }
    }
}
