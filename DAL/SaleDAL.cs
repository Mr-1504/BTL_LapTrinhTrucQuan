using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Utilities;

namespace DAL
{
    public class SaleDAL
    {
        //Lấy giá trị doanh thu ngày hôm nay
        public int GetSaleToday()
        {
            string query = "SELECT SUM(TongTien) FROM DonHang WHERE NgayTao = getdate()";
            if (SqlHelper.ExecuteScalar(query, new object[] { }) == -1) return 0;
            else return SqlHelper.ExecuteScalar(query, new object[] { });
        }
        //Lấy số đơn hàng ngày hôm nay
        public int GetOrderToday() {
            string query = "SELECT COUNT(*) FROM DonHang WHERE NgayTao = getdate() AND TrangThai = N'Đã thanh toán'";
            if (SqlHelper.ExecuteScalar(query, new object[] { }) == -1) return 0;
            else return SqlHelper.ExecuteScalar(query, new object[] { });
        }
        //Lấy số bàn đang đặt ngày hôm nay
        public int GetTableToday()
        {
            string query = "Select count(*) from DonHang where NgayTao = GETDATE() and TrangThai = N'Chưa thanh toán'";
            if (SqlHelper.ExecuteScalar(query, new object[] { }) == -1) return 0;
            else return SqlHelper.ExecuteScalar(query, new object[] { });
        }
        //Lấy số nhân viên 
        public int GetEmployee()
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien LIKE 'LT%' OR MaNhanVien LIKE 'KH%'";
            if (SqlHelper.ExecuteScalar(query, new object[] { }) == -1) return 0;
            else return SqlHelper.ExecuteScalar(query, new object[] { });
        }

        //Doanh thu tuần hiện tại
        public int GetTotalSalesCurrentWeek()
        {
            string query = "SELECT SUM(TongTien) FROM DonHang WHERE DATEPART(WEEK, NgayTao) = DATEPART(WEEK, GETDATE()) AND DATEPART(YEAR, NgayTao) = DATEPART(YEAR, GETDATE())";
            if (SqlHelper.ExecuteScalar(query, new object[] { }) == -1) return 0;
            else return SqlHelper.ExecuteScalar(query, new object[] { });
        }

        //Doanh thu tháng hiện tại
        public int GetTotalSalesCurrentMonth()
        {
            string query = "SELECT SUM(TongTien) FROM DonHang WHERE MONTH(NgayTao) = MONTH(GETDATE()) AND YEAR(NgayTao) = YEAR(GETDATE())";
            if (SqlHelper.ExecuteScalar(query, new object[] { }) == -1) return 0;
            else return SqlHelper.ExecuteScalar(query, new object[] { });
        }

        //Doanh thu năm hiện tại
        public int GetTotalSalesCurrentYear()
        {
            string query = "SELECT SUM(TongTien) FROM DonHang WHERE YEAR(NgayTao) = YEAR(GETDATE())";
            if (SqlHelper.ExecuteScalar(query, new object[] { }) == -1) return 0;
            else return SqlHelper.ExecuteScalar(query, new object[] { });
        }

        //Số đơn hàng nhân tuần hiện tại
        public int GetOrderCountCurrentWeek()
        {
            string query = "SELECT COUNT(*) FROM DonHang WHERE DATEPART(WEEK, NgayTao) = DATEPART(WEEK, GETDATE()) AND DATEPART(YEAR, NgayTao) = DATEPART(YEAR, GETDATE()) AND TrangThai = N'Đã thanh toán'";
            if (SqlHelper.ExecuteScalar(query, new object[] { }) == -1) return 0;
            else return SqlHelper.ExecuteScalar(query, new object[] { });
        }

        //Số đơn hàng tháng hiện tại
        public int GetOrderCountCurrentMonth()
        {
            string query = "SELECT COUNT(*) FROM DonHang WHERE MONTH(NgayTao) = MONTH(GETDATE()) AND YEAR(NgayTao) = YEAR(GETDATE()) AND TrangThai = N'Đã thanh toán'";
            if (SqlHelper.ExecuteScalar(query, new object[] { }) == -1) return 0;
            else return SqlHelper.ExecuteScalar(query, new object[] { });
        }

