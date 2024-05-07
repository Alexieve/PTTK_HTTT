using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class HopDongDAL
    {
        private DbConnection conn = new();

        public HopDongDAL() { }

        public DataTable Get_All_For_DuyetHS()
        {
            string procName = "USP_HOPDONG_GET_ALL_FOR_DUYETHS";
            OracleParameter[] parameter =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };

            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameter);
        }

        public DataTable Get_All_For_PhanHoiHS()
        {
            string procName = "USP_HOPDONG_GET_ALL_FOR_PHANHOIHS";
            OracleParameter[] parameter =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };

            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameter);
        }

        public DataTable Get_YeuCauDN(string MAHOPDONG)
        {
            string procName = "USP_HOPDONG_GET_TIEUCHIDN";
            OracleParameter[] parameter =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("P_MAHOPDONG", OracleDbType.Varchar2, MAHOPDONG, ParameterDirection.Input)
            };

            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameter);
        }
        public DataTable Get_All_BaiDangTuyenDung()
        {
            string procName = "USP_GET_LIST_TUYEN_DUNG";
            OracleParameter[] parameter =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
            };

            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameter);
        }
        public DataTable Search_BaiDangTuyenDung(string SearchString)
        {
            string procName = "USP_GET_LIST_TUYEN_DUNG_BY_NAME";
            OracleParameter[] parameter =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("SearchString", OracleDbType.Varchar2, SearchString, ParameterDirection.Input)
            };

            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameter);
        }
        public DataTable Get_Detail_BaiDangTuyenDung(string MAHD)
        {
            string procName = "USP_GET_DETAIL_TUYEN_DUNG";
            OracleParameter[] parameter =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("MAHD", OracleDbType.Varchar2, MAHD, ParameterDirection.Input)
            };

            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameter);
        }
                public DataTable Get_All_For_TraCuuHD_DN()
        {
            string procName = "USP_HOPDONG_GET_ALL_FOR_TRACUUHD_DN";
            OracleParameter[] parameter =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };

            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameter);
        }
        public DataTable Get_All_For_TraCuuHD_DN_SEARCH(string keyword)
        {
            string procName = "USP_HOPDONG_GET_ALL_FOR_TRACUUHD_DN_SEARCH";
            OracleParameter[] parameter =
            {
                new("P_KEYWORD", OracleDbType.Varchar2, ParameterDirection.Input) {Value = keyword},
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };

            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameter);
        }
        public DataTable Get_BAIDANG_For_TraCuuHD_DN(string keyword)
        {
            string procName = "USP_HOPDONG_GET_BAIDANG_FOR_TRACUUHD_DN";
            OracleParameter[] parameter =
            {
                new("P_KEYWORD", OracleDbType.Varchar2, ParameterDirection.Input) {Value = keyword},
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };

            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameter);
        }
        public string ThemDNPhanHoi(string  mahd, string noidung)
        {
            string ProcName = "USP_DN_PHANHOI_ADD";
            OracleParameter[] Parameters =
            {
                   new OracleParameter("P_MaHopDong", OracleDbType.Varchar2, mahd, ParameterDirection.Input ),
                   new OracleParameter("P_NoiDung", OracleDbType.Varchar2, noidung, ParameterDirection.Input ),
                   new OracleParameter("P_RES", OracleDbType.Decimal, ParameterDirection.Output)
            };
            conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
            return Parameters[Parameters.Length - 1].Value.ToString();
            //object resValue = Parameters[Parameters.Length - 1].Value; // Lấy giá trị của tham số đầu ra P_RES
            //if (resValue.ToString() == "1")
            //    return 0;
            //if (resValue.ToString() == "5")
            //    return 5;
            //return 1;
        }
        public DataTable Get_PHANHOI_For_TraCuuHD_DN(string keyword)
        {
            string procName = "USP_HOPDONG_GET_PHANHOI_FOR_TRACUUHD_DN";
            OracleParameter[] parameter =
            {
                new("P_KEYWORD", OracleDbType.Varchar2, ParameterDirection.Input) {Value = keyword},
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };

            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameter);
        }
        public DataTable Get_NgayThanhToan_For_TraCuuHD_DN(string keyword)
        {
            string procName = "USP_HOPDONG_GET_NGAYTHANHTOAN_FOR_TRACUUHD_DN";
            OracleParameter[] parameter =
            {
                new("P_KEYWORD", OracleDbType.Varchar2, ParameterDirection.Input) {Value = keyword},
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };

            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameter);
        }
        public DataTable Get_TRANGTHAI_For_TraCuuHD(string keyword)
        {
            string procName = "USP_HOPDONG_GET_TRANGTHAI_FOR_TRACUUHD";
            OracleParameter[] parameter =
            {
                new("P_KEYWORD", OracleDbType.Varchar2, ParameterDirection.Input) {Value = keyword},
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };

            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameter);
        }
        public string Check_Tontai_PhanHoi(string keyword)
        {
            string procName = "USP_DN_CHECK_PHANHOI_TRACUUHD";
            OracleParameter[] Parameters =
            {
                new("P_KEYWORD", OracleDbType.Varchar2, ParameterDirection.Input) {Value = keyword},
               new OracleParameter("P_RES", OracleDbType.Decimal, ParameterDirection.Output)
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, Parameters);
            return Parameters[Parameters.Length - 1].Value.ToString();
    
        }
        public DataTable Get_All_For_TraCuuHD_NV()
        {
            string procName = "USP_HOPDONG_GET_ALL_FOR_TRACUUHD_NV";
            OracleParameter[] parameter =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };

            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameter);
        }
        public DataTable Get_All_For_TraCuuHD_NV_SEARCH(string keyword)
        {
            string procName = "USP_HOPDONG_GET_ALL_FOR_TRACUUHD_NV_SEARCH";
            OracleParameter[] parameter =
            {
                new("P_KEYWORD", OracleDbType.Varchar2, ParameterDirection.Input) {Value = keyword},
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };

            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameter);
        }
        public string UpdateBaiDang(string mahd, string noidung)
        {
            string ProcName = "USP_NV_BAIDANG_UPDATE";
            OracleParameter[] Parameters =
            {
                   new OracleParameter("P_MaHopDong", OracleDbType.Varchar2, mahd, ParameterDirection.Input ),
                   new OracleParameter("P_NoiDung", OracleDbType.Varchar2, noidung, ParameterDirection.Input ),
                   new OracleParameter("P_RES", OracleDbType.Decimal, ParameterDirection.Output)
            };
            conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
            return Parameters[Parameters.Length - 1].Value.ToString();
            //object resValue = Parameters[Parameters.Length - 1].Value; // Lấy giá trị của tham số đầu ra P_RES
            //if (resValue.ToString() == "1")
            //    return 0;
            //if (resValue.ToString() == "5")
            //    return 5;
            //return 1;
        }

        public string Insert(string CAPBAC, string VITRITD, string KYNANG, int SOLUONGTD, string YEUCAU, string HINHTHUC, int THOIGIANTD, DateTime NGAYTD)
        {
            try
            {
                string procName = "USP_HOPDONG_INSERT";
                OracleParameter[] parameters =
                {
                    new("vCAPBACTD", OracleDbType.Varchar2,CAPBAC, ParameterDirection.Input),
                    new("vVITRITD", OracleDbType.Varchar2,VITRITD, ParameterDirection.Input),
                    new("vKYNANG", OracleDbType.Varchar2,KYNANG, ParameterDirection.Input),
                    new("vSOLUONGTD", OracleDbType.Int32,SOLUONGTD, ParameterDirection.Input),
                    new("vYEUCAU", OracleDbType.NVarchar2,YEUCAU, ParameterDirection.Input),
                    new("vHINHTHUC", OracleDbType.NVarchar2,HINHTHUC, ParameterDirection.Input),
                    new("vTHOIGIANTD", OracleDbType.Int32,THOIGIANTD, ParameterDirection.Input),
                    new("vNGAYTD", OracleDbType.Date,NGAYTD, ParameterDirection.Input)
                };
                conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, parameters);
                return "success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public HopDongDTO Find_BY_MAHOPDONG(string MAHOPDONG)
        {
            string procName = "USP_FIND_HOPDONG_BY_MAHOPDONG";
            OracleParameter[] parameter =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("P_MAHOPDONG", OracleDbType.Varchar2, MAHOPDONG, ParameterDirection.Input)
            };

            HopDongDTO _HopDongDTO = new HopDongDTO();

            DataTable dt = conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameter);
            if (dt.Rows.Count != 0)
            {
                _HopDongDTO.TONGTIEN = Convert.ToSingle(dt.Rows[0]["TONGTIEN"]);
                _HopDongDTO.TIENCONLAI = Convert.ToSingle(dt.Rows[0]["TIENCONLAI"]);
                _HopDongDTO.THOIGIANTD = (int)Convert.ToSingle(dt.Rows[0]["THOIGIANTD"]);
                return _HopDongDTO;
            }
            return null;
        }
    }
}
