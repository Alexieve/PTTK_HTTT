using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class DangNhapDAL
    {
        private DbConnection conn = new();

        public DangNhapDAL()
        {
            if (conn == null || conn.username != "C##ADMIN")
                conn.Connect("C##ADMIN", "123");
        }
        public string GetUsernameByEmailSDT(string username)
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

        public string Connect(string username, string password)
        {
            conn.Connect(username, password);
            return conn.role;
        }
    }
}
