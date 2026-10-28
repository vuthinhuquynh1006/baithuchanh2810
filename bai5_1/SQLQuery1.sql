
USE LoginDB;
GO

IF COL_LENGTH('dbo.TaiKhoan', 'MatKhau') IS NULL
BEGIN
    ALTER TABLE dbo.TaiKhoan
    ADD MatKhau NVARCHAR(100) NULL;
END
GO

IF EXISTS (
    SELECT 1
    FROM dbo.TaiKhoan
    WHERE TenDangNhap = N'admin'
)
BEGIN
    UPDATE dbo.TaiKhoan
    SET MatKhau = N'123456'
    WHERE TenDangNhap = N'admin';
END
ELSE
BEGIN
    INSERT INTO dbo.TaiKhoan (TenDangNhap, MatKhau)
    VALUES (N'admin', N'123456');
END
GO

SELECT * FROM dbo.TaiKhoan;
GO
