GO
CREATE DATABASE QL_NHASACH;
GO
USE QL_NHASACH;

-- Bảng các bộ phận
CREATE TABLE bo_phan (
    id_bo_phan INT IDENTITY(1,1) PRIMARY KEY,         -- ID của bộ phận (khóa chính)
    ten_bo_phan NVARCHAR(255) NOT NULL UNIQUE,        -- Tên bộ phận (duy nhất và không được để trống)
    mo_ta NVARCHAR(500),                               -- Mô tả về bộ phận
    create_at DATETIME DEFAULT GETDATE(),              -- Thời điểm tạo bản ghi
    update_at DATETIME DEFAULT GETDATE()               -- Thời điểm cập nhật bản ghi
);

-- Bảng nhân viên
CREATE TABLE nhan_vien (
    id_nhan_vien INT IDENTITY(1,1) PRIMARY KEY,      -- ID của nhân viên (khóa chính)
    ten NVARCHAR(100) NOT NULL,                      -- Tên nhân viên (không được để trống)
    email NVARCHAR(100) UNIQUE,                     -- Email của nhân viên (duy nhất)
    so_dien_thoai NVARCHAR(15),                     -- Số điện thoại của nhân viên
    ngay_sinh DATE,                                 -- Ngày sinh của nhân viên
    ngay_vao_lam DATE,                              -- Ngày vào làm của nhân viên
    he_so_luong DECIMAL(10, 2),                     -- Hệ số lương của nhân viên
    id_bo_phan INT,                                 -- ID bộ phận của nhân viên (khóa ngoại)
    create_at DATETIME DEFAULT GETDATE(),           -- Thời điểm tạo bản ghi
    update_at DATETIME DEFAULT GETDATE(),           -- Thời điểm cập nhật bản ghi
    FOREIGN KEY (id_bo_phan) REFERENCES bo_phan(id_bo_phan), -- Khóa ngoại liên kết với bảng bo_phan
    -- Ràng buộc CHECK để đảm bảo ngày sinh phải nhỏ hơn ngày hiện tại và từ 16 tuổi trở lên
    CONSTRAINT chk_ngay_sinh CHECK (ngay_sinh <= GETDATE() AND DATEDIFF(YEAR, ngay_sinh, GETDATE()) >= 16),
    -- Ràng buộc CHECK để đảm bảo ngày vào làm phải nhỏ hơn hoặc bằng ngày hiện tại
    CONSTRAINT chk_ngay_vao_lam CHECK (ngay_vao_lam <= GETDATE()), 
    -- Ràng buộc CHECK để đảm bảo hệ số lương phải lớn hơn 0
    CONSTRAINT chk_he_so_luong CHECK (he_so_luong > 0)
);

-- Bảng người dùng (Users) Nhân viên có nhiều tài khoản người dùng và tài khoản chỉ thuộc về 1 nhân viên.
CREATE TABLE nguoi_dung (
    id_nguoi_dung INT IDENTITY(1,1) PRIMARY KEY,      -- ID của người dùng (khóa chính)
    ten_dang_nhap NVARCHAR(100) NOT NULL UNIQUE,      -- Tên người dùng (duy nhất và không được để trống)
    mat_khau NVARCHAR(255) NOT NULL,         			   -- Mật khẩu đã được mã hóa (không được để trống)
    trang_thai_hoat_dong INT DEFAULT 1,               -- Trạng thái hoạt động (-1: disable, 0: không hoạt động, 1: hoạt động)
    id_nhan_vien INT NULL,                            -- ID của nhân viên liên kết (khóa ngoại)
    create_at DATETIME DEFAULT GETDATE(),             -- Thời điểm tạo bản ghi
    update_at DATETIME DEFAULT GETDATE(),             -- Thời điểm cập nhật bản ghi
    FOREIGN KEY (id_nhan_vien) REFERENCES nhan_vien(id_nhan_vien), -- Khóa ngoại liên kết với bảng nhan_vien  
    -- Ràng buộc CHECK để đảm bảo trang_thai_hoat_dong chỉ nhận giá trị -1, 0, hoặc 1
    CONSTRAINT chk_trang_thai_hoat_dong CHECK (trang_thai_hoat_dong IN (-1, 0, 1))
);

