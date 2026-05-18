
--XOÁ DATABASE

USE master;
GO
ALTER DATABASE QuanLyCuaHangDoAnNhanh SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO
DROP DATABASE QuanLyCuaHangDoAnNhanh;
GO

--THÊM DATABASE

CREATE DATABASE QuanLyCuaHangDoAnNhanh;
GO
USE QuanLyCuaHangDoAnNhanh;
GO

--BẢNG LOẠI MÓN ĂN

CREATE TABLE LoaiMon (
    maLoaiMon   INT PRIMARY KEY IDENTITY(1,1),
    tenLoaiMon  NVARCHAR(100)   NOT NULL,
    moTa        NVARCHAR(255),
    trangThai   BIT             NOT NULL DEFAULT 1  -- 1: Đang dùng, 0: Ngừng
);
 
--BẢNG MÓN ĂN

CREATE TABLE MonAn (
    maMonAn     INT PRIMARY KEY IDENTITY(1,1),
    maLoaiMon   INT             NOT NULL,
    tenMonAn    NVARCHAR(150)   NOT NULL,
    moTa        NVARCHAR(255),
    donViTinh   NVARCHAR(50),
    giaBan      DECIMAL(18,0)   NOT NULL DEFAULT 0,
	hinhAnh     NVARCHAR(255),
    trangThai   BIT             NOT NULL DEFAULT 1,
 
    CONSTRAINT FK_MonAn_LoaiMon FOREIGN KEY (maLoaiMon)
        REFERENCES LoaiMon(maLoaiMon)
);
 
-- BẢNG KHÁCH HÀNG

CREATE TABLE KhachHang (
    maKH            INT PRIMARY KEY IDENTITY(1,1),
    tenKH           NVARCHAR(150)   NOT NULL,
    soDienThoai     NVARCHAR(20),
    diaChi          NVARCHAR(255),
    ngaySinh        DATE,
    gioiTinh        NVARCHAR(10),
    trangThai       BIT             NOT NULL DEFAULT 1,
);

-- BẢNG NHÂN VIÊN

CREATE TABLE NhanVien (
    maNV            INT PRIMARY KEY IDENTITY(1,1),
    tenNV           NVARCHAR(150)   NOT NULL,
    soDienThoai     NVARCHAR(20),
    diaChi          NVARCHAR(255),
    email           NVARCHAR(150),
    ngaySinh        DATE,
    gioiTinh        NVARCHAR(10),
    trangThai       BIT             NOT NULL DEFAULT 1
);
 
-- BẢNG NHÀ CUNG CẤP

CREATE TABLE NhaCungCap (
    maNhaCC         INT PRIMARY KEY IDENTITY(1,1),
    tenNhaCC        NVARCHAR(150)   NOT NULL,
    diaChi          NVARCHAR(255),
    soDienThoai     NVARCHAR(20),
    email           NVARCHAR(150),
    trangThai       BIT             NOT NULL DEFAULT 1
);
 
--BẢNG NGUYÊN LIỆU 

CREATE TABLE NguyenLieu (
    maNL         NVARCHAR(20)   PRIMARY KEY,
    tenNL        NVARCHAR(150)  NOT NULL,
    donVi        NVARCHAR(50),
	giaNhap      DECIMAL(18,0)  NOT NULL DEFAULT 0,
    soLuongTon   INT            NOT NULL DEFAULT 0,
    tenKho       NVARCHAR(150)  NOT NULL,
    diaChiKho    NVARCHAR(255),
    trangThaiKho BIT            NOT NULL DEFAULT 1
);

-- BẢNG KHUYẾN MÃI 

CREATE TABLE KhuyenMai (
    maKM         INT            PRIMARY KEY IDENTITY(1,1),
    tenKM        NVARCHAR(150)  NOT NULL,
    loaiKM       NVARCHAR(20)   NOT NULL,   -- PhanTram | SoTienCoDinh
    giaTriKM     DECIMAL(18,0)  NOT NULL DEFAULT 0,
    ngayBatDau   DATE           NOT NULL,
    ngayKetThuc  DATE           NOT NULL,
    trangThai    BIT            NOT NULL DEFAULT 1,
    maMonAn      INT,                       -- NULL = áp dụng tất cả món

    CONSTRAINT FK_KhuyenMai_MonAn FOREIGN KEY (maMonAn)
        REFERENCES MonAn(maMonAn)
);

-- BẢNG HÓA ĐƠN BÁN

