using DTO;
using System;
using System.Data;
using Utilities;

namespace DAL
{
    public class EmployeeDAL
    {
        // Lấy số lượng nhân viên đang giữ chức vụ bất kỳ
        private int GetEmployeeCount(EmployeeType prefix, string year)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien LIKE @Prefix + @year + '%'";
            return SqlHelper.ExecuteScalar(query, new object[] { prefix.GetEnumDescription(), year });
        }

        // Kiểm tra xem có nhân viên không
        public int IsExistEmployeeId(string employeeId)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @employeeId";
            return SqlHelper.ExecuteScalar(query, new object[] { employeeId });
        }

        public int IsExistEmployeeName(string employeeName)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE TenNhanVien = @employeeName";
            return SqlHelper.ExecuteScalar(query, new object[] { employeeName });
        }

        // Thêm một nhân viên
        public int AddNewEmployee(EmployeeType prefix, EmployeeDTO employee)
        {
            string year = DateTime.Now.Year.ToString();
            int count = GetEmployeeCount(prefix, year) + 1;
            if (count <= 0)
                return -1;
            string employeeCount = new string('0', 8 - count.ToString().Length - year.Length) + count.ToString();
            string employeeId = prefix.GetEnumDescription() + year + employeeCount;
            Console.WriteLine(employeeId + " SO NGAN VW " + count.ToString());
            string query = "INSERT INTO NhanVien (MaNhanVien, TenNhanVien, GioiTinh, NamSinh, QueQuan, DiaChi, DienThoai, TrangThai) " +
                           "VALUES ( @EMPLOYEEID , @NAME , @GENDER , @BIRTH , @HOMETOWN , @ADDRESS , @NUMBERPHONE , @TRANGTHAI )";
            return SqlHelper.ExecuteNonQuery(query, new object[] {employeeId, employee.Name, employee.Gender.GetEnumDescription(), employee.Birth,
                    employee.Hometown, employee.Address, employee.NumberPhone, employee.Status.GetEnumDescription()});
        }

        // xóa nhân viên
        public int ChangeEmployeeStatus(string employeeId, EmployeeStatus status)
        {
            string query = "UPDATE NhanVien SET TrangThai = @status WHERE MaNhanVien = @employeeId";
            return SqlHelper.ExecuteNonQuery(query, new object[] { status.GetEnumDescription(), employeeId });
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
            string query = $"SELECT * FROM NhanVien WHERE TrangThai = N'{EmployeeStatus.CurrentlyWorking.GetEnumDescription()}'";
            return SqlHelper.ExecuteReader(query, new object[] { });
        }

        
        // tìm kiếm nhân viên theo thông tin bất kỳ
        public DataTable GetEmployee(Employee @enum, string getValue)
        {
            string query = "SELECT * FROM NhanVien WHERE " + @enum.GetEnumDescription() + $" LIKE '%' + @getValue + '%' AND TrangThai = N'{EmployeeStatus.CurrentlyWorking.GetEnumDescription()}'";
            return SqlHelper.ExecuteReader(query, new object[] { getValue });
        }
        public DataTable GetNewesrEmployee(EmployeeType @enum)
        {
            string year = DateTime.Now.Year.ToString();
            int count = GetEmployeeCount(@enum, year);
            if (count == 0)
                return null;
            string employeeCount = new string('0', 8 - count.ToString().Length - year.Length) + count.ToString();
            string employeeId = @enum.GetEnumDescription() + year + employeeCount;
            string query = "SELECT * FROM NhanVien WHERE MaNhanVien = @employeeId";
            return SqlHelper.ExecuteReader(query, new object[] { employeeId });
        }

    }
}
