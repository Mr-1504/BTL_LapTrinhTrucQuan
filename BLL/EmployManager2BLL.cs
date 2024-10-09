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
        public DataTable EditEmployeeManager(string employName, Employee @enum)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();
            return employeeDAL.GetEmployee(@enum, employName);
        }
        public int UpdateEmployee(EmployeeDTO employee)
        {
            Console.WriteLine(Employee.Gender.GetEnumDescription());
            return employeeDAL.UpdateEmployee(employee);
        }
        public int AddEmployee(EmployeeType prefix, EmployeeDTO employee)
        {
            return employeeDAL.AddNewEmployee(prefix, employee);
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
