using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Utilities
{
    public static class SqlHelper
    {
        public static string GetConnectionString()
        {
            string deviceName = Environment.MachineName;

            var baseConnectionString = ConfigurationManager.ConnectionStrings["BaseConnectionString"].ConnectionString;
            var databaseName = ConfigurationManager.AppSettings["DatabaseName"];
            // return "Data Source=DESKTOP-PIULBJ0\\SQLEXPRESS01;Initial Catalog=QuanLyNguyenLieuMonAn;Integrated Security=True;";

            return baseConnectionString.Replace("Data Source=;", $"Data Source={deviceName}\\SQLEXPRESS01;")
                                       .Replace("Initial Catalog=;", $"Initial Catalog={databaseName};");
        }

        public static int ExecuteNonQuery(string query, object[] objects)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int i = 0;
                        string[] parameters = query.Split(' ');
                        foreach (string param in parameters)
                        {
                            if (param[0] == '@')
                                cmd.Parameters.AddWithValue(param, objects[i++]);
                        }
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        return result > 0 ? 1 : 0;
                    }
                }
            }
            catch (SqlException)
            {
                return -1;
            }
        }


        public static int ExecuteScalar(string query, object[] objects)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        string[] parameters = query.Split(' ');
                        int i = 0;
                        foreach(string param in parameters)
                        {
                            if (param[0] == '@')
                                cmd.Parameters.AddWithValue(param, objects[i++]);
                        }
                        conn.Open();
                        return (int) cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public static DataTable ExecuteReader(string query, object[] objects)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        string[] parameters = query.Split(' ');
                        int i = 0;
                        foreach (string param in parameters)
                            if (param[0] == '@')
                                cmd.Parameters.AddWithValue(param, objects[i++]);
                            
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (SqlException)
            {
                return null;
            }
        }
    }
}
