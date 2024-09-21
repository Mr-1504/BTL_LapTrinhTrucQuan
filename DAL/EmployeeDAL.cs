using DTO;
using System;
using System.Data;
using Utilities;

namespace DAL
{
    public class EmployeeDAL
    {
        private string connectionString = SqlHelper.GetConnectionString();

        // Lấy số lượng nhân viên đang giữ chức vụ bất kỳ
        private int GetEmployeeCount(string prefix)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien LIKE @Prefix + '%'";
            return SqlHelper.ExecuteScalar(query, new object[] { prefix });
        }

        // Kiểm tra xem có nhân viên không
        public int IsExistID(string userID)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @userID";
            return SqlHelper.ExecuteScalar(query, new object[] {userID});
        }


        // Thêm một nhân viên
        public int AddNewEmployee(string prefix, string name, string gender, DateTime birth, string hometown, string address, string numberPhone)
        {
            string employeeCount = (GetEmployeeCount(prefix) + 1).ToString();
            employeeCount = new string('0', 4 - employeeCount.Length) + employeeCount;
            string employeeId = prefix + employeeCount;
            string query = "INSERT INTO NhanVien (MaNhanVien, TenNhanVien, GioiTinh, NamSinh, QueQuan, DiaChi, DienThoai) " +
                           "VALUES ( @EMPLOYEEID , @NAME , @GENDER , @BIRTH , @HOMETOWN , @ADDRESS , @NUMBERPHONE )";
            return SqlHelper.ExecuteNonQuery(query, new object[] {employeeId, name, gender, birth, hometown, address, numberPhone});
        }

        // xóa nhân viên
        public int RemoveEmployee(string employeeId)
        {
            string query = "DELETE FROM NhanVien WHERE MaNhanVien = @employeeId";
            return SqlHelper.ExecuteNonQuery(query, new object[] { employeeId });
        }


        // cập nhật thông tin nhân viên
        public int UpdateEmployee(string employeeId, string name, string gender, DateTime birth, string hometown, string address, string numberPhone)
        {
            string query = "UPDATE NhanVien SET TenNhanVien = @name , GioiTinh = @gender , NamSinh = @birth , QueQuan = @hometown , " +
                "DiaChi = @address , DienThoai = @numberPhone WHERE MaNhanVien = @employeeId";
            return SqlHelper.ExecuteNonQuery(query, new object[] { name, gender, birth, hometown, address, numberPhone, employeeId });
        }


        // lấy danh sách nhân viên
        public DataTable GetEmployees()
        {
            string query = "SELECT * FROM NhanVien";
            return SqlHelper.ExecuteReader(query, new object[] { });
        }

        // kiểm tra xem value có trong enum Employee không
        private bool IsValidRole(string role)
        {
            return Enum.TryParse<Employee>(role, true, out var _);
        }

        // tìm kiếm nhân viên theo thông tin bất kỳ
        public DataTable GetEmployee(Enum @enum, string getValue) 
        {
            if (IsValidRole(@enum.ToString()))
            {
                string query = "SELECT * FROM NhanVien WHERE " + @enum.GetEnumDescription() + " = @getValue";
                Console.WriteLine(query);
                return SqlHelper.ExecuteReader(query, new object[] { getValue });
            }
            return null;
        }
    }
}
