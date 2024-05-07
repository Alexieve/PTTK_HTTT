CREATE OR REPLACE PROCEDURE USP_HOPDONG_GET_ALL_FOR_DUYETHS(P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
        WITH HOPDONG_FILTERED AS (
            SELECT MAHOPDONG, CAPBACTD, VITRITD, NGAYTD, THOIGIANTD
            FROM HOPDONG
            WHERE (NGAYTD + THOIGIANTD) <= (SYSDATE + 50)
        ),
        HSUNGTUYEN_OF_HOPDONG AS (
            SELECT HSUT.MAHOPDONG, COUNT(HSUT.MAHOPDONG) AS SOLUONGHS
            FROM HSUNGTUYEN HSUT
            JOIN HOPDONG_FILTERED HD ON HSUT.MAHOPDONG = HD.MAHOPDONG
            WHERE HSUT.KETQUA >= 2 AND HSUT.KETQUA <= 4
            GROUP BY HSUT.MAHOPDONG
        )
        SELECT HD.MAHOPDONG, CB.MOTA AS CAPBACTD, VT.MOTA AS VITRITD, 
        HD.NGAYTD, HD.THOIGIANTD, HSUT.SOLUONGHS
        FROM HOPDONG_FILTERED HD
        JOIN HSUNGTUYEN_OF_HOPDONG HSUT ON HD.MAHOPDONG = HSUT.MAHOPDONG
        JOIN CAPBAC CB ON HD.CAPBACTD = CB.MACB
        JOIN VITRI VT ON HD.VITRITD = VT.MAVT;
END;
/
GRANT EXECUTE ON USP_HOPDONG_GET_ALL_FOR_DUYETHS TO RL_NHANVIEN;




CREATE OR REPLACE PROCEDURE USP_HOPDONG_GET_ALL_FOR_PHANHOIHS(P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
        WITH HOPDONG_FILTERED AS (
            SELECT MAHOPDONG, CAPBACTD, VITRITD, NGAYTD, THOIGIANTD
            FROM HOPDONG
            WHERE (NGAYTD + THOIGIANTD) <= (SYSDATE + 50)
        ),
        HSUNGTUYEN_OF_HOPDONG AS (
            SELECT HSUT.MAHOPDONG, COUNT(HSUT.MAHOPDONG) AS SOLUONGHS
            FROM HSUNGTUYEN HSUT
            JOIN HOPDONG_FILTERED HD ON HSUT.MAHOPDONG = HD.MAHOPDONG
            WHERE HSUT.KETQUA >= 4 AND DOUUTIEN IS NOT NULL
            GROUP BY HSUT.MAHOPDONG
        )
        SELECT HD.MAHOPDONG, CB.MOTA AS CAPBACTD, VT.MOTA AS VITRITD, 
        HD.NGAYTD, HD.THOIGIANTD, HSUT.SOLUONGHS
        FROM HOPDONG_FILTERED HD
        JOIN HSUNGTUYEN_OF_HOPDONG HSUT ON HD.MAHOPDONG = HSUT.MAHOPDONG
        JOIN CAPBAC CB ON HD.CAPBACTD = CB.MACB
        JOIN VITRI VT ON HD.VITRITD = VT.MAVT;
END;
/
GRANT EXECUTE ON USP_HOPDONG_GET_ALL_FOR_PHANHOIHS TO RL_DOANHNGHIEP;




CREATE OR REPLACE PROCEDURE USP_HOPDONG_GET_TIEUCHIDN(
    P_RES OUT SYS_REFCURSOR,
    P_MAHOPDONG IN VARCHAR2
)
AS
BEGIN
    OPEN P_RES FOR
        SELECT YEUCAU
        FROM HOPDONG
        WHERE MAHOPDONG = P_MAHOPDONG;
END;
/
GRANT EXECUTE ON USP_HOPDONG_GET_TIEUCHIDN TO RL_NHANVIEN, RL_DOANHNGHIEP;



CREATE OR REPLACE PROCEDURE USP_GET_LIST_TUYEN_DUNG(P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
        SELECT HD.MAHOPDONG, VT.MOTA as VITRITD, DN.TENDN, CB.MOTA as CAPBACTD, DN.DIACHI, LISTAGG(KN.MOTA,', ') as KYNANG FROM HOPDONG HD JOIN DOANHNGHIEP DN ON HD.MADN = DN.MADN
                                                                                            JOIN CAPBAC CB ON HD.CAPBACTD = CB.MACB
                                                                                            JOIN VITRI VT ON HD.VITRITD = VT.MAVT
                                                                                            JOIN HOPDONG_KYNANG HDKN ON HD.MAHOPDONG = HDKN.MAHOPDONG
                                                                                            JOIN KYNANG KN ON HDKN.MAKN = KN.MAKN
        WHERE HD.TIENCONLAI < HD.TONGTIEN AND (HD.NGAYTD + HD.THOIGIANTD) > SYSDATE
        GROUP BY HD.MAHOPDONG, VT.MOTA, DN.TENDN, CB.MOTA, DN.DIACHI;
END;
/

GRANT EXECUTE ON USP_GET_LIST_TUYEN_DUNG TO RL_UNGVIEN;

CREATE OR REPLACE PROCEDURE USP_GET_LIST_TUYEN_DUNG_BY_NAME(P_RES OUT SYS_REFCURSOR, SearchString IN VARCHAR2)
AS
BEGIN
    OPEN P_RES FOR
        WITH CTE AS
        (
        SELECT HD.MAHOPDONG AS MAHD FROM HOPDONG HD JOIN DOANHNGHIEP DN ON HD.MADN = DN.MADN
                                            JOIN CAPBAC CB ON HD.CAPBACTD = CB.MACB
                                            JOIN VITRI VT ON HD.VITRITD = VT.MAVT
                                            JOIN HOPDONG_KYNANG HDKN ON HD.MAHOPDONG = HDKN.MAHOPDONG
                                            JOIN KYNANG KN ON HDKN.MAKN = KN.MAKN
        WHERE (LOWER(VT.MOTA) LIKE '%' ||SearchString || '%' OR LOWER(DN.TENDN) LIKE '%' ||SearchString || '%' OR LOWER(KN.MOTA) LIKE '%' ||SearchString || '%')
        AND (HD.TIENCONLAI < HD.TONGTIEN AND (HD.NGAYTD + HD.THOIGIANTD) > SYSDATE)
        GROUP BY HD.MAHOPDONG, VT.MOTA, DN.TENDN, CB.MOTA, DN.DIACHI
        )
        SELECT HD.MAHOPDONG, VT.MOTA as VITRITD, DN.TENDN, CB.MOTA AS CAPBACTD, DN.DIACHI, LISTAGG(KN.MOTA,', ') AS KYNANG FROM HOPDONG HD JOIN DOANHNGHIEP DN ON HD.MADN = DN.MADN
                                                                                            JOIN CAPBAC CB ON HD.CAPBACTD = CB.MACB
                                                                                            JOIN VITRI VT ON HD.VITRITD = VT.MAVT
                                                                                            JOIN HOPDONG_KYNANG HDKN ON HD.MAHOPDONG = HDKN.MAHOPDONG
                                                                                            JOIN KYNANG KN ON HDKN.MAKN = KN.MAKN
                                                                                            JOIN CTE ON HD.MAHOPDONG = CTE.MAHD
        GROUP BY HD.MAHOPDONG, VT.MOTA, DN.TENDN, CB.MOTA, DN.DIACHI;
END;
/
GRANT EXECUTE ON USP_GET_LIST_TUYEN_DUNG_BY_NAME TO RL_UNGVIEN;

CREATE OR REPLACE PROCEDURE USP_GET_DETAIL_TUYEN_DUNG(P_RES OUT SYS_REFCURSOR, MAHD IN VARCHAR2)
AS
BEGIN
    OPEN P_RES FOR
        SELECT HD.MAHOPDONG, HD.MADN, CB.MOTA AS CAPBACTD, VT.MOTA as VITRITD, HD.SOLUONGTD, HD.YEUCAU, HD.THOIGIANTD, HD.NGAYTD, DN.TENDN, DN.DIACHI, LISTAGG(KN.MOTA,', ') AS KYNANG, DN.EMAIL 
        FROM HOPDONG HD JOIN DOANHNGHIEP DN ON HD.MADN = DN.MADN
        JOIN CAPBAC CB ON HD.CAPBACTD = CB.MACB
        JOIN VITRI VT ON HD.VITRITD = VT.MAVT
        JOIN HOPDONG_KYNANG HDKN ON HD.MAHOPDONG = HDKN.MAHOPDONG
        JOIN KYNANG KN ON HDKN.MAKN = KN.MAKN
        WHERE HD.MAHOPDONG = MAHD
        GROUP BY HD.MAHOPDONG, VT.MOTA, DN.TENDN, CB.MOTA, DN.DIACHI, HD.MADN, HD.SOLUONGTD, HD.YEUCAU, HD.THOIGIANTD, HD.NGAYTD, DN.EMAIL;
END;
/
GRANT EXECUTE ON USP_GET_DETAIL_TUYEN_DUNG TO RL_UNGVIEN;
/
CREATE OR REPLACE PROCEDURE USP_HOPDONG_GET_ALL_FOR_TRACUUHD_DN(P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
        SELECT MAHOPDONG, NGAYTD, SOLUONGTD, TONGTIEN, TIENCONLAI
        FROM HOPDONG;
END;
/
GRANT EXECUTE ON USP_HOPDONG_GET_ALL_FOR_TRACUUHD_DN TO RL_DOANHNGHIEP;
/
CREATE OR REPLACE PROCEDURE USP_HOPDONG_GET_ALL_FOR_TRACUUHD_DN_SEARCH(P_KEYWORD IN VARCHAR2,P_RES OUT SYS_REFCURSOR)
AS
V_KEYWORD VARCHAR2(100);
BEGIN
     V_KEYWORD := P_KEYWORD || '%';
    OPEN P_RES FOR
        SELECT MAHOPDONG, NGAYTD, SOLUONGTD, TONGTIEN, TIENCONLAI
        FROM HOPDONG
        WHERE MAHOPDONG LIKE V_KEYWORD;
END;
/
GRANT EXECUTE ON USP_HOPDONG_GET_ALL_FOR_TRACUUHD_DN_SEARCH TO RL_DOANHNGHIEP;
/
CREATE OR REPLACE PROCEDURE USP_HOPDONG_GET_BAIDANG_FOR_TRACUUHD_DN(P_KEYWORD IN VARCHAR2,P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
        SELECT HD.MAHOPDONG, HD.MADN, CB.MOTA AS CAPBACTD, VT.MOTA as VITRITD, HD.SOLUONGTD, HD.YEUCAU, HD.THOIGIANTD, HD.NGAYTD, DN.TENDN, DN.DIACHI, LISTAGG(KN.MOTA,', ') AS KYNANG, DN.EMAIL 
        FROM HOPDONG HD JOIN DOANHNGHIEP DN ON HD.MADN = DN.MADN
        JOIN CAPBAC CB ON HD.CAPBACTD = CB.MACB
        JOIN VITRI VT ON HD.VITRITD = VT.MAVT
        JOIN HOPDONG_KYNANG HDKN ON HD.MAHOPDONG = HDKN.MAHOPDONG
        JOIN KYNANG KN ON HDKN.MAKN = KN.MAKN
        WHERE HD.MAHOPDONG = P_KEYWORD
        GROUP BY HD.MAHOPDONG, VT.MOTA, DN.TENDN, CB.MOTA, DN.DIACHI, HD.MADN, HD.SOLUONGTD, HD.YEUCAU, HD.THOIGIANTD, HD.NGAYTD, DN.EMAIL;
END;
/
GRANT EXECUTE ON USP_HOPDONG_GET_BAIDANG_FOR_TRACUUHD_DN TO RL_DOANHNGHIEP;
GRANT EXECUTE ON USP_HOPDONG_GET_BAIDANG_FOR_TRACUUHD_DN TO RL_NHANVIEN;
/
CREATE OR REPLACE PROCEDURE USP_HOPDONG_GET_ALL_FOR_TRACUUHD_NV(P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
        SELECT HD.MAHOPDONG, HD.MADN, DN.TENDN, HD.TONGTIEN, HD.TIENCONLAI
        FROM HOPDONG HD JOIN DOANHNGHIEP DN ON HD.MADN = DN.MADN;
END;
/
--ALTER SESSION SET CURRENT_SCHEMA=C##ADMIN;

GRANT EXECUTE ON USP_HOPDONG_GET_ALL_FOR_TRACUUHD_NV TO RL_NHANVIEN;
/
CREATE OR REPLACE PROCEDURE USP_HOPDONG_GET_ALL_FOR_TRACUUHD_NV_SEARCH(P_KEYWORD IN VARCHAR2,P_RES OUT SYS_REFCURSOR)
AS
V_KEYWORD VARCHAR2(100);
BEGIN
     V_KEYWORD := P_KEYWORD || '%';
    OPEN P_RES FOR
        SELECT HD.MAHOPDONG, HD.MADN, DN.TENDN, HD.TONGTIEN, HD.TIENCONLAI
        FROM HOPDONG HD JOIN DOANHNGHIEP DN ON HD.MADN = DN.MADN
        WHERE HD.MAHOPDONG LIKE V_KEYWORD;
END;
/
GRANT EXECUTE ON USP_HOPDONG_GET_ALL_FOR_TRACUUHD_NV_SEARCH TO RL_NHANVIEN;
/
CREATE OR REPLACE PROCEDURE USP_DN_PHANHOI_ADD (
  P_MaHopDong IN VARCHAR2,
  P_NoiDung IN VARCHAR2,
  P_ErrCode OUT NUMBER
)
AS
v_count NUMBER := 0;
BEGIN
  -- Insert with error handling
  SELECT COUNT(*) INTO v_count FROM DNPHANHOI WHERE MAHOPDONG = P_MaHopDong;
    P_ErrCode := v_count;
IF v_count > 0 THEN
    -- Set error code to 5 and return from the procedure
    P_ErrCode := 5;
    RETURN;
END IF;
  INSERT INTO DNPHANHOI
  VALUES (P_MaHopDong, to_date(TO_CHAR(sysdate, 'MM/DD/YYYY'),'MM/DD/YYYY'),P_NoiDung);
  
  -- Handle potential errors during insert
   P_ErrCode := 0;
  EXCEPTION
    WHEN OTHERS THEN
      P_ErrCode := 1; -- Set error code to 1
      RETURN; -- Terminate procedure
END;
/
GRANT EXECUTE ON USP_DN_PHANHOI_ADD TO RL_DOANHNGHIEP;
/
CREATE OR REPLACE PROCEDURE USP_HOPDONG_GET_PHANHOI_FOR_TRACUUHD_DN(P_KEYWORD IN VARCHAR2,P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
       SELECT MAHOPDONG, THOIGIANPH AS NGAYPH, NOIDUNG
       FROM DNPHANHOI
       WHERE MAHOPDONG = P_KEYWORD;
END;
/
GRANT EXECUTE ON USP_HOPDONG_GET_PHANHOI_FOR_TRACUUHD_DN TO RL_DOANHNGHIEP, RL_NHANVIEN;
/
CREATE OR REPLACE PROCEDURE USP_DN_CHECK_PHANHOI_TRACUUHD (
  P_MaHopDong IN VARCHAR2,
  P_ErrCode OUT NUMBER
)
AS
v_count NUMBER := 0;
BEGIN
  -- Insert with error handling
  SELECT COUNT(*) INTO v_count FROM DNPHANHOI WHERE MAHOPDONG = P_MaHopDong;
    P_ErrCode := v_count;
    RETURN;
END;
/
GRANT EXECUTE ON USP_DN_CHECK_PHANHOI_TRACUUHD TO RL_DOANHNGHIEP;
GRANT EXECUTE ON USP_DN_CHECK_PHANHOI_TRACUUHD TO RL_NHANVIEN;
/
CREATE OR REPLACE PROCEDURE USP_NV_BAIDANG_UPDATE (
  P_MaHopDong IN VARCHAR2,
  P_NoiDung IN VARCHAR2,
  P_ErrCode OUT NUMBER
)
AS
BEGIN
  -- Insert with error handling
  UPDATE HOPDONG SET YEUCAU = P_NoiDung WHERE MAHOPDONG = P_MaHopDong;
   P_ErrCode := 0;
  EXCEPTION
    WHEN OTHERS THEN
      P_ErrCode := 1; -- Set error code to 1
      RETURN; -- Terminate procedure
END;
/
GRANT EXECUTE ON USP_NV_BAIDANG_UPDATE TO RL_NHANVIEN;



CREATE OR REPLACE PROCEDURE USP_HOPDONG_INSERT
(
    vCAPBACTD IN VARCHAR2,
    vVITRITD IN VARCHAR2,
    vKYNANG IN VARCHAR2,
    vSOLUONGTD IN NUMBER,
    vYEUCAU	IN NVARCHAR2,
    vHINHTHUC IN NVARCHAR2,
    vTHOIGIANTD IN NUMBER,
    vNGAYTD IN DATE
)
AS
    vUSER VARCHAR2(50):= SYS_CONTEXT('USERENV', 'SESSION_USER');
    vTONGTIEN INT := 0;
    pkMAHD VARCHAR2(10);
    vMAKN VARCHAR2(10);
    vMAHT VARCHAR2(10);
    
    CURSOR cKYNANG IS (
        SELECT REGEXP_SUBSTR(vKYNANG, '[^,]+', 1, level) AS parts
        FROM dual
        CONNECT BY REGEXP_SUBSTR(vKYNANG, '[^,]+', 1, level) IS NOT NULL
    );
    
    CURSOR cHINHTHUC IS (
        SELECT REGEXP_SUBSTR(vHINHTHUC, '[^,]+', 1, level) AS parts
        FROM dual
        CONNECT BY REGEXP_SUBSTR(vHINHTHUC, '[^,]+', 1, level) IS NOT NULL
    );
BEGIN
    SELECT TO_CHAR(COUNT(*) + 1) INTO pkMAHD
    FROM HOPDONG;
    
    pkMAHD := 'NV' || TO_CHAR(TO_NUMBER(SUBSTR(vUSER, -8))) || '_' || pkMAHD;
    
--    RAISE_APPLICATION_ERROR(-20001, pkMAHD);
    
    INSERT INTO HOPDONG(MAHOPDONG, MADN, CAPBACTD, VITRITD, SOLUONGTD, YEUCAU, THOIGIANTD, NGAYTD, NGAYLAP, TRANGTHAI, TONGTIEN, TIENCONLAI)
    VALUES(pkMAHD, vUSER, vCAPBACTD, vVITRITD, vSOLUONGTD, vYEUCAU, vTHOIGIANTD, vNGAYTD, SYSDATE, 0, 1, 1);
    
    SELECT SUM(CHIPHITD) + NVL(vTONGTIEN, 0) INTO vTONGTIEN
    FROM (
        SELECT CHIPHITD FROM CAPBAC WHERE MACB = vCAPBACTD 
        UNION ALL
        SELECT CHIPHITD FROM VITRI WHERE MAVT = vVITRITD
        );
        
    OPEN cKYNANG;
    LOOP
        FETCH cKYNANG INTO vMAKN;
        EXIT WHEN cKYNANG%NOTFOUND;
        
        SELECT CHIPHITD + NVL(vTONGTIEN, 0) INTO vTONGTIEN
        FROM KYNANG
        WHERE MAKN = vMAKN;
        
        INSERT INTO HOPDONG_KYNANG
        VALUES(pkMAHD, vMAKN);
        
    END LOOP;
    CLOSE cKYNANG;
   
    OPEN cHINHTHUC;
    LOOP
        FETCH cHINHTHUC INTO vMAHT;
        EXIT WHEN cHINHTHUC%NOTFOUND;
        
        SELECT CHIPHITD + NVL(vTONGTIEN, 0) INTO vTONGTIEN
        FROM HINHTHUC
        WHERE MAHT = vMAHT;
        
        INSERT INTO HINHTHUC_HOPDONG
        VALUES(pkMAHD, vMAHT);
        
    END LOOP;
    CLOSE cHINHTHUC;
    
    UPDATE HOPDONG
    SET TONGTIEN = vTONGTIEN, TIENCONLAI = vTONGTIEN
    WHERE MAHOPDONG = pkMAHD;
END;
/
GRANT EXECUTE ON USP_HOPDONG_INSERT TO RL_DOANHNGHIEP;


CREATE OR REPLACE PROCEDURE USP_FIND_HOPDONG_BY_MAHOPDONG(P_RES OUT SYS_REFCURSOR, vMAHOPDONG IN VARCHAR)
AS
BEGIN
    OPEN P_RES FOR
        SELECT TONGTIEN, TIENCONLAI, THOIGIANTD FROM HOPDONG
        WHERE MAHOPDONG = vMAHOPDONG;
END;
/
GRANT EXECUTE ON USP_FIND_HOPDONG_BY_MAHOPDONG TO RL_NHANVIEN;
