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
    public class GiayToDAL
    {
        private DbConnection conn = new DbConnection();
        public GiayToDAL() { }

        public void Insert(GiayToDTO gt)
        {
            string procName = "USP_GIAYTO_INSERT";
            OracleParameter[] Parameters =
            {
                new("P_MAHOPDONG", OracleDbType.Varchar2, gt.MAHOPDONG, ParameterDirection.Input),
                new("P_LOAI", OracleDbType.Varchar2, gt.LOAI, ParameterDirection.Input),
                new("P_NOIDUNG", OracleDbType.Varchar2, gt.NOIDUNG, ParameterDirection.Input)
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public DataTable Get_GiayTo_By_MAUV_MAHOPDONG(string MAUV, string MAHOPDONG)
        {
            string procName = "USP_GIAYTO_GET_BY_MAUV_MAHOPDONG";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("P_MAUV", OracleDbType.Varchar2, MAUV, ParameterDirection.Input),
                new("P_MAHOPDONG", OracleDbType.Varchar2, MAHOPDONG, ParameterDirection.Input)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
    }
}
