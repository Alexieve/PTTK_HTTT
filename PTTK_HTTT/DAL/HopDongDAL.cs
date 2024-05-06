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
