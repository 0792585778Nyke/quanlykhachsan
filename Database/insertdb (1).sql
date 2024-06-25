USE QLKS;

-- Thiết lập định dạng ngày
SET DATEFORMAT DMY;

-- Chèn dữ liệu vào bảng CUSTOMER
INSERT INTO CUSTOMER (CUS_ID, FULL_NAME, BIRTHDAY, SEX, CUS_IDENTITY, PHONE, CAREER, NATIONALITY) VALUES
('KH01', N'Nguyễn Văn An', '01-01-1980', N'Nam', 1, '0912345678', N'Kinh doanh', N'Việt Nam'),
('KH02', N'Trần Thị Bích', '02-02-1985', N'Nữ', 1, '0912345679', N'Giáo viên', N'Việt Nam'),
('KH03', N'Lê Văn Chiến', '03-03-1990', N'Nam', 1, '0912345680', N'Kỹ sư', N'Việt Nam'),
('KH04', N'Phạm Thị Dung', '04-04-1995', N'Nữ', 1, '0912345681', N'Bác sĩ', N'Việt Nam'),
('KH05', N'Hoàng Văn Dũng', '05-05-1982', N'Nam', 1, '0912345682', N'Nông dân', N'Việt Nam'),
('KH06', N'Phan Thị Hoa', '06-06-1983', N'Nữ', 1, '0912345683', N'Nhân viên văn phòng', N'Việt Nam'),
('KH07', N'Đỗ Văn Hùng', '07-07-1984', N'Nam', 1, '0912345684', N'Tài xế', N'Việt Nam'),
('KH08', N'Bùi Thị Lan', '08-08-1986', N'Nữ', 1, '0912345685', N'Kế toán', N'Việt Nam'),
('KH09', N'Ngô Văn Long', '09-09-1987', N'Nam', 1, '0912345686', N'Thợ điện', N'Việt Nam'),
('KH10', N'Tôn Thất Lâm', '10-10-1988', N'Nam', 1, '0912345687', N'Kiến trúc sư', N'Việt Nam');


-- Chèn dữ liệu vào bảng STAFF
INSERT INTO STAFF (STAFF_ID, FULL_NAME, BIRTHDAY, SEX, STAFF_IDENTITY, PHONE, STAFF_ADDRESS, SALARY, POSITION) VALUES
('NV01', N'Nguyễn Văn Lâm', '01-01-1975', N'Nam', 1, '0987654321', N'123 Đường A', 20000000, N'Quản lý'),
('NV02', N'Trần Thị Mai', '01-01-1980', N'Nữ', 1, '0987654322', N'456 Đường B', 10000000, N'Nhân viên'),
('NV03', N'Lê Văn Phú', '01-01-1981', N'Nam', 1, '0987654323', N'789 Đường C', 10000000, N'Nhân viên'),
('NV04', N'Phạm Thị Hương', '01-01-1982', N'Nữ', 1, '0987654324', N'101 Đường D', 10000000, N'Nhân viên'),
('NV05', N'Hoàng Văn Khánh', '01-01-1983', N'Nam', 1, '0987654325', N'112 Đường E', 10000000, N'Nhân viên'),
('NV06', N'Phan Thị Ngọc', '01-01-1984', N'Nữ', 1, '0987654326', N'131 Đường F', 10000000, N'Nhân viên'),
('NV07', N'Đỗ Văn Nam', '01-01-1985', N'Nam', 1, '0987654327', N'145 Đường G', 10000000, N'Nhân viên'),
('NV08', N'Bùi Thị Thanh', '01-01-1986', N'Nữ', 1, '0987654328', N'178 Đường H', 10000000, N'Nhân viên'),
('NV09', N'Ngô Văn Hùng', '01-01-1987', N'Nam', 1, '0987654329', N'199 Đường I', 10000000, N'Nhân viên'),
('NV10', N'Tôn Thất Bình', '01-01-1988', N'Nam', 1, '0987654330', N'234 Đường J', 10000000, N'Nhân viên');


