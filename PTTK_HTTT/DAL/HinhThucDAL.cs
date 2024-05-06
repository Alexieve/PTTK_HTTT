using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HinhThucDAL
    {
        DbConnection conn;

        public HinhThucDAL()
        {
            conn = new DbConnection();
        }

        public DataTable getAll()
        {
            string procName = "USP_HINHTHUC_GET_ALL";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
    }
}
