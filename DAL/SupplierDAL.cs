using DTO;
using System.Data;
using Utilities;

namespace DAL
{
    public class SupplierDAL
    {
        private int GetSupplierCount(SupplierType prefix)
        {
            string query = "SELECT COUNT(*) FROM NhaCungCap WHERE MaNhaCungCap LIKE 'NCC_' + @prefix + '%'";
            return SqlHelper.ExecuteScalar(query, new object[] { prefix.GetEnumDescription() });
        }

        public int IsExist(string value)
        {
            string query = "SELECT COUNT(*) FROM NhaCungCap WHERE TenNhaCungCap = @supplierName";
            return SqlHelper.ExecuteScalar(query, new object[] { value });
        }

        public int AddNewSupplier(SupplierType prefix, SupplierDTO supplier)
        {
            int count = GetSupplierCount(prefix) + 1;
            if (count == 0)
            {
                return -1;
            }
            string supplierId = "NCC_" + prefix.GetEnumDescription() + new string('0', 4 - count.ToString().Length) + count.ToString();
            string query = "INSERT INTO NhaCungCap" +
                "(MaNhaCungCap, TenNhaCungCap, DiaChi, DienThoai, TrangThai )" +
                " VALUES ( @supplierId , @supplierName , @supplierAddress ," +
                " @supplierNumberPhone , @status )";
            return SqlHelper.ExecuteNonQuery(query, new object[]
            {
                supplierId, supplier.SupplierName, supplier.SupplierAddress, 
                supplier.SupplierNumberPhone, (int)supplier.Status
            });
        }

        public int UpdateSupplier(SupplierDTO supplier)
        {
            string query = "UPDATE NhaCungCap SET TenNhaCungCap = @supplierName , " +
                "DiaChi = @supplierAddress , DienThoai = @supplierNumberPhone WHERE MaNhaCungCap = @supplierId";
            return SqlHelper.ExecuteNonQuery(query, new object[]
                {supplier.SupplierName, supplier.SupplierAddress, supplier.SupplierNumberPhone, supplier.SupplierId});
        }

        public int ChangeSupplierStatus(string supplierId, Status status)
        {
            string query = "UPDATE NhaCungCap SET Trangthai = @status WHERE MaNhaCungCap = @supplierId";
            return SqlHelper.ExecuteNonQuery(query, new object[] { (int)status, supplierId });
        }

        public DataTable GetSuppliers()
        {
            string query = "SELECT * FROM NhaCungCap WHERE TrangThai = 1";
            return SqlHelper.ExecuteReader(query, new object[] { });
        }

        public DataTable GetSupplierById(string supplierId)
        {
            string query = "SELECT * FROM NhaCungCap WHERE MaNhaCungCap = @supplierId AND TrangThai = 1";
            return SqlHelper.ExecuteReader(query, new object[] { supplierId });
        }
        public DataTable GetSuppliers(string supplierName)
        {
            string query = "SELECT * FROM NhaCungCap WHERE TenNhaCungCap LIKE '%' + @supplierName + '%' AND TrangThai = 1";
            return SqlHelper.ExecuteReader(query, new object[] { supplierName });
        }

        public DataTable GetSupplierByName(string supplierName)
        {
            string query = "SELECT * FROM NhaCungCap WHERE TenNhaCungCap = @supplierName AND TrangThai = 1";
            return SqlHelper.ExecuteReader(query, new object[] { supplierName });
        }
    }
}