        //Số đơn hàng năm hiện tại
        public int GetOrderCountCurrentYear()
        {
            string query = "SELECT COUNT(*) FROM DonHang WHERE YEAR(NgayTao) = YEAR(GETDATE()) AND TrangThai = N'Đã thanh toán'";
            if (SqlHelper.ExecuteScalar(query, new object[] { }) == -1) return 0;
            else return SqlHelper.ExecuteScalar(query, new object[] { });
        }


        //Danh sách doanh thu từng tháng 
        public List<int> GetMonthlySales()
        {
            List<int> doanhThuThang = new List<int>();
            for (int i = 0; i < 12; i++)
            {
                doanhThuThang.Add(0);
            }
            using (SqlConnection conn = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                conn.Open();
                string query = "SELECT MONTH(NgayTao) AS Thang, SUM(TongTien) AS DoanhThu FROM DonHang GROUP BY MONTH(NgayTao) ORDER BY MONTH(NgayTao)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int thang = reader.GetInt32(0); // Tháng
                            int doanhThu = reader.GetInt32(1); // Doanh thu

                            // Lưu doanh thu vào danh sách doanhThuThang
                            doanhThuThang[thang - 1] = doanhThu; 
                        }
                    }
                }
            }

            return doanhThuThang;
        }
        //Số nhà cung cấp 
        public int GetSupplier()
        {
            string query = "SELECT COUNT(*) FROM NhaCungCap Where TrangThai = 1";
            if (SqlHelper.ExecuteScalar(query, new object[] { }) == -1) return 0;
            else return SqlHelper.ExecuteScalar(query, new object[] { });
        }
        //Số nhân viên kho
        public int GetEmployeeWarehouse()
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien LIKE 'KH%'";
            if (SqlHelper.ExecuteScalar(query, new object[] { }) == -1) return 0;
            else return SqlHelper.ExecuteScalar(query, new object[] { });
        }
        //Tổng chi kho
        public int GetTotalWarehouse()
        {
            string query = "SELECT SUM(DonGia*SoLuong) FROM ChiTietHoaDonNhap";
            if (SqlHelper.ExecuteScalar(query, new object[] { }) == -1) return 0;
            else return SqlHelper.ExecuteScalar(query, new object[] { });
        }
        //Số nguyên liệu
        public int GetIngredient()
        {
            string query = "SELECT COUNT(*) FROM NguyenLieu";
            if (SqlHelper.ExecuteScalar(query, new object[] { }) == -1) return 0;
            else return SqlHelper.ExecuteScalar(query, new object[] { });
        }

        //Nguyên liệu lâu nhất 
        public DataTable GetIngredientOld()
        {
            string query = $"SELECT DISTINCT TOP 1 nl.MaNguyenLieu, nl.TenNguyenLieu, (nl.SoLuong - ISNULL(SUM(ctdh.SoLuong), 0)) AS SoLuongConLai, hn.NgayNhap FROM NguyenLieu nl JOIN NguyenLieuMonAn nlma ON nl.MaNguyenLieu = nlma.MaNguyenLieu JOIN MonAn ma ON nlma.MaMonAn = ma.MaMonAn JOIN ChiTietDonHang ctdh ON ma.MaMonAn = ctdh.MaMonAn JOIN ChiTietHoaDonNhap as ctdn on ctdn.MaNguyenLieu = nl.MaNguyenLieu JOIN HoaDonNhap hn ON hn.MaHoaDonNhap=ctdn.MaHoaDonNhap GROUP BY nl.MaNguyenLieu, nl.TenNguyenLieu, nl.SoLuong, hn.NgayNhap HAVING (nl.SoLuong - ISNULL(SUM(ctdh.SoLuong), 0)) > 0 ORDER BY hn.NgayNhap ASC";
            return SqlHelper.ExecuteReader(query, new object[] { });
        }

        //Số tiền nhập nguyên liệu hôm nay
        public int GetMoneyIngredient()
        {
            string query = "SELECT SUM(DonGia*SoLuong) FROM ChiTietHoaDonNhap as ct JOIN HoaDonNhap as dn on ct.MaHoaDonNhap = dn.MaHoaDonNhap Where NgayNhap = GetDate()";
            if (SqlHelper.ExecuteScalar(query, new object[] { }) == -1) return 0;
            else return SqlHelper.ExecuteScalar(query, new object[] { });
        }
    }
}
