﻿using DTO;
using System;
using System.Data;
using Utilities;

namespace DAL
{
    public class EmployeeDAL
    {
        // Lấy số lượng nhân viên đang giữ chức vụ bất kỳ
        private int GetEmployeeCount(string prefix)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien LIKE @Prefix + '%'";
            return SqlHelper.ExecuteScalar(query, new object[] { prefix });
        }

        // Kiểm tra xem có nhân viên không
        public int IsExistEmployeeId(string employeeId)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @employeeId";
            return SqlHelper.ExecuteScalar(query, new object[] {employeeId});
        }

        public int IsExistEmployeeName(string employeeName)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE TenNhanVien = @employeeName";
            return SqlHelper.ExecuteScalar(query, new object[] { employeeName });
        }

        // Thêm một nhân viên
        public int AddNewEmployee(string prefix, EmployeeDTO employee)
        {
            string employeeCount = (GetEmployeeCount(prefix) + 1).ToString();
            employeeCount = new string('0', 4 - employeeCount.Length) + employeeCount;
            string employeeId = prefix + employeeCount;
            string query = "INSERT INTO NhanVien (MaNhanVien, TenNhanVien, GioiTinh, NamSinh, QueQuan, DiaChi, DienThoai) " +
                           "VALUES ( @EMPLOYEEID , @NAME , @GENDER , @BIRTH , @HOMETOWN , @ADDRESS , @NUMBERPHONE )";
            return SqlHelper.ExecuteNonQuery(query, new object[] {employeeId, employee.Name, employee.Gender.GetEnumDescription(), employee.Birth, 
                    employee.Hometown, employee.Address, employee.NumberPhone});
        }

        // xóa nhân viên
        public int RemoveEmployee(string employeeId)
        {
            string query = "DELETE FROM NhanVien WHERE MaNhanVien = @employeeId";
            return SqlHelper.ExecuteNonQuery(query, new object[] { employeeId });
        }


        // cập nhật thông tin nhân viên
        public int UpdateEmployee(EmployeeDTO employee)
        {
            string query = "UPDATE NhanVien SET TenNhanVien = @name , GioiTinh = @gender , NamSinh = @birth , QueQuan = @hometown , " +
                "DiaChi = @address , DienThoai = @numberPhone WHERE MaNhanVien = @employeeId";
            return SqlHelper.ExecuteNonQuery(query, new object[] { employee.Name, employee.Gender.GetEnumDescription(), employee.Birth, employee.Hometown
                    , employee.Address, employee.NumberPhone, employee.EmployeeId});
        }


        // lấy danh sách nhân viên
        public DataTable GetEmployees()
        {
            string query = "SELECT * FROM NhanVien";
            return SqlHelper.ExecuteReader(query, new object[] { });
        }

        // tìm kiếm nhân viên theo thông tin bất kỳ
        public DataTable GetEmployee(Enum @enum, string getValue) 
        {
            if (Config.IsValidEnum<Employee>(@enum.ToString()))
            {
                string query = "SELECT * FROM NhanVien WHERE " + @enum.GetEnumDescription() + " = @getValue";
                Console.WriteLine(query);
                return SqlHelper.ExecuteReader(query, new object[] { getValue });
            }
            return null;
        }
    }
}
