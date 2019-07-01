using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using FSSS.DAL.Interface;

namespace FSSS.DAL
{
   public class UserDao:IUserDao
    {
        private string connectionString = @"Data Source=ALEKSOV\SQLEXPRESS1;Initial Catalog=FSSS;Integrated Security=True";

        public int QuerySqlShow(string query, string log, string pass)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue(@"login", log);
                cmd.Parameters.AddWithValue(@"password", pass);
                connection.Open();
                cmd.ExecuteNonQuery();
                return (int)cmd.ExecuteScalar();
            }
        }

        public void Registrate(string query, string name, string log, string pass)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue(@"name", name);
                cmd.Parameters.AddWithValue(@"login", log);
                cmd.Parameters.AddWithValue(@"password", pass);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
