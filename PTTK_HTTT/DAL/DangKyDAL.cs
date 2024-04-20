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
    public class DangKyDAL
    {
        private DbConnection conn = new();
        
        public DangKyDAL() { }

        public string checkExist(string username)
        {
            string procName = "USP_GET_USERNAME_BY_EMAIL_SDT";
            OracleParameter[] parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("P_USERNAME", OracleDbType.Varchar2, username, ParameterDirection.Input)
            };
            DataTable dt = conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameters);
            if (dt.Rows.Count == 0) return null;
            return dt.Rows[0][0].ToString();
        }
        public void DangKy_UV(UngVienDTO uv, string password)
        {
            string procName = "USP_DANGKY_UV";
            OracleParameter[] parameters =
            {
                new("P_HOTEN", OracleDbType.Varchar2, uv.HOTEN, ParameterDirection.Input),
                new("P_PHAI", OracleDbType.Varchar2, uv.PHAI, ParameterDirection.Input),
                new("P_NGAYSINH", OracleDbType.Date, uv.NGAYSINH, ParameterDirection.Input),
                new("P_DIACHI", OracleDbType.Varchar2, uv.DIACHI, ParameterDirection.Input),
                new("P_SDT", OracleDbType.Varchar2, uv.SDT, ParameterDirection.Input),
                new("P_EMAIL", OracleDbType.Varchar2, uv.EMAIL, ParameterDirection.Input),
                new("P_PASSWORD", OracleDbType.Varchar2, password, ParameterDirection.Input)
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, parameters);
        }

        public void DangKy_DN(DoanhNghiepDTO dn, string password)
        {
            string procName = "USP_DANGKY_DN";
            OracleParameter[] parameters =
            {
                new("P_TENDN", OracleDbType.Varchar2, dn.TENDN, ParameterDirection.Input),
                new("P_MSTHUE", OracleDbType.Varchar2, dn.MSTHUE, ParameterDirection.Input),
                new("P_NGDAIDIEN", OracleDbType.Varchar2, dn.NGDAIDIEN, ParameterDirection.Input),
                new("P_DIACHI", OracleDbType.Varchar2, dn.DIACHI, ParameterDirection.Input),
                new("P_SDT", OracleDbType.Varchar2, dn.SDT, ParameterDirection.Input),
                new("P_EMAIL", OracleDbType.Varchar2, dn.EMAIL, ParameterDirection.Input),
                new("P_PASSWORD", OracleDbType.Varchar2, password, ParameterDirection.Input)
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, parameters);
        }
    }
}
