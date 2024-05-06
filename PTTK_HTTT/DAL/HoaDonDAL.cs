using DTO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        DbConnection conn;
        public HoaDonDAL() 
        {
            conn = new DbConnection();
        }

        public DataTable GET_BY_MAHOPDONG(string MAHOPDONG)
        {
            string procName = "USP_HOADON_GET_BY_MAHOADON";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("vMAHOPDONG", OracleDbType.Varchar2, MAHOPDONG, ParameterDirection.Input)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public string THANH_TOAN(float SOTIEN, string HINHTHUCTT, string MAHOPDONG)
        {
            try
            {
                string procName = "USP_HOADON_THANH_TOAN";
                OracleParameter[] parameters =
                {
                    new("vSOTIEN", OracleDbType.Int32, SOTIEN, ParameterDirection.Input),
                    new("vHINHTHUCTT", OracleDbType.NVarchar2, HINHTHUCTT, ParameterDirection.Input),
                    new("vMAHOPDONG", OracleDbType.Varchar2, MAHOPDONG, ParameterDirection.Input)
                };
                conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, parameters);
                return "Thanh toán thành công";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
