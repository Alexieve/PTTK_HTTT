/*
    DROP TABLE
*/
DROP TABLE DOANHNGHIEP CASCADE CONSTRAINTS PURGE;
DROP TABLE NHANVIEN CASCADE CONSTRAINTS PURGE;
DROP TABLE UNGVIEN CASCADE CONSTRAINTS PURGE;
DROP TABLE VITRI CASCADE CONSTRAINTS PURGE;
DROP TABLE HINHTHUC CASCADE CONSTRAINTS PURGE;
DROP TABLE CAPBAC CASCADE CONSTRAINTS PURGE;
DROP TABLE KYNANG CASCADE CONSTRAINTS PURGE;
DROP TABLE HOPDONG CASCADE CONSTRAINTS PURGE;
DROP TABLE HOADON CASCADE CONSTRAINTS PURGE;
DROP TABLE HSUNGTUYEN CASCADE CONSTRAINTS PURGE;
DROP TABLE UUDAI CASCADE CONSTRAINTS PURGE;
DROP TABLE DNPHANHOI CASCADE CONSTRAINTS PURGE;
DROP TABLE NVPHANHOI CASCADE CONSTRAINTS PURGE;
DROP TABLE GIAYTOUV CASCADE CONSTRAINTS PURGE;
DROP TABLE HINHTHUC_HOPDONG CASCADE CONSTRAINTS PURGE;
DROP TABLE HOPDONG_KYNANG CASCADE CONSTRAINTS PURGE;


/*
    CREATE TABLES
*/
CREATE TABLE DOANHNGHIEP
(
  MADN VARCHAR2(10) NOT NULL,
  TENDN NVARCHAR2(50) NOT NULL,
  MSTHUE CHAR(10) NOT NULL,
  NGDAIDIEN NVARCHAR2(50) NOT NULL,
  DIACHI NVARCHAR2(200) NOT NULL,
  SDT CHAR(10) NOT NULL UNIQUE,
  EMAIL VARCHAR2(50) NOT NULL UNIQUE,
  TRANGTHAI NUMBER(1, 0) NOT NULL,
  CONSTRAINT PK_DOANHNGHIEP PRIMARY KEY (MADN),
  CONSTRAINT C_DOANHNGHIEP_TRANGTHAI CHECK (TRANGTHAI IN (0, 1)) -- 0: Chưa xác thực; 1: Đã xác thực, có thể đăng nhập
);

CREATE TABLE NHANVIEN
(
  MANV VARCHAR2(10) NOT NULL,
  HOTEN NVARCHAR2(50) NOT NULL,
  VAITRO NUMBER(1, 0) NOT NULL, -- 0: Nhân viên, 1: Ban lãnh đạo
  CONSTRAINT PK_NHANVIEN PRIMARY KEY (MANV),
  CONSTRAINT C_NHHANVIEN_VAITRO CHECK (VAITRO IN (0, 1))
);

CREATE TABLE UNGVIEN
(
  MAUV VARCHAR2(10) NOT NULL,
  HOTEN NVARCHAR2(50) NOT NULL,
  PHAI NVARCHAR2(5) NOT NULL,
  NGAYSINH DATE NOT NULL,
  DIACHI NVARCHAR2(200) NOT NULL,
  SDT CHAR(10) NOT NULL UNIQUE,
  EMAIL VARCHAR2(50) NOT NULL UNIQUE,
  CONSTRAINT PK_UNGVIEN PRIMARY KEY (MAUV)
);

CREATE TABLE VITRI
(
  MAVT VARCHAR2(10) NOT NULL,
  MOTA NVARCHAR2(200) NOT NULL,
  CHIPHITD FLOAT NOT NULL,
  CONSTRAINT PK_VITRI PRIMARY KEY (MAVT)
);

CREATE TABLE HINHTHUC
(
  MAHT VARCHAR2(10) NOT NULL,
  MOTA NVARCHAR2(200) NOT NULL,
  CHIPHITD FLOAT NOT NULL,
  CONSTRAINT PK_HINHTHUC PRIMARY KEY (MAHT)
);

CREATE TABLE CAPBAC
(
  MACB VARCHAR2(10) NOT NULL,
  MOTA NVARCHAR2(200) NOT NULL,
  CHIPHITD FLOAT NOT NULL,
  CONSTRAINT PK_CAPBAC PRIMARY KEY (MACB)
);

CREATE TABLE KYNANG
(
  MAKN VARCHAR2(10) NOT NULL,
  MOTA NVARCHAR2(200) NOT NULL,
  CHIPHITD FLOAT NOT NULL,
  CONSTRAINT PK_KYNANG PRIMARY KEY (MAKN)
);

