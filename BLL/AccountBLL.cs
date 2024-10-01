﻿using DAL;
using System;

namespace BLL
{
    public class AccountBLL
    {
        private AccountDAL account = new AccountDAL();
        public string Login(string employeeId, string password)
        {
            if (employeeId == "")
                return "E," + "Nhập đủ thông tin";
            if (password == "")
                return "P," + "Nhập đủ thông tin";
            int result = account.IsExist(employeeId);
            if (result == -1)
                return "W," + "Lỗi cơ sở dữ liệu.\nThử lại sau.";
            else if (result == 0)
                return "E," + "Mã nhân viên không đúng";
            if (SecurityBLL.VerifyPassword(password, account.GetPasswordHash(employeeId)))
                return "R,";
            else return "P," + "Mật khẩu không chính xác";
        }
    }
}