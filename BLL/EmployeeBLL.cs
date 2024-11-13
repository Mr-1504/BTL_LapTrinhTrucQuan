using DAL;
using DTO;
using System;
using System.Data;
using Utilities;

namespace BLL
{
    public class EmployeeBLL
    {
        public EmployeeDTO GetEmployee(string employeeId)
        {
            DataTable data = new EmployeeDAL().GetInAllEmployees(Employee.EmployeeId, employeeId);

            DateTime date = default;
            try
            {
                date = DateTime.Parse(data.Rows[0][3].ToString());
            }
            catch { }
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
