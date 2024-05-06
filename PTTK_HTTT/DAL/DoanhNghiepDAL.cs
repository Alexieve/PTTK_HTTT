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
    public class DoanhNghiepDAL
    {
        private DbConnection conn = new();
        public DoanhNghiepDAL() { }
        public DataTable Get_List_DN_For_Xac_Thuc()
        {
            string procName = "USP_DOANHNGHIEP_GET_LIST_DN_FOR_XAC_THUC";
            OracleParameter[] parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameters);
        }

        public DataTable Get_Detail(string MADN)
        {
            string procName = "USP_DOANHNGHIEP_GET_DETAIL";
            OracleParameter[] parameters =
            {
                new("P_MADN", OracleDbType.Varchar2, MADN, ParameterDirection.Input),
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameters);
        }
        public void Delete(string MADN)
        {
            string procName = "USP_DOANHNGHIEP_TU_CHOI_DN";
            OracleParameter[] parameters =
            {
                new("P_MADN", OracleDbType.Varchar2, MADN, ParameterDirection.Input)
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, parameters);
        }

        public void Xac_Thuc(DoanhNghiepDTO dn)
        {
            string procName = "USP_DOANHNGHIEP_XAC_NHAN_DN";
            OracleParameter[] parameters =
            {
                new("P_MADN", OracleDbType.Varchar2, dn.MADN, ParameterDirection.Input),
                new("P_TENDN", OracleDbType.NVarchar2, dn.TENDN, ParameterDirection.Input),
                new("P_MSTHUE", OracleDbType.Varchar2, dn.MSTHUE, ParameterDirection.Input),
                new("P_NGDAIDIEN", OracleDbType.NVarchar2, dn.NGDAIDIEN, ParameterDirection.Input),
                new("P_DIACHI", OracleDbType.NVarchar2, dn.DIACHI, ParameterDirection.Input)
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, parameters);
        }
    }
}
