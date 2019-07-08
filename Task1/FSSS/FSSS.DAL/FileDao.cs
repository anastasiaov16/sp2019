using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using FSSS.DAL.Interface;
using System.Windows.Forms;
using FSSS.Entitie;
using System.Configuration;


namespace FSSS.DAL
{
    public class FileDao:IFileDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void AddFile(string query, File file, int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue(@"name", file.Title);
                cmd.Parameters.AddWithValue(@"date", file.DateOfCreation);
                cmd.Parameters.AddWithValue(@"size", file.Size);
                cmd.Parameters.AddWithValue(@"id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ShowFile(string query, DataGridView DGV, int k)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue(@"id", k);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tablee = new DataTable();
                da.Fill(tablee);
                DGV.DataSource = new BindingSource(tablee, null);
            }
        }

        public void DeleteFile(string query, string title, DateTime date, int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue(@"title", title);
                cmd.Parameters.AddWithValue(@"date", date);
                cmd.Parameters.AddWithValue(@"id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateFile(string query, string OldName, string name, int id)
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

        public void FindFile(string query, DataGridView DGV, string name, int k)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue(@"name", name);
                cmd.Parameters.AddWithValue(@"id", k);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tablee = new DataTable();
                da.Fill(tablee);
                DGV.DataSource = new BindingSource(tablee, null);
            }
        }

        public void SendFile(string query, string name, string log, int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue(@"name", name);
                cmd.Parameters.AddWithValue(@"log", log);
                cmd.Parameters.AddWithValue(@"id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int GetTitleForDelete(int id, string title)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetTitleForDelete";
                cmd.Parameters.AddWithValue(@"id", id);
                cmd.Parameters.AddWithValue(@"title", title);
                connection.Open();
                cmd.ExecuteNonQuery();
                return (int)cmd.ExecuteScalar();
            }
        }

     
    }
}