CREATE TABLE HoaDonBan (
    maHD        INT PRIMARY KEY IDENTITY(1,1),
    maKH        INT,                        
    maKM        INT,                        
    maNV        INT             NOT NULL,
    ngayLap     DATETIME        NOT NULL DEFAULT GETDATE(),
    tongTien    DECIMAL(18,0)   NOT NULL DEFAULT 0,
    trangThai   NVARCHAR(50)    NOT NULL DEFAULT N'Chờ xử lý',
 
    CONSTRAINT FK_HDB_KhachHang FOREIGN KEY (maKH)
        REFERENCES KhachHang(maKH),
    CONSTRAINT FK_HDB_KhuyenMai FOREIGN KEY (maKM)
        REFERENCES KhuyenMai(maKM),
    CONSTRAINT FK_HDB_NhanVien  FOREIGN KEY (maNV)
        REFERENCES NhanVien(maNV)
);
 
--BẢNG CHI TIẾT HÓA ĐƠN BÁN

CREATE TABLE ChiTietHDB (
    maHD        INT             NOT NULL,
    maMonAn     INT             NOT NULL,
    soLuong     INT             NOT NULL DEFAULT 1,
    donGia      DECIMAL(18,0)   NOT NULL DEFAULT 0,
    maHDB       NVARCHAR(20),             
 
    PRIMARY KEY (maHD, maMonAn),
 
    CONSTRAINT FK_CTHDB_HoaDon  FOREIGN KEY (maHD)
        REFERENCES HoaDonBan(maHD),
    CONSTRAINT FK_CTHDB_MonAn   FOREIGN KEY (maMonAn)
        REFERENCES MonAn(maMonAn)
);

--BẢNG HÓA ĐƠN NHẬP

CREATE TABLE HoaDonNhap (
    maHDN       INT             PRIMARY KEY IDENTITY(1,1),
    maNhaCC     INT             NOT NULL,
    maNV        INT             NOT NULL,
    tongTien    DECIMAL(18,0)   NOT NULL DEFAULT 0,
    ngayNhap    DATETIME        NOT NULL DEFAULT GETDATE(),
    trangThai   NVARCHAR(50)    NOT NULL DEFAULT N'Chờ xử lý',

    CONSTRAINT FK_HDN_NhaCungCap FOREIGN KEY (maNhaCC)
        REFERENCES NhaCungCap(maNhaCC),
    CONSTRAINT FK_HDN_NhanVien   FOREIGN KEY (maNV)
        REFERENCES NhanVien(maNV)
);

--BẢNG CHI TIẾT HÓA ĐƠN NHẬP

CREATE TABLE ChiTietHDN (
    maHDN       INT             NOT NULL,
    maNL        NVARCHAR(20)    NOT NULL,
    soLuong     INT             NOT NULL DEFAULT 1,
    donGia      DECIMAL(18,0)   NOT NULL DEFAULT 0,

    PRIMARY KEY (maHDN, maNL),

    CONSTRAINT FK_CTHDN_HoaDonNhap FOREIGN KEY (maHDN)
        REFERENCES HoaDonNhap(maHDN),
    CONSTRAINT FK_CTHDN_NguyenLieu FOREIGN KEY (maNL)
        REFERENCES NguyenLieu(maNL)
);

-- BẢNG NGƯỜI DÙNG (Phân quyền đăng nhập)

CREATE TABLE NguoiDung (
    maNguoiDung INT PRIMARY KEY IDENTITY(1,1),
    tenDangNhap NVARCHAR(50)    NOT NULL UNIQUE,
    matKhau     NVARCHAR(255)   NOT NULL,
    vaiTro      NVARCHAR(20)    NOT NULL,
    -- N'QuanLy', N'NhanVien'
    maNV        INT,                       
    trangThai   BIT             NOT NULL DEFAULT 1,
 
    CONSTRAINT FK_NguoiDung_NhanVien FOREIGN KEY (maNV)
        REFERENCES NhanVien(maNV)
);

--DỮ LIỆU MẪU 

-- 1. LOẠI MÓN ĂN

INSERT INTO LoaiMon (tenLoaiMon, moTa, trangThai) VALUES
(N'Cơm hộp', N'Các suất cơm hộp tiện lợi', 1),
(N'Mì - Cháo - Súp', N'Mì tôm, cháo ăn liền các loại', 1),
(N'Đồ uống', N'Cà phê, trà, nước đóng chai, sữa', 1),
(N'Bánh & Snack', N'Bánh mì, bánh ngọt, snack ăn vặt', 1),
(N'Ăn nhanh hâm nóng', N'Xúc xích, há cảo, chiên quay tại quầy', 1);

-- 2. MÓN ĂN

