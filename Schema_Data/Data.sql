SET DEFINE OFF

-- UNGVIEN
INSERT INTO UNGVIEN (MAUV, HOTEN, PHAI, NGAYSINH, DIACHI, SDT, EMAIL) 
VALUES ('UV00000001', N'Vũ Minh Quỳnh', N'Nam', to_date('01/01/2003', 'MM/DD/YYYY'), N'227, đường Nguyễn Văn Cừ, quận 5, thành phố Hồ Chí Minh', '0000000001', 'vmquynh21@clc.fitus.edu.vn');

INSERT INTO UNGVIEN (MAUV, HOTEN, PHAI, NGAYSINH, DIACHI, SDT, EMAIL) 
VALUES ('UV00000002', N'Võ Đoàn Vương Thịnh', N'Nam', to_date('01/02/2003', 'MM/DD/YYYY'), N'227, đường Nguyễn Văn Cừ, quận 5, thành phố Hồ Chí Minh', '0000000002', 'vdvthinh21@clc.fitus.edu.vn');

INSERT INTO UNGVIEN (MAUV, HOTEN, PHAI, NGAYSINH, DIACHI, SDT, EMAIL) 
VALUES ('UV00000003', N'Trương Vĩnh Phúc', N'Nam', to_date('01/03/2003', 'MM/DD/YYYY'), N'227, đường Nguyễn Văn Cừ, quận 5, thành phố Hồ Chí Minh', '0000000003', 'tvphuc21@clc.fitus.edu.vn');

INSERT INTO UNGVIEN (MAUV, HOTEN, PHAI, NGAYSINH, DIACHI, SDT, EMAIL) 
VALUES ('UV00000004', N'Nguyễn Lê Hoàng Kha', N'Nam', to_date('01/04/2003', 'MM/DD/YYYY'), N'227, đường Nguyễn Văn Cừ, quận 5, thành phố Hồ Chí Minh', '0000000004', 'nlhkha21@clc.fitus.edu.vn');

INSERT INTO UNGVIEN (MAUV, HOTEN, PHAI, NGAYSINH, DIACHI, SDT, EMAIL) 
VALUES ('UV00000005', N'Lô Thuỷ Tiên', N'Nữ', to_date('01/05/2003', 'MM/DD/YYYY'), N'227, đường Nguyễn Văn Cừ, quận 5, thành phố Hồ Chí Minh', '0000000005', 'lttien21@clc.fitus.edu.vn');


-- NHANVIEN
INSERT INTO NHANVIEN (MANV, HOTEN, VAITRO) 
VALUES ('NV00000001', N'Vũ Minh Quỳnh', 0);

INSERT INTO NHANVIEN (MANV, HOTEN, VAITRO) 
VALUES ('NV00000002', N'Võ Đoàn Vương Thịnh', 0);

INSERT INTO NHANVIEN (MANV, HOTEN, VAITRO) 
VALUES ('NV00000003', N'Trương Vĩnh Phúc', 0);

INSERT INTO NHANVIEN (MANV, HOTEN, VAITRO) 
VALUES ('NV00000004', N'Nguyễn Lê Hoàng Kha', 0);

INSERT INTO NHANVIEN (MANV, HOTEN, VAITRO) 
VALUES ('NV00000005', N'Lô Thuỷ Tiên', 0);

INSERT INTO NHANVIEN (MANV, HOTEN, VAITRO) 
VALUES ('NV00000006', N'Vũ Minh Quỳnh', 1);

INSERT INTO NHANVIEN (MANV, HOTEN, VAITRO) 
VALUES ('NV00000007', N'Võ Đoàn Vương Thịnh', 1);

INSERT INTO NHANVIEN (MANV, HOTEN, VAITRO) 
VALUES ('NV00000008', N'Trương Vĩnh Phúc', 1);

INSERT INTO NHANVIEN (MANV, HOTEN, VAITRO) 
VALUES ('NV00000009', N'Nguyễn Lê Hoàng Kha', 1);

