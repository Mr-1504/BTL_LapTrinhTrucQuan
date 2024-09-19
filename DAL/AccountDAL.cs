﻿using System;
using System.Collections.Generic;
using System.Data;
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
            string query = "UPDATE Account SET Password = @Password WHERE Account.MaNhanVien = @UserID";
            return SqlHelper.ExecuteNonQuery(query, new object[] {acc.PasswordHash, acc.Id });
        }

        //kiểm tra đã có tài khoản chưa bằng mã nhân viên, có trả về 1, không có trả về 0, trả về -1 khi không mở được csdl
        public int IsExist(string userId)
        {
            string query = "SELECT COUNT(*) FROM Account WHERE MaNhanVien = @userID";
            return SqlHelper.ExecuteScalar(query, new object[] {userId});
        }

        //thêm tài khoản cho mã nhân viên, thêm được trả về 1, thêm lỗi trả về 0, trả về -1 khi không mở được csdl
        public int AddNewAccount(AccountDTO acc)
        {
            string query = "INSERT INTO Account (MaNhanVien, Password) VALUES ( @UserID , @Password )";
            return SqlHelper.ExecuteNonQuery(query, new object[] { acc.Id, acc.PasswordHash });
        }

        //xóa tài khoản theo mã nhân viên, xóa được trả về 1, xóa lỗi trả về 0, trả về -1 khi k mở được csdl

        public int RemoveAccount(string userId)
        {
            string query = "DELETE FROM Account WHERE MaNhanVien = @userID";
            return SqlHelper.ExecuteNonQuery(query, new object[] {userId});
        }
    }

}
