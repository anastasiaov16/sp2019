using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using FSSS.DAL.Interface;
using FSSS.Entitie;
using System.Configuration;

namespace FSSS.DAL
{
   public class UserDao:IUserDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public int QuerySqlShow(string query, string log, string pass)
        {
            using (var connection = new SqlConnection(_connectionString))
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

        public void Registrate(string query, User user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue(@"name", user.Name);
                cmd.Parameters.AddWithValue(@"login", user.Login);
                cmd.Parameters.AddWithValue(@"password", user.Password);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ChangeName(string query, string OldName, string name, int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue(@"oldName", OldName);
                cmd.Parameters.AddWithValue(@"name", name);
                cmd.Parameters.AddWithValue(@"id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ChangePassword(string query, string OldPas, string pas, int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue(@"oldName", OldPas);
                cmd.Parameters.AddWithValue(@"name", pas);
                cmd.Parameters.AddWithValue(@"id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int GetNameForCreate(int id, string name)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetNameForCreate";
                cmd.Parameters.AddWithValue(@"id", id);
                cmd.Parameters.AddWithValue(@"name", name);
                connection.Open();
                cmd.ExecuteNonQuery();
                return (int)cmd.ExecuteScalar();
            }
        }

        public int GetPasswordForCreate(int id, string pas)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetPasswordForCreate";
                cmd.Parameters.AddWithValue(@"id", id);
                cmd.Parameters.AddWithValue(@"pas", pas);
                connection.Open();
                cmd.ExecuteNonQuery();
                return (int)cmd.ExecuteScalar();
            }
        }
        public int GetPasswordForRegistrate(string pas)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetPasswordForRegistrate";
                cmd.Parameters.AddWithValue(@"pas", pas);
                connection.Open();
                cmd.ExecuteNonQuery();
                return (int)cmd.ExecuteScalar();
            }
        }

        public int GetLoginForSend(string log)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetLoginForSend";
                cmd.Parameters.AddWithValue(@"log", log);
                connection.Open();
                cmd.ExecuteNonQuery();
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