INSERT INTO NHANVIEN (MANV, HOTEN, VAITRO) 
VALUES ('NV00000010', N'Lô Thuỷ Tiên', 1);


-- DOANHNGHIEP
INSERT INTO DOANHNGHIEP (MADN, TENDN, MSTHUE, NGDAIDIEN, DIACHI, SDT, EMAIL, TRANGTHAI) 
VALUES ('DN00000001', N'Quỳnh Company', '1111111111', N'Vũ Minh Quỳnh', N'227, đường Nguyễn Văn Cừ, quận 5, thành phố Hồ Chí Minh', '0100000001', 'vmquynh21@clc.fitus.edu.vn', 1);

INSERT INTO DOANHNGHIEP (MADN, TENDN, MSTHUE, NGDAIDIEN, DIACHI, SDT, EMAIL, TRANGTHAI) 
VALUES ('DN00000002', N'Thịnh Company', '2222222222', N'Võ Đoàn Vương Thịnh', N'227, đường Nguyễn Văn Cừ, quận 5, thành phố Hồ Chí Minh', '0100000002', 'vdvthinh21@clc.fitus.edu.vn', 1);

INSERT INTO DOANHNGHIEP (MADN, TENDN, MSTHUE, NGDAIDIEN, DIACHI, SDT, EMAIL, TRANGTHAI) 
VALUES ('DN00000003', N'Phúc Company', '3333333333', N'Trương Vĩnh Phúc', N'227, đường Nguyễn Văn Cừ, quận 5, thành phố Hồ Chí Minh', '0100000003', 'tvphuc21@clc.fitus.edu.vn', 1);

INSERT INTO DOANHNGHIEP (MADN, TENDN, MSTHUE, NGDAIDIEN, DIACHI, SDT, EMAIL, TRANGTHAI) 
VALUES ('DN00000004', N'Kha Company', '4444444444', N'Nguyễn Lê Hoàng Kha', N'227, đường Nguyễn Văn Cừ, quận 5, thành phố Hồ Chí Minh', '0100000004', 'nlhkha21@clc.fitus.edu.vn', 1);

INSERT INTO DOANHNGHIEP (MADN, TENDN, MSTHUE, NGDAIDIEN, DIACHI, SDT, EMAIL, TRANGTHAI) 
VALUES ('DN00000005', N'Tiên Company', '5555555555', N'Lô Thuỷ Tiên', N'227, đường Nguyễn Văn Cừ, quận 5, thành phố Hồ Chí Minh', '0100000005', 'lttien21@clc.fitus.edu.vn', 1);



-- HINHTHUC
INSERT INTO HINHTHUC (MAHT, MOTA, CHIPHITD) 
VALUES ('GIAYBAO', N'Tuyển dụng trên giấy báo', 100000.0);

INSERT INTO HINHTHUC (MAHT, MOTA, CHIPHITD) 
VALUES ('BANNER', N'Tuyển dụng trên banner', 200000.0);

INSERT INTO HINHTHUC (MAHT, MOTA, CHIPHITD) 
VALUES ('MXH', N'Tuyển dụng trên mạng xã hội', 300000.0);


-- CAPBAC
INSERT INTO CAPBAC (MACB, MOTA, CHIPHITD) 
VALUES ('INTERN', N'Intern', 100000.0);

INSERT INTO CAPBAC (MACB, MOTA, CHIPHITD) 
VALUES ('FRESHER', N'Fresher', 200000.0);

INSERT INTO CAPBAC (MACB, MOTA, CHIPHITD) 
VALUES ('JUNIOR', N'Junior', 300000.0);

INSERT INTO CAPBAC (MACB, MOTA, CHIPHITD) 
VALUES ('MIDDLE', N'Middle', 400000.0);

INSERT INTO CAPBAC (MACB, MOTA, CHIPHITD) 
VALUES ('SENIOR', N'Senior', 500000.0);

