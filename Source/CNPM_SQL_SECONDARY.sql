/*=============================================================================================================*/
--SELECT * FROM sys.database_principals
--DROP USER nam4
/*Thủ tục sử dụng cấu trúc rẽ nhánh, cấu trúc lặp hoặc các hàm có sẵn*/
CREATE PROCEDURE P_GETLOAIKH
    @ma_khach CHAR(15),
    @tong_chi_tieu FLOAT OUTPUT,
	@rank NVARCHAR(MAX) OUTPUT
AS
BEGIN
    SET @tong_chi_tieu = 0;

    -- Kiểm tra xem khách hàn	g có tồn tại hay không
    IF EXISTS (SELECT 1 FROM KHACHHANG WHERE MAKH = @ma_khach)
    BEGIN
        -- Tính tổng số tiền từ các hóa đơn của khách hàng
        SET @tong_chi_tieu = (
            SELECT SUM(SOLUONG * GIABAN)
            FROM CHITIETHOADON CT
            JOIN HOADON HD ON CT.MAHD = HD.MAHD
            WHERE HD.MAKH = @ma_khach
        );
        -- Nếu khách hàng không có giao dịch nào thì tổng chi tiêu vẫn là 0
        IF @tong_chi_tieu IS NULL
            SET @tong_chi_tieu = 0;

        -- Cập nhật trạng thái thành viên dựa trên tổng chi tiêu
        IF @tong_chi_tieu >= 20000000
        BEGIN
            SET @rank = N'Khách hàng đã được nâng cấp lên thành viên kim cương.';
        END
		ELSE IF @tong_chi_tieu >= 10000000
        BEGIN
            SET @rank = N'Khách hàng đã được nâng cấp lên thành viên vàng.';
        END
		ELSE IF @tong_chi_tieu >= 5000000
        BEGIN
            SET @rank = N'Khách hàng đã được nâng cấp lên thành viên bạc.';
        END
        ELSE IF @tong_chi_tieu >= 2000000
        BEGIN
           SET @rank = N'Khách hàng đã được nâng cấp lên thành viên đồng.';
        END
		ELSE
		BEGIN
           SET @rank = N'Khách hàng thường.';
        END

    END
    ELSE
    BEGIN
         Print N'Không tìm thấy khách hàng với mã đã cung cấp.';
    END
END;

GO
DECLARE @TONGTIEN FLOAT, @RANK NVARCHAR(100), @TAM NVARCHAR(100)
EXEC P_GETLOAIKH 1, @TONGTIEN OUTPUT, @RANK OUTPUT
PRINT N'Khách hàng đã chi tiêu tổng: '+CONVERT(NVARCHAR(30),CONVERT(numeric(16,0), CAST(@TONGTIEN AS FLOAT)))+' '+@RANK
/*Hàm  sử dung, cấu trúc lặp hoặc các hàm có sẵn*/
go
CREATE FUNCTION F_TinhTuoiNhanVien (@MaNV CHAR(15))
RETURNS INT
AS
BEGIN
    DECLARE @NgaySinh DATE;
    SELECT @NgaySinh = NGAYSINH FROM THONGTINNHANVIEN WHERE MANV = @MaNV;    
    RETURN DATEDIFF(YEAR, @NgaySinh, GETDATE());
END;
GO

DECLARE @TUOI INT
SET @TUOI=dbo.F_TinhTuoiNhanVien(1)
PRINT @TUOI




select * from NHANVIEN
select * from THONGTINNHANVIEN
GO

/*Thủ tục sử dụng cấu trúc rẽ nhánh, cấu trúc lặp hoặc các hàm có sẵn*/
ALTER PROCEDURE P_GETLOAIKH
    @ma_khach CHAR(15),
    @tong_chi_tieu FLOAT OUTPUT,
	@rank NVARCHAR(200) OUTPUT
