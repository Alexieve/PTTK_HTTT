using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
