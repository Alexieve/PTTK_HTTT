using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace BLL
{
    public class UngVienBLL
    {
        private DAL.UngVienDAL ungVienDAL = new();
        public UngVienBLL() { }

        public UngVienDTO Get_TT_UngTuyen_By_MAUV(string MAUV)
        {
            DataTable dt = ungVienDAL.Get_TT_UngTuyen_By_MAUV(MAUV);
            return Utility.ToObject<UngVienDTO>(dt.Rows[0]);
        }
    }
}
