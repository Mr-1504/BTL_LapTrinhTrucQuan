using DTO;
using System.Data;
using Utilities;

namespace DAL
{
    public class PurchaseInvoiceDetailDAL
    {
        public int AddNewPurchaseInvoiceDetail(PurchaseInvoiceDetailDTO detail)
        {
            string query = "INSERT INTO ChiTietHoaDonNhap (MaHoaDonNhap, MaNguyenLieu, SoLuong, DonGia) " +
                "VALUES ( @purchaseInvoiceId , @ingredientId , @quantity , @unitPrice )";
            return SqlHelper.ExecuteNonQuery(query, new object[]
            {
                detail.PurchaseInvoiceId, detail.IngredientId, detail.Quantity, detail.UnitPrice
            });
        }

        public int UpdatePurchaseInvoiceDetail(PurchaseInvoiceDetailDTO detail)
        {
            string query = "UPDATE ChiTietHoaDonNhap SET SoLuong = @quantity , DonGia = @unitPrice WHERE " +
                "MaHoaDonNhap = @PurchaseInvoiceId AND MaNguyenLieu = @ingredientId";
            return SqlHelper.ExecuteNonQuery(query, new object[]
            {
                detail.Quantity, detail.UnitPrice, detail.PurchaseInvoiceId, detail.IngredientId
            });
        }

        public DataTable GetPurchaseInvoiceDetail()
        {
            string query = "SELECT * FROM ChiTietHoaDonNhap";
            return SqlHelper.ExecuteReader(query, null);
        }

        public DataTable GetPurchaseInvoiceDetail(string purchaseInvoiceId = "", string ingredientId = "")
        {
            string query = "SELECT * FROM ChiTietHoaDonNhap WHERE ";
            object[] objects = new object[2];
            if (purchaseInvoiceId != "" && ingredientId != "")
            {
                query += "MaHoaDonNhap LIKE @PurchaseInvoiceId + '%' AND MaNguyenLieu LIKE @ingredientId + '%'";
                objects[0] = purchaseInvoiceId;
                objects[1] = ingredientId;
            }
            else if (purchaseInvoiceId != "" && ingredientId == "")
            {
                query += "MaHoaDonNhap LIKE @PurchaseInvoiceId + '%'";
                objects[0] = purchaseInvoiceId;
            }
            else if (purchaseInvoiceId == "" && ingredientId != "")
            {
                query += "MaNguyenLieu LIKE @ingredientId + '%'";
                objects[0] = ingredientId;
            }    
            return SqlHelper.ExecuteReader(query, objects);
        }
    }
}
