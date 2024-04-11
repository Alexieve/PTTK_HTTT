using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class DbConnection // Oracle
    {
        private OracleConnection conn;
        private OracleDataAdapter adapter;

        public DbConnection(string username, string password)
        {
            string connectionString = "User ID=" + username + "; Password=" + password + "; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = " + "localhost" + ")(PORT = 1521))(CONNECT_DATA=(SERVER = DEDICATED)(SERVICE_NAME = PTTK)));";
            this.conn = new OracleConnection(connectionString);
            adapter = new OracleDataAdapter();
        }

        private OracleConnection OpenConnection()
        {
            if (this.conn.State == ConnectionState.Closed
                || this.conn.State == ConnectionState.Broken)
                this.conn.Open();
            return this.conn;
        }

        private void Close()
        {
            if (this.conn.State == ConnectionState.Open)
                this.conn.Close();
        }

        public DataTable ExecuteStoredProcedure(string procedureName, OracleParameter[]? parameters)
        {
            DataTable dt;
            DataSet ds = new DataSet();
            try
            {
                OracleCommand cmd = new OracleCommand(procedureName, OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                // Show the number of table in dataset
                Console.WriteLine("Number of tables in dataset: " + ds.Tables.Count);
                dt = ds.Tables[0];
                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                throw new Exception("Error executing stored procedure: " + ex.Message);
            }
            finally
            {
                Close();
            }
            return dt;
        }
    }
}
