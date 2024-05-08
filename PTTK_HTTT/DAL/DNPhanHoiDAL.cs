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
    public class DNPhanHoiDAL
    {
        private DbConnection conn = new();

        public DNPhanHoiDAL() { }

        
        public string ThemDNPhanHoi(string mahd, string noidung)
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


    }
}
