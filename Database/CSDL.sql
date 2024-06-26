﻿CREATE DATABASE My_Application
GO
USE My_Application
GO

-- ĐẶT ĐỊNH DẠNG DATE DD/MM/YYYY
SET DATEFORMAT DMY

-- TẠO CHUỖI SỐ THỨ TỰ TĂNG TỰ ĐỘNG, BẮT ĐẦU TỪ 1, TĂNG 1 ĐƠN VỊ
CREATE SEQUENCE STT
	START WITH 1100
	INCREMENT BY 1

--=========================================================--

CREATE TABLE USERS (
	TEN_USER	NVARCHAR(50) UNIQUE,	-- TÊN NGƯỜI DÙNG GỒM: BAN GIÁM HIỆU, GIÁO VỤ, GIÁO VIÊN
	TAIKHOAN	VARCHAR(20) PRIMARY KEY,	-- TÀI KHOẢN GỒM: bgh (ban giám hiệu), gvu (giáo vụ), gvi (giáo viên)
	MATKHAU		VARCHAR(50) NOT NULL
)

INSERT INTO USERS VALUES (N'Ban Giám Hiệu', 'bgh', 'bgh123')
INSERT INTO USERS VALUES (N'Giáo Vụ', 'gvu', 'gvu123')
INSERT INTO USERS VALUES (N'Giáo Viên', 'gvi', 'gvi123')
INSERT INTO USERS VALUES (N'Admin', 'admin', 'admin123')

SELECT * FROM USERS
DROP TABLE USERS
--=========================================================--

CREATE TABLE KHOILOP (
	MAKHOI		CHAR(3) PRIMARY KEY,	--MÃ KHỐI: K10, K11, K12
	TENKHOI		NVARCHAR(10) NOT NULL,
	SL_LOP		INT NOT NULL
)

INSERT INTO KHOILOP VALUES ('K10', N'Khối 10', 4)
INSERT INTO KHOILOP VALUES ('K11', N'Khối 11', 3)
INSERT INTO KHOILOP VALUES ('K12', N'Khối 12', 2)

--=========================================================--

CREATE TABLE LOP (
	TENLOP		VARCHAR(5)	PRIMARY KEY,	--TÊN LỚP: 10A1, 10A2, 10A3, 10A4, 11A1, 11A2, 11A3, 12A1, 12A2,...
	MAKHOI		CHAR(3) FOREIGN KEY REFERENCES KHOILOP(MAKHOI),	 
	SISO		INT DEFAULT 0 NOT NULL	--NẾU SISO = 0 THÌ LỚP KHÔNG TỒN TẠI HOẶC LỚP MỚI MỞ, CHƯA CÓ HỌC SINH
	CONSTRAINT SISO_LOWER_40 CHECK (SISO <= 40)
)
--ALTER TABLE LOP ADD CONSTRAINT SISO_COUNT CHECK (SISO = (SELECT COUNT(*) FROM XEPLOP WHERE LOP.TENLOP = XEPLOP.TENLOP))
INSERT INTO LOP (TENLOP, MAKHOI) VALUES ('10A1', 'K10')
INSERT INTO LOP (TENLOP, MAKHOI) VALUES ('10A2', 'K10')
INSERT INTO LOP (TENLOP, MAKHOI) VALUES ('10A3', 'K10')
INSERT INTO LOP (TENLOP, MAKHOI) VALUES ('10A4', 'K10')
INSERT INTO LOP (TENLOP, MAKHOI) VALUES ('11A1', 'K11')
INSERT INTO LOP (TENLOP, MAKHOI) VALUES ('11A2', 'K11')
INSERT INTO LOP (TENLOP, MAKHOI) VALUES ('11A3', 'K11')
INSERT INTO LOP (TENLOP, MAKHOI) VALUES ('12A1', 'K12')
INSERT INTO LOP (TENLOP, MAKHOI) VALUES ('12A2', 'K12')

SELECT * FROM LOP

--=========================================================--

