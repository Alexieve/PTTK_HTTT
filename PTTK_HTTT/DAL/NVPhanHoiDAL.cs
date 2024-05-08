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
    public class NVPhanHoiDAL
    {
        private DbConnection conn = new();

        public NVPhanHoiDAL() { }
        public void Insert(NVPhanHoiDTO ph)
        {
            string procName = "USP_NVPHANHOI_INSERT";
            OracleParameter[] Parameters =
            {
                new("P_MAUV", OracleDbType.Varchar2, ph.MAUV, ParameterDirection.Input),
                new("P_MAHOPDONG", OracleDbType.Varchar2, ph.MAHOPDONG, ParameterDirection.Input),
                new("P_NOIDUNG", OracleDbType.NVarchar2, ph.NOIDUNG, ParameterDirection.Input)
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public DataTable Get_New(string MAUV, string MAHOPDONG)
        {
            string procName = "USP_NVPHANHOI_GET_NEW";
            OracleParameter[] Parameters =
            {
                new("P_MAUV", OracleDbType.Varchar2, MAUV, ParameterDirection.Input),
                new("P_MAHOPDONG", OracleDbType.Varchar2, MAHOPDONG, ParameterDirection.Input),
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
    }
}
