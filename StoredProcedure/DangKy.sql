CREATE OR REPLACE FUNCTION USP_GET_NEW_MAUV
RETURN VARCHAR2
AS
    V_MAX_ID NUMBER;
    V_NEW_MAUV VARCHAR2(10);
    V_NUM_LEN NUMBER;
BEGIN
    SELECT TO_NUMBER(SUBSTR(MAX(MAUV), 3)) INTO V_MAX_ID 
    FROM UNGVIEN;
    
    V_MAX_ID := V_MAX_ID + 1;
    
    V_NUM_LEN := LENGTH(V_MAX_ID);
    
    V_NEW_MAUV := 'UV' || LPAD(V_MAX_ID, 9 - V_NUM_LEN, '0');
    
    RETURN V_NEW_MAUV;
END;
/


CREATE OR REPLACE FUNCTION USP_GET_NEW_MADN
RETURN VARCHAR2
AS
    V_MAX_ID NUMBER;
    V_NEW_MADN VARCHAR2(10);
    V_NUM_LEN NUMBER;
BEGIN
    SELECT TO_NUMBER(SUBSTR(MAX(MADN), 3)) INTO V_MAX_ID 
    FROM DOANHNGHIEP;
    
    V_MAX_ID := V_MAX_ID + 1;
    
    V_NUM_LEN := LENGTH(V_MAX_ID);
    
    
    V_NEW_MADN := 'DN' || LPAD(V_MAX_ID, 9 - V_NUM_LEN, '0');
        
    RETURN V_NEW_MADN;
END;
/

CREATE OR REPLACE PROCEDURE USP_DANGKY_UV(
    P_HOTEN IN NVARCHAR2,
    P_PHAI IN NVARCHAR2,
    P_NGAYSINH IN DATE,
    P_DIACHI IN NVARCHAR2,
    P_SDT IN CHAR,
    P_EMAIL IN VARCHAR2,
    P_PASSWORD IN VARCHAR2
)
AS
    P_MAUV VARCHAR2(10) := USP_GET_NEW_MAUV;
BEGIN
    INSERT INTO UNGVIEN VALUES (P_MAUV, P_HOTEN, P_PHAI, P_NGAYSINH, P_DIACHI, P_SDT, P_EMAIL);
    USP_CREATE_USER(P_MAUV, P_PASSWORD);
    EXECUTE IMMEDIATE ('GRANT RL_UNGVIEN TO ' || P_MAUV);
END;
/

CREATE OR REPLACE PROCEDURE USP_DANGKY_DN(
    P_TENDN IN NVARCHAR2,
    P_MSTHUE IN CHAR,
    P_NGDAIDIEN IN NVARCHAR2,
    P_DIACHI IN NVARCHAR2,
    P_SDT IN CHAR,
    P_EMAIL IN VARCHAR2,
    P_PASSWORD IN VARCHAR2
)
AS
    P_MADN VARCHAR2(10) := USP_GET_NEW_MADN;
BEGIN
    INSERT INTO DOANHNGHIEP VALUES (P_MADN, P_TENDN, P_MSTHUE, P_NGDAIDIEN, P_DIACHI, P_SDT, P_EMAIL, 0);
    USP_CREATE_USER(P_MADN, P_PASSWORD);
    EXECUTE IMMEDIATE ('GRANT RL_DOANHNGHIEP TO ' || P_MADN);
    EXECUTE IMMEDIATE ('ALTER USER ' || P_MADN || ' ACCOUNT LOCK');
END;
/