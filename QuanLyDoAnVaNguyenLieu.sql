USE [master]
GO
/****** Object:  Database [QuanLyNguyenLieuMonAn]    Script Date: 12/11/2024 11:50:29 PM ******/
CREATE DATABASE [QuanLyNguyenLieuMonAn]
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
/****** Object:  Table [dbo].[Account]    Script Date: 12/11/2024 11:50:29 PM ******/
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
/****** Object:  Table [dbo].[Admin]    Script Date: 12/11/2024 11:50:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminId] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 12/11/2024 11:50:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaDon] [nvarchar](14) NOT NULL,
	[MaMonAn] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDon] ASC,
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDonNhap]    Script Date: 12/11/2024 11:50:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonNhap](
	[MaHoaDonNhap] [nvarchar](14) NOT NULL,
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
/****** Object:  Table [dbo].[DonHang]    Script Date: 12/11/2024 11:50:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDon] [nvarchar](14) NOT NULL,
	[NgayTao] [datetime] NULL,
	[TongTien] [int] NULL,
	[TrangThai] [nvarchar](50) NULL,
	[SoBan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 12/11/2024 11:50:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[MaHoaDonNhap] [nvarchar](14) NOT NULL,
	[MaNhanVien] [nvarchar](10) NULL,
	[MaNhaCungCap] [nvarchar](10) NULL,
	[NgayNhap] [datetime] NULL,
	[ThanhTien] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 12/11/2024 11:50:30 PM ******/
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
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 12/11/2024 11:50:30 PM ******/
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
/****** Object:  Table [dbo].[NguyenLieuMonAn]    Script Date: 12/11/2024 11:50:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieuMonAn](
	[MaMonAn] [nvarchar](10) NOT NULL,
	[MaNguyenLieu] [nvarchar](10) NOT NULL,
	[SoLuong] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC,
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 12/11/2024 11:50:30 PM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/11/2024 11:50:30 PM ******/
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
/****** Object:  Table [dbo].[QuyenTruyCap]    Script Date: 12/11/2024 11:50:30 PM ******/
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
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224001', N'AP0001', 5)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224001', N'AP0002', 2)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224001', N'DS0002', 6)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224001', N'MN0001', 10)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224001', N'MN0002', 4)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224001', N'MN0003', 7)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224004', N'AP0001', 2)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224004', N'AP0002', 2)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224004', N'AP0003', 3)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224004', N'DS0001', 1)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224009', N'MN0001', 3)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224009', N'MN0002', 3)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224010', N'DS0001', 8)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224010', N'DS0003', 4)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224010', N'MN0003', 5)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224016', N'AP0001', 2)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224016', N'AP0003', 7)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224016', N'DS0002', 5)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224016', N'MN0001', 6)
INSERT [dbo].[ChiTietDonHang] ([MaDon], [MaMonAn], [SoLuong]) VALUES (N'HDB010224016', N'MN0003', 9)
GO
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN010224001', N'TH0001', 10, 20000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN010224002', N'RA0002', 40, 6000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN010224004', N'HA0002', 10, 60000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN010224005', N'DA0002', 25, 3500)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN060224001', N'TH0002', 5, 30000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN070224001', N'RA0003', 30, 4000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN070224002', N'GA0001', 20, 3000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN071124001', N'DA0001', 1, 1234567891)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN090224001', N'HA0001', 12, 50000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN090224002', N'DA0001', 15, 4000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN090224003', N'TH0003', 20, 15000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN101024001', N'DA0001', 10, 10)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN101024001', N'DA0004', 20, 20000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN101024002', N'HA0002', 10, 100000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN101024002', N'HA0003', 10, 100000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN111024001', N'DA0001', 10, 10)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN120224001', N'RA0004', 50, 5000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN120224002', N'GA0002', 60, 2500)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN120224003', N'HA0003', 30, 12000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN120224003', N'TH0001', 18, 20000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN120224003', N'TH0002', 12, 8000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN120224003', N'TH0003', 5, 7000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN120224004', N'DA0004', 25, 10000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN141024001', N'DA0001', 10, 10)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN160224001', N'TH0004', 15, 50000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN180224001', N'GA0004', 30, 15000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN200224001', N'DA0003', 10, 25000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHoaDonNhap], [MaNguyenLieu], [SoLuong], [DonGia]) VALUES (N'HDN241024001', N'DA0001', 12, 100000)
GO
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224001', CAST(N'2024-02-01T00:00:00.000' AS DateTime), 150000, N'Đã thanh toán', 1)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224002', CAST(N'2024-02-02T00:00:00.000' AS DateTime), 250000, N'Đã thanh toán', 2)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224003', CAST(N'2024-02-03T00:00:00.000' AS DateTime), 300000, N'Đã thanh toán', 3)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224004', CAST(N'2024-02-04T00:00:00.000' AS DateTime), 200000, N'Đã thanh toán', 4)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224005', CAST(N'2024-02-05T00:00:00.000' AS DateTime), 180000, N'Đã thanh toán', 5)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224006', CAST(N'2024-02-06T00:00:00.000' AS DateTime), 220000, N'Đã thanh toán', 6)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224007', CAST(N'2024-02-07T00:00:00.000' AS DateTime), 140000, N'Đã thanh toán', 7)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224008', CAST(N'2024-02-08T00:00:00.000' AS DateTime), 320000, N'Đã thanh toán', 8)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224009', CAST(N'2024-02-09T00:00:00.000' AS DateTime), 270000, N'Đã thanh toán', 9)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224010', CAST(N'2024-02-10T00:00:00.000' AS DateTime), 330000, N'Đã thanh toán', 10)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224011', CAST(N'2024-02-11T00:00:00.000' AS DateTime), 150000, N'Đã thanh toán', 11)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224012', CAST(N'2024-02-12T00:00:00.000' AS DateTime), 200000, N'Đã thanh toán', 12)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224013', CAST(N'2024-02-13T00:00:00.000' AS DateTime), 240000, N'Đã thanh toán', 1)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224014', CAST(N'2024-02-14T00:00:00.000' AS DateTime), 300000, N'Đã thanh toán', 2)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224015', CAST(N'2024-02-15T00:00:00.000' AS DateTime), 160000, N'Đã thanh toán', 4)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224016', CAST(N'2024-02-16T00:00:00.000' AS DateTime), 270000, N'Đã thanh toán', 5)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224017', CAST(N'2024-02-17T00:00:00.000' AS DateTime), 190000, N'Đã thanh toán', 6)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224018', CAST(N'2024-02-18T00:00:00.000' AS DateTime), 210000, N'Đã thanh toán', 2)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010224019', CAST(N'2024-02-19T00:00:00.000' AS DateTime), 350000, N'Đã thanh toán', 3)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010324020', CAST(N'2024-03-01T00:00:00.000' AS DateTime), 100000, N'Đã thanh toán', 2)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB010424020', CAST(N'2024-04-01T00:00:00.000' AS DateTime), 100000, N'Đã thanh toán', 2)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB020424020', CAST(N'2024-04-01T00:00:00.000' AS DateTime), 100000, N'Chưa thanh toán', 2)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB071124001', CAST(N'2024-11-07T10:14:32.117' AS DateTime), 0, N'Chưa thanh toán', 0)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB071124002', CAST(N'2024-11-07T10:14:37.273' AS DateTime), 0, N'Chưa thanh toán', 0)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB121124001', CAST(N'2024-11-12T16:42:51.647' AS DateTime), 0, N'Chưa thanh toán', 0)
INSERT [dbo].[DonHang] ([MaDon], [NgayTao], [TongTien], [TrangThai], [SoBan]) VALUES (N'HDB201024020', CAST(N'2024-10-20T00:00:00.000' AS DateTime), 290000, N'Đã thanh toán', 12)
GO
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN010224001', N'KH20240003', N'NCC_TH0001', CAST(N'2024-02-01T00:00:00.000' AS DateTime), CAST(200000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN010224002', N'KH20230002', N'NCC_RA0002', CAST(N'2024-02-01T00:00:00.000' AS DateTime), CAST(240000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN010224003', N'KH20240004', N'NCC_GA0003', CAST(N'2024-02-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN010224004', N'KH20240003', N'NCC_HA0004', CAST(N'2024-02-01T00:00:00.000' AS DateTime), CAST(600000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN010224005', N'KH20240005', N'NCC_DA0002', CAST(N'2024-02-01T00:00:00.000' AS DateTime), CAST(87500.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN060224001', N'KH20240003', N'NCC_TH0002', CAST(N'2024-02-06T00:00:00.000' AS DateTime), CAST(150000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN070224001', N'KH20240005', N'NCC_RA0003', CAST(N'2024-02-07T00:00:00.000' AS DateTime), CAST(120000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN070224002', N'KH20240003', N'NCC_GA0001', CAST(N'2024-02-07T00:00:00.000' AS DateTime), CAST(60000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN071124001', N'KH20240001', N'NCC_DA0001', CAST(N'2024-11-07T14:16:26.850' AS DateTime), CAST(1234567891.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN090224001', N'KH20240001', N'NCC_HA0001', CAST(N'2024-02-09T00:00:00.000' AS DateTime), CAST(600000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN090224002', N'KH20240003', N'NCC_DA0001', CAST(N'2024-02-09T00:00:00.000' AS DateTime), CAST(60000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN090224003', N'KH20240002', N'NCC_TH0003', CAST(N'2024-02-09T00:00:00.000' AS DateTime), CAST(300000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN101024001', N'KH20240001', N'NCC_DA0001', CAST(N'2024-10-10T00:00:00.000' AS DateTime), CAST(400100.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN101024002', N'KH20240001', N'NCC_HA0001', CAST(N'2024-10-10T00:00:00.000' AS DateTime), CAST(2000000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN111024001', N'kh20240001', N'NCC_DA0001', CAST(N'2024-10-11T00:00:00.000' AS DateTime), CAST(100.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN120224001', N'KH20240005', N'NCC_RA0004', CAST(N'2024-02-12T00:00:00.000' AS DateTime), CAST(250000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN120224002', N'KH20240003', N'NCC_GA0002', CAST(N'2024-02-12T00:00:00.000' AS DateTime), CAST(150000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN120224003', N'KH20240005', N'NCC_HA0003', CAST(N'2024-02-12T00:00:00.000' AS DateTime), CAST(851000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN120224004', N'KH20240002', N'NCC_DA0004', CAST(N'2024-02-12T00:00:00.000' AS DateTime), CAST(250000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN141024001', N'KH20240001', N'NCC_DA0001', CAST(N'2024-10-14T15:59:59.017' AS DateTime), CAST(100000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN160224001', N'KH20240003', N'NCC_TH0004', CAST(N'2024-02-16T00:00:00.000' AS DateTime), CAST(750000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN160224002', N'KH20240003', N'NCC_RA0005', CAST(N'2024-02-16T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN180224001', N'KH20240001', N'NCC_GA0004', CAST(N'2024-02-18T00:00:00.000' AS DateTime), CAST(450000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN190224001', N'KH20240002', N'NCC_HA0002', CAST(N'2024-02-19T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN200224001', N'KH20240003', N'NCC_DA0003', CAST(N'2024-02-20T00:00:00.000' AS DateTime), CAST(250000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [MaNhanVien], [MaNhaCungCap], [NgayNhap], [ThanhTien]) VALUES (N'HDN241024001', N'kh20240001', N'NCC_DA0001', CAST(N'2024-10-24T22:19:06.680' AS DateTime), CAST(1200000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'AP0001', N'Phở Bò', N'Nấu nước dùng', 35000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'AP0002', N'Bún Chả', N'Nướng thịt, làm nước mắm', 40000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'AP0003', N'Mì Quảng', N'Nấu mì', 35000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'AP0004', N'Bánh Xèo', N'Đổ bánh xèo', 30000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'AP0005', N'Bánh Mì', N'Làm pate, bơ', 20000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'AP0006', N'Canh Chua', N'Nấu canh chua', 30000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'AP0007', N'Gà Chiên', N'Chiên gà', 40000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'DS0001', N'Chả Cá', N'Rán cá với dầu', 45000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'DS0002', N'Nem Rán', N'Rán nem với dầu', 40000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'DS0003', N'Chả Giò', N'Rán chả giò', 25000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'DS0004', N'Bánh Canh', N'Nấu nước dùng', 25000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'DS0005', N'Cá Kho', N'Kho cá với nước', 45000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'DS0006', N'Thịt Xiên', N'Nướng thịt', 35000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'MN0001', N'Ngan cháy tỏi', N'Cháy tỏi vịt', 50000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'MN0002', N'Vịt cháy tỏi', N'Cháy tỏi vịt', 50000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'MN0003', N'Gà luộc', N'Đun sôi nước rồi luộc', 50000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'MN0004', N'Bún Riêu', N'Nấu nước dùng', 30000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'MN0005', N'Cơm Tấm', N'Nướng thịt, nước mắm', 50000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'MN0006', N'Hủ Tiếu', N'Nấu hủ tiếu', 30000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'MN0007', N'Bún Thịt Nướng', N'Nướng thịt, làm bún', 45000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'MN0008', N'Gà Nướng', N'Nướng gà', 55000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'MN0009', N'Thịt Kho', N'Kho thịt', 40000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [CachLam], [DonGia], [TrangThai]) VALUES (N'MN0010', N'Cơm Cháy', N'Rán cơm', 25000, 1)
GO
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'DA0001', N'Cá khô', N'Kg', N'ăn', N'Bảo quản nơi khô ráo', N'Không dùng cho người bị dị ứng', CAST(43.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'DA0002', N'Bột Mì', N'Kg', N'Làm Bánh', N'Tươi', N'Không', CAST(75.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'DA0003', N'Mì Chính', N'Gói', N'Làm Món Ăn', N'Không', N'Không', CAST(110.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'DA0004', N'Hạt Nêm', N'Gói', N'Làm Món Ăn', N'Không', N'Không', CAST(90.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'GA0001', N'Muối', N'Gói', N'Làm Món Ăn', N'Không', N'Không', CAST(50.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'GA0002', N'Tiêu', N'Kg', N'Làm Nem Rán', N'Không', N'Không', CAST(90.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'GA0003', N'Nước Mắm', N'Chai', N'Làm Bún', N'Không', N'Không', CAST(100.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'GA0004', N'Gừng', N'Kg', N'Làm Gia Vị', N'Tươi', N'Không', CAST(65.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'HA0001', N'Mực', N'Kg', N'Làm Chả Mực', N'Tươi', N'Không', CAST(70.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'HA0002', N'Cá Hồi', N'Kg', N'Làm Sushi', N'Tươi', N'Không', CAST(60.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'HA0003', N'Cá Ngừ', N'Kg', N'Làm Món Cá', N'Tươi', N'Không', CAST(70.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'HA0004', N'Tôm', N'Kg', N'Làm Hải Sản', N'Tươi', N'Không', CAST(75.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'RA0001', N'Rau Thơm', N'Kg', N'Làm Bún', N'Tươi', N'Không', CAST(80.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'RA0002', N'Rau Muống', N'Kg', N'Làm Rau Muống', N'Tươi', N'Không', CAST(150.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'RA0003', N'Rau Thơm', N'Kg', N'Làm Phở', N'Tươi', N'Không', CAST(40.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'RA0004', N'Rau Đắng', N'Kg', N'Làm Gỏi', N'Tươi', N'Không', CAST(55.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'TH0001', N'Thịt Bò', N'Kg', N'Làm Phở', N'Tươi', N'Không', CAST(100.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'TH0002', N'Thịt Heo', N'Kg', N'Làm Cơm Tấm', N'Tươi', N'Không', CAST(200.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'TH0003', N'Thịt Gà', N'Kg', N'Làm Gà Rán', N'Tươi', N'Không', CAST(80.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [CongDung], [YeuCau], [ChongChiDinh], [Soluong]) VALUES (N'TH0004', N'Thịt Cừu', N'Kg', N'Làm Món Ăn', N'Tươi', N'Không', CAST(85.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'AP0001', N'TH0001', CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'AP0001', N'TH0002', CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'AP0002', N'TH0001', CAST(3.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'AP0002', N'TH0003', CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'AP0003', N'TH0002', CAST(4.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'AP0003', N'TH0004', CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'AP0004', N'TH0001', CAST(3.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'AP0004', N'TH0004', CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'DS0001', N'TH0002', CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'DS0001', N'TH0003', CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'DS0002', N'TH0001', CAST(4.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'DS0002', N'TH0003', CAST(3.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'DS0003', N'TH0002', CAST(5.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'DS0003', N'TH0004', CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MN0001', N'TH0002', CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MN0001', N'TH0003', CAST(5.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MN0002', N'TH0001', CAST(3.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MN0002', N'TH0004', CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MN0003', N'TH0002', CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[NguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MN0003', N'TH0003', CAST(1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_DA0001', N'Công Ty Đồ Khô', N'654 Đường E', N'0922222222', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_DA0002', N'Công Ty Đồ Khô Nhập Khẩu', N'468 Đường J', N'0977777777', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_DA0003', N'Công Ty Đồ Khô Chất Lượng', N'913 Đường O', N'0923232323', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_DA0004', N'Công Ty Đồ Khô Cao Cấp', N'468 Đường T', N'0978787878', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_GA0001', N'Công Ty Gia Vị', N'789 Đường C', N'0909090909', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_GA0002', N'Công Ty Gia Vị Nhập Khẩu', N'246 Đường H', N'0955555555', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_GA0003', N'Công Ty Gia Vị Sạch', N'791 Đường M', N'0901010101', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_GA0004', N'Công Ty Gia Vị Đặc Biệt', N'246 Đường R', N'0956565656', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_HA0001', N'Công Ty Hải Sản', N'321 Đường D', N'0912121212', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_HA0002', N'Công Ty Hải Sản Tươi', N'357 Đường I', N'0966666666', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_HA0003', N'Công Ty Hải Sản Nguyên Chất', N'802 Đường N', N'0912121212', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_HA0004', N'Công Ty Hải Sản Chất Lượng', N'357 Đường S', N'0967676767', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_RA0001', N'Fuji Fresh', N'Xã Đàn, Đống Đa', N'0909898978', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_RA0002', N'Công Ty Rau Sạch', N'456 Đường B', N'0987654321', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_RA0003', N'Công Ty Rau Quả', N'135 Đường G', N'0944444444', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_RA0004', N'Công Ty Rau Quả Tươi', N'680 Đường L', N'0999999999', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_RA0005', N'Công Ty Rau Xanh', N'135 Đường Q', N'0945454545', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_TH0001', N'Công Ty Thịt Bò', N'123 Đường A', N'0123456789', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_TH0002', N'Công Ty Thịt Heo', N'987 Đường F', N'0933333333', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_TH0003', N'Công Ty Thịt Gà', N'579 Đường K', N'0988888888', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'NCC_TH0004', N'Công Ty Thịt Chất Lượng', N'963 Đường T', N'0919292929', 1)
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'KH20230001', N'Lê Thị B', N'Nữ', CAST(N'1992-02-02' AS Date), N'Hải Phòng', N'45 Trần Phú', N'0987654321', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'KH20230002', N'Phạm Văn E', N'Nam', CAST(N'1988-03-03' AS Date), N'Hải Dương', N'78 Trần Hưng Đạo', N'0933333333', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'KH20230003', N'Nguyễn Văn H', N'Nam', CAST(N'1990-06-06' AS Date), N'Quảng Trị', N'34 Hai Bà Trưng', N'0955555555', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'KH20240001', N'Lê Đăng Sơn', N'Nữ', CAST(N'2004-12-12' AS Date), N'Nam Định', N'Láng', N'0824382348', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'KH20240002', N'Nguyễn Văn L', N'Nam', CAST(N'1993-09-09' AS Date), N'Hà Nam', N'67 Võ Nguyên Giáp', N'0988888888', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'KH20240003', N'Lê Văn O', N'Nam', CAST(N'1994-12-12' AS Date), N'Hải Phòng', N'34 An Dương Vương', N'0912121212', N'Đã nghỉ việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'KH20240004', N'Nguyễn Văn R', N'Nam', CAST(N'1989-03-03' AS Date), N'Thanh Hóa', N'12 Bạch Đằng', N'0945454545', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'KH20240005', N'Nguyễn Văn U', N'Nam', CAST(N'1992-06-06' AS Date), N'Bình Định', N'78 Nguyễn Tri Phương', N'0978787878', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'LT20230001', N'Nguyễn Văn A', N'Nam', CAST(N'1990-01-01' AS Date), N'Hà Nội', N'123 Hoàng Hoa Thám', N'0123456789', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'LT20230002', N'Nguyễn Thị D', N'Nữ', CAST(N'1989-09-09' AS Date), N'Hà Nam', N'56 Lê Lợi', N'0912121212', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'LT20230003', N'Nguyễn Thị G', N'Nữ', CAST(N'1991-05-05' AS Date), N'Vinh', N'23 Lê Lợi', N'0944444444', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'LT20230004', N'Lê Văn K', N'Nam', CAST(N'1984-08-08' AS Date), N'Nghệ An', N'56 Phan Bội Châu', N'0977777777', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'LT20240001', N'Mai Đức Vinh', N'Nữ', CAST(N'2004-12-12' AS Date), N'Thanh Hóa', N'Đào Tấn, Ba Đình', N'0909837823', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'LT20240002', N'Nguyễn Thị N', N'Nữ', CAST(N'1992-11-11' AS Date), N'Hà Nội', N'12 Trường Chinh', N'0901010101', N'Đã nghỉ việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'LT20240003', N'Nguyễn Thị Q', N'Nữ', CAST(N'1990-02-02' AS Date), N'Hà Nội', N'78 Phạm Văn Đồng', N'0934343434', N'Đã nghỉ việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'LT20240004', N'Lê Văn T', N'Nam', CAST(N'1990-05-05' AS Date), N'Quảng Nam', N'56 Đồng Khởi', N'0967676767', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'QL20230001', N'Trần Văn C', N'Nam', CAST(N'1985-05-05' AS Date), N'Đà Nẵng', N'67 Nguyễn Huệ', N'0909090909', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'QL20230002', N'Lê Văn F', N'Nam', CAST(N'1987-04-04' AS Date), N'Nam Định', N'12 Trần Quốc Toản', N'0922222222', N'Đã nghỉ việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'QL20230003', N'Trần Thị I', N'Nữ', CAST(N'1986-07-07' AS Date), N'Thanh Hóa', N'45 Lý Thường Kiệt', N'0966666666', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'QL20230004', N'Lê Văn J', N'Nam', CAST(N'1988-08-08' AS Date), N'Hà Nội', N'34 Hàng Bông', N'0945454545', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'QL20240001', N'Nguyễn Thị Lan', N'Nữ', CAST(N'1995-10-10' AS Date), N'Hà Nội', N'90 Trần Đại Nghĩa', N'0912345678', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'QL20240002', N'Lê Văn M', N'Nam', CAST(N'1999-09-09' AS Date), N'Hà Nội', N'23 Phạm Ngọc Thạch', N'0988888888', N'Đang làm việc')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [QueQuan], [DiaChi], [DienThoai], [TrangThai]) VALUES (N'QL20240003', N'Lê Thị N', N'Nữ', CAST(N'1982-12-12' AS Date), N'Bắc Giang', N'34 Nguyễn Khuyến', N'0919191919', N'Đang làm việc')
GO
INSERT [dbo].[QuyenTruyCap] ([ChucVu], [Menu]) VALUES (N'KH', N'pnlImport')
INSERT [dbo].[QuyenTruyCap] ([ChucVu], [Menu]) VALUES (N'QL', N'pnlEditInformation')
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
