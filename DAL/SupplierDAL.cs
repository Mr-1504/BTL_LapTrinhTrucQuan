using DTO;
using System.Data;
using Utilities;

namespace DAL
{
    public class SupplierDAL
    {
        private int GetSupplierCount()
        {
            string query = "SELECT COUNT(*) FROM NhaCungCap";
            return SqlHelper.ExecuteScalar(query, null);
        }

        public int AddNewSupplier(SupplierDTO supplier)
        {
            string supplierId = (GetSupplierCount() + 1).ToString();
            supplierId = new string('0', 4 - supplierId.Length) + supplierId;

            string query = "INSERT INTO NhaCungCap(MaNhaCungCap, TenNhaCungCap, DiaChi, DienThoai)" +
                " VALUES ( @supplierId , @sukpplierName , @supplierAddress , @supllierNumberPhone )";
            return SqlHelper.ExecuteNonQuery(query, new object[]
                { supplierId, supplier.SupplierName, supplier.SupplierAddress, supplier.SupplierNumberPhone });
        }

        public int UpdateSupplier(SupplierDTO supplier)
        {
            string query = "UPDATE NhaCungCap SET TenNhaCungCap = @supplierName , " +
                "DiaChi = @supplierAddress , DienThoai = @supplierNumberPhone WHERE MaNhaCungCap = @supplierId";
            return SqlHelper.ExecuteNonQuery(query, new object[] 
                {supplier.SupplierName, supplier.SupplierAddress, supplier.SupplierNumberPhone, supplier.SupplierId});
        }

        public int RemoveSupplier(string supplierId)
        {
            string query = "DELETE FROM NhaCungCap WHERE MaNhaCungCap = @supplierId";
            return SqlHelper.ExecuteNonQuery(query, new object[] {supplierId});
        }

        public DataTable GetSuppliers()
        {
            string query = "SELECT * FROM NhaCungCap";
            return SqlHelper.ExecuteReader(query, null);
        }

        public DataTable GetSupplier(string supplierId)
        {
            string query = "SELECT * FROM NhaCungCap WHERE MaNhaCungCap = @supplierId";
            return SqlHelper.ExecuteReader(query, new object[] { supplierId });
        }
    }
}