CREATE TABLE HOPDONG
(
  MAHOPDONG VARCHAR2(10) NOT NULL,
  MADN VARCHAR2(10) NOT NULL,
  CAPBACTD VARCHAR2(10) NOT NULL,
  VITRITD VARCHAR2(10) NOT NULL,
  SOLUONGTD NUMBER(2, 0) NOT NULL,
  YEUCAU NVARCHAR2(2000) NOT NULL,
  THOIGIANTD NUMBER(2, 0) NOT NULL,
  NGAYTD DATE NOT NULL,
  NGAYLAP DATE NOT NULL,
  TRANGTHAI NUMBER(1, 0) NOT NULL, -- 0: Không yêu cầu hiệu chỉnh từ DN, 1: Có yêu cầu hiệu chỉnh DN
  TONGTIEN FLOAT NOT NULL,
  TIENCONLAI FLOAT NOT NULL,
  CONSTRAINT PK_HOPDONG PRIMARY KEY (MAHOPDONG),
  CONSTRAINT C_HOPDONG_SOLUONGTD CHECK(SOLUONGTD > 0),
  CONSTRAINT C_HOPDONG_THOIGIANTD CHECK(THOIGIANTD > 0),
  CONSTRAINT C_HOPDONG_TONGTIEN CHECK(TONGTIEN > 0),
  CONSTRAINT C_HOPDONG_TIENCONLAI CHECK(TIENCONLAI >= 0),
  CONSTRAINT C_HOPDONG_TONGTIEN_TIENCONLAI CHECK(TONGTIEN >= TIENCONLAI),
  CONSTRAINT C_HOPDONG_NGAYTD_NGAYLAP CHECK(NGAYTD >= NGAYLAP),
  CONSTRAINT C_HOPDONG_TRANGTHAI CHECK(TRANGTHAI IN(0, 1))
);

CREATE TABLE HOADON
(
  MAHOADON VARCHAR2(10) NOT NULL,
  NGAYTT DATE NOT NULL,
  SOTIEN FLOAT NOT NULL,
  HINHTHUCTT NVARCHAR2(20) NOT NULL, -- Tiền mặt, Thẻ
  NVTHANHTOAN VARCHAR2(10) NOT NULL,
  MAHOPDONG VARCHAR2(10) NOT NULL,
  CONSTRAINT PK_HOADON PRIMARY KEY (MAHOADON),
  CONSTRAINT C_HOADON_SOTIEN CHECK(SOTIEN > 0)
);

CREATE TABLE HSUNGTUYEN
(
  MAUV VARCHAR2(10) NOT NULL,
  MAHOPDONG VARCHAR2(10) NOT NULL,
  NGAYNOP DATE NOT NULL,
  GIOITHIEU NVARCHAR2(2000) NOT NULL,
  HOCVAN NVARCHAR2(2000) NOT NULL,
  KINHNGHIEM NVARCHAR2(2000) NOT NULL,
  KETQUA NUMBER(1, 0) NOT NULL, -- 0: Đang chờ, 1: Cần hiệu chỉnh, 2: Không đủ điều kiện, 3: Đủ điều kiện, 4: Không đạt, 5 Đạt
  DOUUTIEN NUMBER(1, 0) UNIQUE NULL,
  CONSTRAINT PK_HSUNGTUYEN PRIMARY KEY (MAUV, MAHOPDONG),
  CONSTRAINT C_HSUNGTUYEN_DOUUTIEN CHECK(DOUUTIEN >= 0),
  CONSTRAINT C_HSUNGTUYEN_KETQUA CHECK(KETQUA >= 0 AND KETQUA <= 5)
);

CREATE TABLE UUDAI
(
  MAHOPDONG VARCHAR2(10) NOT NULL,
  NGAYAPDUNG DATE NOT NULL,
  CHIETKHAU NUMBER(2, 0) NOT NULL,
  CONSTRAINT PK_UUDAI PRIMARY KEY (MAHOPDONG, NGAYAPDUNG),
  CONSTRAINT C_UUDAI_CHIEUKHAU CHECK(CHIETKHAU > 0 AND CHIETKHAU < 100)
);

CREATE TABLE DNPHANHOI
(
  MAHOPDONG VARCHAR2(10) NOT NULL,
  THOIGIANPH DATE NOT NULL,
  NOIDUNG NVARCHAR2(2000) NOT NULL,
  CONSTRAINT PK_DNPHANHOI PRIMARY KEY (MAHOPDONG, THOIGIANPH)
);

