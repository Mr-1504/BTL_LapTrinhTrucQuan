using DTO;
using System;
using System.Data;
using Utilities;

namespace DAL
{
    public class EmployeeDAL
    {
        // Lấy số lượng nhân viên đang giữ chức vụ bất kỳ
        private int GetEmployeeCount(string prefix, string year)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien LIKE @Prefix + @year + '%'";
            return SqlHelper.ExecuteScalar(query, new object[] { prefix, year });
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
        public int AddNewEmployee(string prefix, EmployeeDTO employee)
        {
            string year = DateTime.Now.Year.ToString();
            string employeeCount = (GetEmployeeCount(prefix, year) + 1).ToString();
            employeeCount = new string('0', 8 - employeeCount.Length - year.Length) + employeeCount;
            string employeeId = prefix + year + employeeCount;
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