-- Chèn dữ liệu vào bảng HOTELSERVICE
INSERT INTO HOTELSERVICE (SER_ID, STAFF_ID, FULL_NAME, PRICE) VALUES
('HS001', 'NV02', N'Dọn phòng', 50000),
('HS002', 'NV03', N'Giặt ủi', 70000),
('HS003', 'NV04', N'Bữa sáng', 150000),
('HS004', 'NV05', N'Bữa trưa', 200000),
('HS005', 'NV06', N'Bữa tối', 250000),
('HS006', 'NV07', N'Đưa đón sân bay', 300000),
('HS007', 'NV08', N'Tour du lịch', 400000),
('HS008', 'NV09', N'Massage', 350000),
('HS009', 'NV10', N'Thể dục thẩm mỹ', 450000),
('HS010', 'NV02', N'Bơi lội', 500000);

-- Chèn dữ liệu vào bảng ROOM
INSERT INTO ROOM (RO_ID, RO_TYPE, PRICE_HOUR, PRICE_DAY, PRICE_NIGHT) VALUES
('101', N'Single', 100000, 500000, 300000),
('102', N'Single', 100000, 500000, 300000),
('103', N'Single', 100000, 500000, 300000),
('104', N'Single', 100000, 500000, 300000),
('105', N'Single', 100000, 500000, 300000),
('201', N'Double', 150000, 700000, 400000),
('202', N'Double', 150000, 700000, 400000),
('203', N'Double', 150000, 700000, 400000),
('204', N'Double', 150000, 700000, 400000),
('205', N'Double', 150000, 700000, 400000),
('301', N'Triple', 200000, 900000, 500000),
('302', N'Triple', 200000, 900000, 500000),
('303', N'Triple', 200000, 900000, 500000),
('304', N'Triple', 200000, 900000, 500000),
('305', N'Triple', 200000, 900000, 500000),
('401', N'Double-Double', 250000, 1100000, 600000),
('402', N'Double-Double', 250000, 1100000, 600000),
('403', N'Double-Double', 250000, 1100000, 600000),
('404', N'Double-Double', 250000, 1100000, 600000),
('405', N'Double-Double', 250000, 1100000, 600000);



-- Chèn dữ liệu vào bảng USERSROLE
INSERT INTO USERSROLE (ROLE_ID, DISPLAYNAME) VALUES
(1, N'Admin'),
(2, N'Staff');

INSERT INTO USERS (US_ID, US_USERNAME, US_PASSWORD, STAFF_ID, DISPLAYNAME, ROLE_ID, SOURCES) VALUES
('US1', 'admin', 'db69fc039dcbd2962cb4d28f5891aae1', 'NV01', N'Nguyễn Văn Lâm', 1, NULL),
('US2', 'staff1', '978aae9bb6bee8fb75de3e4830a1be46', 'NV01', N'Nguyễn Văn Lâm', 2, NULL),
('US3', 'staff2', '978aae9bb6bee8fb75de3e4830a1be46', 'NV02', N'Trần Thị Mai', 2, NULL),
('US4', 'staff3', '978aae9bb6bee8fb75de3e4830a1be46', 'NV03', N'Lê Văn Phú', 2, NULL),
('US5', 'staff4', '978aae9bb6bee8fb75de3e4830a1be46', 'NV04', N'Phạm Thị Hương', 2, NULL),
('US6', 'staff5', '978aae9bb6bee8fb75de3e4830a1be46', 'NV05', N'Hoàng Văn Khánh', 2, NULL),
('US7', 'staff6', '978aae9bb6bee8fb75de3e4830a1be46', 'NV06', N'Phan Thị Ngọc', 2, NULL),
('US8', 'staff7', '978aae9bb6bee8fb75de3e4830a1be46', 'NV07', N'Đỗ Văn Nam', 2, NULL),
('US9', 'staff8', '978aae9bb6bee8fb75de3e4830a1be46', 'NV08', N'Bùi Thị Thanh', 2, NULL),
('US10', 'staff9', '978aae9bb6bee8fb75de3e4830a1be46', 'NV09', N'Ngô Văn Hùng', 2, NULL),
('US11', 'staff10', '978aae9bb6bee8fb75de3e4830a1be46', 'NV10', N'Tôn Thất Bình', 2, NULL);