-- Bảng quyền truy cập của người dùng.
CREATE TABLE quyen_truy_cap (
    id_quyen INT IDENTITY(1,1) PRIMARY KEY,      -- ID của quyền truy cập (khóa chính)
    ten_quyen NVARCHAR(50) NOT NULL UNIQUE,      -- Tên của quyền truy cập (duy nhất và không được để trống)
    mo_ta NVARCHAR(255) NULL,                    -- Mô tả quyền truy cập (có thể để trống)
    create_at DATETIME DEFAULT GETDATE(),        -- Thời điểm tạo bản ghi
    update_at DATETIME DEFAULT GETDATE()         -- Thời điểm cập nhật bản ghi
);

-- Bảng người dùng có thuộc quyền.
CREATE TABLE nguoi_dung_quyen (
    id_nguoi_dung INT,                           -- ID của người dùng (khóa ngoại)
    id_quyen INT,                                -- ID của quyền truy cập (khóa ngoại)
    create_at DATETIME DEFAULT GETDATE(),        -- Thời điểm tạo bản ghi
		update_at DATETIME DEFAULT GETDATE(),             -- Thời điểm cập nhật bản ghi
    PRIMARY KEY (id_nguoi_dung, id_quyen),       -- Khóa chính kết hợp từ id_nguoi_dung và id_quyen
    FOREIGN KEY (id_nguoi_dung) REFERENCES nguoi_dung(id_nguoi_dung), -- Khóa ngoại liên kết với bảng nguoi_dung
    FOREIGN KEY (id_quyen) REFERENCES quyen_truy_cap(id_quyen) -- Khóa ngoại liên kết với bảng quyen_truy_cap
);

-- Bảng nhà xuất bản.
CREATE TABLE nha_xuat_ban (
    id_nha_xuat_ban INT IDENTITY(1,1) PRIMARY KEY,    -- ID của nhà xuất bản (khóa chính)
    ten_nha_xuat_ban NVARCHAR(255) NOT NULL,          -- Tên nhà xuất bản (không được để trống)
    dia_chi NVARCHAR(500),                            -- Địa chỉ của nhà xuất bản
    so_dien_thoai NVARCHAR(15),                       -- Số điện thoại của nhà xuất bản
    email NVARCHAR(100),                              -- Email của nhà xuất bản
    website NVARCHAR(500),                            -- Website của nhà xuất bản
    nam_thanh_lap INT,                                -- Năm thành lập nhà xuất bản
    mo_ta NVARCHAR(500),                              -- Mô tả về nhà xuất bản
    create_at DATETIME DEFAULT GETDATE(),             -- Thời điểm tạo bản ghi
    update_at DATETIME DEFAULT GETDATE(),             -- Thời điểm cập nhật bản ghi
    -- Ràng buộc kiểm tra nam_thanh_lap phải bé hơn hoặc bằng năm hiện tại
    CONSTRAINT chk_nam_thanh_lap CHECK (nam_thanh_lap <= YEAR(GETDATE()))
);

-- Bảng lĩnh vực
CREATE TABLE linh_vuc (
    id_linh_vuc INT IDENTITY(1,1) PRIMARY KEY,       -- ID của lĩnh vực (khóa chính)
    ten_linh_vuc NVARCHAR(500) NOT NULL UNIQUE,      -- Tên lĩnh vực (duy nhất và không được để trống)
    mo_ta NVARCHAR(900),                             -- Mô tả về lĩnh vực
    create_at DATETIME DEFAULT GETDATE(),            -- Thời điểm tạo bản ghi
    update_at DATETIME DEFAULT GETDATE()             -- Thời điểm cập nhật bản ghi
);

-- Bảng loại sách
CREATE TABLE loai_sach (
    id_loai_sach INT IDENTITY(1,1) PRIMARY KEY,      -- ID của loại sách (khóa chính)
    ten_loai_sach NVARCHAR(255) NOT NULL UNIQUE,     -- Tên loại sách (duy nhất và không được để trống)
    mo_ta NVARCHAR(500),                             -- Mô tả về loại sách
    create_at DATETIME DEFAULT GETDATE(),            -- Thời điểm tạo bản ghi
    update_at DATETIME DEFAULT GETDATE()             -- Thời điểm cập nhật bản ghi
);