INSERT INTO CAPBAC (MACB, MOTA, CHIPHITD) 
VALUES ('PROLEAD', N'Project Leader', 600000.0);

INSERT INTO CAPBAC (MACB, MOTA, CHIPHITD) 
VALUES ('HEADOFF', N'Head Office', 700000.0);

INSERT INTO CAPBAC (MACB, MOTA, CHIPHITD) 
VALUES ('ALLLV', N'All Levels', 800000.0);


-- VITRI
INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('BE', N'Back-end Developer', 100000.0);

INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('BA', N'Business Analyst', 100000.0);

INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('DA', N'Data Analyst', 200000.0);

INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('DE', N'Data Engineer', 100000.0);

INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('DEV', N'Developer', 500000.0);

INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('FE', N'Front-end Developer', 200000.0);

INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('FS', N'Full-stack', 500000.0);

INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('PM', N'Product Manager', 100000.0);

INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('PL', N'Project Leader', 300000.0);

INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('SCRUM', N'Scrum Master', 300000.0);

INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('SCA', N'Security Architect', 400000.0);

INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('SCD', N'Security Developer', 300000.0);

INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('SCE', N'Security Engineer', 500000.0);

INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('SE', N'Software Engineer', 300000.0);

INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('SA', N'System Admin', 500000.0);

INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('SYSE', N'System Engineer', 300000.0);

INSERT INTO VITRI (MAVT, MOTA, CHIPHITD) 
VALUES ('QC', N'Tester', 400000.0);