INSERT INTO MonAn
(maLoaiMon, tenMonAn, moTa, donViTinh, giaBan, hinhAnh, trangThai)
VALUES
(1, N'Cơm hộp gà teriyaki', N'Cơm trắng + gà sốt teriyaki Nhật', N'Hộp', 45000, N'com_ga.jpg', 1),
(1, N'Cơm hộp thịt kho trứng', N'Cơm trắng + thịt kho trứng', N'Hộp', 40000, N'com_thitkho.jpg', 1),
(2, N'Mì cay Hàn Quốc Shin', N'Mì cay cấp độ 3 nhập khẩu Hàn', N'Gói', 25000, N'mi_shin.jpg', 1),
(3, N'Cà phê sữa đá GS25', N'Cà phê pha sẵn thương hiệu GS25', N'Ly', 20000, N'caphe_gs25.jpg', 1),
(4, N'Bánh mì kẹp xúc xích', N'Bánh mì mềm kẹp xúc xích nướng', N'Cái', 15000, N'banhmi_xucxich.jpg', 1);

-- 3. KHÁCH HÀNG

INSERT INTO KhachHang (tenKH, soDienThoai, diaChi, ngaySinh, gioiTinh, trangThai) VALUES
(N'Nguyễn Minh Tuấn',  '0901234567', N' Nguyễn Trãi, Hà Nội',        '1998-05-12', N'Nam', 1),
(N'Trần Thị Lan Anh',  '0912345678', N' Lê Văn Sỹ, TP.HCM',          '2000-09-23', N'Nữ',  1),
(N'Lê Công Dũng',      '0923456789', N' Điện Biên Phủ, Đà Nẵng',     '1995-03-08', N'Nam', 1),
(N'Phạm Huyền Trang',  '0934567890', N' Trần Phú, Nha Trang',        '2001-11-17', N'Nữ',  1),
(N'Hoàng Thế Vinh',    '0945678901', N' Lý Tự Trọng, Cần Thơ',      '1997-07-30', N'Nam', 1);

-- 4. NHÂN VIÊN

INSERT INTO NhanVien (tenNV, soDienThoai, diaChi, email, ngaySinh, gioiTinh, trangThai) VALUES
(N'Nguyễn Thị Thu Hà',  '0911000001', N'10 Bà Triệu, Hà Nội',         'hanha.gs25@gmail.com',  '1999-04-15', N'Nữ',  1),
(N'Trần Quốc Bảo',      '0922000002', N'34 CMT8, TP.HCM',              'bao.gs25@gmail.com',    '1997-08-20', N'Nam', 1),
(N'Lê Thị Kiều My',     '0933000003', N'67 Hùng Vương, Huế',           'kieumy.gs25@gmail.com', '2000-01-10', N'Nữ',  1),
(N'Phạm Thanh Long',    '0944000004', N'89 Ngô Gia Tự, Bắc Ninh',     'long.gs25@gmail.com',   '1996-06-05', N'Nam', 1),
(N'Võ Ngọc Phương',     '0955000005', N'11 Lê Lợi, Vũng Tàu',         'phuong.gs25@gmail.com', '2001-12-28', N'Nữ',  1);

-- 5. NHÀ CUNG CẤP

INSERT INTO NhaCungCap (tenNhaCC, diaChi, soDienThoai, email, trangThai) VALUES
(N'Công ty CP CJ Foods Việt Nam',   N'KCN Mỹ Phước, Bình Dương',      '02743111111', 'cjfoods@cj.vn',       1),
(N'Công ty Acecook Việt Nam',       N'KCN Tân Bình, TP.HCM',          '02838222222', 'acecook@acecook.vn',  1),
(N'Công ty TNHH Kirin Việt Nam',    N'KCN Long Hậu, Long An',         '02723333333', 'kirin@kirin.vn',      1),
(N'Công ty CP Vissan',              N'420 Nơ Trang Long, TP.HCM',     '02838444444', 'vissan@vissan.vn',    1),
(N'Công ty Lotte Việt Nam',         N'KCN Thăng Long, Hà Nội',        '02436555555', 'lotte@lotte.vn',      1);

-- 6. NGUYÊN LIỆU

INSERT INTO NguyenLieu (maNL, tenNL, donVi, soLuongTon, tenKho, diaChiKho, trangThaiKho) VALUES
('NL001', N'Gạo Japonica',         N'Kg',   150, N'Kho Khô GS25',    N'Tầng 1 - Khu A', 1),
('NL002', N'Ức gà đông lạnh',      N'Kg',    40, N'Kho Lạnh GS25',   N'Tầng 1 - Khu B', 1),
('NL003', N'Xúc xích heo Vissan',  N'Cây', 500, N'Kho Lạnh GS25',   N'Tầng 1 - Khu B', 1),
('NL004', N'Mì Shin Ramyun',       N'Gói',  200, N'Kho Khô GS25',    N'Tầng 1 - Khu A', 1),
('NL005', N'Trà xanh Kirin 500ml', N'Chai', 300, N'Kho Mát GS25',    N'Tầng 2 - Khu C', 1);