CREATE TABLE HOCSINH (
	MAHS		CHAR(6)	PRIMARY KEY,	--MÃ HS: HS0001 -> HS3000
	HO			NVARCHAR(20) NOT NULL,
	DEM			NVARCHAR(40) NULL,
	TEN			NVARCHAR(20) NOT NULL,
	NGAYSINH	SMALLDATETIME NOT NULL,
	GIOITINH	NVARCHAR(5) NOT NULL,
	EMAIL		VARCHAR(50) NULL,
	DIACHI		NVARCHAR(100) NOT NULL
)

-- LỚP 10
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Nguyễn' , N'Văn', N'Nam', '2/1/2009', 'Nam', NULL, 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Trần', N'Gia', N'Bảo', '6/5/2009', 'Nam', 'gb10@gmail.com', 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Nguyễn', N'Minh', N'Thư', '6/11/2009', N'Nữ', NULL, 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Đinh', N'Hữu', N'Tài', '19/10/2009', 'Nam', 'dht10@gmail.com', 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Trần', N'Lê Bảo' , N'Anh', '2/4/2009', N'Nữ', 'tlba10@gmail.com', 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Trần', N'Ngọc', N'Phúc', '1/7/2009', 'Nam', NULL, 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Lê', N'Thanh', N'Tâm', '27/4/2009', N'Nữ', 'ltt10@gmail.com', 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Nguyễn', N'Đức', N'Mạnh', '20/1/2009', 'Nam', NULL, 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Đỗ', N'Tiến', N'Đức', '2/1/2009', 'Nam', 'dtd10@gmail.com', 'TPHCM')
-- LỚP 11
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Trần', N'Hữu', N'Tài', '19/8/2008', 'Nam', 'tht11@gmail.com', 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Trần', N'Bảo' , N'Ngọc', '2/4/2008', N'Nữ', 'tbn11@gmail.com', 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Nguyễn', N'Lâm Thanh', N'Phúc', '11/4/2008', 'Nam', NULL, 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Lê', N'Thanh', N'Tâm', '25/2/2008', N'Nữ', 'ltt11@gmail.com', 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Nguyễn', N'Ngọc Đức', N'Mạnh', '6/1/2008', 'Nam', NULL, 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Trương', N'Mai Trọng', N'Tiến', '13/11/2008', 'Nam', 'tmtt11@gmail.com', 'TPHCM')
-- LỚP 12
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Nguyễn' , N'Minh', N'Anh', '2/1/2007', 'Nam', 'nma12@gmail.com', 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Lê', N'Gia', N'Trí', '6/5/2007', 'Nam', 'lgt12@gmail.com', 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Nguyễn', N'Nam', N'Anh', '6/11/2007', N'Nam', 'nna12@gmail.com', 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Đào', N'Minh', N'Toàn', '9/10/2007', N'Nam', 'dmt12@gmail.com', 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Trần', N'Lê Bảo' , N'Anh', '22/5/2007', N'Nữ', 'tlba17@gmail.com', 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Trần', N'Thanh', N'Phúc', '1/7/2007', 'Nam', 'ttp12@gmail.com', 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Lê', N'Bảo', N'Thy', '7/12/2007', N'Nữ', 'lbt12@gmail.com', 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Nguyễn', N'Lê Bảo', N'Trâm', '13/8/2007', 'Nam', 'nlbt12@gmail.com', 'TPHCM')
INSERT INTO HOCSINH VALUES ('HS' + CAST(NEXT VALUE FOR STT AS CHAR(4)), N'Mai', N'Văn', N'Lâm', '24/6/2007', 'Nam', 'mvl12@gmail.com', 'TPHCM')

SELECT * FROM HOCSINH

--=========================================================--

CREATE TABLE XEPLOP (
	TENLOP		VARCHAR(5) FOREIGN KEY REFERENCES LOP(TENLOP),
	STT			INT,
	MAHS		CHAR(6) FOREIGN KEY REFERENCES HOCSINH(MAHS),
	PRIMARY KEY (TENLOP, STT)
)
DROP TABLE XEPLOP

--=========================================================--