-- Bảng liên kết giữa loại sách và lĩnh vực
CREATE TABLE loai_sach_linh_vuc (
    id_loai_sach INT,                              -- ID của loại sách (khóa ngoại)
    id_linh_vuc INT,                               -- ID của lĩnh vực (khóa ngoại)
    PRIMARY KEY (id_loai_sach, id_linh_vuc),       -- Khóa chính bao gồm cả hai cột
    FOREIGN KEY (id_loai_sach) REFERENCES loai_sach(id_loai_sach), -- Khóa ngoại liên kết với bảng loai_sach
    FOREIGN KEY (id_linh_vuc) REFERENCES linh_vuc(id_linh_vuc) -- Khóa ngoại liên kết với bảng linh_vuc
);

-- Bảng sách
CREATE TABLE sach (
    id_sach INT IDENTITY(1,1) PRIMARY KEY,          -- ID của sách (khóa chính)
    ten_sach NVARCHAR(900) NOT NULL UNIQUE,         -- Tên sách (không được để trống)
    id_nha_xuat_ban INT,                            -- ID nhà xuất bản (khóa ngoại)
    id_loai_sach INT,                               -- ID loại sách (khóa ngoại)
    nam_xuat_ban INT,                               -- Năm xuất bản
    isbn NVARCHAR(255) UNIQUE,                      -- ISBN của sách (duy nhất)
    lan_tai_ban INT,                                -- Lần tái bản
    nam_nop_luu_chieu INT,                          -- Năm nộp lưu chiểu
    create_at DATETIME DEFAULT GETDATE(),           -- Thời điểm tạo bản ghi
    update_at DATETIME DEFAULT GETDATE(),           -- Thời điểm cập nhật bản ghi
    -- Ràng buộc kiểm tra nam_xuat_ban phải bé hơn hoặc bằng năm hiện tại
    CONSTRAINT chk_nam_xuat_ban CHECK (nam_xuat_ban <= YEAR(GETDATE())),
    -- Ràng buộc kiểm tra nam_nop_luu_chieu phải lớn hơn hoặc bằng nam_xuat_ban
    CONSTRAINT chk_nam_nop_luu_chieu CHECK (nam_nop_luu_chieu >= nam_xuat_ban),
    FOREIGN KEY (id_nha_xuat_ban) REFERENCES nha_xuat_ban(id_nha_xuat_ban), -- Khóa ngoại liên kết với bảng nha_xuat_ban
    FOREIGN KEY (id_loai_sach) REFERENCES loai_sach(id_loai_sach) -- Khóa ngoại liên kết với bảng loai_sach
);


-- Bảng ảnh sách
CREATE TABLE anh_sach (
    id_anh_sach INT IDENTITY(1,1) PRIMARY KEY,     -- ID của ảnh sách (khóa chính)
    id_sach INT,                                  -- ID của sách (khóa ngoại)
    url_anh TEXT,              										-- Đường dẫn đến ảnh (không được để trống)
    mo_ta NVARCHAR(500),                         -- Mô tả về ảnh
    is_cover BIT NOT NULL DEFAULT 0,          	 -- 0: không phải ảnh bìa, 1: ảnh bìa (mặc định là 0)
    create_at DATETIME DEFAULT GETDATE(),        -- Thời điểm tạo bản ghi
    update_at DATETIME DEFAULT GETDATE(),        -- Thời điểm cập nhật bản ghi
    FOREIGN KEY (id_sach) REFERENCES sach(id_sach) -- Khóa ngoại liên kết với bảng sach
);

-- Bảng tác giả
CREATE TABLE tac_gia (
    id_tac_gia INT IDENTITY(1,1) PRIMARY KEY,      -- ID của tác giả (khóa chính)
    ten_tac_gia NVARCHAR(100) NOT NULL,           -- Tên tác giả (không được để trống)
    tieu_su NVARCHAR(800),                         -- Tiểu sử tác giả
    create_at DATETIME DEFAULT GETDATE(),          -- Thời điểm tạo bản ghi
    update_at DATETIME DEFAULT GETDATE()           -- Thời điểm cập nhật bản ghi
);

