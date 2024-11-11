using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace BLL
{
    public class HomeManagerBLL
    {
        SaleDAL saleDAL = new SaleDAL();
        EmployeeDAL employeeDAL = new EmployeeDAL();
        public int GetSaleToday()
        {
            return saleDAL.GetSaleToday();
        }
        public int GetOrderToday()
        {
            return saleDAL.GetOrderToday();
        }
        public int GetEmployee()
        {
            return saleDAL.GetEmployee();
        }
        //Doanh thu tuần hiện tại
        public int GetTotalSalesCurrentWeek()
        {
            return saleDAL.GetTotalSalesCurrentWeek();
        }

        //Doanh thu tháng hiện tại
        public int GetTotalSalesCurrentMonth()
        {
            return saleDAL.GetTotalSalesCurrentMonth();
        }

        //Doanh thu năm hiện tại
        public int GetTotalSalesCurrentYear()
        {
            return saleDAL.GetTotalSalesCurrentYear();
        }
        

        //Số đơn hàng nhân tuần hiện tại
        public int GetOrderCountCurrentWeek()
        {
            return saleDAL.GetOrderCountCurrentWeek();
        }

        //Số đơn hàng tháng hiện tại
        public int GetOrderCountCurrentMonth()
        {
            return saleDAL.GetOrderCountCurrentMonth();
        }

        //Số đơn hàng năm hiện tại
        public int GetOrderCountCurrentYear()
        {
            return saleDAL.GetOrderCountCurrentYear();
        }

        //Danh sách doanh thu theo tháng
        public List<int> GetMonthlySales()
        {
            return saleDAL.GetMonthlySales();
        }
        //Danh sách doanh thu theo tháng năm trước
        public List<int> GetMonthlySales2()
        {
            return saleDAL.GetMonthlySales2();
        }
        //Số bàn 
        public int GetTable()
        {
            return saleDAL.GetTableToday();
        }
        //Số nhà cung cấp 
        public int GetSupplier()
        {
            return saleDAL.GetSupplier();
        }
        //Số nhân viên kho
        public int GetEmployeeWarehouse()
        {
            return saleDAL.GetEmployeeWarehouse();
        }
        //Tổng chi kho
        public int GetTotalWarehouse()
        {
            return saleDAL.GetTotalWarehouse();
        }
        //Số nguyên liệu
        public int GetIngredient()
        {
            return saleDAL.GetIngredient();
        }

        //Nguyên liệu lâu nhất 
        public string GetIngredientOld()
        {
            try
            {
                return saleDAL.GetIngredientOld().Rows[0][1].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xảy ra: " + ex.Message);
                return string.Empty; 
            }
        }

        //Số tiền nhập nguyên liệu hôm nay
        public int GetMoneyIngredient()
        {
            return saleDAL.GetMoneyIngredient();
        }
        public DataTable GetEmployee(Employee @enum, string getValue)
        {
            return employeeDAL.GetEmployee(@enum, getValue);
        }
    }
}