CREATE TABLE MONHOC (
	MAMON		CHAR(3) PRIMARY KEY,	--MÃ MÔN: M01, M02,...., M09
	TENMON		NVARCHAR(50) UNIQUE		--TÊN MÔN: Toán, Lý, Hóa, Sinh, Sử, Địa, Văn, Đạo Đức, Thể Dục
)
INSERT INTO MONHOC VALUES ('M01', N'Toán')
INSERT INTO MONHOC VALUES ('M02', N'Lý')
INSERT INTO MONHOC VALUES ('M03', N'Hóa')
INSERT INTO MONHOC VALUES ('M04', N'Sinh')
INSERT INTO MONHOC VALUES ('M05', N'Sử')
INSERT INTO MONHOC VALUES ('M06', N'Địa')
INSERT INTO MONHOC VALUES ('M07', N'Văn')
INSERT INTO MONHOC VALUES ('M08', N'Đạo Đức')
INSERT INTO MONHOC VALUES ('M09', N'Thể Dục')
SELECT * FROM MONHOC

--=========================================================--

CREATE TABLE BANGDIEM_MONHOC (
	TENLOP		VARCHAR(5),
	TENMON		NVARCHAR(50) FOREIGN KEY REFERENCES MONHOC(TENMON),
	HOCKY		VARCHAR(2),					--HỌC KỲ: I, II
	STT			INT,
	DIEM_15P	FLOAT,
	DIEM_1T		FLOAT,
	DIEM_TB		FLOAT,
	PRIMARY KEY (TENLOP, TENMON, HOCKY, STT),

	CONSTRAINT FK_TENLOP_STT FOREIGN KEY (TENLOP, STT) REFERENCES XEPLOP(TENLOP, STT),
	CONSTRAINT CK_HOCKY CHECK (HOCKY IN ('I', 'II')),
	CONSTRAINT CK_DIEM_15P CHECK (DIEM_15P >= 0 AND DIEM_15P <= 10),
	CONSTRAINT CK_DIEM_1T CHECK (DIEM_1T >= 0 AND DIEM_1T <= 10),
	CONSTRAINT CK_DIEM_TB CHECK (DIEM_TB >= 0 AND DIEM_TB <= 10)
)
SELECT * FROM BANGDIEM_MONHOC
DROP TABLE BANGDIEM_MONHOC

--=========================================================--

CREATE TABLE BAOCAO_MONHOC (
	TENMON		NVARCHAR(50) FOREIGN KEY REFERENCES MONHOC(TENMON),
	HOCKY		VARCHAR(2),
	TENLOP		VARCHAR(5) FOREIGN KEY REFERENCES LOP(TENLOP),
	SISO		INT NOT NULL,
	SL_DAT		INT NOT NULL,
	TI_LE		FLOAT
	PRIMARY KEY (TENMON, HOCKY, TENLOP)
)
DROP TABLE BAOCAO_MONHOC

--=========================================================--

CREATE TABLE BAOCAO_HOCKY (
	HOCKY		VARCHAR(2) CHECK (HOCKY IN ('I', 'II', '1', '2')),
	TENLOP		VARCHAR(5) FOREIGN KEY REFERENCES LOP(TENLOP),
	SISO		INT NOT NULL,
	SL_DAT		INT NOT NULL,
	TI_LE		FLOAT
	PRIMARY KEY (HOCKY, TENLOP)
)
DROP TABLE BAOCAO_HOCKY

--=========================================================--

CREATE TABLE QUYDINH (
	MAQD		CHAR(4) PRIMARY KEY,
	TENQD		NVARCHAR(30) NOT NULL,
	GIATRI		FLOAT
)
DROP TABLE QUYDINH

INSERT INTO QUYDINH VALUES ('QD01', N'Tuổi tối thiểu', 15)
INSERT INTO QUYDINH VALUES ('QD02', N'Tuổi tối đa', 20)
INSERT INTO QUYDINH VALUES ('QD03', N'Sĩ số tối đa', 40)
INSERT INTO QUYDINH VALUES ('QD04', N'Số lượng lớp 10', 4)
INSERT INTO QUYDINH VALUES ('QD05', N'Số lượng lớp 11', 3)
INSERT INTO QUYDINH VALUES ('QD06', N'Số lượng lớp 12', 2)
INSERT INTO QUYDINH VALUES ('QD07', N'Số lượng môn', 9)
INSERT INTO QUYDINH VALUES ('QD08', N'Điểm đạt môn', 5.0)
INSERT INTO QUYDINH VALUES ('QD09', N'Điểm đạt', 5.0)

SELECT * FROM QUYDINH