AS
BEGIN
    SET @tong_chi_tieu = 0;

    -- Kiểm tra xem khách hàng có tồn tại hay không
    IF EXISTS (SELECT 1 FROM KHACHHANG WHERE MAKH = @ma_khach)
    BEGIN
        -- Tính tổng số tiền từ các hóa đơn của khách hàng
        SET @tong_chi_tieu = (
            SELECT SUM(SOLUONG * GIABAN)
            FROM CHITIETHOADON CT
            JOIN HOADON HD ON CT.MAHD = HD.MAHD
            WHERE HD.MAKH = @ma_khach
        );
        -- Nếu khách hàng không có giao dịch nào thì tổng chi tiêu vẫn là 0
        IF @tong_chi_tieu IS NULL
            SET @tong_chi_tieu = 0;

        -- Cập nhật trạng thái thành viên dựa trên tổng chi tiêu
        IF @tong_chi_tieu >= 20000000
        BEGIN
            SET @rank = N'Kim cương.';
        END
		ELSE IF @tong_chi_tieu >= 10000000
        BEGIN
            SET @rank = N'Vàng.';
        END
		ELSE IF @tong_chi_tieu >= 5000000
        BEGIN
            SET @rank = N'Bạc.';
        END
        ELSE IF @tong_chi_tieu >= 2000000
        BEGIN
           SET @rank = N'Đồng.';
        END
		ELSE
		BEGIN
           SET @rank = N'Thường.';
        END

    END
    ELSE
    BEGIN
         Print N'Không tìm thấy khách hàng với mã đã cung cấp.';
    END
END;

GO
DECLARE @TONGTIEN FLOAT, @RANK NVARCHAR(100), @TAM NVARCHAR(100)
EXEC P_GETLOAIKH 1, @TONGTIEN OUTPUT, @RANK OUTPUT
PRINT N'Khách hàng đã chi tiêu tổng: '+CONVERT(NVARCHAR(30),CONVERT(numeric(16,0), CAST(@TONGTIEN AS FLOAT)))+' '+@RANK
--TẠO CURSOR LỘC RANK NGƯỜI DÙNG
go
create PROCEDURE P_XUAT_HANG_KHACH_HANG
AS
BEGIN
    DECLARE @ma_khach CHAR(15);
    DECLARE @ten_khach NVARCHAR(50);
    DECLARE @dia_chi NVARCHAR(50);
    DECLARE @sodt NVARCHAR(15);
    DECLARE @tong_chi_tieu FLOAT;
    DECLARE @rank NVARCHAR(200);

    -- Tạo bảng tạm để lưu kết quả
    DECLARE @ResultTable TABLE (
        MaKhach CHAR(15),
        TenKhach NVARCHAR(50),
        DiaChi NVARCHAR(50),
        SoDT NVARCHAR(15),
        TongChiTieu FLOAT,
        Rank NVARCHAR(200)
    );
END;

    -- Khởi tạo con trỏ để lấy thông tin khách hàng
    DECLARE khach_hang_cursor CURSOR FOR
    SELECT MAKH, TENKH, DIACHI, SODT FROM KHACHHANG;

    OPEN khach_hang_cursor;

	FETCH NEXT FROM khach_hang_cursor INTO @ma_khach, @ten_khach, @dia_chi, @sodt;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Gọi thủ tục để tính toán tổng chi tiêu và hạng của khách hàng
        EXEC P_GETLOAIKH @ma_khach, @tong_chi_tieu OUTPUT, @rank OUTPUT;

        -- Thêm kết quả vào bảng tạm
        INSERT INTO @ResultTable (MaKhach, TenKhach, DiaChi, SoDT, TongChiTieu, Rank)
        VALUES (@ma_khach, @ten_khach, @dia_chi, @sodt, @tong_chi_tieu, @rank);

        FETCH NEXT FROM khach_hang_cursor INTO @ma_khach, @ten_khach, @dia_chi, @sodt;

    CLOSE khach_hang_cursor;
    DEALLOCATE khach_hang_cursor;

    -- Xuất toàn bộ dữ liệu từ bảng tạm
    SELECT * FROM @ResultTable;
END;

select * from NHANVIEN
select * from THONGTINNHANVIEN



