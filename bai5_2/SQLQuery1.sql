
IF DB_ID(N'DangKyKhoaHocDB') IS NULL
    CREATE DATABASE DangKyKhoaHocDB;
GO

USE DangKyKhoaHocDB;
GO

IF OBJECT_ID(N'dbo.KhoaHoc', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.KhoaHoc
    (
        MaKhoaHoc INT IDENTITY(1,1) PRIMARY KEY,
        TenKhoaHoc NVARCHAR(100) NOT NULL,
        HocPhi DECIMAL(18,2) NOT NULL
    );
END
GO

IF OBJECT_ID(N'dbo.DangKy', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.DangKy
    (
        MaDangKy INT IDENTITY(1,1) PRIMARY KEY,
        HoTen NVARCHAR(100) NOT NULL,
        SoDienThoai NVARCHAR(20) NOT NULL,
        NgaySinh DATE NOT NULL,
        GioiTinh NVARCHAR(10) NOT NULL,
        MaKhoaHoc INT NOT NULL,
        DichVu NVARCHAR(200),
        NgayDangKy DATETIME NOT NULL DEFAULT GETDATE(),
        FOREIGN KEY (MaKhoaHoc)
            REFERENCES dbo.KhoaHoc(MaKhoaHoc)
    );
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.KhoaHoc)
BEGIN
    INSERT INTO dbo.KhoaHoc (TenKhoaHoc, HocPhi)
    VALUES
        (N'Lập trình C#', 2500000),
        (N'Lập trình Java', 2800000),
        (N'Lập trình Python', 2200000),
        (N'Lập trình Web', 3000000);
END
GO

SELECT * FROM dbo.KhoaHoc;
GO