-- KYNANG
INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('.NET', N'.NET', 500000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('ANDROID', N'Android', 200000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('ANGULAR', N'Angular', 100000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('ANGULARJS', N'AngularJS', 300000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('ASP.NET', N'ASP.NET', 300000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('AWS', N'AWS', 100000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('AZURE', N'Azure', 300000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('C#', N'C#', 200000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('C++', N'C++', 400000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('CLOUD', N'Cloud', 200000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('DATABASE', N'Database', 200000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('DEVOPS', N'DevOps', 400000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('EMBEDDED', N'Embedded', 200000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('FLUTTER', N'Flutter', 200000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('GAME', N'Game', 100000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('GOLANG', N'Golang', 300000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('HTML', N'HTML', 200000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('IOS', N'iOS', 500000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('JAVA', N'Java', 400000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('JAVASCRIPT', N'JavaScript', 400000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('KOTLIN', N'Kotlin', 400000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('LARAVEL', N'Laravel', 200000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('MOBILE', N'Mobile', 400000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('NETWORK', N'Network', 300000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('NODEJS', N'NodeJS', 500000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('PHP', N'PHP', 400000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('PYTHON', N'Python', 200000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('REACT', N'React', 100000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('REACTJS', N'ReactJS', 500000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('SQL', N'SQL', 200000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('TESTER', N'Tester', 200000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('UI/UX', N'UI/UX', 200000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('UNITY', N'Unity', 100000.0);

INSERT INTO KYNANG (MAKN, MOTA, CHIPHITD) 
VALUES ('VUEJS', N'VueJS', 500000.0);


-- HOPDONG
INSERT INTO HOPDONG (MAHOPDONG, MADN, CAPBACTD, VITRITD, SOLUONGTD, YEUCAU, THOIGIANTD, NGAYTD, NGAYLAP, TRANGTHAI, TONGTIEN, TIENCONLAI) 
VALUES ('HD00000001', 'DN00000001', 'INTERN', 'BE', 5, N'Chúng tôi đang tìm kiếm một intern back-end năng động và ham học hỏi để tham gia vào đội ngũ phát triển phần mềm của chúng tôi. Ứng viên lý tưởng sẽ có kiến thức cơ bản về lập trình back-end và mong muốn học hỏi và phát triển kỹ năng trong môi trường làm việc thực tế.', 30, to_date('04/20/2024', 'MM/DD/YYYY'), to_date('04/13/2024', 'MM/DD/YYYY'), 0, 1, 0);

INSERT INTO HOPDONG (MAHOPDONG, MADN, CAPBACTD, VITRITD, SOLUONGTD, YEUCAU, THOIGIANTD, NGAYTD, NGAYLAP, TRANGTHAI, TONGTIEN, TIENCONLAI) 
VALUES ('HD00000002', 'DN00000002', 'FRESHER', 'BA', 6, N'Chúng tôi đang tìm kiếm một fresher business analyst đam mê và sáng tạo để tham gia vào đội ngũ phân tích kinh doanh của chúng tôi. Ứng viên lý tưởng sẽ có kiến thức cơ bản về phân tích kinh doanh và khả năng làm việc trong môi trường đa dạng và động.', 21, to_date('04/21/2024', 'MM/DD/YYYY'), to_date('04/14/2024', 'MM/DD/YYYY'), 0, 1, 0);

INSERT INTO HOPDONG (MAHOPDONG, MADN, CAPBACTD, VITRITD, SOLUONGTD, YEUCAU, THOIGIANTD, NGAYTD, NGAYLAP, TRANGTHAI, TONGTIEN, TIENCONLAI) 
VALUES ('HD00000003', 'DN00000003', 'JUNIOR', 'DA', 7, N'Chúng tôi đang tìm kiếm một junior data analyst nhiệt huyết và có kỹ năng phân tích dữ liệu để tham gia vào đội ngũ phân tích dữ liệu của chúng tôi. Ứng viên lý tưởng sẽ có kiến thức cơ bản về phân tích dữ liệu và mong muốn phát triển kỹ năng trong lĩnh vực này.', 35, to_date('04/22/2024', 'MM/DD/YYYY'), to_date('04/15/2024', 'MM/DD/YYYY'), 0, 1, 0);

INSERT INTO HOPDONG (MAHOPDONG, MADN, CAPBACTD, VITRITD, SOLUONGTD, YEUCAU, THOIGIANTD, NGAYTD, NGAYLAP, TRANGTHAI, TONGTIEN, TIENCONLAI) 
VALUES ('HD00000004', 'DN00000004', 'MIDDLE', 'DE', 8, N'Chúng tôi đang tìm kiếm một middle developer có kinh nghiệm và sáng tạo để tham gia vào đội ngũ phát triển phần mềm của chúng tôi. Ứng viên lý tưởng sẽ có kinh nghiệm trong việc phát triển phần mềm, kiến thức vững về các ngôn ngữ lập trình và có khả năng làm việc hiệu quả trong môi trường đội nhóm.', 14, to_date('04/23/2024', 'MM/DD/YYYY'), to_date('04/16/2024', 'MM/DD/YYYY'), 0, 1, 0);

INSERT INTO HOPDONG (MAHOPDONG, MADN, CAPBACTD, VITRITD, SOLUONGTD, YEUCAU, THOIGIANTD, NGAYTD, NGAYLAP, TRANGTHAI, TONGTIEN, TIENCONLAI) 
VALUES ('HD00000005', 'DN00000005', 'SENIOR', 'DEV', 9, N'Chúng tôi đang tìm kiếm một senior developer có kinh nghiệm và năng động để tham gia vào đội ngũ phát triển phần mềm của chúng tôi và đóng góp vào việc xây dựng các sản phẩm chất lượng. Ứng viên lý tưởng sẽ có kinh nghiệm rộng lớn trong việc phát triển phần mềm, lãnh đạo và hướng dẫn các thành viên khác trong đội ngũ.', 40, to_date('04/24/2024', 'MM/DD/YYYY'), to_date('04/17/2024', 'MM/DD/YYYY'), 0, 1, 0);



-- HINHTHUC_HOPDONG
INSERT INTO HINHTHUC_HOPDONG (MAHOPDONG, MAHT) 
VALUES ('HD00000001', 'GIAYBAO');

INSERT INTO HINHTHUC_HOPDONG (MAHOPDONG, MAHT) 
VALUES ('HD00000002', 'BANNER');

INSERT INTO HINHTHUC_HOPDONG (MAHOPDONG, MAHT) 
VALUES ('HD00000003', 'MXH');

INSERT INTO HINHTHUC_HOPDONG (MAHOPDONG, MAHT) 
VALUES ('HD00000004', 'GIAYBAO');

INSERT INTO HINHTHUC_HOPDONG (MAHOPDONG, MAHT) 
VALUES ('HD00000004', 'BANNER');

INSERT INTO HINHTHUC_HOPDONG (MAHOPDONG, MAHT) 
VALUES ('HD00000005', 'MXH');

INSERT INTO HINHTHUC_HOPDONG (MAHOPDONG, MAHT) 
VALUES ('HD00000005', 'GIAYBAO');

INSERT INTO HINHTHUC_HOPDONG (MAHOPDONG, MAHT) 
VALUES ('HD00000005', 'BANNER');


-- HOPDONG_KYNANG

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000001', '.NET');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000001', 'ANDROID');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000001', 'ANGULAR');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000001', 'ANGULARJS');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000001', 'ASP.NET');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000002', 'AWS');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000002', 'AZURE');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000002', 'C#');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000002', 'C++');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000002', 'CLOUD');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000003', 'DATABASE');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000003', 'DEVOPS');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000003', 'EMBEDDED');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000003', 'FLUTTER');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000003', 'GAME');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000004', 'GOLANG');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000004', 'HTML');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000004', 'IOS');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000004', 'JAVA');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000004', 'JAVASCRIPT');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000005', 'KOTLIN');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000005', 'LARAVEL');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000005', 'MOBILE');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000005', 'NETWORK');

INSERT INTO HOPDONG_KYNANG (MAHOPDONG, MAKN) 
VALUES ('HD00000005', 'NODEJS');


-- HOADON
INSERT INTO HOADON (MAHOADON, NGAYTT, SOTIEN, HINHTHUCTT, NVTHANHTOAN, MAHOPDONG) 
VALUES ('HD00000001', to_date('04/13/2024', 'MM/DD/YYYY'), 1, N'Tiền mặt', 'NV00000001', 'HD00000001');

INSERT INTO HOADON (MAHOADON, NGAYTT, SOTIEN, HINHTHUCTT, NVTHANHTOAN, MAHOPDONG) 
VALUES ('HD00000002', to_date('04/14/2024', 'MM/DD/YYYY'), 1, N'Thẻ', 'NV00000002', 'HD00000002');

INSERT INTO HOADON (MAHOADON, NGAYTT, SOTIEN, HINHTHUCTT, NVTHANHTOAN, MAHOPDONG) 
VALUES ('HD00000003', to_date('04/15/2024', 'MM/DD/YYYY'), 1, N'Tiền mặt', 'NV00000003', 'HD00000003');

INSERT INTO HOADON (MAHOADON, NGAYTT, SOTIEN, HINHTHUCTT, NVTHANHTOAN, MAHOPDONG) 
VALUES ('HD00000004', to_date('04/16/2024', 'MM/DD/YYYY'), 1, N'Thẻ', 'NV00000004', 'HD00000004');

INSERT INTO HOADON (MAHOADON, NGAYTT, SOTIEN, HINHTHUCTT, NVTHANHTOAN, MAHOPDONG) 
VALUES ('HD00000005', to_date('04/17/2024', 'MM/DD/YYYY'), 1, N'Tiền mặt', 'NV00000005', 'HD00000005');


-- HSUNGTUYEN
INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000001', 'HD00000001', to_date('04/20/2024', 'MM/DD/YYYY'), N'Giới thiệu 1', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000002', 'HD00000001', to_date('04/20/2024', 'MM/DD/YYYY'), N'Giới thiệu 2', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000003', 'HD00000001', to_date('04/20/2024', 'MM/DD/YYYY'), N'Giới thiệu 3', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000004', 'HD00000001', to_date('04/20/2024', 'MM/DD/YYYY'), N'Giới thiệu 4', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000005', 'HD00000001', to_date('04/20/2024', 'MM/DD/YYYY'), N'Giới thiệu 5', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000001', 'HD00000002', to_date('04/21/2024', 'MM/DD/YYYY'), N'Giới thiệu 1', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000002', 'HD00000002', to_date('04/21/2024', 'MM/DD/YYYY'), N'Giới thiệu 2', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000003', 'HD00000002', to_date('04/21/2024', 'MM/DD/YYYY'), N'Giới thiệu 3', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000004', 'HD00000002', to_date('04/21/2024', 'MM/DD/YYYY'), N'Giới thiệu 4', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000005', 'HD00000002', to_date('04/21/2024', 'MM/DD/YYYY'), N'Giới thiệu 5', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000001', 'HD00000003', to_date('04/22/2024', 'MM/DD/YYYY'), N'Giới thiệu 1', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000002', 'HD00000003', to_date('04/22/2024', 'MM/DD/YYYY'), N'Giới thiệu 2', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000003', 'HD00000003', to_date('04/22/2024', 'MM/DD/YYYY'), N'Giới thiệu 3', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000004', 'HD00000003', to_date('04/22/2024', 'MM/DD/YYYY'), N'Giới thiệu 4', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000005', 'HD00000003', to_date('04/22/2024', 'MM/DD/YYYY'), N'Giới thiệu 5', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000001', 'HD00000004', to_date('04/23/2024', 'MM/DD/YYYY'), N'Giới thiệu 1', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000002', 'HD00000004', to_date('04/23/2024', 'MM/DD/YYYY'), N'Giới thiệu 2', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000003', 'HD00000004', to_date('04/23/2024', 'MM/DD/YYYY'), N'Giới thiệu 3', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000004', 'HD00000004', to_date('04/23/2024', 'MM/DD/YYYY'), N'Giới thiệu 4', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000005', 'HD00000004', to_date('04/23/2024', 'MM/DD/YYYY'), N'Giới thiệu 5', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000001', 'HD00000005', to_date('04/24/2024', 'MM/DD/YYYY'), N'Giới thiệu 1', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000002', 'HD00000005', to_date('04/24/2024', 'MM/DD/YYYY'), N'Giới thiệu 2', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000003', 'HD00000005', to_date('04/24/2024', 'MM/DD/YYYY'), N'Giới thiệu 3', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000004', 'HD00000005', to_date('04/24/2024', 'MM/DD/YYYY'), N'Giới thiệu 4', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);

INSERT INTO HSUNGTUYEN (MAUV, MAHOPDONG, NGAYNOP, GIOITHIEU, HOCVAN, KINHNGHIEM, KETQUA) 
VALUES ('UV00000005', 'HD00000005', to_date('04/24/2024', 'MM/DD/YYYY'), N'Giới thiệu 5', N'HCMUS', N'3 Năm kinh nghiệm C++', 0);



-- GIAYTOUV
INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000001', 'HD00000001', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000002', 'HD00000001', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000003', 'HD00000001', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000004', 'HD00000001', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000005', 'HD00000001', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000001', 'HD00000002', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000002', 'HD00000002', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000003', 'HD00000002', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000004', 'HD00000002', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000005', 'HD00000002', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000001', 'HD00000003', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000002', 'HD00000003', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000003', 'HD00000003', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000004', 'HD00000003', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000005', 'HD00000003', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000001', 'HD00000004', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000002', 'HD00000004', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000003', 'HD00000004', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000004', 'HD00000004', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000005', 'HD00000004', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000001', 'HD00000005', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000002', 'HD00000005', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000003', 'HD00000005', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000004', 'HD00000005', N'IELTS', N'Overall 9.0');

INSERT INTO GIAYTOUV (MAUV, MAHOPDONG, LOAI, NOIDUNG) 
VALUES ('UV00000005', 'HD00000005', N'IELTS', N'Overall 9.0');



-- 