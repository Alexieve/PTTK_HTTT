using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class UngVienDAL
    {
        private DbConnection conn = new();
        public UngVienDAL() {}

        public DataTable Get_TT_UngTuyen_BY_MAUV(string MAUV)
        {
            if (MAUV == "") MAUV = conn.username;
            string procName = "USP_UNGVIEN_GET_TTUNGTUYEN_BY_MAUV";
            OracleParameter[] parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("P_MAUV", OracleDbType.Varchar2, MAUV, ParameterDirection.Input)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameters);
        }
    }
}