-- Bảng liên kết giữa sách và tác giả
CREATE TABLE sach_tac_gia (
    id_sach INT,                                 -- ID của sách (khóa ngoại)
    id_tac_gia INT,                              -- ID của tác giả (khóa ngoại)
    PRIMARY KEY (id_sach, id_tac_gia),           -- Khóa chính bao gồm cả hai cột
    FOREIGN KEY (id_sach) REFERENCES sach(id_sach), -- Khóa ngoại liên kết với bảng sach
    FOREIGN KEY (id_tac_gia) REFERENCES tac_gia(id_tac_gia) -- Khóa ngoại liên kết với bảng tac_gia
);

-- Bảng lô sách
CREATE TABLE lo_sach (
    id_lo_sach INT IDENTITY(1,1) PRIMARY KEY,     -- ID của lô sách (khóa chính)
    id_sach INT,                                  -- ID của sách (khóa ngoại)
    so_luong INT,                                 -- Số lượng sách trong lô
    ngay_nhap DATETIME DEFAULT GETDATE(),         -- Ngày nhận lô sách
    ghi_chu NVARCHAR(800),                        -- Ghi chú lô nhập sách
    create_at DATETIME DEFAULT GETDATE(),         -- Thời điểm tạo bản ghi
    update_at DATETIME DEFAULT GETDATE(),         -- Thời điểm cập nhật bản ghi
    -- Ràng buộc kiểm tra so_luong phải lớn hơn 0
    CONSTRAINT chk_so_luong CHECK (so_luong > 0),
    -- Ràng buộc kiểm tra ngay_nhap không được vượt quá ngày hiện tại
    CONSTRAINT chk_ngay_nhap CHECK (ngay_nhap <= GETDATE()),
    FOREIGN KEY (id_sach) REFERENCES sach(id_sach) -- Khóa ngoại liên kết với bảng sach
);

-- Bảng giá sách
CREATE TABLE gia_sach (
    id_gia_sach INT IDENTITY(1,1) PRIMARY KEY,    -- ID của giá sách (khóa chính)
    id_sach INT,                                 -- ID của sách (khóa ngoại)
    gia_sach DECIMAL(10, 2) NOT NULL,            -- Giá sách (không được để trống)
    ngay_hieu_luc DATETIME DEFAULT GETDATE(),    -- Ngày áp dụng giá
    create_at DATETIME DEFAULT GETDATE(),        -- Thời điểm tạo bản ghi
    update_at DATETIME DEFAULT GETDATE(),        -- Thời điểm cập nhật bản ghi
    -- Ràng buộc kiểm tra gia_sach phải lớn hơn 0
    CONSTRAINT chk_gia_sach CHECK (gia_sach >= 0),
    -- Ràng buộc kiểm tra ngay_hieu_luc không được vượt quá ngày hiện tại
    CONSTRAINT chk_ngay_hieu_luc CHECK (ngay_hieu_luc <= GETDATE()),
    FOREIGN KEY (id_sach) REFERENCES sach(id_sach) -- Khóa ngoại liên kết với bảng sach
);

-- Bảng giảm giá sách
CREATE TABLE giam_gia_sach (
    id_giam_gia_sach INT IDENTITY(1,1) PRIMARY KEY,  -- ID của giảm giá sách (khóa chính)
    id_sach INT,                                  -- ID của sách (khóa ngoại)
    phan_tram_giam_gia DECIMAL(5, 2) NOT NULL,    -- Phần trăm giảm giá (không được để trống)
    ngay_bat_dau DATETIME DEFAULT GETDATE(),      -- Ngày bắt đầu giảm giá
    ngay_ket_thuc DATETIME DEFAULT GETDATE(),     -- Ngày kết thúc giảm giá
    create_at DATETIME DEFAULT GETDATE(),        -- Thời điểm tạo bản ghi
    update_at DATETIME DEFAULT GETDATE(),        -- Thời điểm cập nhật bản ghi
    -- Ràng buộc kiểm tra phần trăm giảm giá nằm trong khoảng từ 0 đến 100
    CONSTRAINT chk_phan_tram_giam_gia CHECK (phan_tram_giam_gia BETWEEN 0 AND 100),
    -- Ràng buộc kiểm tra ngày bắt đầu giảm giá không được vượt quá ngày kết thúc giảm giá
    CONSTRAINT chk_ngay_bat_dau_ngay_ket_thuc CHECK (ngay_bat_dau <= ngay_ket_thuc),
    -- Ràng buộc kiểm tra ngày bắt đầu giảm giá không được vượt quá ngày hiện tại
    CONSTRAINT chk_ngay_bat_dau CHECK (ngay_bat_dau <= GETDATE()),
    FOREIGN KEY (id_sach) REFERENCES sach(id_sach) -- Khóa ngoại liên kết với bảng sach
);

