using DTO;
using System.Data;
using Utilities;
namespace DAL
{
    public class PurchaseInvoiceDAL
    {
        private int GetPurchaseInvoiceCount()
        {
            string query = "SELECT COUNT(*) FROM HoaDonNhap";
            return SqlHelper.ExecuteScalar(query, null);
        }
        public int AddNewPurchaseInvoice(PurchaseInvoiceDTO purchaseInvoiceDTO)
        {
            string purchaseInvoiceId = (GetPurchaseInvoiceCount() + 1).ToString();
            purchaseInvoiceId = new string('0', 10 - purchaseInvoiceId.Length) + purchaseInvoiceId;
            string query = "INSERT INTO HoaDonNhap (MaHoaDonNhap, MaNhanVien, MaNhaCungCap, NgayNhap)" +
                " VALUES ( @purchaseInvoiceId , @employeeId , @supplier , @dateOfPurchase )";
            return SqlHelper.ExecuteNonQuery(query, new object[]
                 { purchaseInvoiceId, purchaseInvoiceDTO.EmployeeId,
                 purchaseInvoiceDTO.SupplierId, purchaseInvoiceDTO.DateOfPurchase });
        }

        public int UpdatePurchaseInvoice(PurchaseInvoiceDTO purchaseInvoiceDTO)
        {
            string query = "UPDATE HoaDonNhap SET NgayNhap = @dateOfPurchase " +
                "WHERE MaHoaDonNhap = @purchaseInvoiceId and MaNhanVien = @employeeId and MaNhaCungCap = @supplier";
            return SqlHelper.ExecuteNonQuery(query,
                new object[] { purchaseInvoiceDTO.DateOfPurchase, purchaseInvoiceDTO.PurchaseInvoiceId, purchaseInvoiceDTO.EmployeeId, purchaseInvoiceDTO.SupplierId });
        }

        public DataTable GetPurchaseInvoiceTable()
        {
            string query = "SELECT * FROM HoaDonNhap";
            return SqlHelper.ExecuteReader(query, null);
        }

        public DataTable GetPurchaseInvoice(string purchaseInvoiceId = "", string employeeId = "", string supplierId = "")
        {
            string query = "SELECT * FROM HoaDonNhap WHERE ";
            object[] objects = new object[3];
            if (purchaseInvoiceId != "" && employeeId != "" && supplierId != "")
            {
                query += "MaHoaDonNhap = @purchaseInvoiceId" +
                    " AND MaNhanVien = @employeeId AND MaNhaCungCap = @supplierId";
                objects[0] = purchaseInvoiceId;
                objects[1] = employeeId;
                objects[2] = supplierId;
            }
            else if (purchaseInvoiceId != "" && employeeId != "" && supplierId == "")
            {
                query += "MaHoaDonNhap = @purchaseInvoiceId AND MaNhanVien = @employeeId";
                objects[0] = purchaseInvoiceId;
                objects[1] = employeeId;
            }
            else if (purchaseInvoiceId != "" && employeeId == "" && supplierId != "")
            {
                query += "MaHoaDonNhap = @purchaseInvoiceId AND MaNhaCungCap = @supplierId";
                objects[0] = purchaseInvoiceId;
                objects[1] = supplierId;
            }
            else if (purchaseInvoiceId == "" && employeeId != "" && supplierId != "")
            {
                query += "MaNhanVien = @employeeId AND MaNhaCungCap = @supplierId";
                objects[0] = employeeId;
                objects[1] = supplierId;
            }
            else if (purchaseInvoiceId != "" && employeeId == "" && supplierId == "")
            {
                query += "MaHoaDonNhap = @purchaseInvoiceId";
                objects[0] = purchaseInvoiceId;
            }
            else if (purchaseInvoiceId == "" && employeeId != "" && supplierId == "")
            {
                query += "MaNhanVien = @employeeId";
                objects[0] = employeeId;
            }
            else if (purchaseInvoiceId == "" && employeeId == "" && supplierId != "")
            {
                query += "MaNhaCungCap = @supplierId";
                objects[0] = supplierId;
            }
            return SqlHelper.ExecuteReader(query, objects);
        }
    }
}