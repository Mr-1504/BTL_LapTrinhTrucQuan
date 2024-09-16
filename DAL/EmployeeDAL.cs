using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DAL
{
    public class EmployeeDAL
    {
        private string connectionString = SqlHelper.GetConnectionString();
        public int IsExistID(string userID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @userID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("userID", userID);

                        conn.Open();
                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException)
            {
                return -1;
            }
        }
    }
}