-- Bảng đơn hàng (Orders)
CREATE TABLE don_hang (
    id_don_hang INT IDENTITY(1,1) PRIMARY KEY,    -- ID của đơn hàng (khóa chính)
    id_nguoi_dung INT,                          -- ID của người dùng (khóa ngoại)
    ngay_dat_hang DATETIME DEFAULT GETDATE() NOT NULL, -- Ngày đặt hàng (không được để trống)
    trang_thai NVARCHAR(50) NOT NULL,           -- Trạng thái của đơn hàng (không được để trống)
    tong_tien DECIMAL(18, 2) NOT NULL DEFAULT 0, -- Tổng tiền của đơn hàng
    create_at DATETIME DEFAULT GETDATE(),        -- Thời điểm tạo bản ghi
    update_at DATETIME DEFAULT GETDATE(),        -- Thời điểm cập nhật bản ghi
    -- Ràng buộc kiểm tra ngày đặt hàng không được vượt quá ngày hiện tại
    CONSTRAINT chk_ngay_dat_hang CHECK (ngay_dat_hang <= GETDATE()),
    -- Ràng buộc kiểm tra tổng tiền không được âm
    CONSTRAINT chk_tong_tien CHECK (tong_tien >= 0),
    FOREIGN KEY (id_nguoi_dung) REFERENCES nguoi_dung(id_nguoi_dung) -- Khóa ngoại liên kết với bảng nguoi_dung
);

-- Bảng chi tiết đơn hàng (Order_Details)
CREATE TABLE chi_tiet_don_hang (
    id_don_hang INT,                            		-- ID của đơn hàng (khóa ngoại)
    id_sach INT,                               			-- ID của sách (khóa ngoại)
    so_luong INT NOT NULL DEFAULT 1,                -- Số lượng sách (không được để trống)
    gia_sach DECIMAL(10, 2) NOT NULL,              	-- Giá sách (không được để trống)
    so_tien_giam_gia DECIMAL(10, 2) NOT NULL DEFAULT 0, -- Số tiền giảm giá
    thanh_tien DECIMAL(18, 2) NOT NULL DEFAULT 0, 	-- Thành tiền của từng chi tiết đơn hàng
    PRIMARY KEY (id_don_hang, id_sach),        			-- Khóa chính bao gồm cả hai cột
    create_at DATETIME DEFAULT GETDATE(),       		-- Thời điểm tạo bản ghi
    update_at DATETIME DEFAULT GETDATE(),       		-- Thời điểm cập nhật bản ghi
    -- Ràng buộc kiểm tra số lượng sách phải là số nguyên dương
    CONSTRAINT chk_so_luong_cthd CHECK (so_luong > 0),
    -- Ràng buộc kiểm tra giá sách phải là số dương
    CONSTRAINT chk_gia_sach_cthd CHECK (gia_sach >= 0),
    -- Ràng buộc kiểm tra số tiền giảm giá không được âm và không vượt quá giá sách
    CONSTRAINT chk_so_tien_giam_gia CHECK (so_tien_giam_gia >= 0 AND so_tien_giam_gia <= gia_sach),
    -- Ràng buộc kiểm tra thành tiền phải đúng theo công thức
    CONSTRAINT chk_thanh_tien CHECK (thanh_tien = (gia_sach - so_tien_giam_gia) * so_luong),
    FOREIGN KEY (id_don_hang) REFERENCES don_hang(id_don_hang), -- Khóa ngoại liên kết với bảng don_hang
    FOREIGN KEY (id_sach) REFERENCES sach(id_sach) -- Khóa ngoại liên kết với bảng sach
);