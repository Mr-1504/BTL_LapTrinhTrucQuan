using DTO;
using System;
using System.Data;
using Utilities;
namespace DAL
{
    public class PurchaseInvoiceDAL
    {
        private int GetPurchaseInvoiceCount(string day, string month, string year)
        {
            string query = "SELECT COUNT(*) FROM HoaDonNhap WHERE MaHoaDonNhap LIKE 'HDN" + day + month + year + "%'";
            return SqlHelper.ExecuteScalar(query, null);
        }
        public int AddNewPurchaseInvoice(PurchaseInvoiceDTO purchaseInvoiceDTO)
        {
            string year = DateTime.Now.Year.ToString().Substring(2);
            string month = new string('0', 2 - DateTime.Now.Month.ToString().Length) + DateTime.Now.Month.ToString();
            string day = new string('0', 2 - DateTime.Now.Day.ToString().Length) + DateTime.Now.Day.ToString();
            string purchaseInvoiceId = (GetPurchaseInvoiceCount(day, month, year) + 1).ToString();
            purchaseInvoiceId = "HDN" + day + month + year + new string('0', 3 - purchaseInvoiceId.Length) + purchaseInvoiceId;
            string query = "INSERT INTO HoaDonNhap (MaHoaDonNhap, MaNhanVien, MaNhaCungCap, NgayNhap, ThanhTien)" +
                " VALUES ( @purchaseInvoiceId , @employeeId , @supplier , @dateOfPurchase , @total )";
            return SqlHelper.ExecuteNonQuery(query, new object[]
                 { purchaseInvoiceId, purchaseInvoiceDTO.EmployeeId,
                 purchaseInvoiceDTO.SupplierId, purchaseInvoiceDTO.DateOfPurchase, purchaseInvoiceDTO.Total });
        }

        public int UpdatePurchaseInvoice(PurchaseInvoiceDTO purchaseInvoiceDTO)
        {
            string query = "UPDATE HoaDonNhap SET NgayNhap = @dateOfPurchase " +
                "WHERE MaHoaDonNhap = @purchaseInvoiceId and MaNhanVien = @employeeId and MaNhaCungCap = @supplier";
            return SqlHelper.ExecuteNonQuery(query,
                new object[] { purchaseInvoiceDTO.DateOfPurchase, purchaseInvoiceDTO.PurchaseInvoiceId, purchaseInvoiceDTO.EmployeeId, purchaseInvoiceDTO.SupplierId });
        }
        public DataTable GetNewestPurchaseInvoice()
        {
            string year = DateTime.Now.Year.ToString().Substring(2);
            string month = new string('0', 2 - DateTime.Now.Month.ToString().Length) + DateTime.Now.Month.ToString();
            string day = new string('0', 2 - DateTime.Now.Day.ToString().Length) + DateTime.Now.Day.ToString();
            string purchaseInvoiceId = GetPurchaseInvoiceCount(day, month, year).ToString();
            purchaseInvoiceId = "HDN" + day + month + year + new string('0', 3 - purchaseInvoiceId.Length) + purchaseInvoiceId;
            string query = "SELECT * FROM HoaDonNhap WHERE MaHoaDonNhap = @purchaseInvoiceId";
            return SqlHelper.ExecuteReader(query, new object[] { purchaseInvoiceId });
        }
        public DataTable GetPurchaseInvoiceTable()
        {
            string query = "SELECT * FROM HoaDonNhap";
            return SqlHelper.ExecuteReader(query, null);
        }

        public DataTable GetPurchaseInvoice(string purchaseInvoiceId = "", string employeeId = "", string supplierId = "")
        {
            string query = "SELECT * FROM HoaDonNhap WHERE ";
            object[] objects = new object[1];
            if (purchaseInvoiceId != "" && employeeId == "" && supplierId == "")
            {
                query += "MaHoaDonNhap LIKE @purchaseInvoiceId + '%'";
                objects[0] = purchaseInvoiceId;
            }
            else if (purchaseInvoiceId == "" && employeeId != "" && supplierId == "")
            {
                query += "MaNhanVien LIKE @employeeId + '%'";
                objects[0] = employeeId;
            }
            else if (purchaseInvoiceId == "" && employeeId == "" && supplierId != "")
            {
                query += "MaNhaCungCap LIKE @supplierId + '%'";
                objects[0] = supplierId;
            }
            return SqlHelper.ExecuteReader(query, objects);
        }
        public int RemovePurchaseInvoice(string purchaseInvoiceId)
        {
            string query = "DELETE FROM HoaDonNhap WHERE MaHoaDonNhap = @purchaseInvoiceId";
            return SqlHelper.ExecuteNonQuery(query, new object[] { purchaseInvoiceId });
        }
    }
}