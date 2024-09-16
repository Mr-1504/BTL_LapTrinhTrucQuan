using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Utilities;

namespace DAL
{
    public class AccountDAL
    {
        private string connectionString = SqlHelper.GetConnectionString();

        //cập nhật mật khẩu theo mã nhân viên, cập nhật được trả về 1, cập nhật lỗi trả về 0, trả về -1 khi không mở được csdl
        public int UpdatePassword(AccountDTO acc)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Account SET Password = @Password WHERE Account.MaNhanVien = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Password", acc.PasswordHash);
                        cmd.Parameters.AddWithValue("@UserID", acc.Id);

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

        //kiểm tra đã có tài khoản chưa bằng mã nhân viên, có trả về 1, không có trả về 0, trả về -1 khi không mở được csdl

        public int IsExist(string userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Account WHERE MaNhanVien = @userID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userID", userId);
                        conn.Open();
                        return (int)cmd.ExecuteScalar();
                    }
                        
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        //thêm tài khoản cho mã nhân viên, thêm được trả về 1, thêm lỗi trả về 0, trả về -1 khi không mở được csdl

        public int AddNewAccount(AccountDTO acc)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Account (MaNhanVien, Password) VALUES (@UserID, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", acc.Id);
                        cmd.Parameters.AddWithValue("@Password", acc.PasswordHash);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        return result > 0 ? 1 : 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL: " + ex.Message);
                return -1;
            }
        }

        //xóa tài khoản theo mã nhân viên, xóa được trả về 1, xóa lỗi trả về 0, trả về -1 khi k mở được csdl

        public int RemoveAccount(string userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Account WHERE MaNhanVien = @userID";
                    using (SqlCommand cmd = new SqlCommand (query, conn))
                    {
                        cmd.Parameters.AddWithValue ("userId", userId);
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        return (result > 0) ? 1 : 0;
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
