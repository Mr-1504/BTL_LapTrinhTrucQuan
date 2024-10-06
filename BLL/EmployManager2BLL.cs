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
        public void UpdateEmployee(EmployeeDTO employee)
        {
            employeeDAL.UpdateEmployee(employee);
        }
    }
}
