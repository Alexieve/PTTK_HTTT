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
    public class HSUngTuyenDAL
    {
        private DbConnection conn = new DbConnection();

        public HSUngTuyenDAL() { }

        public DataTable Check_Applied(string MAHOPDONG)
        {
            string procName = "USP_HSUNGTUYEN_CHECK_APPLIED";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("P_MAHOPDONG", OracleDbType.Varchar2, MAHOPDONG, ParameterDirection.Input)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
        public void Insert(HSUngTuyenDTO hs)
        {
            string procName = "USP_HSUNGTUYEN_INSERT";
            OracleParameter[] Parameters =
            {
                new("P_MAHOPDONG", OracleDbType.Varchar2, hs.MAHOPDONG, ParameterDirection.Input),
                new("P_GIOITHIEU", OracleDbType.Varchar2, hs.GIOITHIEU, ParameterDirection.Input),
                new("P_HOCVAN", OracleDbType.Varchar2, hs.HOCVAN, ParameterDirection.Input),
                new("P_KINHNGHIEM", OracleDbType.Varchar2, hs.KINHNGHIEM, ParameterDirection.Input)
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public DataTable Get_For_DuyetHS_By_KetQua(string MAHOPDONG, int KETQUA)
        {
            string procName = "USP_HSUNGTUYEN_GET_FOR_DUYETHS_BY_KETQUA";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("P_MAHOPDONG", OracleDbType.Varchar2, MAHOPDONG, ParameterDirection.Input),
                new("P_KETQUA", OracleDbType.Int16, KETQUA, ParameterDirection.Input)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public DataTable Get_For_PhanHoiHS_By_KetQua(string MAHOPDONG, int KETQUA)
        {
            string procName = "USP_HSUNGTUYEN_GET_FOR_PHANHOIHS_BY_KETQUA";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("P_MAHOPDONG", OracleDbType.Varchar2, MAHOPDONG, ParameterDirection.Input),
                new("P_KETQUA", OracleDbType.Int16, KETQUA, ParameterDirection.Input)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public DataTable Get_ChiTiet_HSUngTuyen(string MAUV, string MAHOPDONG)
        {
            string procName = "USP_HSUNGTUYEN_GET_CHITIET_HSUNGTUYEN";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("P_MAUV", OracleDbType.Varchar2, MAUV, ParameterDirection.Input),
                new("P_MAHOPDONG", OracleDbType.Varchar2, MAHOPDONG, ParameterDirection.Input)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public void Update_KetQua(string MAUV, string MAHOPDONG, int KETQUA)
        {
            string procName = "USP_HSUNGTUYEN_UPDATE_KETQUA";
            OracleParameter[] Parameters =
            {
                new("P_MAUV", OracleDbType.Varchar2, MAUV, ParameterDirection.Input),
                new("P_MAHOPDONG", OracleDbType.Varchar2, MAHOPDONG, ParameterDirection.Input),
                new("P_KETQUA", OracleDbType.Int16, KETQUA, ParameterDirection.Input)
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public void Update_DoUuTien(string MAUV, string MAHOPDONG, int DOUUTIEN)
        {
            string procName = "USP_HSUNGTUYEN_UPDATE_DOUUTIEN";
            OracleParameter[] Parameters =
            {
                new("P_MAUV", OracleDbType.Varchar2, MAUV, ParameterDirection.Input),
                new("P_MAHOPDONG", OracleDbType.Varchar2, MAHOPDONG, ParameterDirection.Input),
                new("P_DOUUTIEN", OracleDbType.Int16, DOUUTIEN, ParameterDirection.Input)
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, Parameters);
        }
    }
}
