USE [master]
GO
/****** Object:  Database [QuanLyNguyenLieuMonAn]    Script Date: 10/3/2024 8:04:13 PM ******/
CREATE DATABASE [QuanLyNguyenLieuMonAn]
ON PRIMARY 
( NAME = N'QuanLyNguyenLieuMonAn', SIZE = 8192KB, MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
LOG ON 
( NAME = N'QuanLyNguyenLieuMonAn_log', SIZE = 8192KB, MAXSIZE = 2048GB, FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNguyenLieuMonAn].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLyNguyenLieuMonAn]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 10/3/2024 8:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[Password] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 10/3/2024 8:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminId] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 10/3/2024 8:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaDon] [nvarchar](10) NOT NULL,
	[MaMonAn] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDon] ASC,
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDonNhap]    Script Date: 10/3/2024 8:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonNhap](
	[MaHoaDonNhap] [nvarchar](10) NOT NULL,
	[MaNguyenLieu] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDonNhap] ASC,
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 10/3/2024 8:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDon] [nvarchar](10) NOT NULL,
	[NgayTao] [date] NULL,
	[TongTien] [int] NULL,
	[TrangThai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 10/3/2024 8:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[MaHoaDonNhap] [nvarchar](10) NOT NULL,
	[MaNhanVien] [nvarchar](10) NULL,
	[MaNhaCungCap] [nvarchar](10) NULL,
	[NgayNhap] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 10/3/2024 8:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MaMonAn] [nvarchar](10) NOT NULL,
	[TenMonAn] [nvarchar](40) NULL,
	[CachLam] [ntext] NULL,
	[DonGia] [int] NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 10/3/2024 8:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[MaNguyenLieu] [nvarchar](10) NOT NULL,
	[TenNguyenLieu] [nvarchar](30) NULL,
	[DonViTinh] [nvarchar](20) NULL,
	[CongDung] [ntext] NULL,
	[YeuCau] [nvarchar](200) NULL,
	[ChongChiDinh] [nvarchar](200) NULL,
	[Soluong] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguyenLieuMonAn]    Script Date: 10/3/2024 8:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieuMonAn](
	[MaMonAn] [nvarchar](10) NOT NULL,
	[MaNguyenLieu] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC,
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 10/3/2024 8:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [nvarchar](10) NOT NULL,
	[TenNhaCungCap] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[DienThoai] [nvarchar](15) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/3/2024 8:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[TenNhanVien] [nvarchar](40) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[NamSinh] [date] NULL,
	[QueQuan] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[DienThoai] [nvarchar](13) NULL,
	[TrangThai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyenTruyCap]    Script Date: 10/3/2024 8:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyenTruyCap](
	[ChucVu] [nvarchar](2) NOT NULL,
	[Menu] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([MaNhanVien], [Password]) VALUES (N'KH20240001', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[Account] ([MaNhanVien], [Password]) VALUES (N'LT20240001', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[Account] ([MaNhanVien], [Password]) VALUES (N'QL20240001', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
GO
INSERT [dbo].[Admin] ([AdminId], [Password]) VALUES (N'AD0001', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
GO
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'0000000003', N'RAU0001', 10, 20)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'0000000003', N'THI0001', 17, 20)
GO
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai]) VALUES (N'0001', CAST(N'2014-10-03' AS Date), 1000, N'Đã thanh toán')
GO
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap]) VALUES (N'000000000', N'QL20240001', N'NCC_RA0001', CAST(N'2024-10-05' AS Date))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap]) VALUES (N'0000000003', N'QL20240001', N'NCC_RA0001', CAST(N'2024-10-05' AS Date))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap]) VALUES (N'0001', N'QL20240001', N'NCC_RA0001', CAST(N'2024-10-05' AS Date))
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'MN0001', N'Vịt cháy tỏi', N'Cháy tỏi vịt', 200, 0)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'MN0002', N'Vịt cháy tỏi', N'Cháy tỏi vịt', 200, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'MN0003', N'Gà luộc', N'Đun sôi nước rồi luộc', 50, 1)
GO
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'RAU0001', N'rau cải', N'Gram', N'Bổ sung dinh dưỡng', N'Nấu chính', N'Ai bị dị ứng đừng ăn', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'THI0001', N'Thịt voi', N'Kg', N'Bổ dưỡng lắm', N'Ăn chín nhé', N'Ăn ít thôi', CAST(20.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'THI0002', N'Thịt vịt', N'Kg', N'Bổ dưỡng lắm', N'Ăn chín nhé', N'Ăn ít thôi', CAST(20.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_RA0001', N'Fuji Fress', N'Xã đàn, đống đa', N'0909898978', 1)
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'KH20240001', N'Lê Đăng Sơn', N'Nữ', CAST(N'2004-12-12' AS Date), N'Nam Định', N'Láng', N'0824382348', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'LT20240001', N'Mai Đức Vinh', N'Nữ', CAST(N'2004-12-12' AS Date), N'Thanh Hóa', N'Đào Tấn, Ba Đình', N'0909837823', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'QL20240001', N'Trương Văn Minh', N'Nữ', CAST(N'2004-05-10' AS Date), N'Nghệ An', N'79 Cầu Giấy', N'0373294997', N'Đang làm việc')
GO
INSERT [dbo].[QuyenTruyCap] ([ChucVu], [Menu]) VALUES (N'LT', N'pnlOrderList')
INSERT [dbo].[QuyenTruyCap] ([ChucVu], [Menu]) VALUES (N'KH', N'pnlImport')
INSERT [dbo].[QuyenTruyCap] ([ChucVu], [Menu]) VALUES (N'KH', N'pnlEditInformation')
INSERT [dbo].[QuyenTruyCap] ([ChucVu], [Menu]) VALUES (N'QL', N'pnlFood')
INSERT [dbo].[QuyenTruyCap] ([ChucVu], [Menu]) VALUES (N'QL', N'pnlEmployee')
INSERT [dbo].[QuyenTruyCap] ([ChucVu], [Menu]) VALUES (N'QL', N'pnlOrderList')
INSERT [dbo].[QuyenTruyCap] ([ChucVu], [Menu]) VALUES (N'AD', N'pnlOrderList')
INSERT [dbo].[QuyenTruyCap] ([ChucVu], [Menu]) VALUES (N'AD', N'pnlFood')
INSERT [dbo].[QuyenTruyCap] ([ChucVu], [Menu]) VALUES (N'AD', N'pnlImport')
INSERT [dbo].[QuyenTruyCap] ([ChucVu], [Menu]) VALUES (N'AD', N'pnlEmployee')
INSERT [dbo].[QuyenTruyCap] ([ChucVu], [Menu]) VALUES (N'AD', N'pnlEditInformation')
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([MaDon])
REFERENCES [dbo].[DonHang] ([MaDon])
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[MonAn] ([MaMonAn])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD FOREIGN KEY([MaHoaDonNhap])
REFERENCES [dbo].[HoaDonNhap] ([MaHoaDonNhap])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([MaNguyenLieu])
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[NguyenLieuMonAn]  WITH CHECK ADD FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[MonAn] ([MaMonAn])
GO
ALTER TABLE [dbo].[NguyenLieuMonAn]  WITH CHECK ADD FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([MaNguyenLieu])
GO
USE [master]
GO
ALTER DATABASE [QuanLyNguyenLieuMonAn] SET  READ_WRITE 
GO