-- 7. KHUYẾN MÃI

INSERT INTO KhuyenMai (tenKM, loaiKM, giaTriKM, ngayBatDau, ngayKetThuc, trangThai, maMonAn) VALUES
(N'Giảm 10% cơm hộp gà teriyaki',    N'PhanTram',      10, '2026-05-01', '2026-05-31', 1, 1),
(N'Giảm 5.000đ mì Shin Hàn Quốc',   N'SoTienCoDinh', 5000, '2026-05-01', '2026-05-31', 1, 3),
(N'Combo cà phê + bánh mì giảm 15%', N'PhanTram',      15, '2026-05-10', '2026-05-20', 1, NULL),
(N'Giảm 10% bánh mì kẹp xúc xích',  N'PhanTram',      10, '2026-05-15', '2026-05-20', 1, 5),
(N'Giảm 20% toàn bộ đồ uống',       N'PhanTram',      20, '2026-06-01', '2026-06-30', 1, NULL);

-- 8. HÓA ĐƠN BÁN

INSERT INTO HoaDonBan (maKH, maKM, maNV, ngayLap, tongTien, trangThai) VALUES
(1, 1,    1, '2026-05-10 07:45:00', 40500, N'Hoàn thành'),
(2, NULL, 2, '2026-05-10 08:20:00', 47000, N'Hoàn thành'),
(3, 3,    1, '2026-05-11 09:10:00', 20000, N'Hoàn thành'),
(4, NULL, 3, '2026-05-12 12:00:00', 55000, N'Hoàn thành'),
(5, NULL, 2, '2026-05-13 13:30:00', 29750, N'Hoàn thành');

-- 9. CHI TIẾT HÓA ĐƠN BÁN

INSERT INTO ChiTietHDB (maHD, maMonAn, soLuong, donGia) VALUES
(2, 1, 1, 45000),   -- HĐ5: Cơm gà teriyaki
(3, 1, 1, 40000),   -- HĐ6: Cơm thịt kho trứng
(4, 2, 1, 25000),   -- HĐ7: Mì Shin Hàn Quốc
(5, 3, 1, 20000),   -- HĐ8: Cà phê sữa đá
(6, 4, 1, 15000);   -- HĐ9: Bánh mì kẹp xúc xích

-- 10. HÓA ĐƠN NHẬP

INSERT INTO HoaDonNhap (maNhaCC, maNV, tongTien, ngayNhap, trangThai) VALUES
(1, 1, 3000000, '2026-05-01 06:30:00', N'Hoàn thành'),  -- CJ Foods - gà
(2, 2, 1500000, '2026-05-02 07:00:00', N'Hoàn thành'),  -- Acecook - mì
(3, 1,  900000, '2026-05-05 08:00:00', N'Hoàn thành'),  -- Kirin - trà
(4, 3, 2000000, '2026-05-07 09:00:00', N'Hoàn thành'),  -- Vissan - xúc xích
(5, 2,  800000, '2026-05-09 10:00:00', N'Chờ xử lý');   -- Lotte - snack

-- 11. CHI TIẾT HÓA ĐƠN NHẬP
INSERT INTO ChiTietHDN (maHDN, maNL, soLuong, donGia) VALUES
(1, 'NL002',  30, 85000),   -- ức gà
(2, 'NL004', 100, 13000),   -- mì Shin
(3, 'NL005', 150,  6000),   -- trà Kirin
(4, 'NL003', 200,  8000),   -- xúc xích Vissan
(5, 'NL001',  50, 14000);   -- gạo Japonica


-- Tài khoản đăng nhập (mật khẩu: 123456)
INSERT INTO NguoiDung (tenDangNhap, matKhau, vaiTro, maNV) VALUES
('admin',     '123456', N'Quản Lý',   1),
('nhanvien1', '123456', N'Nhân Viên',  2);
GO

--TRA DATABASE
select*from LoaiMon;
select*from MonAn;
select*from KhachHang;
select*from NhaCungCap;
select*from NguoiDung;
select*from NhanVien;
select*from NguyenLieu;
select*from HoaDonBan;
select*from ChiTietHDB;
select*from HoaDonNhap;
select*from ChiTietHDN;
select*from KhuyenMai;


