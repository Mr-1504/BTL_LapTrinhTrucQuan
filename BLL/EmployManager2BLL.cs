using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using Utilities;
namespace BLL
{
    public class EmployManager2BLL
    {
        EmployeeDAL employeeDAL = new EmployeeDAL();
        public bool ValidateEmployee(EmployeeDTO employee, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (string.IsNullOrWhiteSpace(employee.Name))
            {
                errorMessage = "Tên nhân viên không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(employee.NumberPhone) || !System.Text.RegularExpressions.Regex.IsMatch(employee.NumberPhone, @"^\d{10}$"))
            {
                errorMessage = "Số điện thoại không hợp lệ! Phải là số 10 chữ số.";
                return false;
            }
            if (employee.Gender != Gender.Male && employee.Gender != Gender.Female)
            {
                errorMessage = "Giới tính không hợp lệ!";
                return false;
            }
            if (employee.Birth >= DateTime.Now)
            {
                errorMessage = "Ngày sinh không hợp lệ! Phải là ngày trong quá khứ.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(employee.Address) || string.IsNullOrWhiteSpace(employee.Hometown))
            {
                errorMessage = "Địa chỉ và quê quán không được để trống!";
                return false;
            }

            return true;
        }
        public DataTable EditEmployeeManager(string employName, Employee @enum)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();
            return employeeDAL.GetEmployee(@enum, employName);
        }
        public bool UpdateEmployee(EmployeeDTO employee, out string errorMessage)
        {
            if (ValidateEmployee(employee, out errorMessage))
            {
                int result = employeeDAL.UpdateEmployee(employee);
                if (result > 0)
                {
                    return true; 
                }
                errorMessage = "Cập nhật nhân viên thất bại trong CSDL.";
            }
            return false;
        }
        public bool AddEmployee(EmployeeType prefix, EmployeeDTO employee, out string errorMessage)
        {
            if (ValidateEmployee(employee, out errorMessage))
            {
                int result = employeeDAL.AddNewEmployee(prefix, employee);
                if (result > 0)
                {
                    return true; 
                }
                errorMessage = "Thêm nhân viên thất bại trong CSDL.";
            }
            return false;
        }



        public EmployeeDTO GetNewestEmployee(EmployeeType type)
        {
            DataTable data = new EmployeeDAL().GetNewesrEmployee(type);
            DateTime date = default;

            try
            {
                date = DateTime.Parse(data.Rows[0][3].ToString());
            }
            catch
            {
                return null;
            }
            return new EmployeeDTO(
                data.Rows[0][0].ToString(),
                data.Rows[0][1].ToString(),
                Config.GetEnumValueFromDescription<Gender>(data.Rows[0][2].ToString()),
                date,
                data.Rows[0][4].ToString(),
                data.Rows[0][5].ToString(),
                data.Rows[0][6].ToString(),
                EmployeeStatus.CurrentlyWorking
                );
        }
    }
}