CREATE TABLE NVPHANHOI
(
  MAUV VARCHAR2(10) NOT NULL,
  MAHOPDONG VARCHAR2(10) NOT NULL,
  NGAYPH DATE NOT NULL,
  NOIDUNG NVARCHAR2(2000) NOT NULL,
  CONSTRAINT PK_NVPHANHOI PRIMARY KEY (MAUV, MAHOPDONG, NGAYPH)
);

CREATE TABLE GIAYTOUV
(
  MAUV VARCHAR2(10) NOT NULL,
  MAHOPDONG VARCHAR2(10) NOT NULL,
  LOAI NVARCHAR2(50) NOT NULL,
  NOIDUNG NVARCHAR2(2000) NOT NULL,
  CONSTRAINT PK_GIAYTOUV PRIMARY KEY (MAUV, MAHOPDONG, LOAI)
);

CREATE TABLE HINHTHUC_HOPDONG
(
  MAHOPDONG VARCHAR2(10) NOT NULL,
  MAHT VARCHAR2(10) NOT NULL,
  CONSTRAINT PK_HINHTHUC_HOPDONG PRIMARY KEY (MAHOPDONG, MAHT)
);

CREATE TABLE HOPDONG_KYNANG
(
  MAHOPDONG VARCHAR2(10) NOT NULL,
  MAKN VARCHAR2(10) NOT NULL,
  CONSTRAINT PK_HOPDONG_KYNANG PRIMARY KEY (MAHOPDONG, MAKN)
);

ALTER TABLE HOPDONG_KYNANG
ADD CONSTRAINT FK_HOPDONG_KYNANG_HOPDONG FOREIGN KEY (MAHOPDONG) REFERENCES HOPDONG(MAHOPDONG)
ADD CONSTRAINT FK_HOPDONG_KYNANG_KYNANG FOREIGN KEY (MAKN) REFERENCES KYNANG(MAKN);


ALTER TABLE HINHTHUC_HOPDONG
ADD CONSTRAINT FK_HINHTHUC_HOPDONG_HOPDONG FOREIGN KEY (MAHOPDONG) REFERENCES HOPDONG(MAHOPDONG)
ADD CONSTRAINT FK_HINHTHUC_HOPDONG_HINHTHUC FOREIGN KEY (MAHT) REFERENCES HINHTHUC(MAHT);

ALTER TABLE DNPHANHOI
ADD CONSTRAINT FK_DNPHANHOI_HOPDONG FOREIGN KEY (MAHOPDONG) REFERENCES HOPDONG(MAHOPDONG);

ALTER TABLE HOPDONG
ADD CONSTRAINT FK_HOPDONG_DOANHNGHIEP FOREIGN KEY (MADN) REFERENCES DOANHNGHIEP(MADN)
ADD CONSTRAINT FK_HOPDONG_CAPBAC FOREIGN KEY (CAPBACTD) REFERENCES CAPBAC(MACB)
ADD CONSTRAINT FK_HOPDONG_VITRI FOREIGN KEY (VITRITD) REFERENCES VITRI(MAVT);

ALTER TABLE UUDAI
ADD CONSTRAINT FK_UUDAI_HOPDONG FOREIGN KEY (MAHOPDONG) REFERENCES HOPDONG(MAHOPDONG);


ALTER TABLE HOADON
ADD CONSTRAINT FK_HOADON_HOPDONG FOREIGN KEY (MAHOPDONG) REFERENCES HOPDONG(MAHOPDONG)
ADD CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY (NVTHANHTOAN) REFERENCES NHANVIEN(MANV);

ALTER TABLE HSUNGTUYEN
ADD CONSTRAINT FK_HSUNGTUYEN_HOPDONG FOREIGN KEY (MAHOPDONG) REFERENCES HOPDONG(MAHOPDONG)
ADD CONSTRAINT FK_HSUNGTUYEN_UNGVIEN FOREIGN KEY (MAUV) REFERENCES UNGVIEN(MAUV);

ALTER TABLE NVPHANHOI
ADD CONSTRAINT FK_NVPHANHOI_HSUNGTUYEN FOREIGN KEY (MAUV, MAHOPDONG) REFERENCES HSUNGTUYEN(MAUV, MAHOPDONG);

ALTER TABLE GIAYTOUV
ADD CONSTRAINT FK_GIAYTOUV_HSUNGTUYEN FOREIGN KEY (MAUV, MAHOPDONG) REFERENCES HSUNGTUYEN(MAUV, MAHOPDONG);
