﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DTO;
using DAL;
using Utilities;
namespace BLL
{
    public class EmployManagerBLL
    {
        EmployeeDAL employeeDAL = new EmployeeDAL();
        
        public DataTable GetEmployees() {
            return employeeDAL.GetEmployees(); 
        }
        
        
    }
    
}
