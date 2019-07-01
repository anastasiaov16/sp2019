using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using FSSS.DAL.Interface;
using System.Windows.Forms;

namespace FSSS.DAL
{
    public class FileDao:IFileDao
    {
        private string connectionString = @"Data Source=ALEKSOV\SQLEXPRESS1;Initial Catalog=FSSS;Integrated Security=True";

        public void AddFile(string query, string name, DateTime date, int size, int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue(@"name", name);
                cmd.Parameters.AddWithValue(@"date", date);
                cmd.Parameters.AddWithValue(@"size", size);
                cmd.Parameters.AddWithValue(@"id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ShowFile(string query, DataGridView DGV, int k)
        {
            using (var connection = new SqlConnection(connectionString))
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
            using (var connection = new SqlConnection(connectionString))
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

        public void UpdateFile(string query, string oldName, string name, int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue(@"oldName", oldName);
                cmd.Parameters.AddWithValue(@"name", name);
                cmd.Parameters.AddWithValue(@"id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void FindFile(string query, DataGridView DGV, string name, int k)
        {
            using (var connection = new SqlConnection(connectionString))
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
            using (var connection = new SqlConnection(connectionString))
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
    }
}
